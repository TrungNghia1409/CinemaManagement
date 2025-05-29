using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_HD_MONAN
    {

        public DTO_HD_MONAN(int ID, string MaKM, int IDNhanVien, int IDKhachHang, DateTime NgayMua, decimal TongTien)
        {
            this.ID = ID;
            this.MaKM = MaKM;
            this.IDNhanVien = IDNhanVien;
            this.IDKhachHang = IDKhachHang;
            this.NgayMua = NgayMua;
            this.TongTien = TongTien;
        }
        public DTO_HD_MONAN() { }

        public DTO_HD_MONAN(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaKM = row["TenChucVu"].ToString();
            this.IDNhanVien = (int)row["IDNhanVien"];
            this.IDKhachHang = (int)row["IDKhachHang"];
            this.NgayMua = Convert.ToDateTime(row["NgayMua"]);
            this.TongTien = (decimal)row["TongTien"];
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string maKM;
        public string MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }
        private int iDNhanVien;
        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        private int iDKhachHang;
        public int IDKhachHang
        {
            get { return iDKhachHang; }
            set { iDKhachHang = value; }
        }
        private DateTime ngayMua;
        public DateTime NgayMua
        {
            get { return ngayMua; }
            set { ngayMua = value; }
        }
        private decimal tongTien;
        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
