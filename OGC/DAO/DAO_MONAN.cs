using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_MONAN
    {

        private static DAO_MONAN instance;

        public static DAO_MONAN Instance
        {
            get { if (instance == null) instance = new DAO_MONAN(); return DAO_MONAN.instance; }
            private set { DAO_MONAN.instance = value; }
        }

        private DAO_MONAN() { }


        public Dictionary<string, List<DTO_MONAN>> LayTatCaMonAnTheoLoai()
        {
            string query = @"
            SELECT MA.ID, MA.TenMonAn, MA.IDLoaiMonAn, MA.Gia, MA.MoTa, MA.Anh, LMA.TenLoai 
            FROM MONAN MA
            JOIN LOAIMONAN LMA ON MA.IDLoaiMonAn = LMA.ID";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            Dictionary<string, List<DTO_MONAN>> result = new Dictionary<string, List<DTO_MONAN>>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_MONAN mon = new DTO_MONAN(row);
                string tenLoai = row["TenLoai"].ToString();

                if (!result.ContainsKey(tenLoai))
                {
                    result[tenLoai] = new List<DTO_MONAN>();
                }

                result[tenLoai].Add(mon);
            }

            return result;
        }

        

    }
}
