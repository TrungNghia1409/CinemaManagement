using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_KHUYENMAI
    {
        private static DAO_KHUYENMAI instance;

        public static DAO_KHUYENMAI Instance
        {
            get { if (instance == null) instance = new DAO_KHUYENMAI(); return DAO_KHUYENMAI.instance; }
            private set { DAO_KHUYENMAI.instance = value; }
        }
        private DAO_KHUYENMAI() { }

        //public DTO_KHUYENMAI KiemTraKhuyenMaiHopLe(string maKM, string loaiApDung)
        //{
        //    try
        //    {
        //        string query = @" SELECT * FROM KHUYENMAI
        //                WHERE MaKM = @MaKM
        //                  AND LoaiApDung = @LoaiApDung  
        //                  AND CONVERT(DATE, GETDATE())  BETWEEN CONVERT(DATE, NgayBatDau) AND CONVERT(DATE, NgayKetThuc)";

        //        DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maKM, loaiApDung });

        //        if (dt.Rows.Count > 0)
        //        {
        //            return new DTO_KHUYENMAI(dt.Rows[0]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi: {ex.Message}");
        //    }
        //    return null;
        //}

        public bool KiemTraKhuyenMaiHopLe(string maKM, string loaiApDung)
        {
            try
            {
                string query = @" SELECT MaKM, LoaiApDung FROM KHUYENMAI
                            WHERE MaKM = @MaKM
                          AND LoaiApDung = @LoaiApDung  
                          AND CONVERT(DATE, GETDATE())  BETWEEN CONVERT(DATE, NgayBatDau) AND CONVERT(DATE, NgayKetThuc) ";

                MessageBox.Show($"Tham số: maKM = '{maKM}', loaiApDung = '{loaiApDung}', ngày hiện tại = '{DateTime.Now.ToString("yyyy-MM-dd")}'");
                DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maKM, loaiApDung });
                MessageBox.Show($"Số dòng trả về: {dt.Rows.Count}");
                return dt.Rows.Count > 0;
            }

            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi kiểm tra khuyến mãi: {ex.Message}");
                return false;
            }
        }

        //-----hàm trả về loại áp dụng dựa trên mã khuyến mãi
        public string GetLoaiApDungByMaKM(string maKM)
        {
            try
            {
                string query = "SELECT LoaiApDung FROM KHUYENMAI WHERE MaKM = @MaKM ";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maKM });
                return dt.Rows.Count > 0 ? dt.Rows[0]["LoaiApDung"].ToString() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy LoaiApDung: " + ex.Message);
                return null;
            }

        }

        //-----hàm trả về mức giảm dựa trên mã khuyến mãi
        public int? GetMucGiamByMaKM(string maKM)
        {
            try
            {
                string query = "SELECT MucGiam FROM KHUYENMAI WHERE MaKM = @MaKM ";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maKM });

                if (result != null && int.TryParse(result.ToString(), out int mucGiam))
                {
                    return mucGiam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy Mức Giảm: " + ex.Message);
            }

            return null;
        }



    }
}
