using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_CHUCVU
    {
        private static DAO_CHUCVU instance;

        public static DAO_CHUCVU Instance
        {
            get { if (instance == null) instance = new DAO_CHUCVU(); return DAO_CHUCVU.instance; }
            private set { DAO_CHUCVU.instance = value; }
        }

        private DAO_CHUCVU() { }


        //PHƯƠNG THỨC LOAD DANH SÁCH CHỨC VỤ
        public DataTable DanhSachChucVu()
        {
            string query = "EXEC usp_danhsachCHUCVU";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //PHƯƠNG THỨC THÊM CHỨC VỤ
        public bool ThemChucVu(string tenChucVu)
        {
            string query = "EXEC usp_themCHUCVU @TenChucVu ";

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenChucVu });
                return result > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi thêm tên chức vụ: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN CHỨC VỤ ĐÃ TỒN TÀI HAY CHƯA
        public bool IsTenChucVuExists(string tenChucVu)
        {
            string query = "SELECT COUNT(*) FROM CHUCVU WHERE TenChucVu = @TenChucVu ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenChucVu });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tên chức vụ đã tồn tại
        }

        //PHƯƠNG THỨC LẤY TenChucVu theo Username (NV) --> Phục vụ điều kiện trước khi xóa
        public string LayTenChucVuTheoUsername(string username)
        {
            string tenChucVu = null;
            try
            {
                string query = "EXEC sp_LayTenChucVuTheoUsername @TenChucVu ";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

                if (result != null)
                    return result.ToString();

                return null;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên chức vụ: {ex.Message}");
                return null;
            }
        }
        //PHƯƠNG THỨC XÓA CHỨC VỤ
        public bool XoaChucVu(string tenChucVu)
        {
            // Câu lệnh xóa trong bảng CHUCVU
            string query = @" EXEC usp_XoaTenChucVu @TenChucVu ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng CHUCVU
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenChucVu });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên chức vụ: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA CHỨC VỤ
        public bool SuaChucVu(int iD, string tenChucVu)
        {
            // Câu lệnh sửa tên chức vụ
            string query = @" EXEC usp_suaCHUCVU @ID , @TenChucVu ";

            try
            {
                // Thực thi câu lệnh sửa tên chức vụ
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD, tenChucVu });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa tên chức vụ: {ex.Message}");
                return false;
            }
        }
    }
}
