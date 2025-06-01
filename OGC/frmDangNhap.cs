using OGC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            txbTaiKhoan.Text = "hnghia"; //Username
            txbTaiKhoan.ForeColor = Color.Gray;

            txbMatKhau.Text = "hnghia"; //Password
            txbMatKhau.ForeColor = Color.Gray;
        }

        #region Sự kiện hiển thị sẵn trên ô textbox
        private void txbTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "Username")
            {
                txbTaiKhoan.Text = ""; // Xóa nội dung mặc định
                txbTaiKhoan.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txbTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTaiKhoan.Text)) //Kiểm tra ô textbox rỗng
            {
                txbTaiKhoan.Text = "Username"; // Hiển thị lại nội dung mặc định
                txbTaiKhoan.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }
        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "Password")
            {
                txbMatKhau.Text = "";
                txbMatKhau.PasswordChar = '*';
                txbMatKhau.ForeColor = Color.Black;
            }
        }
        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMatKhau.Text)) //Kiểm tra ô textbox rỗng
            {
                txbMatKhau.PasswordChar = '\0';
                txbMatKhau.Text = "Password";
                txbMatKhau.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Events

        #region Thay đổi viền
        private void pnlTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTaiKhoan, 30);
        }

        private void pnlMatKhau_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlMatKhau, 30);
        }
        private void btnDangNhap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundButtonCorners(btnDangNhap, 30);
        }
        #endregion


        //sự kiện click button đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (DAO_TKNHANVIEN.Instance.Login(username, password))
            {
                this.Hide();
                frmMain mainForm = new frmMain(username); // Truyền tài khoản nhân viên vào frmMain
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



       
    }
}
