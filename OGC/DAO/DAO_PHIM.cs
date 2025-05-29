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

    ////--------lấy IDPhim dựa trên tên phim
    //public int? LayIDTheoTenPhim(string tenPhim)
    //{
    //    try
    //    {
    //        string query = "SELECT ID FROM PHIM WHERE TenPhim = @TenPhim ";
    //        object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenPhim });

    //        if (result != null)
    //        {
    //            return Convert.ToInt32(result);
    //        }
    //        return null;
    //    }

    //    catch (Exception ex)
    //    {
    //        // Nếu có lỗi ,  rollback giao dịch
    //        MessageBox.Show($"Lỗi khi cố gắng lấy ID dựa trên tên phim: {ex.Message}");
    //        return null;
    //    }
    //}


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
}