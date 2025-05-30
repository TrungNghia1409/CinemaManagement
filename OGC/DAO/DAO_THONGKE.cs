using Microsoft.Data.SqlClient;
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
            string query = @" EXEC usp_KhachHangTheoTungKhuVuc ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng chưa từng đặt vé
        public DataTable DanhSachKhachHangChuaTungDatVe()
        {
            string query = @" EXEC usp_DanhSachKhachHangChuaTungDatVe ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng có điểm thưởng cao nhất
        public DataTable DanhSachKhachHangCoDiemThuongCaoNhat()
        {
            string query = @" EXEC usp_DanhSachKhachHangCoDiemThuongCaoNhat ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //----------- Danh sách khách hàng đặt vé nhiều nhất && thống kê khách hàng đã mua
        public DataTable ThucThiProc_ThongKe_KhachHang(string tenProc, int? ngay, int? thang, int? nam)
        {
            string query = $"{tenProc} @Ngay , @Thang , @Nam";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
          {
                ngay.HasValue ? ngay : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
          });

            return result;
        }

        #endregion

        #region thống kê phim

        //--danh sách phim đang chiếu, lọc theo ngày, tháng, năm

        //----- Top 5 Phim có doanh thu cao nhất
        public DataTable ThucThiProc_ThongKe_Phim(string tenProc, int? ngay, int? thang, int? nam)
        {

            string query = $"{tenProc} @Ngay , @Thang , @Nam";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
          {
                ngay.HasValue ? ngay : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
          });

            return result;
        }



        #endregion

        #region thống kê nhân viên

        //danh sách nhân viên mới trong tháng năm
        public DataTable DanhSachNhanVienMoi(int? thang, int? nam)
        {
            string query = "EXEC usp_DanhSachNhanVienMoi @Thang , @Nam" ;
            return DataProvider.Instance.ExecuteQuery(query, new object[]
            {
        thang.HasValue ? (object)thang : DBNull.Value,
        nam.HasValue ? (object)nam : DBNull.Value
            });
        }

        //số lượng bán vé của từng nhân viên
        public DataTable SoLuongVeCuaTungNhanVien()
        {
            string query = @"  EXEC usp_SoLuongHoaDonVe_TheoNhanVien  ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //số lượng bán dịch vụ của từng nhân viên
        public DataTable SoLuongDichVuCuaTungNhanVien()
        {
            string query = @"  EXEC usp_SoLuongHoaDonMonAn_TheoNhanVien ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //nhân viên mang lại doanh thu cao nhất
        public DataTable NhanVienMangLaiDoanhThuCaoNhat()
        {
            string query = @"  EXEC usp_NhanVien_DoanhThuCaoNhat ";

            return DataProvider.Instance.ExecuteQuery(query);
        }


        #endregion

        #region thống kê phòng chiếu
        public DataTable ThucThiProc_ThongKe_PhongChieu(string tenProc, int? ngay, int? thang, int? nam)
        {

            string query = $"{tenProc} @Ngay , @Thang , @Nam";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
          {
                ngay.HasValue ? ngay : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
          });

            return result;
        }


        #endregion

        #region thống kê lịch chiếu
        public DataTable ThucThiProc_ThongKe_LichChieu(string tenProc, int? ngay, int? thang, int? nam)
        {

            string query = $"{tenProc} @Ngay , @Thang , @Nam";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
          {
                ngay.HasValue ? ngay : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
          });

            return result;
        }
        #endregion

        #region thống kê dịch vụ

        public DataTable ThucThiProc_ThongKe_DichVu(string tenProc, int? ngay, int? thang, int? nam)
        {

            string query = $"{tenProc} @Ngay , @Thang , @Nam";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]
          {
                ngay.HasValue ? ngay : (object)DBNull.Value,
                thang.HasValue ? thang : (object)DBNull.Value,
                nam.HasValue ? nam : (object)DBNull.Value
          });

            return result;
        }
        #endregion

    }
}
