using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_LOAIPHONG
    {
        public DTO_LOAIPHONG(int ID, string TenLoaiPhong)
        {
            this.ID = ID;
            this.TenLoaiPhong = TenLoaiPhong;
        }
        public DTO_LOAIPHONG() { }

        public DTO_LOAIPHONG(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenLoaiPhong;
        public string TenLoaiPhong
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }
    }
}
