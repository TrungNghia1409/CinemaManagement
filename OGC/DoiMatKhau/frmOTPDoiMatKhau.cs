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

namespace OGC.DoiMatKhau
{
    public partial class frmOTPDoiMatKhau : Form
    {
        public string currentUser;
        public frmOTPDoiMatKhau(string username)
        {
            InitializeComponent();

            currentUser = username;

            string email = DAO_NHANVIEN.Instance.GetEmailByUsername(currentUser);
            lblEmail.Text = "Mã OTP đã được gửi về mail " + LamMoEmail(email);

            // Tạo OTP mới và gửi mail
            DAO_OTPXN.Instance.TaoOTP(username);
        }

        #region Events
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

        //sự kiện gửi lại mã otp
        private void lblGuiLaiMaOTP_Click(object sender, EventArgs e)
        {
            // 1. Gọi lại hàm tạo mã OTP mới (có sẵn)
            DAO_OTPXN.Instance.TaoOTP(currentUser);

            MessageBox.Show("Đã gửi lại mã OTP mới về email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. Reset lại các textbox nhập mã OTP (nếu muốn)
            XoaOTPTextBoxes();
            txbOTP1.Focus();
        }
        #endregion

        #region Methods
        private void KiemTraOTP(string maOTP)
        {
            bool hopLe = DAO_OTPXN.Instance.KiemTraOTP(currentUser, maOTP);

            if (hopLe)
            {
                MessageBox.Show("Xác thực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (frmDoiMatKhau f = new frmDoiMatKhau(currentUser))
                {
                    this.Hide();
                    f.ShowDialog();
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

        //hàm làm mờ email: hoangnghia@gmail.com ---> ho********@gmail.com
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
        #endregion
    }
}
