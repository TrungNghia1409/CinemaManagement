using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_CHUCVU
    {
        public DTO_CHUCVU(int ID, string TenChucVu)
        {
            this.ID = ID;
            this.TenChucVu = TenChucVu;
        }
        public DTO_CHUCVU() { }

        public DTO_CHUCVU(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenChucVu = row["TenChucVu"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenChucVu;
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }
    }
}
