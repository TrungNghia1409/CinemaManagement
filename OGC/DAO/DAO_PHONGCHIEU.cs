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
                    TrangThai = Convert.ToInt32(row["TrangThai"]),
                    MaLoaiPhong = Convert.ToInt32(row["MaLoaiPhong"]),
                    AnhPhong = row["AnhPhong"] != DBNull.Value ? row["AnhPhong"].ToString() : string.Empty
                };
                ds.Add(phong);
            }

            return ds;
        }

        

        //Nhớ thêm ảnh phòng :>
        public bool ThemPhongChieu(DTO_PHONGCHIEU phong)
        {
            string query = "INSERT INTO PHONGCHIEU (TenPhong,TrangThai, MaLoaiPhong) " +
                           "VALUES ( @TenPhong , @TrangThai , @MaLoaiPhong )";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { phong.TenPhong, phong.TrangThai, phong.MaLoaiPhong, phong.AnhPhong });
            return result > 0;
        }

        public bool SuaPhongChieu(DTO_PHONGCHIEU phong)
        {
            string query = "UPDATE PHONGCHIEU SET TenPhong = @TenPhong , TrangThai = @TrangThai , " +
                           "MaLoaiPhong = @MaLoaiPhong WHERE ID = @ID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { phong.TenPhong, phong.TrangThai, phong.MaLoaiPhong, phong.ID });
            return result > 0;
        }

        public bool XoaPhongChieu(int id)
        {
            string query = "DELETE FROM PHONGCHIEU WHERE ID = @ID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }


        public int? GetIDPhongByTenPhong(string tenPhong)
        {
            string query = "SELECT ID FROM PHONGCHIEU WHERE TenPhong = @TenPhong ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhong });

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["ID"]);
            }
            else
            {
                return null; // Không tìm thấy phòng
            }
        }



        //---- lấy id loại phòng từ id phòng
        public int LayIDLoaiPhongTheoIDPhong(int idPhong)
        {
            string query = "SELECT MaLoaiPhong FROM PHONGCHIEU WHERE ID = @ID ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idPhong });
            return result != null ? Convert.ToInt32(result) : -1;
        }


        public int? GetIDPhongTheoTenPhim(string tenPhim)
        {
            string query = @"
        SELECT TOP 1 LC.IDPhong
        FROM LICHCHIEU LC
        JOIN PHIM P ON LC.IDPhim = P.ID
        WHERE P.TenPhim = @TenPhim ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenPhim });

            if (result != null && result != DBNull.Value)
                return Convert.ToInt32(result);
            else
                return null; // Không tìm thấy phòng chiếu cho phim
        }




        public string GetTenLoaiPhongByIDPhong(int? idPhong)
        {
            string query = @"
        SELECT LP.TenLoaiPhong 
        FROM PHONGCHIEU PC
        JOIN LOAIPHONG LP ON PC.MaLoaiPhong = LP.ID
        WHERE PC.ID = @ID ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idPhong });

            if (result != null && result != DBNull.Value)
                return result.ToString();
            else
                return string.Empty;
        }



    }
}
