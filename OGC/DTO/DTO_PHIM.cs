using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class PhimDTO
    {
        public int ID { get; set; }
        public string TenPhim { get; set; }
        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public int IDTheLoaiPhim { get; set; }
        public int IDDinhDang { get; set; }
        public int ThoiLuong { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public int TrangThai { get; set; }
        public string Trailer_Url { get; set; }
        public string Poster_Url { get; set; }
        public string Anh { get; set; }

        public PhimDTO() { }

        public PhimDTO(int id, string tenPhim, string daoDien, string dienVien, int idTheLoai, int idDinhDang,
                       int thoiLuong, string moTa, DateTime ngayKhoiChieu, int trangThai,
                       string trailerUrl, string posterUrl, string anh)
        {
            ID = id;
            TenPhim = tenPhim;
            DaoDien = daoDien;
            DienVien = dienVien;
            IDTheLoaiPhim = idTheLoai;
            IDDinhDang = idDinhDang;
            ThoiLuong = thoiLuong;
            MoTa = moTa;
            NgayKhoiChieu = ngayKhoiChieu;
            TrangThai = trangThai;
            Trailer_Url = trailerUrl;
            Poster_Url = posterUrl;
            Anh = anh;
        }
    }

}
