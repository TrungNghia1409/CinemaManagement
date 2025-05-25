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
        }
    }

    private PhimDAO() { }

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

    // Thêm phim
    public bool InsertPhim(PhimDTO phim)
    {
        string query = @"INSERT INTO PHIM 
                         (TenPhim, DaoDien, DienVien, IDTheLoaiPhim, IDDinhDang, ThoiLuong, MoTa, NgayKhoiChieu, TrangThai, Trailer_Url, Poster_Url, Anh)
                         VALUES (@TenPhim, @DaoDien, @DienVien, @IDTheLoaiPhim, @IDDinhDang, @ThoiLuong, @MoTa, @NgayKhoiChieu, @TrangThai, @Trailer, @Poster, @Anh)";
        int result = DataProvider.Instance.ExecuteNonQuery(query,
            new object[]
            {
                phim.TenPhim, phim.DaoDien, phim.DienVien, phim.IDTheLoaiPhim, phim.IDDinhDang,
                phim.ThoiLuong, phim.MoTa, phim.NgayKhoiChieu, phim.TrangThai,
                phim.Trailer_Url, phim.Poster_Url, phim.Anh
            });

        return result > 0;
    }

    // Cập nhật phim
    public bool UpdatePhim(PhimDTO phim)
    {
        string query = @"UPDATE PHIM SET 
                            TenPhim = @TenPhim, DaoDien = @DaoDien, DienVien = @DienVien,
                            IDTheLoaiPhim = @IDTheLoaiPhim, IDDinhDang = @IDDinhDang,
                            ThoiLuong = @ThoiLuong, MoTa = @MoTa, NgayKhoiChieu = @NgayKhoiChieu,
                            TrangThai = @TrangThai, Trailer_Url = @Trailer, Poster_Url = @Poster, Anh = @Anh
                         WHERE ID = @ID";
        int result = DataProvider.Instance.ExecuteNonQuery(query,
            new object[]
            {
                phim.TenPhim, phim.DaoDien, phim.DienVien, phim.IDTheLoaiPhim, phim.IDDinhDang,
                phim.ThoiLuong, phim.MoTa, phim.NgayKhoiChieu, phim.TrangThai,
                phim.Trailer_Url, phim.Poster_Url, phim.Anh, phim.ID
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
            row["DoTuoi"] == DBNull.Value ? null : row["DoTuoi"].ToString()
        );
    }
}
