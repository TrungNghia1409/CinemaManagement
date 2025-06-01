using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_CTHD_MONAN
    {
        private static DAO_CTHD_MONAN instance;

        public static DAO_CTHD_MONAN Instance
        {
            get { if (instance == null) instance = new DAO_CTHD_MONAN(); return DAO_CTHD_MONAN.instance; }
            private set { DAO_CTHD_MONAN.instance = value; }
        }

        private DAO_CTHD_MONAN() { }

        //----- thêm chi tiết hóa đơn món ăn
        public bool ThemChiTietHoaDonMonAn(int idHoaDon, int idMonAn, int soLuong, decimal donGia)
        {
            string query = "EXEC usp_ThemCTHDMONAN @IDHoaDon , @IDMonAn , @SoLuong , @DonGia ";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idMonAn, soLuong, donGia });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn món ăn: " + ex.Message);
                return false;
            }
        }

        public DataTable LayDSByIDHoaDon(int idHoaDon)
        {
            string query = "EXEC usp_DanhSachCTHD_MONAN @IDHoaDon ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idHoaDon });
        }




    }
}
