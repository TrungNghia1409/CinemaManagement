using OGC.DAO;
using OGC.DTO;
using OGC.ThuocTinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.LichChieu
{
    public partial class frmThemLichChieu : Form
    {
        public frmThemLichChieu()
        {
            InitializeComponent();


            dtpNgayGio.Format = DateTimePickerFormat.Custom;
            dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";

            // ComboBox tên phim
            cbTenPhim.DataSource = PhimDAO.Instance.GetAllPhim();
            cbTenPhim.DisplayMember = "TenPhim";

            // ComboBox tên phòng
            cbTenPhong.DataSource = DAO_PHONGCHIEU.Instance.DanhSachTenPhong_List();
            cbTenPhong.DisplayMember = "TenPhong";


        }
        #region Events

        //bắt sự kiện khi combobox thay đổi thì Text của textbox cũng thay đỏi theo
        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhim.SelectedItem != null)
            {
                PhimDTO phim = cbTenPhim.SelectedItem as PhimDTO;
                try
                {
                    if (phim != null)
                    {
                        txbIDPhim.Text = phim.ID.ToString();
                        ptbAnh.Load(phim.Anh); // load ảnh từ đường dẫn URL
                    }
                }
                catch
                {
                    ptbAnh.Image = null;
                    MessageBox.Show("Không thể tải ảnh từ đường dẫn.");
                }
            }
            else
            {
                ptbAnh.Image = null;
            }

        }
        

        private void cbTenphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhong.SelectedItem != null)
            {
                DTO_PHONGCHIEU phong = cbTenPhong.SelectedItem as DTO_PHONGCHIEU;
                try
                {
                    if (phong != null)
                    {
                        txbIDPhong.Text = phong.ID.ToString();
                        ptbAnhPhong.Load(phong.AnhPhong);
                    }
                }
                catch
                {
                    ptbAnh.Image = null;
                    MessageBox.Show("Không thể tải ảnh từ đường dẫn.");
                }
            }
        }
        #endregion

        #region Methods
        private void btnDongYThemLC_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = txbIDPhong.Text;
                int iDPhong = int.Parse(maPhong);

                string tenPhim = cbTenPhim.Text;
                string tenPhong = cbTenPhong.Text;
                DateTime ngayGio = dtpNgayGio.Value;
                decimal giaVe = decimal.Parse(txbGiaVe.Text);
                string diaDiem = txbDiaDiem.Text;

                //------ kiểm tra cùng 1 ngày có tồn tại lịch chiếu trùng nhau (yêu cầu giữa 2 lịch chiếu cách nhau ít nhất 2 tiếng)
                List<DateTime> lichChieuTrongNgay = DAO_LICHCHIEU.Instance.GetNgayGioTrongNgay(iDPhong, ngayGio);

                foreach (DateTime thoiDiem in lichChieuTrongNgay)
                {
                    TimeSpan khoangCach = ngayGio - thoiDiem;
                    if (Math.Abs(khoangCach.TotalHours) < 2)
                    {
                        MessageBox.Show("Lịch chiếu này cách lịch hiện có dưới 2 giờ. \n Vui lòng chọn thời gian khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                //Kiểm tra nếu tài khoản rỗng
                if ((string.IsNullOrWhiteSpace(tenPhim)) || (string.IsNullOrWhiteSpace(tenPhong)) || (ngayGio == DateTime.MinValue) )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin lịch chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (giaVe <= 0)
                {
                    MessageBox.Show("Giá vé phải lớn hơn 0 VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (ngayGio < DateTime.Today)
                {
                    MessageBox.Show("Vui lòng nhập lịch chiếu trong tương lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((DAO_LICHCHIEU.Instance.ThemLichChieu(tenPhim, tenPhong, ngayGio, giaVe, diaDiem)))
                {
                    MessageBox.Show("Thêm lịch chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách tài khoản
                    frmQuanLyLichChieu? f = Application.OpenForms["frmQuanLyLichChieu"] as frmQuanLyLichChieu;
                    f?.LoadLichChieu();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Thông tin lịch chiếu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
