using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_LICHCHIEU
    {
        private static DAO_LICHCHIEU instance;

        public static DAO_LICHCHIEU Instance
        {
            get { if (instance == null) instance = new DAO_LICHCHIEU(); return DAO_LICHCHIEU.instance; }
            private set { DAO_LICHCHIEU.instance = value; }
        }

        private DAO_LICHCHIEU() { }


        //-------- Lấy danh sách các lịch chiếu
        public List<DTO_LICHCHIEU> DanhSachLichChieu()
        {
            List<DTO_LICHCHIEU> list = new List<DTO_LICHCHIEU>();

            string query = @" usp_danhsachLICHCHIEU ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                DTO_LICHCHIEU lc = new DTO_LICHCHIEU();
                lc.ID = Convert.ToInt32(row["ID"]);
                lc.IDPhim = Convert.ToInt32(row["IDPhim"]);
                lc.TenPhim = row["TenPhim"].ToString();
                lc.TenPhong = row["TenPhong"].ToString();
                lc.IDPhong = Convert.ToInt32(row["IDPhong"]);
                lc.NgayGio = Convert.ToDateTime(row["NgayGio"]);
                lc.GiaVe = Convert.ToDecimal(row["GiaVe"]); ;
                lc.DiaDiem = row["DiaDiem"].ToString();
                lc.Anh = row["Anh"].ToString();
                lc.AnhPhong = row["AnhPhong"].ToString();

                list.Add(lc);
            }

            return list;
        }
        //--------- Trả về phim được chiếu nhiều nhất
        public List<string> GetPhimChieuNhieuNhat()
        {
            string query = "EXEC usp_PhimChieuNhieuNhat ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<string> danhSach = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(row["TenPhim"].ToString());
            }
            return danhSach;
        }
        //--------- Trả về phim được chiếu ít nhất
        public List<string> GetPhimChieuItNhat()
        {
            string query = "EXEC usp_PhimChieuItNhat ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<string> danhSach = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(row["TenPhim"].ToString());
            }
            return danhSach;
        }

        //--------- thêm lịch chiếu
        public bool ThemLichChieu(string tenPhim, string tenPhong, DateTime ngayGio, decimal giaVe, string diaDiem)
        {
            //chuỗi thực thi proc thêm lịch chiếu
            string queryNhanVien = "EXEC usp_themLICHCHIEU @TenPhim , @TenPhong , @NgayGio , @GiaVe , @DiaDiem ";

            int result = DataProvider.Instance.ExecuteNonQuery(queryNhanVien, new object[] { tenPhim , tenPhong, ngayGio, giaVe, diaDiem });

            return result > 0;

        }


        //--------- xóa lịch chiếu
        public bool XoaLichChieu(int iD)
        {
            //chuỗi thực thi proc xóa lịch chiếu
            string query = @" EXEC usp_suaLICHCHIEU @ID ";


            try
            {
                // Thực thi câu lệnh DELETE cho bảng LICHCHIEU
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD });
                return (result > 0);
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa lịch chiếu: {ex.Message}");
                return false;
            }
        }
        //--------- sửa lịch chiếu
        public bool SuaLichChieu(int iD, string tenPhim, string tenPhong, DateTime ngayGio, decimal giaVe, string diaDiem)
        {
            string query = "EXEC usp_suaLICHCHIEU @ID , @TenPhim , @TenPhong , @NgayGio , @GiaVe , @DiaDiem ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            { iD, tenPhim, tenPhong, ngayGio, giaVe, diaDiem});

            return result > 0;
        }


        //--------- lấy thông tin lịch chiếu dựa trên ID
        public DTO_LICHCHIEU GetLichChieuByID(int id)
        {
            string query = "SELECT * FROM LICHCHIEU WHERE ID = @ID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (data.Rows.Count > 0)
            {
                return new DTO_LICHCHIEU(data.Rows[0]);
            }
            return null;
        }


        //---------- test chức năng lọc ngày chiếu
        public List<DTO_LICHCHIEU> LocLichChieuTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<DTO_LICHCHIEU> danhSach = new List<DTO_LICHCHIEU>();
            string query = @" 
                             SELECT lc.ID, lc.IDPhim, lc.IDPhong, ISNULL(P.TenPhim, LC.TenPhim) AS TenPhim,
                                    pc.TenPhong, LC.NgayGio, LC.GiaVe, LC.DiaDiem, P.Anh, pc.AnhPhong
                             FROM LICHCHIEU LC
                             LEFT JOIN PHIM P ON LC.IDPhim = P.ID
                             LEFT JOIN PHONGCHIEU pc ON pc.ID = lc.IDPhong
                             WHERE ( LC.NgayGio >=  @tuNgay  ) AND ( LC.NgayGio <=   @denNgay  )
                             ORDER BY LC.NgayGio";

            // CHUẨN HÓA: Bao phủ cả ngày đến 23:59:59
            DateTime tuNgayChuan = tuNgay.Date;
            DateTime denNgayChuan = denNgay.Date.AddDays(1).AddTicks(-1);

            // Truyền DateTime trực tiếp
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgayChuan, denNgayChuan });

            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(new DTO_LICHCHIEU(row));
            }

            return danhSach;
        }

        public List<DTO_LICHCHIEU> LocLichChieuTuNgay(DateTime tuNgay)
        {
            List<DTO_LICHCHIEU> danhSach = new List<DTO_LICHCHIEU>();
            string query = "SELECT * FROM LichChieu WHERE NgayGio >= @tuNgay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay });

            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(new DTO_LICHCHIEU(row));
            }
            return danhSach;
        }

        // Lấy danh sách lịch chiếu theo phim, ngày và định dạng
        public List<DTO_LICHCHIEU> GetLichChieuTheoPhimNgayDinhDang(string tenPhim, DateTime ngayChieu, string tenDinhDang)
        {
            List<DTO_LICHCHIEU> danhSach = new List<DTO_LICHCHIEU>();

            string query = "EXEC usp_GetGioChieuTheoPhimNgayDinhDang @TenPhim , @NgayChieu , @TenDinhDang";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim, ngayChieu, tenDinhDang });

            foreach (DataRow row in dt.Rows)
            {
                DTO_LICHCHIEU lc = new DTO_LICHCHIEU();

                // Bắt buộc ánh xạ những trường DTO có
                lc.ID = row.Table.Columns.Contains("IDLichChieu") ? Convert.ToInt32(row["IDLichChieu"]) : 0;
                lc.TenPhim = row["TenPhim"].ToString();
                lc.TenPhong = row["TenPhong"].ToString();
                lc.NgayGio = Convert.ToDateTime($"{row["NgayChieu"]} {row["GioChieu"]}");
                lc.GiaVe = Convert.ToDecimal(row["GiaVe"]);
                lc.DiaDiem = row["DiaDiem"].ToString();

                // Bỏ qua TenDinhDang (vì DTO không có)

                danhSach.Add(lc);
            }

            return danhSach;
        }



        public DataTable GetGioChieuTheoPhimVaNgay(string tenPhim, DateTime ngayChieu)
        {
            string query = "EXEC usp_GetGioChieuTheoPhimVaNgay @TenPhim , @NgayGio ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim, ngayChieu });
        }

        public DTO_DINHDANGPHIM GetDinhDangPhimTheoTenPhim(string tenPhim)
        {
            string query = "EXEC usp_GetDinhDangPhimTheoTenPhim @TenPhim";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new DTO_DINHDANGPHIM
                {
                    ID = Convert.ToInt32(row["ID"]),
                    TenDinhDang = row["TenDinhDang"].ToString()
                };
            }
            return null;
        }

        public List<DateTime> GetNgayChieuTheoPhim(string tenPhim)
        {
            List<DateTime> list = new List<DateTime>();
            string query = "EXEC usp_GetNgayChieuTheoPhim @TenPhim ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim });

            foreach (DataRow row in dt.Rows)
            {
                list.Add(Convert.ToDateTime(row["NgayGio"]));
            }

            return list;
        }

        public int LayIDphongDuaTrenIDPhim(int IDPhim)
        {
            string query = "SELECT IDPhong FROM LICHCHIEU WHERE IDPhim = @IDPhim ";
            try
            {
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { IDPhim });

                if (result != null && int.TryParse(result.ToString(), out int idphim))
                {
                    return idphim;
                }

                return -1; // Không thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy id phòng dựa trên id phim: {ex.Message}");
                return -1;
            }
        }


        public List<DTO_LICHCHIEU> GetLichChieuByPhimVaNgay(string tenPhim, DateTime ngayChieu)
        {
            List<DTO_LICHCHIEU> list = new List<DTO_LICHCHIEU>();

            string query = @"SELECT * FROM LICHCHIEU 
                         WHERE TenPhim = @tenPhim 
                         AND CONVERT(DATE, NgayGio) = @ngayChieu";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim, ngayChieu.Date });

            foreach (DataRow row in data.Rows)
            {
                DTO_LICHCHIEU lc = new DTO_LICHCHIEU(
                    (int)row["ID"],
                    (int)row["IDPhim"],
                    row["TenPhim"].ToString(),
                    (int)row["IDPhong"],
                    row["TenPhong"].ToString(),
                    (DateTime)row["NgayGio"],
                    (decimal)row["GiaVe"],
                    row["DiaDiem"].ToString()
                );
                list.Add(lc);
            }

            return list;
        }

        // 📌 2. Lấy ID phòng từ lịch chiếu
        public int GetIDPhong(string tenPhim, DateTime ngayChieu, TimeSpan gioChieu)
        {
            string query = @"SELECT IDPhong FROM LICHCHIEU 
                         WHERE TenPhim = @tenPhim 
                         AND CONVERT(DATE, NgayGio) = @ngay 
                         AND CONVERT(TIME, NgayGio) = @gio ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenPhim, ngayChieu.Date, gioChieu });

            return (result != null) ? Convert.ToInt32(result) : -1;
        }


        //----- lấy id lịch chiếu dựa trên id phim
        public List<int> LayIDLichChieuTheoIDPhim(int idPhim)
        {
            List<int> list = new List<int>();
            string query = "SELECT ID FROM LICHCHIEU WHERE IDPhim = @IDPhim ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idPhim });

            foreach (DataRow row in dt.Rows)
            {
                list.Add(Convert.ToInt32(row["ID"]));
            }

            return list;
        }

        //---- lấy id phòng chiếu dựa trên id lịch chiếu
        public int LayIDPhongTheoIDLichChieu(int idLichChieu)
        {
            string query = "SELECT IDPhong FROM LICHCHIEU WHERE ID = @ID ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idLichChieu });
            return result != null ? Convert.ToInt32(result) : -1;
        }

        //------ hàm trả về ngày giờ lịch chiếu dựa trên id phòng
        public List<DateTime> GetNgayGioTrongNgay(int idPhong, DateTime ngay)
        {
            string query = @"SELECT NgayGio FROM LICHCHIEU
                            WHERE IDPhong = @IDPhong 
                            AND CONVERT(date, NgayGio) = CONVERT(date, @NgayGio ) ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idPhong, ngay });

            List<DateTime> result = new List<DateTime>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(Convert.ToDateTime(row["NgayGio"]));
            }

            return result;
        }



    }
}
