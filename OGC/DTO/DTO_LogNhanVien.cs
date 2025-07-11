using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_LogNhanVien
    {
        public DTO_LogNhanVien(int ID, string Username, int IDChucVu, string TenChucVu, string ThaoTac, DateTime ThoiGian, string ChucNang, string Gio, string Ngay)
        {
            this.ID = ID;
            this.Username = Username;
            this.IDChucVu = IDChucVu;
            this.TenChucVu = TenChucVu;
            this.ThaoTac = ThaoTac;
            this.ThoiGian = ThoiGian;
            this.chucNang = ChucNang;
            this.Gio = Gio;
            this.Ngay = Ngay;
        }
        public DTO_LogNhanVien() { }

        public DTO_LogNhanVien(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Username = row["Username"].ToString();
            this.IDChucVu = (int)row["IDChucVu"];
            this.TenChucVu = row["TenChucVu"].ToString();
            this.ThaoTac = row["ThaoTac"].ToString();
            this.ThoiGian = Convert.ToDateTime(row["ThoiGian"]);
            this.Gio = row["Gio"].ToString();
            this.Ngay = row["Ngay"].ToString();
            this.ChucNang = row["ChucNang"].ToString();
        }
        public string TenChucVu { get; set; }
        public string Gio { get; set; }
        public string Ngay { get; set; }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int iDChucVu;
        public int IDChucVu
        {
            get { return iDChucVu; }
            set { iDChucVu = value; }
        }
        private string thaoTac;
        public string ThaoTac
        {
            get { return thaoTac; }
            set { thaoTac = value; }
        }
        private DateTime thoiGian;
        public DateTime ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        private string chucNang;
        public string ChucNang
        {
            get { return chucNang; }
            set { chucNang = value; }
        }
    }
}
