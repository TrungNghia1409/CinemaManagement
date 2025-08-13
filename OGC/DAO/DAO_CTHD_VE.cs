using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_CTHD_VE
    {
        private static DAO_CTHD_VE instance;

        public static DAO_CTHD_VE Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_CTHD_VE();
                return instance;
            }
        }

        private DAO_CTHD_VE() { }

        public bool ThemChiTietHoaDonVe(
            int idHoaDon,
            string tenPhim,
            string dinhDang,
            string phong,
            string suatChieu,
            DateTime ngayChieu,
            string ghe,
            decimal giaVe,
            string trangThai
        )
        {
            string query = "EXEC ThemChiTietHoaDonVe @IDHoaDon , @TenPhim , @DinhDang , @Phong , @SuatChieu , @NgayChieu , @Ghe , @GiaVe , @TrangThai ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idHoaDon, tenPhim, dinhDang, phong, suatChieu, ngayChieu, ghe, giaVe, trangThai
            });

            return result > 0;
        }

        public bool XoaCTHDVePhimTheoIDHoaDon(int idHoaDon)
        {
            string query = "EXEC XoaCTHDVePhimTheoIDHoaDon @IDHoaDon ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon });
            return result > 0;
        }

        public bool ThemChiTietHoaDonVeNew(
                        int idHoaDon,
                        int idPhim,
                        int idPhong,
                        int idLichchieu,
                        int idDinhdang,
                        string ghe,
                        decimal giaVe,
                        string trangThai)
                                {
                                    if (idLichchieu == -1)
                                        throw new Exception("Không tìm thấy lịch chiếu phù hợp.");

                                    string query = @"EXEC ThemChiTietHoaDonVe_New 
                                    @IDHoaDon , 
                                    @IDPhim , 
                                    @IDPhongChieu ,
                                    @IDLichChieu , 
                                    @IDDinhDang , 
                                    @Ghe , 
                                    @GiaVe , 
                                    @TrangThai ";

                                    int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                                    {
                        idHoaDon,
                        idPhim,
                        idPhong,
                        idLichchieu,
                        idDinhdang,
                        ghe,
                        giaVe,
                        trangThai
                                    });

            return result > 0;
        }



    }
}
