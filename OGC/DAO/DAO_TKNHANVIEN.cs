using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_TKNHANVIEN
    {
        private static DAO_TKNHANVIEN instance;

        public static DAO_TKNHANVIEN Instance
        {
            get { if (instance == null) instance = new DAO_TKNHANVIEN(); return DAO_TKNHANVIEN.instance; }
            private set { DAO_TKNHANVIEN.instance = value; }
        }

        public DAO_TKNHANVIEN() { }


        #region Kiểm tra đăng nhập
        // Hàm băm mật khẩu
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // Lấy mật khẩu từ database theo tài khoản nhân viên
        public byte[] GetPasswordHash(string username)
        {
            string query = " SELECT Password FROM TKNHANVIEN WHERE Username = @Username ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

            return result as byte[];
        }


        // So sánh hai mảng byte
        private bool CompareByteArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        // Kiểm tra đăng nhập
        public bool Login(string username, string password)
        {
            byte[] hashedPasswordFromDB = GetPasswordHash(username);
            if (hashedPasswordFromDB == null) return false;  // Không tồn tại tài khoản

            byte[] hashedInputPassword = HashPassword(password);

            return CompareByteArrays(hashedPasswordFromDB, hashedInputPassword);
        }
        #endregion

        //PHƯƠNG THỨC LOAD DANH SÁCH TK Nhân viên
        public DataTable DanhSachTaiKhoan()
        {
            string query = "EXEC usp_danhsachTKNHANVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Thêm tài khoản nhân viên

        public bool AddTaiKhoanNhanVien(string username, string password)
        {
            // Băm mật khẩu trước khi lưu vào SQL
            byte[] hashedPassword = HashPassword(password);

            string query = "EXEC usp_themTKNHANVIEN @Username , @Password ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, hashedPassword });

            return result > 0;
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN TK Nhân viên ĐÃ TỒN TÀI HAY CHƯA
        public bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM TKNHANVIEN WHERE Username = @Username ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tên TK Nhân viên đã tồn tại
        }

        //PHƯƠNG THỨC LẤY TenChucVu theo Username (NV) --> Phục vụ điều kiện trước khi xóa
        public string LayTKNhanVienTheoUsername(string username)
        {
            try
            {
                string query = "EXEC usp_layTKNHANVIEN_theoUsername @Username ";
                object tentaikhoan = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

                if (tentaikhoan != null)
                    return tentaikhoan.ToString();

                return null;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên tài khoản: {ex.Message}");
                return null;
            }
        }

        //PHƯƠNG THỨC XÓA TK Nhân viên
        public bool XoaTKNhanVien(string username)
        {
            // Câu lệnh xóa trong bảng TKNHANVIEN
            string query = @" EXEC usp_xoaTKNHANVIEN @Username ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng TKNHANVIEN
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên TK Nhân viên: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA TK Nhân viên
        public bool SuaTKNhanVien(string username, string password)
        {
            // Câu lệnh sửa tên TK Nhân viên
            string query = @" EXEC usp_suaTKNHANVIEN @Username , @Password ";

            try
            {
                // Thực thi câu lệnh sửa tên TK Nhân viên
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa tên TK Nhân viên: {ex.Message}");
                return false;
            }
        }

        //----- Cập nhật trạng thái của tài khoản 
        public bool SetTrangThaiDangDangNhap(string username)
        {
            string query = "UPDATE TKNHANVIEN SET TrangThai = N'Đang đăng nhập' WHERE Username = @Username ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
            return result > 0;
        }

        //lấy tài khoản đang đăng nhập dựa trên trạng thái "Đang đăng nhập"
        public string LayUsernameDangDangNhap()
        {
            string query = "SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? result.ToString() : null;
        }

        public bool ResetTrangThaiDangNhap()
        {
            string query = "UPDATE TKNHANVIEN SET TrangThai = NULL WHERE TrangThai = N'Đang đăng nhập' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void XoaUsernameDangNhap()
        {
            string query = "DELETE FROM LuuTruTam_TKNhanVien_DangDangNhap";
            DataProvider.Instance.ExecuteNonQuery(query);
        }


    }
}
