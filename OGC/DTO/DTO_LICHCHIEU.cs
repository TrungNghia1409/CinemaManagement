using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_LICHCHIEU
    {
        public DTO_LICHCHIEU(int ID, int IDPhim, string TenPhim, int IDPhong, string TenPhong, DateTime NgayGio, decimal GiaVe, string DiaDiem)
        {
            this.ID = ID;
            this.IDPhim = IDPhim;
            this.IDPhong = IDPhong;
            this.TenPhim = TenPhim;
            this.TenPhong = TenPhong;

            this.NgayGio = NgayGio;
            this.GiaVe = GiaVe;
            this.diaDiem = DiaDiem;
            
        }
        public DTO_LICHCHIEU() { }

        public DTO_LICHCHIEU(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDPhim = (int)row["IDPhim"];
            this.TenPhim = row["TenPhim"].ToString();
            this.TenPhong = row["TenPhong"].ToString();

            this.IDPhong = (int)row["IDPhong"];
            this.NgayGio = Convert.ToDateTime(row["Ngaygio"]);
            this.GiaVe  = (decimal)row["GiaVe"];
            this.DiaDiem = row["DiaDiem"].ToString();
        }
        public string Anh { get; set; }
        public string AnhPhong { get; set; }
        public string TrangThai
        {
            get
            {
                return NgayGio > DateTime.Now ? "Sắp chiếu" : "Đã chiếu";
            }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int iDPhim;
        public int IDPhim
        {
            get { return iDPhim; }
            set { iDPhim = value; }
        }

        private string tenPhim;
        public string TenPhim
        {
            get { return tenPhim; }
            set { tenPhim = value; }
        }

        private string tenPhong;
        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }

        private int iDPhong;
        public int IDPhong
        {
            get { return iDPhong; }
            set { iDPhong = value; }
        }

        private DateTime ngayGio;
        public DateTime NgayGio
        {
            get { return ngayGio; }
            set { ngayGio = value; }
        }

        private decimal giaVe;
        public decimal GiaVe
        {
            get { return giaVe; }
            set { giaVe = value; }
        }


        private string diaDiem;
        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }

    }
}
