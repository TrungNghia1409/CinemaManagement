using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_CTHD_MONAN
    {
        public DTO_CTHD_MONAN(int ID, int IDHoaDon, int IDMonAn, int SoLuong)
        {
            this.ID = ID;
            this.IDHoaDon = IDHoaDon;
            this.IDMonAn = IDMonAn;
            this.SoLuong = SoLuong;
        }
        public DTO_CTHD_MONAN() { }

        public DTO_CTHD_MONAN(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDHoaDon = (int)row["IDHoaDon"];
            this.IDMonAn = (int)row["IDMonAn"];
            this.SoLuong = (int)row["SoLuong"];

        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int iDHoaDon;
        public int IDHoaDon
        {
            get { return iDHoaDon; }
            set { iDHoaDon = value; }
        }
        private int iDMonAn;
        public int IDMonAn
        {
            get { return iDMonAn; }
            set { iDMonAn = value; }
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

    }
}
