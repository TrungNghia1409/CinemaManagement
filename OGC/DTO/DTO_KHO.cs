using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_KHO
    {
        public DTO_KHO(int ID, int IDMonAn, string TenMonAn, int SoLuongTon, DateTime NgayCapNhat)
        {
            this.ID = ID;
            this.IDMonAn = IDMonAn;
            this.TenMonAn = TenMonAn;
            this.SoLuongTon = SoLuongTon;
            this.NgayCapNhat = NgayCapNhat;
        }
        public DTO_KHO() { }

        public DTO_KHO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDMonAn = (int)row["IDMonAn"];
            this.TenMonAn = row["TenMonAn"].ToString();
            this.SoLuongTon = (int)row["SoLuongTon"];
            this.NgayCapNhat = Convert.ToDateTime(row["NgayCapNhat"]);


        }


        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int iDMonAn;
        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        private string tenMonAn;
        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        private int soLuongTon;
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        private DateTime ngayCapNhat;
        public DateTime NgayCapNhat
        {
            get { return ngayCapNhat; }
            set { ngayCapNhat = value; }
        }

       
    }
}
