using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    internal class DTO_DOTUOI
    {
        public int ID { get; set; }
        public string TenDoTuoi { get; set; }
        public DTO_DOTUOI() { }
        public DTO_DOTUOI(int id, string tenDoTuoi)
        {
            ID = id;
            TenDoTuoi = tenDoTuoi;
        }
        public DTO_DOTUOI(System.Data.DataRow row)
        {
            ID = (int)row["ID"];
            TenDoTuoi = row["TenDoTuoi"].ToString();
        }
    }
}
