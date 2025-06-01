using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_KHACHHANG
    {
        public DTO_KHACHHANG(int ID, string Username, string HoTen, int Tuoi, string DiaChi, string SDT, string Email, int DiemThuong)
        {
            this.ID = ID;
            this.Username = Username;
            this.HoTen = HoTen;
            this.Tuoi = Tuoi;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Email = Email;
            this.DiemThuong = DiemThuong;
        }

        public DTO_KHACHHANG() { }


        public DTO_KHACHHANG(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Username = row["Username"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.ID = (int)row["ID"];
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
            this.Tuoi = (int)row["Tuoi"];
            this.DiemThuong = (int)row["DiemThuong"];
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


        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private int tuoi;
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
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
        private int diemThuong;
        public int DiemThuong
        {
            get { return diemThuong; }
            set { diemThuong = value; }
        }

    }
}
