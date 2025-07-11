using OGC.OTP_XACNHAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_OTPXN
    {
            private static DAO_OTPXN instance;

            public static DAO_OTPXN Instance
            {
                get { if (instance == null) instance = new DAO_OTPXN(); return DAO_OTPXN.instance; }
                private set { DAO_OTPXN.instance = value; }
            }

            private DAO_OTPXN() { }

        // Tạo OTP mới (xoá cái cũ nếu có)
        public void TaoOTP(string username)
        {
            string maOTP = TaoMaOTP_NgauNhien(); // gọi hàm tạo random 6 số

            //xóa otp cũ, trường hợp trigger chạy không kịp
            string query = @"
            DELETE FROM OTP_XACNHAN 
            WHERE DATEDIFF(MINUTE, ThoiGianTao, GETDATE()) >= 5;

            INSERT INTO OTP_XACNHAN (Username, MaOTP, ThoiGianTao, TrangThai)
            VALUES ( @Username , @MaOTP , GETDATE(), N'Chưa dùng');
        ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, maOTP });

            // Gửi mail OTP
            MailHelper.Instance.GuiMailOTP(username, maOTP); // gọi class gửi mail OTP 
        }

        // Xóa toàn bộ OTP của 1 người
        public void XoaOTP(string username)
        {
            string query = "DELETE FROM OTP_XACNHAN WHERE Username = @Username ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
        }

        // Hàm tạo mã ngẫu nhiên 6 số
        private string TaoMaOTP_NgauNhien()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString(); // 6 chữ số
        }

        //hàm kiểm tra mã otp
        public bool KiemTraOTP(string username, string maOTP)
        {
            string query = @"
        SELECT TOP 1 MaOTP 
        FROM OTP_XACNHAN 
        WHERE Username = @Username 
          AND TrangThai = N'Chưa dùng'
          AND DATEDIFF(MINUTE, ThoiGianTao, GETDATE()) <= 5
        ORDER BY ThoiGianTao DESC ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

            if (result != null && result.ToString() == maOTP)
            {
                // Cập nhật trạng thái sang "Đã dùng"
                string queryUpdate = @"
            UPDATE OTP_XACNHAN 
            SET TrangThai = N'Đã dùng' 
            WHERE Username = @Username AND MaOTP = @MaOTP ";

                DataProvider.Instance.ExecuteNonQuery(queryUpdate, new object[] { username, maOTP });

                return true;
            }

            return false;
        }

    }
}
