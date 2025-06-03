using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace OGC.DAO
{
    public class DAO_Ghe
    {
        private static DAO_Ghe instance;
        public static DAO_Ghe Instance
        {
            get { if (instance == null) instance = new DAO_Ghe(); return instance; }
            private set { instance = value; }
        }
        private DAO_Ghe() { }

        // Lấy danh sách ghế theo ID phòng
        public List<GheDTO> GetListGheByIDPhong(int idPhong)
        {
            List<GheDTO> list = new List<GheDTO>();

            string query = "SELECT * FROM GHE WHERE IDPhong = @IDPhong ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idPhong });

            foreach (DataRow row in data.Rows)
            {
                GheDTO ghe = new GheDTO(
                    Convert.ToInt32(row["ID"]),
                    Convert.ToInt32(row["IDPhong"]),
                    row["MaGhe"].ToString(),
                    Convert.ToInt32(row["TrangThai"])
                );
                list.Add(ghe);
            }

            return list;
        }

        // Cập nhật trạng thái ghế (0 hoặc 1)
        public bool UpdateTrangThaiGhe(int idGhe, int trangThai)
        {
            string query = "UPDATE GHE SET TrangThai = @trangThai WHERE ID = @IDGhe ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { trangThai, idGhe });
            return result > 0;
        }

        // Lấy danh sách ghế của phòng
        public DataTable GetGheTheoPhong(int idPhong)
        {
            string query = "SELECT * FROM GHE WHERE IDPhong = @IDPhong ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idPhong });
        }

        // Lấy trạng thái ghế đã đặt hay chưa tại suất chiếu (phòng, ghế, ngày, giờ)
        public int GetTrangThaiGhe(int idPhong, string maGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = "EXEC usp_GetTrangThaiGheTheoPhongVaSuatChieu @IDPhong , @MaGhe , @NgayChieu , @GioChieu ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idPhong, maGhe, ngayChieu, gioChieu });
            return (result == null) ? 0 : Convert.ToInt32(result);
        }

        // Đặt ghế (update trạng thái hoặc insert vé)
        public bool DatGhe(int idGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = "EXEC usp_DatGhe @IDGhe , @NgayChieu , @GioChieu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idGhe, ngayChieu, gioChieu });
            return result > 0;
        }

        //---- load danh sách số lượng ghế dựa trên loại phòng chiếu
        public DataTable LoadGheTheoLoaiPhong(int idLoaiPhong)
        {
            string query = @"
        SELECT G.*
        FROM GHE G
        INNER JOIN PHONGCHIEU P ON G.IDPhong = P.ID
        WHERE P.MaLoaiPhong = @idLoaiPhong";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { idLoaiPhong });
        }


    }
}
