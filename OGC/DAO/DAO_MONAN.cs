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

        public bool ThemMonAn(string tenMonAn, int idLoaiMonAn, decimal gia, string moTa, string anh)
        {
            string query = "INSERT INTO MONAN (TenMonAn, IDLoaiMonAn, Gia, MoTa, Anh) VALUES ( @ten , @idLoai , @gia , @moTa , @anh )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenMonAn, idLoaiMonAn, gia, moTa, anh });
            return result > 0;
        }

        public bool SuaMonAn(int id, string tenMonAn, int idLoaiMonAn, decimal gia, string moTa, string anh)
        {
            string query = "UPDATE MONAN SET TenMonAn = @ten , IDLoaiMonAn = @idLoai , Gia = @gia , MoTa = @moTa , Anh = @anh WHERE ID = @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenMonAn, idLoaiMonAn, gia, moTa, anh, id });
            return result > 0;
        }

        public bool XoaMonAn(int idMonAn)
        {
            string query = "DELETE FROM MONAN WHERE ID = @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMonAn });
            return result > 0;
        }


        //-----------lấy mã món ăn dựa trên tên món ăn đó
        public int LayIDMonAnTheoTen(string tenMonAn)
        {
            string query = "EXEC usp_LayIDByTenMonAn @TenMonAn ";
            try
            {
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenMonAn });

                if (result != null && int.TryParse(result.ToString(), out int idMonAn))
                    return idMonAn;

                return -1; // Không tìm thấy
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy ID món ăn: " + ex.Message);
                return -1;
            }
        }

        //---- lấy giá dựa trên id
        public decimal GetGiaMonAnByID(int idMonAn)
        {
            string query = "SELECT Gia FROM MONAN WHERE ID = @ID ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idMonAn });

            if (result != null && result != DBNull.Value)
                return Convert.ToDecimal(result);

            return 0; // hoặc bạn có thể throw exception nếu cần
        }





    }
}
