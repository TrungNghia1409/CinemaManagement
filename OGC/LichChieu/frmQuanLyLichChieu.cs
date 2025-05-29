using OGC.DAO;
using OGC.DTO;
using OGC.LichChieu;
using OGC.NHANVIEN;
using OGC.ThuocTinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.LichChieu
{
    public partial class frmQuanLyLichChieu : Form
    {
        public static frmQuanLyLichChieu Instance;
        public frmQuanLyLichChieu()
        {
            InitializeComponent();


            Instance = this;

            LoadLichChieu();
            //LoadLichChieuTheoNgay(dtpBatDau.Value.Date, dtpKetThuc.Value.Date.AddDays(1).AddTicks(-1));
            LoadTenPhong();

        }

        private void LoadLichChieuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            flpLichChieu.Controls.Clear(); // Xóa các UC cũ

            TieuDeUC ucTieuDe = new TieuDeUC(); // Thêm tiêu đề nếu cần
            pnlTieuDe.Controls.Clear();
            pnlTieuDe.Controls.Add(ucTieuDe);

            List<DTO_LICHCHIEU> danhSach = DAO_LICHCHIEU.Instance.LocLichChieuTheoKhoangNgay(tuNgay, denNgay);

            foreach (DTO_LICHCHIEU lc in danhSach)
            {
                LichChieuUC uc = new LichChieuUC(lc);
                uc.LichChieuData = lc;  // Đảm bảo lc không null

                uc.TenPhim = lc.TenPhim;
                uc.TenPhong = lc.TenPhong;
                uc.NgayGio = lc.NgayGio.ToString("dd/MM/yyyy");
                uc.GiaVe = lc.GiaVe;
                uc.DiaDiem = lc.DiaDiem;
                uc.TrangThai = lc.TrangThai;
                uc.Anh = lc.Anh;
                uc.AnhPhong = lc.AnhPhong;

                flpLichChieu.Controls.Add(uc);
            }

        }
        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {
            DateTime batDau = dtpBatDau.Value.Date;
            DateTime ketThuc = dtpKetThuc.Value.Date.AddDays(1).AddTicks(-1);

            if (batDau < DateTime.Now.Date)
            {
                MessageBox.Show("Thời gian bắt đầu không được nhỏ hơn ngày hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadLichChieuTheoNgay(batDau, ketThuc);

        }

        private void dtpKetThuc_ValueChanged(object sender, EventArgs e)
        {
            DateTime batDau = dtpBatDau.Value.Date;
            DateTime ketThuc = dtpKetThuc.Value.Date.AddDays(1).AddTicks(-1);

            if (batDau > ketThuc)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn hoặc bằng thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadLichChieuTheoNgay(batDau, ketThuc);
        }

        //------ Tìm kiếm bằng text không dấu
        public static string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var chars = normalized.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark);
            return new string(chars.ToArray()).Normalize(NormalizationForm.FormC);
        }
        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = RemoveDiacritics(txbTimKiem.Text.Trim().ToLower());
            LoadLichChieu(tuKhoa); // gọi lại hàm LoadNhanVien với từ khóa
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbTimKiem.Text = string.Empty;
        }


        #region Methods
        //Load tên phòng
        private void LoadTenPhong()
        {
            List<string> tenPhong = DAO_LOAIPHONG.Instance.DanhSachTenPhong_List();

            // Thêm tùy chọn "Tất cả" để hiển thị toàn bộ
            tenPhong.Insert(0, "Tất cả");

            cbTenPhong.DataSource = tenPhong;
        }
        //hiển thị danh sách lịch chiếu
        public void LoadLichChieu(string tuKhoa = "")
        {
            flpLichChieu.Controls.Clear(); // Xóa dữ liệu cũ

            TieuDeUC ucTieuDe = new TieuDeUC();// Tạo và thêm UC_TieuDeNhalcien (tiêu đề)
            pnlTieuDe.Controls.Add(ucTieuDe);

            List<DTO_LICHCHIEU> danhSach = DAO_LICHCHIEU.Instance.DanhSachLichChieu();

            // Lọc theo từ khóa (tên nhân viên)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                danhSach = danhSach
                    .Where(lc => RemoveDiacritics(lc.TenPhim.ToLower()).Contains(tuKhoa))
                    .ToList();
            }

            foreach (DTO_LICHCHIEU lc in danhSach)
            {
                LichChieuUC uc = new LichChieuUC(lc);
                uc.LichChieuData = lc;  // Đảm bảo lc không null

                uc.TenPhim = lc.TenPhim;
                uc.TenPhong = lc.TenPhong;
                uc.NgayGio = lc.NgayGio.ToString("dd/MM/yyyy");
                uc.GiaVe = lc.GiaVe;
                uc.DiaDiem = lc.DiaDiem;
                uc.TrangThai = lc.TrangThai;
                uc.Anh = lc.Anh;
                uc.AnhPhong = lc.AnhPhong;

                flpLichChieu.Controls.Add(uc);

            }

            flpLichChieu.Update();
        }
        //hiển thị danh sách lịch chiếu dựa theo tên phòng
        private void LoadLichChieuTheoTenPhong(string tenPhong)
        {
            flpLichChieu.Controls.Clear();

            TieuDeUC ucTieuDe = new TieuDeUC();
            pnlTieuDe.Controls.Clear();
            pnlTieuDe.Controls.Add(ucTieuDe);

            List<DTO_LICHCHIEU> danhSach = DAO_LICHCHIEU.Instance.DanhSachLichChieu();

            if (tenPhong != "Tất cả")
            {
                danhSach = danhSach
                    .Where(lc => lc.TenPhong == tenPhong)
                    .ToList();
            }

            foreach (DTO_LICHCHIEU lc in danhSach)
            {
                LichChieuUC uc = new LichChieuUC(lc);

                uc.TenPhim = lc.TenPhim;
                uc.TenPhong = lc.TenPhong;
                uc.NgayGio = lc.NgayGio.ToString("dd/MM/yyyy");
                uc.GiaVe = lc.GiaVe;
                uc.DiaDiem = lc.DiaDiem;
                uc.TrangThai = lc.TrangThai;
                uc.Anh = lc.Anh;
                uc.AnhPhong = lc.AnhPhong;

                flpLichChieu.Controls.Add(uc);
            }
        }


        #endregion

        #region Events

        //sự kiện thêm lịch chiếu
        private void btnThemLC_Click(object sender, EventArgs e)
        {
            frmThemLichChieu f = new frmThemLichChieu();
            f.ShowDialog();
        }

        //sự kiện lọc lịch chiếu theo tên phòng
        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenPhongChon = cbTenPhong.SelectedItem.ToString();
            LoadLichChieuTheoTenPhong(tenPhongChon);
        }

        #endregion


        private void chbBoLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBoLoc.Checked)
            {
                // Nếu "Bỏ lọc" được bật → hiển thị tất cả
                LoadLichChieu();

                // Vô hiệu hóa DateTimePicker để người dùng không thay đổi
                dtpBatDau.Enabled = false;
                dtpKetThuc.Enabled = false;
            }
            else
            {
                // Khi bỏ chọn "Bỏ lọc" → áp dụng lại bộ lọc theo ngày
                dtpBatDau.Enabled = true;
                dtpKetThuc.Enabled = true;
                LoadLichChieuTheoNgay(dtpBatDau.Value.Date, dtpKetThuc.Value.Date.AddDays(1).AddTicks(-1));
            }
        }
    }
}
