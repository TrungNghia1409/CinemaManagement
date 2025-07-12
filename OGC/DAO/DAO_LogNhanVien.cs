using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_LogNhanVien
    {
        private static DAO_LogNhanVien instance;

        public static DAO_LogNhanVien Instance
        {
            get { if (instance == null) instance = new DAO_LogNhanVien(); return DAO_LogNhanVien.instance; }
            private set { DAO_LogNhanVien.instance = value; }
        }

        private DAO_LogNhanVien() { }

        public List<DTO_LogNhanVien> LayTatCaLog()
        {
            string query = @"   SELECT 
                            L.ID,
                            L.Username,
                            C.TenChucVu AS TenChucVu,
                            L.ThaoTac,
                            FORMAT(L.ThoiGian, 'HH:mm') AS Gio,
                            FORMAT(L.ThoiGian, 'dd/MM/yyyy') AS Ngay,
                            L.ChucNang
                        FROM LOG_NHANVIEN L
                        LEFT JOIN CHUCVU C ON L.IDChucVu = C.ID
                        ORDER BY L.ThoiGian DESC; ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<DTO_LogNhanVien> list = new List<DTO_LogNhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_LogNhanVien log = new DTO_LogNhanVien
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Username = row["Username"].ToString(),
                    TenChucVu = row["TenChucVu"].ToString(),
                    ThaoTac = row["ThaoTac"].ToString(),
                    Gio = row["Gio"].ToString(),
                    Ngay = row["Ngay"].ToString(),
                    ChucNang = row["ChucNang"].ToString()
                };

                list.Add(log);
            }

            return list;
        }

        //lọc nhật ký hoạt động theo thời gian
        public List<DTO_LogNhanVien> LayLogTheoNgay(int? ngay, int? thang, int? nam)
        {
            string query = @"
        SELECT 
            L.ID, 
            L.Username, 
            C.TenChucVu AS TenChucVu, 
            L.ThaoTac, 
            FORMAT(L.ThoiGian, 'HH:mm') AS Gio,
            FORMAT(L.ThoiGian, 'dd/MM/yyyy') AS Ngay,
            L.ChucNang
        FROM LOG_NHANVIEN L
        LEFT JOIN CHUCVU C ON L.IDChucVu = C.ID
        WHERE ( @ngay IS NULL OR DAY(L.ThoiGian) = @ngay )
          AND ( @thang IS NULL OR MONTH(L.ThoiGian) = @thang )
          AND ( @nam IS NULL OR YEAR(L.ThoiGian) = @nam )
        ORDER BY L.ThoiGian DESC";

            object[] parameters = {
        ngay.HasValue ? (object)ngay : DBNull.Value,
        thang.HasValue ? (object)thang : DBNull.Value,
        nam.HasValue ? (object)nam : DBNull.Value
    };

            DataTable dt = DataProvider.Instance.NHN_ExecuteQuery(query, parameters);
            List<DTO_LogNhanVien> list = new List<DTO_LogNhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_LogNhanVien log = new DTO_LogNhanVien
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Username = row["Username"].ToString(),
                    TenChucVu = row["TenChucVu"].ToString(),
                    ThaoTac = row["ThaoTac"].ToString(),
                    Gio = row["Gio"].ToString(),
                    Ngay = row["Ngay"].ToString(),
                    ChucNang = row["ChucNang"].ToString()
                };

                list.Add(log);
            }

            return list;
        }


        public void SetContext_Username(string username)
        {
            string query = @" DECLARE @context VARBINARY(128) = CAST( @Username AS VARBINARY(128));
                              SET CONTEXT_INFO @context ;";

            DataProvider.Instance.NHN_ExecuteNonQuery(query, new object[] { username });
        }



    }
}
