using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_NHANVIEN
    {
        private static DAO_NHANVIEN instance;

        public static DAO_NHANVIEN Instance
        {
            get { if (instance == null) instance = new DAO_NHANVIEN(); return DAO_NHANVIEN.instance; }
            private set { DAO_NHANVIEN.instance = value; }
        }

        private DAO_NHANVIEN() { }

        //load TKNhanVien  ,   ChucVu vào button trong flowlayoutPanel
        public List<DTO_NHANVIEN> LoadNhanVienList()
        {
            List<DTO_NHANVIEN> nhanvienList = new List<DTO_NHANVIEN>();

            DataTable data = DataProvider.Instance.ExecuteQuery(@" EXEC usp_danhsachnhanvien ");

            foreach (DataRow item in data.Rows)
            {
                DTO_NHANVIEN NhanVienDTO = new DTO_NHANVIEN(item);
                nhanvienList.Add(NhanVienDTO);
            }

            return nhanvienList;
        }

        // Thêm nhân viên mới
        public List<DTO_NHANVIEN> DanhSachNhanVien()
        {
            List<DTO_NHANVIEN> list = new List<DTO_NHANVIEN>();

            string query = @"
                            SELECT NV.ID, NV.Username, CV.TenChucVu, NV.HoTen, NV.NgaySinh, 
                                   NV.GioiTinh, NV.SDT, NV.Email, NV.DiaChi
                            FROM NHANVIEN NV
                            JOIN CHUCVU CV ON NV.IDChucVu = CV.ID
                            JOIN TKNHANVIEN TK ON NV.Username = TK.Username ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                DTO_NHANVIEN nv = new DTO_NHANVIEN();
                nv.ID = Convert.ToInt32(row["ID"]);
                nv.Username = row["Username"].ToString();
                nv.TenChucVu = row["TenChucVu"].ToString();
                nv.HoTen = row["HoTen"].ToString();
                nv.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
                nv.GioiTinh = row["GioiTinh"].ToString();
                nv.SDT = row["SDT"].ToString();
                nv.Email = row["Email"].ToString();
                nv.DiaChi = row["DiaChi"].ToString();

                list.Add(nv);
            }

            return list;
        }

    }
}
