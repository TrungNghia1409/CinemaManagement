using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_CTHD_MONAN
    {
        private static DAO_CTHD_MONAN instance;

        public static DAO_CTHD_MONAN Instance
        {
            get { if (instance == null) instance = new DAO_CTHD_MONAN(); return DAO_CTHD_MONAN.instance; }
            private set { DAO_CTHD_MONAN.instance = value; }
        }

        private DAO_CTHD_MONAN() { }

        //----- thêm chi tiết hóa đơn món ăn
        public bool ThemChiTietHoaDonMonAn(int idHoaDon, int idMonAn, int soLuong, decimal donGia)
        {
            string query = "EXEC usp_ThemCTHDMONAN @IDHoaDon , @IDMonAn , @SoLuong , @DonGia ";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idMonAn, soLuong, donGia });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn món ăn: " + ex.Message);
                return false;
            }
        }

        public DataTable LayDSByIDHoaDon(int idHoaDon)
        {
            string query = "EXEC usp_DanhSachCTHD_MONAN @IDHoaDon ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idHoaDon });
        }

        //-----kiểm tra chi tiết hóa đơn tồn tại
        public bool KiemTraTonTaiID(int idHD_MonAn)
        {
            string query = "SELECT COUNT(*) FROM CTHD_MONAN WHERE IDHoaDon = @IDHoaDon ";
            int result = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idHD_MonAn });
            return result > 0;
        }

        //---- cập nhật trạng thái cho hóa đơn, nếu xuất thành công thì hiện "đã in"
        public bool CapNhatTrangThai(string trangThai, int idCTHD)
        {
            string query = "UPDATE CTHD_MONAN SET TrangThai = @TrangThai WHERE IDHoaDon = @IDHoaDon ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  trangThai, idCTHD, });
            return result > 0;
        }

        //-- hàm trả về trạng thái dựa trên id
        public string LayTrangThaiTheoID(int id)
        {
            string query = "SELECT TrangThai FROM CTHD_MONAN WHERE IDHoaDon = @IDHoaDon ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result?.ToString() ?? ""; // Trả về chuỗi rỗng nếu không có dữ liệu
        }

        //---hàm trả về tổng tiền dựa trên id
        public decimal GetTongTienVeTheoIDHoaDon(int idHoaDon)
        {
            string query = "SELECT SUM(Gia * SoLuong) FROM CTHD_MONAN WHERE IDHoaDon = @IDHoaDon ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idHoaDon });

            if (result != DBNull.Value && result != null)
                return Convert.ToDecimal(result);
            return 0;
        }

        //----xóa cthd khi khách đổi món
        public bool XoaCTHDMonAnTheoIDHoaDon(int idHoaDon)
        {
            try
            {
                string query = "DELETE FROM CTHD_MONAN WHERE IDHoaDon = @IDHoaDon ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon });
                return result >= 0; // Có thể = 0 nếu chưa có dòng nào
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa CTHD_MONAN: " + ex.Message);
                return false;
            }
        }










    }
}
