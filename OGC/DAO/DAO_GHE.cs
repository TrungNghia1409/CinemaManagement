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
                    Convert.ToInt32(row["TrangThai"]) // Có thể không dùng nếu bạn lấy theo TRANGTHAIGHE
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
            object result = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
        idGhe, ngayChieu.Date, gioChieu
            });

            return Convert.ToInt32(result) == 1;
        }




        public int GetTrangThaiGheTheoID(int idGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = "SELECT TrangThai FROM TRANGTHAIGHE WHERE IDGhe = @idGhe AND NgayChieu = @ngayChieu AND GioChieu = @gioChieu ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idGhe, ngayChieu, gioChieu });
            return (result == null) ? 0 : Convert.ToInt32(result);
        }


        public int GetTrangThaiGheTheoMa(int idPhong, string maGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = "EXEC usp_GetTrangThaiGheTheoPhongVaSuatChieu @IDPhong , @MaGhe , @NgayChieu , @GioChieu";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
        idPhong,
        maGhe,
        ngayChieu.Date,
        gioChieu
            });

            // Nếu không có kết quả thì mặc định là ghế trống (0)
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public bool TaoGheTheoPhong(int idPhong)
        {
            // Lấy SoHang, SoCot từ loại phòng
            int idLoaiPhong = DAO_PHONGCHIEU.Instance.LayIDLoaiPhongTheoIDPhong(idPhong);
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT SoHang, SoCot FROM LOAIPHONG WHERE ID = @ID ", new object[] { idLoaiPhong });

            if (dt.Rows.Count == 0)
                return false;

            int soHang = Convert.ToInt32(dt.Rows[0]["SoHang"]);
            int soCot = Convert.ToInt32(dt.Rows[0]["SoCot"]);

            string query = "EXEC usp_TaoGheTheoPhong @IDPhong , @SoHang , @SoCot ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idPhong, soHang, soCot });

            return result >= 0; // vì luôn có thể insert 0 hoặc nhiều ghế
        }

        // Hàm loại bỏ dấu tiếng Việt
        public static string LoaiBoDau(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            string[] vietnameseSigns = new string[]
            {
                "aàáâãäåāăą",
                "eèéêẽëēĕę",
                "iìíîĩïīĭ",
                "oòóôõöōŏ",
                "uùúûũüūŭ",
                "yỳýŷỹ",
                "dđ",
                "AÀÁÂÃÄÅĀĂĄ",
                "EÈÉÊẼËĒĔĘ",
                "IÌÍÎĨÏĪĬ",
                "OÒÓÔÕÖŌŎ",
                "UÙÚÛŨÜŪŬ",
                "YỲÝŶỸ",
                "DĐ"
            };

            string result = input;
            for (int i = 0; i < vietnameseSigns.Length; i++)
            {
                char replaceChar = vietnameseSigns[i][0];
                for (int j = 1; j < vietnameseSigns[i].Length; j++)
                {
                    result = result.Replace(vietnameseSigns[i][j], replaceChar);
                }
            }
            return result;
        }


    }
}
