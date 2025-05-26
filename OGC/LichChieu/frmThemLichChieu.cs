using OGC.DAO;
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
            cbTenphong.DataSource = DAO_LOAIPHONG.Instance.DanhSachTenPhong_List(); 
            cbTenphong.DisplayMember = "TenPhong";

            // ComboBox ID phim
            cbIDPhim.DataSource = PhimDAO.Instance.GetAllPhim();
            cbIDPhim.DisplayMember = "ID";

            // ComboBox ID phòng
            cbIDPhong.DataSource = DAO_LOAIPHONG.Instance.LayMaPhong(); 
            cbIDPhong.DisplayMember = "IDPhong";


        }

        private void btnDongYThemLC_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu hợp lệ thì mới tiếp tục sửa nhân viên
                string tenPhim = cbTenPhim.Text;
                string tenPhong = cbTenphong.Text;
                DateTime ngayGio = dtpNgayGio.Value;
                decimal giaVe = decimal.Parse(txbGiaVe.Text);
                string diaDiem = txbDiaDiem.Text;


                //Kiểm tra nếu tài khoản rỗng
                if ((string.IsNullOrWhiteSpace(tenPhim)) || (string.IsNullOrWhiteSpace(tenPhong)) || (ngayGio == DateTime.MinValue) || (giaVe < 50000))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin lịch chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (giaVe < 50000)
                {
                    MessageBox.Show("Giá vé phải lớn hơn 50000 VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
