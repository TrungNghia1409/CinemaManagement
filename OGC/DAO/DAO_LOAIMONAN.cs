using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_LOAIMONAN
    {
        private static DAO_LOAIMONAN instance;

        public static DAO_LOAIMONAN Instance
        {
            get { if (instance == null) instance = new DAO_LOAIMONAN(); return DAO_LOAIMONAN.instance; }
            private set { DAO_LOAIMONAN.instance = value; }
        }

        private DAO_LOAIMONAN() { }

        //PHƯƠNG THỨC LOAD DANH SÁCH LOẠI MÓN ĂN
        public DataTable DanhSachLoaiMonAn()
        {
            string query = "EXEC usp_danhsachLOAIMONAN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //PHƯƠNG THỨC THÊM LOẠI MÓN ĂN
        public bool ThemLoaiMonAn(string tenLoaiMonAn)
        {
            string query = "EXEC usp_themLOAIMONAN @TenLoai ";

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoaiMonAn });
                return result > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi thêm tên loại món ăn: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN LOẠI MÓN ĂN ĐÃ TỒN TÀI HAY CHƯA
        public bool IsTenLoaiMonAnExists(string tenLoaiMonAn)
        {
            string query = "SELECT COUNT(*) FROM LoaiMonAn WHERE TenLoai = @TenLoai ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenLoaiMonAn });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tên LOẠI MÓN ĂN đã tồn tại
        }

        //PHƯƠNG THỨC XÓA LOẠI MÓN ĂN
        public bool XoaLoaiMonAn(string tenLoaiMonAn)
        {
            // Câu lệnh xóa trong bảng LoaiMonAn
            string query = @" EXEC usp_XoaLOAIMONAN @TenLoai ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng LoaiMonAn
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoaiMonAn });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên LOẠI MÓN ĂN: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA LOẠI MÓN ĂN
        public bool SuaLoaiMonAn(int iD, string tenLoaiMonAn)
        {
            // Câu lệnh sửa tên LOẠI MÓN ĂN
            string query = @" EXEC usp_suaLOAIMONAN @ID , @TenLoai ";

            try
            {
                // Thực thi câu lệnh sửa tên LOẠI MÓN ĂN
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD, tenLoaiMonAn });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa tên LOẠI MÓN ĂN: {ex.Message}");
                return false;
            }
        }
    }
}
