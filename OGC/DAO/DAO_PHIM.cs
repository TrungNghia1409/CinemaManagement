using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class PhimDAO
{
    private static PhimDAO instance;

    public static PhimDAO Instance
    {
        get
        {
            if (instance == null) instance = new PhimDAO();
            return instance;
            //get { if (instance == null) instance = new PhimDAO(); return PhimDAO.instance; }
            //private set { PhimDAO.instance = value; }
    }
    }

    private PhimDAO() { }

    // Lấy danh sách phim theo bộ lọc
    public List<PhimDTO> GetPhimTheoBoLoc(DateTime ngayChieu, int idTheLoai, int idDinhDang, string tuKhoa)
    {
        string query = "SELECT * FROM PHIM WHERE 1=1";

        List<object> parameters = new List<object>();
        if (ngayChieu != DateTime.MinValue)
        {
            query += " AND CONVERT(date, NgayKhoiChieu) = @NgayChieu";
            parameters.Add(ngayChieu);
        }
        if (idTheLoai != 0)
        {
            query += " AND IDTheLoaiPhim = @IDTheLoai";
            parameters.Add(idTheLoai);
        }
        if (idDinhDang != 0)
        {
            query += " AND IDDinhDang = @IDDinhDang";
            parameters.Add(idDinhDang);
        }
        if (!string.IsNullOrEmpty(tuKhoa))
        {
            query += " AND LOWER(TenPhim) LIKE @TuKhoa";
            parameters.Add("%" + tuKhoa.ToLower() + "%");
        }

        DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters.ToArray());

        List<PhimDTO> list = new List<PhimDTO>();

        foreach (DataRow row in dt.Rows)
        {
            list.Add(DataRowToPhimDTO(row));
        }

        return list;
    }







    // Hàm chuyển DataRow sang PhimDTO
    private PhimDTO DataRowToPhimDTO(DataRow row)
    {
        return new PhimDTO(
            id: Convert.ToInt32(row["ID"]),
            tenPhim: row["TenPhim"].ToString(),
            daoDien: row["DaoDien"].ToString(),
            dienVien: row["DienVien"].ToString(),
            idTheLoai: Convert.ToInt32(row["IDTheLoaiPhim"]),
            idDinhDang: Convert.ToInt32(row["IDDinhDang"]),
            thoiLuong: Convert.ToInt32(row["ThoiLuong"]),
            moTa: row["MoTa"].ToString(),
            ngayKhoiChieu: Convert.ToDateTime(row["NgayKhoiChieu"]),
            trangThai: Convert.ToInt32(row["TrangThai"]),
            trailerUrl: row["Trailer_Url"].ToString(),
            posterUrl: row["Poster_Url"].ToString(),
            anh: row["Anh"].ToString(),
            doTuoi: row["IDDoTuoi"].ToString()
        );
    }


    // Lấy tất cả phim
    public List<PhimDTO> GetAllPhim()
    {
        List<PhimDTO> list = new List<PhimDTO>();
        string query = "SELECT * FROM PHIM";
        DataTable data = DataProvider.Instance.ExecuteQuery(query);

        foreach (DataRow row in data.Rows)
        {
            PhimDTO phim = MapPhim(row);
            list.Add(phim);
        }

        return list;
    }


    //Phim có doanh thu cao nhất
    public List<string> GetPhimDoanhThuCaoNhatThang()
    {
        string query = "EXEC usp_PhimDoanhThuCaoNhatThang ";

        DataTable data = DataProvider.Instance.ExecuteQuery(query);

        List<string> danhSach = new List<string>();
        foreach (DataRow row in data.Rows)
        {
            danhSach.Add(row["TenPhim"].ToString());
        }
        return danhSach;
    }

    // Thêm phim
    public bool InsertPhim(PhimDTO phim)
    { //nhớ bổ sung URL TRAILER, ANH vào câu lệnh SQl ở dòng 45 46
        string query = @"INSERT INTO PHIM 
                        (TenPhim, DaoDien, DienVien, IDTheLoaiPhim, IDDinhDang, ThoiLuong, MoTa, NgayKhoiChieu, TrangThai, Trailer_Url, Anh, IDDoTuoi)
                        VALUES ( @TenPhim , @DaoDien , @DienVien , @IDTheLoaiPhim , @IDDinhDang , @ThoiLuong , @MoTa , @NgayKhoiChieu , @TrangThai , @Trailer_Url , @Anh ,  @IDDoTuoi )";
        int result = DataProvider.Instance.ExecuteNonQuery(query,
            new object[]
            {
                 phim.TenPhim,
                phim.DaoDien,
                phim.DienVien,
                phim.IDTheLoaiPhim,
                phim.IDDinhDang,
                phim.ThoiLuong,
                phim.MoTa,
                phim.NgayKhoiChieu,
                phim.TrangThai,
                phim.Trailer_Url,  
                phim.Anh,
                phim.IDDoTuoi
            });

        return result > 0;
    }

    // Cập nhật phim
    public bool UpdatePhim(PhimDTO phim)
    {
        string query = @"UPDATE PHIM SET 
                            TenPhim = @TenPhim , DaoDien = @DaoDien , DienVien = @DienVien ,
                            IDTheLoaiPhim = @IDTheLoaiPhim , IDDinhDang = @IDDinhDang ,
                            ThoiLuong = @ThoiLuong , MoTa = @MoTa , NgayKhoiChieu = @NgayKhoiChieu ,
                            TrangThai = @TrangThai , Trailer_Url = @Trailer , Anh = @Anh 
                             WHERE ID = @ID ";
        int result = DataProvider.Instance.ExecuteNonQuery(query,
            new object[]
            {
                phim.TenPhim,
                phim.DaoDien,
                phim.DienVien,
                phim.IDTheLoaiPhim,
                phim.IDDinhDang,
                phim.ThoiLuong,
                phim.MoTa,
                phim.NgayKhoiChieu,
                phim.TrangThai,
                phim.Trailer_Url,
                string.IsNullOrEmpty(phim.Anh) ? (object)DBNull.Value : phim.Anh,
                phim.ID
            });


        return result > 0;
    }

    // Xóa phim
    public bool DeletePhim(int id)
    {
        string query = "DELETE FROM PHIM WHERE ID = @ID";
        int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        return result > 0;
    }

    // Lấy phim theo ID
    public PhimDTO GetPhimByID(int id)
    {
        string query = "SELECT * FROM PHIM WHERE ID = @ID";
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

        if (data.Rows.Count > 0)
        {
            return MapPhim(data.Rows[0]);
        }

        return null;
    }

    public List<PhimDTO> GetPhimByIDDinhDang(int idDinhDang)
    {
        List<PhimDTO> list = new List<PhimDTO>();

        string query = "SELECT * FROM PHIM WHERE IDDinhDang = @IDDinhDang ";
        DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idDinhDang });

        foreach (DataRow row in dt.Rows)
        {
            PhimDTO phim = MapPhim(row);
            list.Add(phim);
        }

        return list;
    }

    public List<PhimDTO> GetPhimByIDTheLoai(int idTheLoai)
    {
        List<PhimDTO> list = new List<PhimDTO>();

        string query = "SELECT * FROM PHIM WHERE IDTheLoaiPhim = @ID ";
        DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idTheLoai });

        foreach (DataRow row in dt.Rows)
        {
            PhimDTO phim = MapPhim(row);
            list.Add(phim);
        }

        return list;
    }
 

    public List<PhimDTO> GetPhimByNgayChieu(DateTime ngayChieu)
    {
        List<PhimDTO> list = new List<PhimDTO>();
        string query = "SELECT * FROM PHIM WHERE CAST(NgayKhoiChieu AS DATE) = @ngayChieu";

        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ngayChieu.Date });

        foreach (DataRow row in data.Rows)
        {
            list.Add(MapPhim(row));
        }

        return list;
    }

    //----- lấy id phim dựa trên tên phim
    public int LayIDPhimTheoTen(string tenPhim)
    {
        string query = "SELECT ID FROM PHIM WHERE TenPhim = @TenPhim ";
        object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenPhim });
        return result != null ? Convert.ToInt32(result) : -1;
    }



    // Hàm ánh xạ từ DataRow sang DTO
    private PhimDTO MapPhim(DataRow row)
    {
        return new PhimDTO(
            (int)row["ID"],
            row["TenPhim"].ToString(),
            row["DaoDien"]?.ToString(),
            row["DienVien"]?.ToString(),
            (int)row["IDTheLoaiPhim"],
            (int)row["IDDinhDang"],
            (int)row["ThoiLuong"],
            row["MoTa"]?.ToString(),
            (DateTime)row["NgayKhoiChieu"],
            (int)row["TrangThai"],
            row["Trailer_Url"]?.ToString(),
            row["Poster_Url"]?.ToString(),
            row["Anh"]?.ToString(),
            row["IDDoTuoi"] == DBNull.Value ? null : row["IDDoTuoi"].ToString()
        );
    }

    public PhimDTO GetPhimTheoTen(string tenPhim)
    {
        string query = "SELECT * FROM PHIM WHERE TenPhim = @TenPhim ";
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim });

        if (data.Rows.Count > 0)
            return MapPhim(data.Rows[0]);

        return null;
    }

}