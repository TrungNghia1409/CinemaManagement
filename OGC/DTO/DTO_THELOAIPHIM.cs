using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_THELOAIPHIM
    {
        public DTO_THELOAIPHIM(int ID, string TenTheLoai)
        {
            this.ID = ID;
            this.TenTheLoai = TenTheLoai;
        }
        public DTO_THELOAIPHIM() { }

        public DTO_THELOAIPHIM(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenTheLoai;
        public string TenTheLoai
        {
            get { return tenTheLoai; }
            set { tenTheLoai = value; }
        }
    }
}
