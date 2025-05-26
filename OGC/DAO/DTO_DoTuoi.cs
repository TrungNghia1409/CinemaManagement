using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    internal class DTO_DoTuoi
    {
        public string ID { get; set; }        
        public string TenDoTuoi { get; set; }   

        public DTO_DoTuoi(string id, string tenDoTuoi)
        {
            ID = id;
            TenDoTuoi = tenDoTuoi;
        }

        public DTO_DoTuoi(DataRow row)
        {
            ID = row["ID"].ToString();
            TenDoTuoi = row["TenDoTuoi"].ToString();
        }

        public override string ToString()
        {
            return TenDoTuoi;
        }
    }
}
