using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_HD_VE
    {
        private static DAO_HD_VE instance;

        public static DAO_HD_VE Instance
        {
            get { if (instance == null) instance = new DAO_HD_VE(); return DAO_HD_VE.instance; }
            private set { DAO_HD_VE.instance = value; }
        }

        private DAO_HD_VE() { }

        //------- Phương thức lấy doanh thu vé bán của ngày hiện tại
        public double GetDoanhThuNgay()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HD_VE WHERE CAST(NgayDat AS DATE) = CAST(GETDATE() AS DATE)";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToDouble(result);
        }

        //------- Phương thức lấy doanh thu vé bán của tháng hiện tại
        public double GetDoanhThuThang()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HD_VE WHERE MONTH(NgayDat) = MONTH(GETDATE()) AND YEAR(NgayDat) = YEAR(GETDATE())";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToDouble(result);
        }

        //----- Phương thức trả về số vé bán được trong ngày hiện tại
        public int GetSoVeBanTrongNgay()
        {
            string query = "SELECT COUNT(ID) FROM HD_VE WHERE CAST(NgayDat AS DATE) = CAST(GETDATE() AS DATE)";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        //----- Phương thức trả về số vé bán được trong tháng hiện tại
        public int GetSoVeBanTrongThang()
        {
            string query = "SELECT COUNT(ID) FROM HD_VE WHERE MONTH(NgayDat) = MONTH(GETDATE()) AND YEAR(NgayDat) = YEAR(GETDATE())";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        //------ Phương thức trả về nhân viên bán vé nổi trội nhất
        public List<string> GetDanhSachNhanVienBanVeNoiTroi()
        {
            string query = "EXEC usp_NhanVienNoiTroiNhatThang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<string> danhSach = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(row["HoTen"].ToString());
            }
            return danhSach;
        }

        //------ Phương thức trả về phim được chiếu nhiều nhất (ở DAO LICHCHIEU)
        
        //------ Phương thức trả về phim được chiếu ít nhất
        //------ Phương thức trả về phim có doanh thu cao nhất


    }
}
