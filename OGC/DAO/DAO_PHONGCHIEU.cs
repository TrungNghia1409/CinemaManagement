using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_PHONGCHIEU
    {
        private static DAO_PHONGCHIEU instance;

        public static DAO_PHONGCHIEU Instance
        {
            get { if (instance == null) instance = new DAO_PHONGCHIEU(); return DAO_PHONGCHIEU.instance; }
            private set { DAO_PHONGCHIEU.instance = value; }
        }

        private DAO_PHONGCHIEU() { }

        public List<DTO_PHONGCHIEU> DanhSachTenPhong_List()
        {
            List<DTO_PHONGCHIEU> ds = new List<DTO_PHONGCHIEU>();

            string query = "SELECT * FROM PHONGCHIEU ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU();
                phong.ID = Convert.ToInt32(row["ID"]);
                phong.TenPhong = row["TenPhong"].ToString();
                phong.AnhPhong = row["AnhPhong"] != DBNull.Value ? row["AnhPhong"].ToString() : string.Empty;
                ds.Add(phong);
            }

            return ds;
        }

    }
}
