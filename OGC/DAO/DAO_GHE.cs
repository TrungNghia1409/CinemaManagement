using Microsoft.Data.SqlClient;
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


        //public int GetTrangThaiGheTheoMa(int idPhong, string maGhe, DateTime ngayChieu, TimeSpan gioChieu)
        //{
        //    string query = "EXEC usp_GetTrangThaiGheTheoPhongVaSuatChieu @IDPhong , @MaGhe , @NgayChieu , @GioChieu ";

        //    object result = DataProvider.Instance.ExecuteScalar(query, new object[]
        //    {
        //idPhong,
        //maGhe,
        //ngayChieu.Date,
        //gioChieu
        //    });

        //    // Nếu không có kết quả thì mặc định là ghế trống (0)
        //    return result != null ? Convert.ToInt32(result) : 0;
        //}


        public int GetTrangThaiGheTheoMa(int idPhong, string maGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = "EXEC usp_GetTrangThaiGheTheoPhongVaSuatChieu @IDPhong , @MaGhe , @NgayChieu , @GioChieu ";

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

        public int GetTrangThaiGheFromGhe(int idGhe)
        {
            try
            {
                Console.WriteLine($"Querying status from GHE for IDGhe={idGhe}");
                string query = "SELECT TrangThai FROM TRANGTHAIGHE WHERE ID = @IDGhe ";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idGhe });
                int trangThai = result != null ? Convert.ToInt32(result) : 0;
                Console.WriteLine($"Returned TrangThai from GHE for ID {idGhe}: {trangThai}");
                return trangThai;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTrangThaiGheFromGhe: {ex.Message}");
                return 0;
            }
        }



        

        // Hàm lấy ID ghế theo mã ghế và ID phòng
        public int LayIDGheTheoMaVaPhong(int idPhong, string maGhe)
        {
            string query = "SELECT ID FROM GHE WHERE IDPhong = @IDPhong AND MaGhe = @MaGhe ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idPhong, maGhe });
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public void ResetTrangThaiGheSauSuatChieu(DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = @"UPDATE TRANGTHAIGHE 
                    SET TrangThai = 0 
                    WHERE NgayChieu <= @NgayChieu 
                    AND GioChieu < @GioChieu 
                    AND TrangThai = 1";

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngayChieu, gioChieu });
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi reset trạng thái ghế: {ex.Message}");
            }
        }


        public int GetTrangThaiGheTheoSuat(int idGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = @"
        SELECT TOP 1 TrangThai 
        FROM TrangThaiGhe 
        WHERE IDGhe = @idGhe 
          AND CAST(NgayChieu AS DATE) = CAST( @ngayChieu AS DATE)
          AND CONVERT(VARCHAR(5), GioChieu, 108) = CONVERT(VARCHAR(5), @gioChieu , 108)";

            object result = DataProvider.Instance.ExecuteScalar(query,
                new object[] { idGhe, ngayChieu.Date, gioChieu });
            return result != null ? Convert.ToInt32(result) : 0;
        }



        

    

        // Hàm mới thay cho DatGhe cũ (dùng SQL trực tiếp, chỉ insert khi ghế chưa có trong TRANGTHAIGHE)
        public bool DatGhe_New(int idGhe, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string queryCheck = @"SELECT COUNT(*) 
                           FROM TRANGTHAIGHE 
                           WHERE IDGhe = @IDGhe 
                             AND NgayChieu = @NgayChieu 
                             AND GioChieu = @GioChieu ";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(queryCheck, new object[]
            {
        idGhe, ngayChieu, gioChieu
            }));

            if (count == 0)
            {
                string insertQuery = @"INSERT INTO TRANGTHAIGHE (IDGhe, NgayChieu, GioChieu, TrangThai) 
                               VALUES ( @IDGhe , @NgayChieu , @GioChieu , 1)";
                int result = DataProvider.Instance.ExecuteNonQuery(insertQuery, new object[]
                {
            idGhe, ngayChieu, gioChieu
                });
                return result > 0;
            }
            return false; // Ghế đã được đặt
        }

        // Lấy ID ghế theo mã ghế
        public int GetIDGheByMaGhe(string maGhe, int idPhong)
        {
            string query = "SELECT ID FROM GHE WHERE MaGhe = @MaGhe AND IDPhong = @IDPhong ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maGhe, idPhong });
            return result != null ? Convert.ToInt32(result) : -1;
        }


    }
}
