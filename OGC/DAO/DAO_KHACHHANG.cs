using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_KHACHHANG
    {

        private static DAO_KHACHHANG instance;

        public static DAO_KHACHHANG Instance
        {
            get { if (instance == null) instance = new DAO_KHACHHANG(); return DAO_KHACHHANG.instance; }
            private set { DAO_KHACHHANG.instance = value; }
        }

        private DAO_KHACHHANG() { }

        public int LayIDBySDT(string SDT)
        {
            string query = "EXEC LayIDBySDT SDT = @SDT ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { SDT });

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                return id;
            }

            return -1; // Trả về -1 nếu không tìm thấy
        }

    }
}
