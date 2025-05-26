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
    }
}
