using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    internal class DAO_DoTuoi
    {
        private static DAO_DoTuoi instance;

        public static DAO_DoTuoi Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_DoTuoi();
                return instance;
            }
        }

        private DAO_DoTuoi() { }

        public List<DTO_DoTuoi> DanhSachDoTuoi()
        {
            List<DTO_DoTuoi> list = new List<DTO_DoTuoi>();

            string query = "SELECT * FROM DOTUOI";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO_DoTuoi(row));
            }

            return list;
        }

        public string DanhSachIDDoTuoi(string tenDoTuoi)
        {
            string query = @"SELECT ID FROM DOTUOI WHERE LTRIM(RTRIM(TenDoTuoi)) = LTRIM(RTRIM( @TenDoTuoi ))";

            object result = DataProvider.Instance.ExecuteScalar(query,
                new object[]
                {
            tenDoTuoi
                });

            if (result != null)
                return result.ToString();

            return null; // hoặc trả về string.Empty tùy bạn
        }

        public DTO_DOTUOI GetDoTuoiTheoTenPhim(string tenPhim)
        {
            string query = @"
                SELECT DT.* 
                FROM DOTUOI DT
                JOIN PHIM P ON P.IDDoTuoi = DT.ID
                WHERE P.TenPhim = @TenPhim";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim });

            if (dt.Rows.Count > 0)
            {
                return new DTO_DOTUOI(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }


    }


}
