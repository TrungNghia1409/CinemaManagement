using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public  class DAO_THONGKE
    {
        private static DAO_THONGKE instance;

        public static DAO_THONGKE Instance
        {
            get { if (instance == null) instance = new DAO_THONGKE(); return DAO_THONGKE.instance; }
            private set { DAO_THONGKE.instance = value; }
        }

        private DAO_THONGKE() { }

        #region Thống kê doanh thu
        //-------------------------------- Thống kê doanh thu
        //thống kê doanh thu theo từng nhân viên
        public DataTable DoanhThuTheoTungNhanVien()
        {
            string query = @"EXEC usp_DoanhThuTheoTungNhanVien ";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        //thống kê doanh thu theo từng phim
        public DataTable DoanhThuTheoTungPhim()
        {
            string query = @" EXEC usp_DoanhThuTheoTungPhim";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Doanh thu theo từng suất chiếu
        public DataTable DoanhThuTheoTungSuatChieu()
        {
            string query = @" EXEC usp_DoanhThuTheoTungSuatChieu";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion


        #region thống kê số vé
        //----------------------------- Thống kê vé
        //số vé bán theo từng suất chiếu
        public DataTable SoVeTheoTungSuatChieu()
        {
            string query = @" EXEC usp_SoVeDaBanTheoSuatChieu";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //số vé bán theo từng phim
        public DataTable SoVeTheoTungPhim()
        {
            string query = @" EXEC usp_SoVeDaBanTheoPhim ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //số vé bán theo từng loại phòng
        public DataTable SoVeTheoTungLoaiPhong()
        {
            string query = @" EXEC usp_SoVeDaBanTheoLoaiPhong";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion


        #region thống kê khách hàng
        //----------- Danh sách khách hàng theo từng khu vực
        public DataTable KhachHangTheoTungKhuVuc()
        {
            string query = @" SELECT DiaChi, COUNT(*) AS SoLuongKhach
                                FROM KhachHang
                                GROUP BY DiaChi ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng chưa từng đặt vé
        public DataTable DanhSachKhachHangChuaTungDatVe()
        {
            string query = @" SELECT * FROM KhachHang
                        WHERE ID NOT IN (
                            SELECT DISTINCT IDKhachHang
                            FROM HD_VE
                            WHERE IDKhachHang IS NOT NULL
                        )";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng có điểm thưởng cao nhất
        public DataTable DanhSachKhachHangCoDiemThuongCaoNhat()
        {
            string query = @" SELECT TOP 10 *
                                FROM KhachHang
                                ORDER BY DiemThuong DESC ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng đặt vé nhiều nhất
        public DataTable DanhSachKhachHangDatVeNhieuNhat()
        {
            string query = @" SELECT kh.ID, kh.HoTen, COUNT(*) AS SoLuotDatVe
                                FROM HD_VE hd
                                JOIN KhachHang kh ON hd.IDKhachHang = kh.ID
                                GROUP BY kh.ID, kh.HoTen
                                ORDER BY SoLuotDatVe DESC ";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion

        #region thống kê phim

        //--danh sách phim đang chiếu, lọc theo ngày, tháng, năm
        public DataTable ThongKePhim(DateTime? ngay, int? thang, int? nam)
        {
            string query = @" EXEC usp_ThongKePhim @Ngay , @Thang , @Nam ";

             DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
            {
                ngay.HasValue ? ngay.Value.Date : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
            });

            return result;
        }

        //----- Top 5 Phim có doanh thu cao nhất
        public DataTable PhimDoanhThuCaoNhat()
        {
            string query = @"  SELECT TOP 5 p.ID, p.TenPhim, SUM(hd.TongTien) AS DoanhThu
                                FROM PHIM p
                                JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
                                JOIN VE v ON lc.ID = v.IDLichChieu
                                JOIN HD_VE hd ON v.IDHoaDonVe = hd.ID
                                GROUP BY p.ID, p.TenPhim
                                ORDER BY DoanhThu DESC; ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----- Top 5 Phim có doanh thu thấp nhất
        public DataTable PhimDoanhThuThapNhat()
        {
            string query = @"  SELECT TOP 5 p.ID, p.TenPhim, SUM(hd.TongTien) AS DoanhThu
                                FROM PHIM p
                                JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
                                JOIN VE v ON lc.ID = v.IDLichChieu
                                JOIN HD_VE hd ON v.IDHoaDonVe = hd.ID
                                GROUP BY p.ID, p.TenPhim
                                ORDER BY DoanhThu ASC; ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----- Top 5 Phim được đặt vé nhiều nhất
        public DataTable PhimDuocDatVeNhieuNhat()
        {
            string query = @" SELECT TOP 5 p.ID, p.TenPhim, SUM(v.SoLuong) AS SoVe
                                FROM PHIM p
                                JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
                                JOIN VE v ON lc.ID = v.IDLichChieu
                                GROUP BY p.ID, p.TenPhim
                                ORDER BY SoVe DESC; ";

            return DataProvider.Instance.ExecuteQuery(query);
        }



        #endregion

    }
}
