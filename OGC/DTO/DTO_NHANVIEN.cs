using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_NHANVIEN
    {
        public DTO_NHANVIEN(int ID, string Username, int IDChucVu, int IDChuVu, string HoTen, DateTime NgaySinh,
                            string GioiTinh, string SDT, string Email, string DiaChi, string TenChucVu)
        {
            this.ID = ID;
            this.Username = Username;
            this.IDChucVu = IDChucVu;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SDT = SDT;
            this.Email = Email;
            this.DiaChi = DiaChi;

            this.TenChucVu = TenChucVu;
        }

        public DTO_NHANVIEN() { }


        public DTO_NHANVIEN(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Username = row["Username"].ToString();
            this.IDChucVu = (int)row["IDChucVu"];
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            this.GioiTinh = row["GioiTinh"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

            this.TenChucVu = row["TenChucVu"].ToString();
        }


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

        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string gioiTinh;
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private string sDT;
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }


        private string tenChucVu;
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }
    }

}
