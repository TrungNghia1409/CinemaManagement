using OGC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.DoiMatKhau
{
    public partial class frmDoiMatKhau : Form
    {
        public string currentUser;
        public frmDoiMatKhau(string username)
        {
            InitializeComponent();

            currentUser = username;

            txbMatKhauMoi.PasswordChar = '*';
            txbXacNhanMatKhauMoi.PasswordChar = '*';

        }

        #region Events
        private void chbHien_MKMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHien_MKMoi.Checked)
            {
                txbMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txbMatKhauMoi.PasswordChar = '*';
            }
        }

        private void chbHien_XacNhanMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHien_XacNhanMKMoi.Checked)
            {
                txbXacNhanMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txbXacNhanMatKhauMoi.PasswordChar = '*';
            }
        }

        private void txbMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            KiemTraTrungMatKhau();
        }

        private void txbXacNhanMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            KiemTraTrungMatKhau();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mkMoi = txbMatKhauMoi.Text.Trim();
            string xacNhan = txbXacNhanMatKhauMoi.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xác nhận khớp
            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash mật khẩu mới
            byte[] hashedPassword = DAO_TKNHANVIEN.Instance.HashPassword(mkMoi); 

            // SET CONTEXT trước khi đổi mật khẩu
            DAO_LogNhanVien.Instance.SetContext_Username(currentUser);

            // Gọi DAO để đổi mật khẩu
            bool ketQua = DAO_TKNHANVIEN.Instance.DoiMatKhau(hashedPassword, currentUser);
            if (ketQua)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                // Quay về form đăng nhập
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods
        //--hàm so sánh 2 mật khẩu
        private void KiemTraTrungMatKhau()
        {
            string mk1 = txbMatKhauMoi.Text.Trim();
            string mk2 = txbXacNhanMatKhauMoi.Text.Trim();

            if (!string.IsNullOrEmpty(mk1) && !string.IsNullOrEmpty(mk2))
            {
                if (mk1 != mk2)
                {
                    lblSoSanh.Text = "Mật khẩu chưa trùng khớp";
                    lblSoSanh.ForeColor = Color.Red;
                    lblSoSanh.Visible = true;
                }
                else
                {
                    lblSoSanh.Visible = false; // Ẩn label nếu trùng khớp
                }
            }
            else
            {
                lblSoSanh.Visible = false; // Cũng ẩn nếu chưa nhập gì cả
            }
        }
        #endregion

        
    }
}
