using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_HD_MONAN
    {
        private static DAO_HD_MONAN instance;

        public static DAO_HD_MONAN Instance
        {
            get { if (instance == null) instance = new DAO_HD_MONAN(); return DAO_HD_MONAN.instance; }
            private set { DAO_HD_MONAN.instance = value; }
        }

        private DAO_HD_MONAN() { }

        //------- Phương thức lấy doanh thu món ăn của ngày hiện tại
        public double GetDoanhThuNgay()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HD_MONAN WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE)";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToDouble(result);
        }

        //------- Phương thức lấy doanh thu món ăn của tháng hiện tại
        public double GetDoanhThuThang()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HD_MONAN WHERE MONTH(NgayMua) = MONTH(GETDATE()) AND YEAR(NgayMua) = YEAR(GETDATE())";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToDouble(result);
        }

        //------ Phương thức trả về nhân viên dịch vụ nổi trội nhất
        public List<string> GetDanhSachNhanVienDichVuNoiTroi()
        {
            string query = "EXEC usp_NhanVienDichVuNoiTroiNhatThang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<string> danhSach = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(row["HoTen"].ToString());
            }
            return danhSach;
        }

    }
}
