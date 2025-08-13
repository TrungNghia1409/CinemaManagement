using OGC.DAO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using QuestPDF.Fluent;

using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure; 
using QuestPDF.Helpers;       
using QuestPDF.Drawing;

namespace OGC.Phim
{
    public partial class FrmChiTietHoaDonVePhim : Form
    {
        public string tenPhim;

        private int idNhanVien;
        private int idKhach;
        private int idHoaDon;
        private decimal tongTien;
        private int idVe;
        private decimal giaVe;
        private decimal tienKhachDua;
        private decimal tienThoi;
        private string phong;
        private DateTime ngayChieu;
        private TimeSpan gioChieu;
        private List<string> danhSachGhe;

        public FrmChiTietHoaDonVePhim(
            int idNhanVien,
            int idKhach,
            string tenPhim,
            string suatChieu,
            string phong,
            List<string> ghe,
            string dinhDang,
            decimal giaVe,
            decimal tienKhachDua,
            decimal tienThoi,
            decimal tongTien

        )
        {
            InitializeComponent();

            this.tenPhim = tenPhim;
            this.idNhanVien = idNhanVien;
            this.idKhach = idKhach;
            this.giaVe = giaVe;
            this.tongTien = tongTien;
            this.tienKhachDua = tienKhachDua;
            this.tienThoi = tienThoi;

            this.phong = phong;
            this.danhSachGhe = ghe;

            // Parse suất chiếu: "dd/MM/yyyy HH:mm"
            DateTime suatChieuDateTime = DateTime.ParseExact(suatChieu, "dd/MM/yyyy - HH:mm", CultureInfo.InvariantCulture);
            this.ngayChieu = suatChieuDateTime.Date;
            this.gioChieu = suatChieuDateTime.TimeOfDay;


            // Gộp danh sách ghế thành chuỗi
            string gheDaChon = string.Join(", ", ghe);

            // Hiển thị thông tin lên Label
            lbTenPhim.Text = tenPhim;
            lbSuatChieu.Text = suatChieu;
            lbPhong.Text = phong;
            lbGhe.Text = gheDaChon;
            lbDinhDang.Text = dinhDang;
            lbGiaVe.Text = giaVe.ToString("N0") + " VND";
            lbTongTien.Text = tongTien.ToString("N0") + " VND";
            lbTienKhachDua.Text = tienKhachDua.ToString("N0") + " VND";
            lbTienThoi.Text = tienThoi.ToString("N0") + " VND";

            // Ngày lập hóa đơn
            DateTime ngayLap = DateTime.Now;
            lbNgayLap.Text = ngayLap.ToString("dd/MM/yyyy HH:mm:ss");

            // Mã hóa đơn logic: HD + yyyyMMddHHmmss
            string maHoaDon = "HD" + ngayLap.ToString("yyyyMMdd");
            lbMaHoaDon.Text = maHoaDon;

            // Gán giảm giá mặc định
            lbGiamGia.Text = "0%";

            // Hiển thị tên nhân viên
            string tenNhanVien = DAO_NHANVIEN.Instance.GetTenByID(idNhanVien);
            lbTenNhanVien.Text = tenNhanVien;

            // Thêm hóa đơn vào DB
            idHoaDon = DAO_HD_VE.Instance.ThemHoaDonVe(idNhanVien, idKhach, tongTien);

            // Lấy ID từ các DAO
            int idPhim = PhimDAO.Instance.LayIDPhimTheoTen(tenPhim);
            int idPhong = DAO_PHONGCHIEU.Instance.GetIDPhongByTenPhong(phong);
            int idDinhDang = DAO_DINHDANGPHIM.Instance.LayIdDinhDang(dinhDang);

            if (idPhim == -1 || idPhong == -1 || idDinhDang == -1)
                throw new Exception("Không tìm thấy phim, phòng chiếu hoặc định dạng phim.");

            // Lấy ID lịch chiếu
            int idLichChieu = DAO_LICHCHIEU.Instance.GetIDLichChieu(idPhim, idPhong, ngayChieu);


            // Thêm chi tiết hóa đơn vào DB
            DAO_CTHD_VE.Instance.ThemChiTietHoaDonVeNew(
                idHoaDon,
                idPhim,
                idPhong,
                idLichChieu,
                idDinhDang,
                gheDaChon,
                giaVe,
                "Đã thanh toán"
            );

            // Sinh mã vạch
            string noiDungMaVach = $"{idHoaDon}";
            HienThiMaVach(noiDungMaVach);


        }


        private void HienThiMaVach(string noiDung)
        {
            if (string.IsNullOrEmpty(noiDung)) return;

            var writer = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 300,
                    Margin = 1
                }
            };

