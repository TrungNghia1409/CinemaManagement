using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_DINHDANGPHIM
    {
        private static DAO_DINHDANGPHIM instance;

        public static DAO_DINHDANGPHIM Instance
        {
            get { if (instance == null) instance = new DAO_DINHDANGPHIM(); return DAO_DINHDANGPHIM.instance; }
            private set { DAO_DINHDANGPHIM.instance = value; }
        }

        private DAO_DINHDANGPHIM() { }

        //PHƯƠNG THỨC LOAD DANH SÁCH ĐỊNH DẠNG
        public DataTable DanhSachDinhDang()
        {
            string query = "EXEC usp_danhsachDINHDANGPHIM";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //PHƯƠNG THỨC KIỂM TRA TÊN ĐỊNH DẠNG ĐÃ TỒN TÀI HAY CHƯA
        public bool IsTenDinhDangExists(string tenDinhDang)
        {
            string query = "SELECT COUNT(*) FROM DINHDANGPHIM WHERE TenDinhDang = @TenDinhDang ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenDinhDang });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tên định dạng đã tồn tại
        }

        //PHƯƠNG THỨC THÊM ĐỊNH DẠNG
        public bool ThemDinhDang(string tenDinhDang)
        {
            string query = "EXEC usp_themDINHDANGPHIM @TenDinhDang ";

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDinhDang });
                return result > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi thêm tên định dạng: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA ĐỊNH DẠNG
        public bool XoaDinhDang(string tenDinhDang)
        {
            // Câu lệnh xóa trong bảng DINHDANG
            string query = @" EXEC usp_xoaDINHDANGPHIM  @TenDinhDang ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng DINHDANG
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDinhDang });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa tên định dạng: {ex.Message}");
                return false;
            }
        }

        //PHƯƠNG THỨC XÓA ĐỊNH DẠNG
        public bool SuaDINHDANG(int iD, string tenDinhDang)
        {
            // Câu lệnh sửa tên định dạng
            string query = @" EXEC usp_suaDINHDANGPHIM @ID , @TenDinhDang ";

            try
            {
                // Thực thi câu lệnh sửa tên định dạng
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD, tenDinhDang });

                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi sửa tên định dạng: {ex.Message}");
                return false;
            }
        }

        public List<DTO_DINHDANGPHIM> ListDinhDangPhim()
        {
            List<DTO_DINHDANGPHIM> list = new List<DTO_DINHDANGPHIM>();

            string query = "EXEC usp_danhsachDINHDANGPHIM";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO_DINHDANGPHIM(row));
            }

            return list;
        }
    }
}
