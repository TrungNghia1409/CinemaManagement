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

namespace OGC.OTP_XACNHAN
{
    public partial class frmOTPXacNhanAdmin : Form
    {
        public string currentUser; // Biến lưu tài khoản nhân viên đăng nhập
        public frmOTPXacNhanAdmin(string username)
        {
            InitializeComponent();

            currentUser = username;

            string email = DAO_NHANVIEN.Instance.GetEmailByUsername(currentUser);
            lblEmail.Text = "Mã OTP đã được gửi về mail " + LamMoEmail(email);

            // Tạo OTP mới và gửi mail
            DAO_OTPXN.Instance.TaoOTP(username);
        }

        private void txbOTP1_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP1.Text.Length == 1)
                txbOTP2.Focus();
        }

        private void txbOTP2_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP2.Text.Length == 1)
                txbOTP3.Focus();
        }

        private void txbOTP3_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP3.Text.Length == 1)
                txbOTP4.Focus();
        }

        private void txbOTP4_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP4.Text.Length == 1)
                txbOTP5.Focus();
        }

        private void txbOTP5_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP5.Text.Length == 1)
                txbOTP6.Focus();
        }

        private void txbOTP6_TextChanged(object sender, EventArgs e)
        {
            if (txbOTP6.Text.Length == 1)
            {
                // Gộp 6 textbox thành 1 mã OTP
                string maOTP = txbOTP1.Text + txbOTP2.Text + txbOTP3.Text +
                               txbOTP4.Text + txbOTP5.Text + txbOTP6.Text;

                KiemTraOTP(maOTP);
            }
        }

        //Hàm kiểm tra mã otp
        private void KiemTraOTP(string maOTP)
        {
            bool hopLe = DAO_OTPXN.Instance.KiemTraOTP(currentUser, maOTP);

            if (hopLe)
            {
                MessageBox.Show("Xác thực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (frmMain mainForm = new frmMain(currentUser))
                {
                    this.Hide();
                    mainForm.ShowDialog();
                }

                this.Close(); // Đóng OTP sau khi main đóng
            }
            else
            {
                MessageBox.Show("Mã OTP không hợp lệ hoặc đã hết hạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XoaOTPTextBoxes();
                txbOTP1.Focus();
            }
        }

        private void XoaOTPTextBoxes()
        {
            txbOTP1.Clear();
            txbOTP2.Clear();
            txbOTP3.Clear();
            txbOTP4.Clear();
            txbOTP5.Clear();
            txbOTP6.Clear();
        }

        public string LamMoEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex <= 2)
                return new string('*', atIndex) + email.Substring(atIndex);

            string prefix = email.Substring(0, 2);
            string stars = new string('*', atIndex - 2);
            string domain = email.Substring(atIndex);

            return prefix + stars + domain;
        }



    }
}
