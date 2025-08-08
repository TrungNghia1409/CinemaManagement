using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DAO
{
    public class DAO_NHANVIEN
    {
        private static DAO_NHANVIEN instance;

        public static DAO_NHANVIEN Instance
        {
            get { if (instance == null) instance = new DAO_NHANVIEN(); return DAO_NHANVIEN.instance; }
            private set { DAO_NHANVIEN.instance = value; }
        }

        private DAO_NHANVIEN() { }

        ////load TKNhanVien  ,   ChucVu vào button trong flowlayoutPanel
        //public List<DTO_NHANVIEN> LoadNhanVienList()
        //{
        //    List<DTO_NHANVIEN> nhanvienList = new List<DTO_NHANVIEN>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery(@" EXEC usp_danhsachnhanvien ");

        //    foreach (DataRow item in data.Rows)
        //    {
        //        DTO_NHANVIEN NhanVienDTO = new DTO_NHANVIEN(item);
        //        nhanvienList.Add(NhanVienDTO);
        //    }

        //    return nhanvienList;
        //}

        // Thêm nhân viên mới
        public List<DTO_NHANVIEN> DanhSachNhanVien()
        {
            List<DTO_NHANVIEN> list = new List<DTO_NHANVIEN>();

            string query = @" usp_danhsachNHANVIEN ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                DTO_NHANVIEN nv = new DTO_NHANVIEN();
                nv.ID = Convert.ToInt32(row["ID"]);
                nv.Username = row["Username"].ToString();
                nv.TenChucVu = row["TenChucVu"].ToString();
                nv.HoTen = row["HoTen"].ToString();
                nv.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
                nv.GioiTinh = row["GioiTinh"].ToString();
                nv.SDT = row["SDT"].ToString();
                nv.Email = row["Email"].ToString();
                nv.DiaChi = row["DiaChi"].ToString();

                list.Add(nv);
            }

            return list;
        }


        //------Phương thức thêm nhân viên
        // Thêm nhân viên mới
        public bool ThemNhanVien(string tkNhanVien, string mkNhanVien)
        {
            // Thêm tài khoản nhân viên trước
            bool addTaiKhoan = DAO_TKNHANVIEN.Instance.AddTaiKhoanNhanVien(tkNhanVien, mkNhanVien); //gọi phương thức AddTaiKhoanNhanVien trong DAO_TKNHANVIEN, bởi vì
                                                                                                    //tạo nhân viên mới trong DAO_TKNHANVIEN sẽ hợp lý hơn, nhưng mà cũng cần vài trường trong table NhanVien nên phải rườm rà như vậy
            if (!addTaiKhoan) return false;

            // Sau khi thêm tài khoản thành công, thêm thông tin vào bảng NhanVien
            string queryNhanVien = "EXEC usp_themNHANVIEN @Username , @IDChucVu , @HoTen , @NgaySinh , @GioiTinh , @SDT , @Email , @DiaChi ";

            int iDChucVu = 1;
            string hoTen = "Chưa cập nhật";
            DateTime ngaySinh = new DateTime(2025, 1, 1);
            string gioiTinh = "Chưa cập nhật";
            string sDT = "Chưa cập nhật";
            string email = "Chưa cập nhật";
            string diaChi = "Chưa cập nhật";

            int result = DataProvider.Instance.ExecuteNonQuery(queryNhanVien, new object[] { tkNhanVien, iDChucVu, hoTen, ngaySinh, gioiTinh, sDT, email, diaChi });

            return result > 0;

        }

        //------Phương thức lấy mã nhân viên dựa vào Username 
        public int GetIDByUsername(string tkNhanVien)
        {
            string query = "SELECT ID FROM NHANVIEN WHERE Username = @Username ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tkNhanVien });

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                return id;
            }

            return -1; // Trả về -1 nếu không tìm thấy
        }
        //Xóa thông tin nhân viên (Xóa nhân viên)
        public bool XoaNhanVien(string tkNhanVien)
        {
            int id = DAO_NHANVIEN.Instance.GetIDByUsername(tkNhanVien);
            if (id == -1)
            {
                MessageBox.Show("Không tìm thấy nhân viên với username này!");
            }

            // Câu lệnh xóa trong bảng NhanVien
            string query_NV = @" EXEC usp_xoaNHANVIEN @ID ";

            // Câu lệnh xóa trong bảng TKNhanVien
            string query_TKNV = @" EXEC usp_xoaTKNHANVIEN @Username ";


            try
            {
                // Thực thi câu lệnh DELETE cho bảng NhanVien
                int result1 = DataProvider.Instance.ExecuteNonQuery(query_NV, new object[] { id });

                // Thực thi câu lệnh DELETE cho bảng TKNhanVien
                int result2 = DataProvider.Instance.ExecuteNonQuery(query_TKNV, new object[] { tkNhanVien });

                return ((result1 > 0) && (result2 > 0));
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}");
                return false;
            }
        }
        //------Phương thức sửa thông tin nhân tin
        public bool SuaNhanVien(string username, string hoTen, DateTime ngaySinh, string gioiTinh, string sDT, string email, string diaChi, string tenChucVu, string anhNV)
        {
            string query = "EXEC usp_suaNHANVIEN @Username , @HoTen , @NgaySinh , @GioiTinh , @SDT , @Email , @DiaChi , @TenChucVu , @AnhNV ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            { username, hoTen, ngaySinh, gioiTinh, sDT, email, diaChi, tenChucVu, anhNV});

            return result > 0;
        }

        //-------- lấy thong tin chức vụ dựa vào tài khoản nhân viên
        public string GetTenChucVuByUsername(string username)
        {
            string query = @"
                        SELECT CV.TenChucVu
                        FROM NHANVIEN NV
                        JOIN CHUCVU CV ON NV.IDChucVu = CV.ID
                        WHERE NV.Username = @Username ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

            return result?.ToString() ?? ""; // Trả về "" nếu không có kết quả
        }

        //------ lấy tên nhân viên dựa vào mã nhân viên
        public string GetTenByID(int iDNhanVien)
        {
            string query = @" SELECT HoTen FROM NHANVIEN
                        WHERE ID = @ID ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { iDNhanVien });

            return result?.ToString() ?? ""; // Trả về "" nếu không có kết quả
        }

        //--hàm lấy ảnh từ mã nhân viên
        public string LayAnhNhanVien(int idNhanVien)
        {
            string query = "SELECT AnhNV FROM NHANVIEN WHERE ID = @ID ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idNhanVien });

            return result != null ? result.ToString() : null;
        }

        //lấy email dựa trên username
        public string GetEmailByUsername(string username)
        {
            string query = "SELECT Email FROM NHANVIEN WHERE Username = @username ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });

            return result != null ? result.ToString() : string.Empty;
        }

        //--lấy thông tin: Họ tên, sđt, email phục vụ cho việc xác nhận thông tin đổi mật khẩu
        public DataTable LayThongTinNhanVien(string username)
        {
            string query = "SELECT HoTen, Email, SDT FROM NHANVIEN WHERE Username = @Username ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }
    }
}
