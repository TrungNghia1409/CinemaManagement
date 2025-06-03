using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_PHONGCHIEU
    {
        public DTO_PHONGCHIEU(int ID, string TenPhong, int SucChua, int TrangThai, int MaLoaiPhong, string AnhPhong)
        {
            this.ID = ID;
            this.TenPhong = TenPhong;
            this.SucChua = SucChua;
            this.TrangThai = TrangThai;
            this.MaLoaiPhong = MaLoaiPhong;
            this.AnhPhong = AnhPhong;
        }
        public DTO_PHONGCHIEU() { }

        public DTO_PHONGCHIEU(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenPhong = row["TenPhong"].ToString();
            this.SucChua = (int)row["SucChua"];
            this.TrangThai = (int)row["TrangThai"];
            this.MaLoaiPhong = (int)row["MaLoaiPhong"];
            this.AnhPhong = row["AnhPhong"].ToString();
        }
        private int SucChua { get; set; }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenPhong;
        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }

        private int trangThai;
        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private int maLoaiPhong;
        public int MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }
        private string anhPhong;
        public string AnhPhong
        {
            get { return anhPhong; }
            set { anhPhong = value; }
        }
    }
}
