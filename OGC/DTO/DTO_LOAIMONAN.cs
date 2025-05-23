using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_LOAIMONAN
    {
        public DTO_LOAIMONAN(int ID, string TenLoai)
        {
            this.ID = ID;
            this.TenLoai = TenLoai;
        }
        public DTO_LOAIMONAN() { }

        public DTO_LOAIMONAN(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenLoai = row["TenLoai"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenLoai;
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

    }
}
