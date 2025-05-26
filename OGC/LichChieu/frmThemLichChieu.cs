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

            // ComboBox tên phim
            cbTenPhim.DataSource = PhimDAO.Instance.GetAllPhim();
            cbTenPhim.DisplayMember = "TenPhim";

            // ComboBox tên phòng
            cbTenPhong.DataSource = DAO_LOAIPHONG.Instance.DanhSachTenPhong_List();
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
                DTO_LOAIPHONG phong = cbTenPhong.SelectedItem as DTO_LOAIPHONG;
                if (phong != null)
                {
                    txbIDPhong.Text = phong.ID.ToString();
                }
            }
        }
        #endregion

        #region Methods
        private void btnDongYThemLC_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu hợp lệ thì mới tiếp tục sửa nhân viên
                string tenPhim = cbTenPhim.Text;
                string tenPhong = cbTenPhong.Text;
                DateTime ngayGio = dtpNgayGio.Value;
                decimal giaVe = decimal.Parse(txbGiaVe.Text);
                string diaDiem = txbDiaDiem.Text;


                //Kiểm tra nếu tài khoản rỗng
                if ((string.IsNullOrWhiteSpace(tenPhim)) || (string.IsNullOrWhiteSpace(tenPhong)) || (ngayGio == DateTime.MinValue) || (giaVe < 50000))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin lịch chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (giaVe < 50000)
                {
                    MessageBox.Show("Giá vé phải lớn hơn 50000 VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
