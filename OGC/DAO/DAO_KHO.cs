using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_KHO
    {
        private static DAO_KHO instance;

        public static DAO_KHO Instance
        {
            get { if (instance == null) instance = new DAO_KHO(); return DAO_KHO.instance; }
            private set { DAO_KHO.instance = value; }
        }

        private DAO_KHO() { }

        //---- load danh sách món ăn hiện có trong kho
        public DataTable LoadKho()
        {
            string query = @" EXEC usp_danhsachKHO";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //----- thêm món ăn vào kho (nhập món mới về kho)
        public bool ThemKho(int idMonAn, string tenMonAn, int soLuong, DateTime ngayCapnhat)
        {
            string query = "EXEC usp_ThemKHO @IDMonAn , @TenMonAn , @SoLuongTon , @NgayCapNhat ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMonAn, tenMonAn, soLuong, ngayCapnhat });
            return result > 0;
        }

        //------ sửa thông tin món ăn trong kho (nhập lô hàng với món ăn đã có trong kho)
        public bool SuaKho(string tenMonAn, int soLuongThem)
        {
            string query = "EXEC sp_SuaKHO @TenMonAn , @SoLuongThem ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenMonAn, soLuongThem });
            return result > 0;
        }

        //------Xóa món ăn khỏi kho
        public bool XoaKho(string tenMonAn)
        {
            string query = "EXEC sp_XoaKHO @TenMonAn ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenMonAn });
            return result > 0;
        }


        public int LayMaxIDMonAn()
        {
            string query = " SELECT MAX(IDMonAn) FROM KHO ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { });
            return Convert.ToInt32(result);
        }

        public int LayMaxIDKho()
        {
            string query = " SELECT MAX(ID) FROM KHO ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { });
            return Convert.ToInt32(result);
        }


        //----- lấy IDMonAn dựa trên tên, mục đích xác định xem món đó đã có trong kho chưa
        public int LayIDMonAnTheoTen(string tenMonAn)
        {
            string query = @" SELECT IDMonAn FROM KHO WHERE TenMonAn = @TenMonAn ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenMonAn });
            return Convert.ToInt32(result);
        }

        //---- kiểm tra ID (món ăn) đó có tồn tại trong kho hay không
        public bool KiemTraMonAnTrongKho(int idMonAn)
        {
            string query = "SELECT COUNT(*) FROM KHO WHERE IDMonAn = @IDMonAn ";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idMonAn });
            return count > 0;
        }







    }
}
