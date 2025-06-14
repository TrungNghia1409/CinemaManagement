using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_MONAN
    {
        public DTO_MONAN(int ID, string TenMonAn, int IDLoaiMonAn, decimal Gia, string MoTa , string Anh, string TenLoaiMonAn)
        {
            this.ID = ID;
            this.TenMonAn = TenMonAn;
            this.IDLoaiMonAn = IDLoaiMonAn;
            this.Gia = Gia;
            this.Anh = Anh;
            this.MoTa = MoTa;
            this.TenLoaiMonAn = TenLoaiMonAn;
        }
        public DTO_MONAN() { }

        public DTO_MONAN(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenMonAn = row["TenMonAn"].ToString();
            this.IDLoaiMonAn = (int)row["IDLoaiMonAn"];
            this.Gia = (decimal)row["Gia"];
            this.MoTa = row["MoTa"].ToString();
            this.Anh = row["Anh"].ToString();
        }

        public string TenLoaiMonAn {  get; set; } 

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenMonAn;
        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        private int iDLoaiMonAn;
        public int IDLoaiMonAn
        {
            get { return iDLoaiMonAn; }
            set { iDLoaiMonAn = value; }
        }

        private decimal gia;
        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }


        private string moTa;
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        private string anh;
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
    }
}