            Bitmap qrCodeBitmap = writer.Write(noiDung);
            ptbQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            ptbQRCode.Image = qrCodeBitmap;
        }


        public static void XuatPDFHoaDonVePhim(string tenHD, string ngayLap, string tenNhanVien,
                                       string tenPhim, string suatChieu, string phong, string ghe, string dinhDang,
                                       string giaVe, string giamGia, string tongTien, string tienKhach, string tienThoi,
                                       System.Drawing.Image maVachImage
)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tenHD + ".pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A6);
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Content().Column(col =>
                    {
                        // Tiêu đề và địa chỉ
                        col.Item().AlignCenter().Text("🎬 OGC Cinema").FontSize(16).Bold();
                        col.Item().AlignCenter().Text("123 Lê Lợi, Q.1, TP.HCM");
                        col.Item().AlignCenter().Text("Hotline: 1900.0000");

                        col.Item().PaddingVertical(10).AlignCenter().Text("CHI TIẾT HÓA ĐƠN").FontSize(14).Bold();

                        // Thông tin hóa đơn
                        col.Item().Text($"Mã hóa đơn:      {tenHD}");
                        col.Item().Text($"Ngày lập:        {ngayLap}");
                        col.Item().Text($"Tên nhân viên:   {tenNhanVien}");

                        // Làm nổi bật tên phim, ghế, phòng
                        col.Item().PaddingTop(10).Text(text =>
                        {
                            text.Span("Tên phim: ").SemiBold();
                            text.Span(tenPhim).Bold().FontSize(14);
                        });

                        col.Item().Text(text =>
                        {
                            text.Span("Suất chiếu: ").SemiBold();
                            text.Span(suatChieu);
                        });

                        col.Item().Text(text =>
                        {
                            text.Span("Phòng: ").SemiBold();
                            text.Span(phong).Bold();
                        });

                        col.Item().Text(text =>
                        {
                            text.Span("Ghế: ").SemiBold();
                            text.Span(ghe).Bold();
                        });

                        col.Item().Text(text =>
                        {
                            text.Span("Định dạng: ").SemiBold();
                            text.Span(dinhDang);
                        });

                        // Dòng kẻ
                        col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                        // Giá trị
                        col.Item().Text($"Giá vé:          {giaVe} đ");
                        col.Item().Text($"Giảm giá:        {giamGia} %");
                        col.Item().Text($"Tổng tiền:       {tongTien} đ");
                        col.Item().Text($"Tiền khách đưa:  {tienKhach} đ");
                        col.Item().Text($"Tiền thối:       {tienThoi} đ").Bold();

                        // Mã vạch
                        if (maVachImage != null)
                        {
                            using var ms = new MemoryStream();
                            maVachImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                            col.Item().PaddingTop(15).AlignCenter().Image(ms.ToArray(), ImageScaling.FitWidth);
                        }
                    });
                });
            }).GeneratePdf(filePath);

            MessageBox.Show("Đã xuất hóa đơn ra PDF tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer", filePath);
        }


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string tenHD = lbMaHoaDon.Text;
                string ngayLap = lbNgayLap.Text;
                string tenNhanVien = lbTenNhanVien.Text;
                string tenPhim = lbTenPhim.Text;
                string suatChieu = lbSuatChieu.Text; // "09/08/2025 - 10:52"
                string phong = lbPhong.Text;
                string ghe = lbGhe.Text;
                string dinhDang = lbDinhDang.Text;
                string giaVe = lbGiaVe.Text.Replace(" VND", "").Replace(",", "").Trim();
                string giamGia = lbGiamGia.Text.Replace("%", "").Trim();
                string tongTien = lbTongTien.Text.Replace(" VND", "").Replace(",", "").Trim();
                string tienKhach = lbTienKhachDua.Text.Replace(" VND", "").Replace(",", "").Trim();
                string tienThoi = lbTienThoi.Text.Replace(" VND", "").Replace(",", "").Trim();

                // Parse suất chiếu
                if (!DateTime.TryParseExact(
                    suatChieu,
                    "dd/MM/yyyy - HH:mm",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime suatChieuDateTime))
                {
                    MessageBox.Show("Định dạng suất chiếu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayChieu = suatChieuDateTime.Date;
                TimeSpan gioChieu = suatChieuDateTime.TimeOfDay;

                // Xuất PDF
                XuatPDFHoaDonVePhim(
                    tenHD, ngayLap, tenNhanVien,
                    tenPhim, suatChieu, phong, ghe, dinhDang,
                    giaVe, giamGia, tongTien, tienKhach, tienThoi,
                    ptbQRCode.Image
                );

                // Lưu trạng thái ghế đã đặt 
                foreach (var gheItem in danhSachGhe)
                {
                    int idGhe = DAO_Ghe.Instance.GetIDGheByMaGhe(gheItem);
                    if (idGhe > 0)
                    {
                        DAO_Ghe.Instance.DatGhe_New(
                            idGhe,
                            ngayChieu,
                            gioChieu
                        );
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy ID cho ghế {gheItem}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất PDF hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            // Hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn này không?",
                                                  "Xác nhận hủy",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa chi tiết hóa đơn vé phim trước
                bool xoaChiTiet = DAO_CTHD_VE.Instance.XoaCTHDVePhimTheoIDHoaDon(idHoaDon);

                // Xóa hóa đơn vé phim
                bool xoaHoaDon = DAO_HD_VE.Instance.XoaHDVePhimTheoID(idHoaDon);

                if (xoaChiTiet && xoaHoaDon)
                {
                    MessageBox.Show("Hóa đơn đã được hủy thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hủy hóa đơn thất bại!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
