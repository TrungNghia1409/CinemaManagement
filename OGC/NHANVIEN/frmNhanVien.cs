using OGC.DAO;
using OGC.DTO;
using System.Globalization;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.NHANVIEN
{
    public partial class frmNhanVien : Form
    {
        public string currentUser;
        public static frmNhanVien Instance;
        public frmNhanVien(string username)
        {
            InitializeComponent();
            Instance = this; // Gán thể hiện hiện tại vào Instance

            currentUser = username;

            lblUserLogin.Text = "Xin chào " + username;

            LoadNhanVien();
            LoadChucVu();
        }

        private void lblBackHome_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain(currentUser);
            f.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbTimKiem.Text = string.Empty;
        }

        //------ Tìm kiếm bằng text không dấu
        public static string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var chars = normalized.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark);
            return new string(chars.ToArray()).Normalize(NormalizationForm.FormC);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = RemoveDiacritics(txbTimKiem.Text.Trim().ToLower());
            LoadNhanVien(tuKhoa); // gọi lại hàm LoadNhanVien với từ khóa
        }



        public void LoadNhanVien(string tuKhoa = "")
        {
            flpNhanVien.Controls.Clear(); // Xóa dữ liệu cũ

            TieuDeNhanVienUC ucTieuDe = new TieuDeNhanVienUC();// Tạo và thêm UC_TieuDeNhanVien (tiêu đề)
            flpTieuDeNhanVien.Controls.Add(ucTieuDe);

            List<DTO_NHANVIEN> danhSach = DAO_NHANVIEN.Instance.DanhSachNhanVien();

            // Lọc theo từ khóa (tên nhân viên)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                danhSach = danhSach
                    .Where(nv => RemoveDiacritics(nv.HoTen.ToLower()).Contains(tuKhoa))
                    .ToList();
            }

            foreach (DTO_NHANVIEN nv in danhSach)
            {
                NhanVienUC uc = new NhanVienUC(nv);
                uc.NhanVienData = nv;  // Đảm bảo nv không null

                uc.ID = nv.ID.ToString();
                uc.Username = nv.Username;
                uc.ChucVu = nv.TenChucVu;
                uc.HoTen = nv.HoTen;
                uc.NgaySinh = nv.NgaySinh.ToString("dd/MM/yyyy");
                uc.GioiTinh = nv.GioiTinh;
                uc.SDT = nv.SDT;
                uc.Email = nv.Email;
                uc.DiaChi = nv.DiaChi;

                flpNhanVien.Controls.Add(uc);
               


            }
        }


        //------- Phương thức hiển thị danh sách chức vụ
        private void LoadChucVu()
        {
            List<string> chucVu = DAO_CHUCVU.Instance.DanhSachChucVu_List();

            // Thêm tùy chọn "Tất cả" để hiển thị toàn bộ
            chucVu.Insert(0, "Tất cả");

            cbChucVu.DataSource = chucVu;
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chucVuChon = cbChucVu.SelectedItem.ToString();
            LoadNhanVienTheoChucVu(chucVuChon);
        }
        //-------- Load Nhân viên theo chức vụ
        private void LoadNhanVienTheoChucVu(string chucVu)
        {
            flpNhanVien.Controls.Clear();

            TieuDeNhanVienUC ucTieuDe = new TieuDeNhanVienUC();
            flpTieuDeNhanVien.Controls.Clear();
            flpTieuDeNhanVien.Controls.Add(ucTieuDe);

            List<DTO_NHANVIEN> danhSach = DAO_NHANVIEN.Instance.DanhSachNhanVien();

            if (chucVu != "Tất cả")
            {
                danhSach = danhSach
                    .Where(nv => nv.TenChucVu == chucVu)
                    .ToList();
            }

            foreach (DTO_NHANVIEN nv in danhSach)
            {
                NhanVienUC uc = new NhanVienUC(nv);
                uc.ID = nv.ID.ToString();
                uc.Username = nv.Username;
                uc.ChucVu = nv.TenChucVu;
                uc.HoTen = nv.HoTen;
                uc.NgaySinh = nv.NgaySinh.ToString("dd/MM/yyyy");
                uc.GioiTinh = nv.GioiTinh;
                uc.SDT = nv.SDT;
                uc.Email = nv.Email;
                uc.DiaChi = nv.DiaChi;

                flpNhanVien.Controls.Add(uc);
            }
        }

    }
}
