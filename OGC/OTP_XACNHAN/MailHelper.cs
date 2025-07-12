using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using OGC.DAO;

namespace OGC.OTP_XACNHAN
{
    public class MailHelper
    {
        private static MailHelper instance;
        public static MailHelper Instance
        {
            get
            {
                if (instance == null) instance = new MailHelper();
                return instance;
            }
        }

        private MailHelper() { }

        public void GuiMailOTP(string username, string otp)
        {
            // Lấy email của nhân viên
            string query = "SELECT Email FROM NHANVIEN WHERE Username = @Username ";
            string emailNguoiNhan = DataProvider.Instance.ExecuteScalar(query, new object[] { username })?.ToString();

            if (string.IsNullOrEmpty(emailNguoiNhan))
            {
                MessageBox.Show("Không tìm thấy email của người dùng " + username, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailGui = "nhoangnghia2104@gmail.com"; // Email gửi 
            string matKhauApp = "arxw alfv jwxf vvwe"; // Mật khẩu App Gmail 16 ký tự
            string tieuDe = "Xác thực OTP đăng nhập hệ thống";
            string noiDung = $"Mã OTP xác thực của bạn là: {otp}\n\nMã có hiệu lực trong 5 phút.";

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(emailGui);
                message.To.Add(emailNguoiNhan);
                message.Subject = tieuDe;
                message.Body = noiDung;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(emailGui, matKhauApp);
                smtp.EnableSsl = true;

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
