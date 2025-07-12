using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_KHUYENMAI
    {
        public DTO_KHUYENMAI(string MaKM, string TenKM, int MucGiam, DateTime NgayBatDau, DateTime NgayKetThuc, string MoTa, string LoaiApDung)
        {
            this.MaKM = MaKM;
            this.TenKM = TenKM;
            this.MucGiam = MucGiam;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.MoTa = MoTa;
            this.LoaiApDung = LoaiApDung;   
        }
        public DTO_KHUYENMAI() { }

        public DTO_KHUYENMAI(DataRow row)
        {
            this.MaKM = row["MaKM"].ToString();
            this.TenKM = row["TenKM"].ToString();
            this.MucGiam = (int)row["MucGiam"];
            this.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
            this.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
            this.MoTa = row["MoTa"].ToString();
            this.LoaiApDung = row["LoaiApDung"].ToString();
        }

        private string maKM;
        public string MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }

        private string tenKM;
        public string TenKM
        {
            get { return tenKM; }
            set { tenKM = value; }
        }

        private int mucGiam;
        public int MucGiam
        {
            get { return mucGiam; }
            set { mucGiam = value; }
        }

        private DateTime ngayBatDau;
        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        private DateTime ngayKetThuc;
        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        private string moTa;
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        private string loaiApDung;
        public string LoaiApDung
        {
            get { return loaiApDung; }
            set { loaiApDung = value; }
        }

    }
}
