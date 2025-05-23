using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_DINHDANGPHIM
    {
        public DTO_DINHDANGPHIM(int ID, string TenDinhDang)
        {
            this.ID = ID;
            this.TenDinhDang = TenDinhDang;
        }
        public DTO_DINHDANGPHIM() { }

        public DTO_DINHDANGPHIM(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenDinhDang = row["TenDinhDang"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenDinhDang;
        public string TenDinhDang
        {
            get { return tenDinhDang; }
            set { tenDinhDang = value; }
        }
    }
}
