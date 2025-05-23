using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_THELOAIPHIM
    {
        private static DAO_THELOAIPHIM instance;

        public static DAO_THELOAIPHIM Instance
        {
            get { if (instance == null) instance = new DAO_THELOAIPHIM(); return DAO_THELOAIPHIM.instance; }
            private set { DAO_THELOAIPHIM.instance = value; }
        }

        private DAO_THELOAIPHIM() { }

        //PHƯƠNG THỨC LOAD DANH SÁCH THỂ LOẠI
        public DataTable DanhSachTheLoaiPhim()
        {
            string query = "EXEC usp_danhsachTHELOAIPHIM";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //PHƯƠNG THỨC THÊM THỂ LOẠI
        public bool ThemTheLoaiPhim(string tenTheLoai)
        {
            string query = "EXEC usp_themTHELOAIPHIM @TenTheLoai ";

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTheLoai });
                return result > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi thêm thể loại phim: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN CHỨC VỤ ĐÃ TỒN TÀI HAY CHƯA
        public bool IsTheLoaiPhimExists(string tenTheLoai)
        {
            string query = "SELECT COUNT(*) FROM CHUCVU WHERE TenTheLoai = @TenTheLoai ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenTheLoai });

            return Convert.ToInt32(result) > 0; // Trả về true nếu thể loại đã tồn tại
        }


        //PHƯƠNG THỨC SỬA THỂ LOẠI
        public bool SuaTheLoaiPhim(string tenTheLoai)
        {
            // Câu lệnh xóa trong bảng THELOAIPHIM
            string query = @" EXEC usp_suaTHELOAIPHIM @TenTheLoai ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng THELOAIPHIM
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTheLoai });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa thể loại phim: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA THỂ LOẠI
        public bool XoaTheLoaiPhim(string tenTheLoai)
        {
            // Câu lệnh xóa trong bảng THELOAIPHIM
            string query = @" EXEC usp_xoaTHELOAIPHIM @TenTheLoai ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng THELOAIPHIM
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTheLoai });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa thể loại phim: {ex.Message}");
                return false;
            }
        }
    }
}
