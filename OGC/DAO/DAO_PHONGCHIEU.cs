using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_PHONGCHIEU
    {
        private static DAO_PHONGCHIEU instance;

        public static DAO_PHONGCHIEU Instance
        {
            get { if (instance == null) instance = new DAO_PHONGCHIEU(); return DAO_PHONGCHIEU.instance; }
            private set { DAO_PHONGCHIEU.instance = value; }
        }

        private DAO_PHONGCHIEU() { }

        public List<DTO_PHONGCHIEU> DanhSachTenPhong_List()
        {
            List<DTO_PHONGCHIEU> ds = new List<DTO_PHONGCHIEU>();

            string query = "SELECT * FROM PHONGCHIEU ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU();
                phong.ID = Convert.ToInt32(row["ID"]);
                phong.TenPhong = row["TenPhong"].ToString();
                phong.AnhPhong = row["AnhPhong"] != DBNull.Value ? row["AnhPhong"].ToString() : string.Empty;
                ds.Add(phong);
            }

            return ds;
        }

        public List<DTO_PHONGCHIEU> DanhSachPhongChieu()
        {
            List<DTO_PHONGCHIEU> ds = new List<DTO_PHONGCHIEU>();

            // Chỉ chọn những cột thực sự cần thiết
            string query = @"SELECT 
                         ID, 
                         TenPhong, 
                         SucChua, 
                         TrangThai, 
                         MaLoaiPhong, 
                         AnhPhong 
                     FROM PHONGCHIEU";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU
                {
                    ID = Convert.ToInt32(row["ID"]),
                    TenPhong = row["TenPhong"].ToString(),
                    SucChua = Convert.ToInt32(row["SucChua"]),
                    TrangThai = Convert.ToInt32(row["TrangThai"]),
                    MaLoaiPhong = Convert.ToInt32(row["MaLoaiPhong"]),
                    AnhPhong = row["AnhPhong"] != DBNull.Value ? row["AnhPhong"].ToString() : string.Empty
                };
                ds.Add(phong);
            }

            return ds;
        }

        


        public bool ThemPhongChieu(DTO_PHONGCHIEU phong)
        {
            string query = "INSERT INTO PHONGCHIEU (TenPhong, SucChua, TrangThai, MaLoaiPhong, AnhPhong) " +
                           "VALUES (@TenPhong, @SucChua, @TrangThai, @MaLoaiPhong, @AnhPhong)";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { phong.TenPhong, phong.SucChua, phong.TrangThai, phong.MaLoaiPhong, phong.AnhPhong });
            return result > 0;
        }

        public bool SuaPhongChieu(DTO_PHONGCHIEU phong)
        {
            string query = "UPDATE PHONGCHIEU SET TenPhong = @TenPhong, SucChua = @SucChua, TrangThai = @TrangThai, " +
                           "MaLoaiPhong = @MaLoaiPhong, AnhPhong = @AnhPhong WHERE ID = @ID";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { phong.TenPhong, phong.SucChua, phong.TrangThai, phong.MaLoaiPhong, phong.AnhPhong, phong.ID });
            return result > 0;
        }

        public bool XoaPhongChieu(int id)
        {
            string query = "DELETE FROM PHONGCHIEU WHERE ID = @ID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }



    }
}
