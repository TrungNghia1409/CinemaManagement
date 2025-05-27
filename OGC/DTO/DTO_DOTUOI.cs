using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    internal class DTO_DOTUOI
    {
        public string ID { get; set; }
        public string TenDoTuoi { get; set; }
        public DTO_DOTUOI() { }
        public DTO_DOTUOI(string id, string tenDoTuoi)
        {
            ID = id;
            TenDoTuoi = tenDoTuoi;
        }
        public DTO_DOTUOI(System.Data.DataRow row)
        {
            ID = row["ID"].ToString();
            TenDoTuoi = row["TenDoTuoi"].ToString();
        }
    }
}
