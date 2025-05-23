using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_LOAIPHONG
    {
        private static DAO_LOAIPHONG instance;

        public static DAO_LOAIPHONG Instance
        {
            get { if (instance == null) instance = new DAO_LOAIPHONG(); return DAO_LOAIPHONG.instance; }
            private set { DAO_LOAIPHONG.instance = value; }
        }
        //PHƯƠNG THỨC LOAD DANH SÁCH LOẠI PHÒNG
        public DataTable DanhSachLoaiPhong()
        {
            string query = "EXEC usp_danhsachLOAIPHONG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //PHƯƠNG THỨC THÊM loại phòng
        public bool ThemLoaiPhong(string tenLoaiPhong)
        {
            string query = "EXEC usp_themLOAIPHONG @TenLoaiPhong ";

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoaiPhong });
                return result > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi thêm tên loại phòng: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN LOẠI PHÒNG ĐÃ TỒN TÀI HAY CHƯA
        public bool IsTenLoaiPhongExists(string tenLoaiPhong)
        {
            string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE TenLoaiPhong = @TenLoaiPhong ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenLoaiPhong });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tên loại phòng đã tồn tại
        }

        //PHƯƠNG THỨC XÓA loại phòng
        public bool XoaLoaiPhong(string tenLoaiPhong)
        {
            // Câu lệnh xóa trong bảng LOAIPHONG
            string query = @" EXEC usp_XoaLoaiPhong @TenLoaiPhong ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng LOAIPHONG
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoaiPhong });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên loại phòng: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA loại phòng
        public bool SuaLoaiPhong(int iD, string tenLoaiPhong)
        {
            // Câu lệnh sửa tên loại phòng
            string query = @" EXEC usp_suaLOAIPHONG @ID , @TenLoaiPhong ";

            try
            {
                // Thực thi câu lệnh sửa tên loại phòng
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD, tenLoaiPhong });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa tên loại phòng: {ex.Message}");
                return false;
            }
        }
    }
}
