using OGC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DrawingImage = System.Drawing.Image;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;
using QRCoder;
using static OGC.DTO.DTO_CartItem;
using System.Diagnostics;

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QContainer = QuestPDF.Infrastructure.IContainer;





namespace OGC.QuanLyDichVu
{
    public partial class frmChiTietHoaDonMonAn : Form
    {
        public int iDHoaDon;
        public int iDNhanVien;
        public int iDKhach;
        public int mucGiam;
        List<CartItem> gioHang;
        public decimal tongTien;
        public frmChiTietHoaDonMonAn(int iDNhanVien, int iDKhach, List<CartItem> gioHang, decimal tongTien, int mucGiam)
        {
            InitializeComponent();

            this.iDNhanVien = iDNhanVien;
            this.iDKhach = iDKhach;
            this.gioHang = gioHang;
            this.tongTien = tongTien;
            this.mucGiam = mucGiam;

            //lấy tên nhân viên và hiển thị
            string tennv = DAO_NHANVIEN.Instance.GetTenByID(iDNhanVien);
            lblTenNhanVien.Text = tennv;

            // Lấy tiền khách đưa
            decimal tienKhachDua = string.IsNullOrEmpty(txbTienKhachDua.Text) ? 0 :
                       decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);

            // Lấy tổng tiền từ biến tongTien (tránh Parse lại từ label)
            decimal tienGiam = tongTien * mucGiam / 100;
            decimal tienPhaiTra = tongTien - tienGiam;
            decimal tienThoi = tienKhachDua - tienPhaiTra;

            lblTongTien_KetQua.Text = tienPhaiTra.ToString("N0", CultureInfo.InvariantCulture);
            lblTienThoi_KetQua.Text = tienThoi.ToString();
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblMucGiam_KetQua.Text = mucGiam.ToString() + "%";


        }

        private void frmChiTietHoaDonMonAn_Load(object sender, EventArgs e)
        {
            iDHoaDon = DAO_HD_MONAN.Instance.ThemHoaDonMonAn(iDNhanVien, iDKhach, tongTien);
            lblMaHoaDon.Text = "HD2025" + iDHoaDon.ToString();

            foreach (var item in gioHang)
            {
                int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(item.TenMonAn); 
                decimal gia = DAO_MONAN.Instance.GetGiaMonAnByID(idMonAn);


                ptbMaQR.Image = GenerateQRCode(iDHoaDon.ToString());
                DAO_CTHD_MONAN.Instance.ThemChiTietHoaDonMonAn(iDHoaDon, idMonAn, item.SoLuong, gia);
            }

            dgvChiTiet.DataSource = DAO_CTHD_MONAN.Instance.LayDSByIDHoaDon(iDHoaDon);

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.Columns["ID"].FillWeight = 15;
            dgvChiTiet.Columns["Ten"].FillWeight = 25;
            dgvChiTiet.Columns["SL"].FillWeight = 10;
            dgvChiTiet.Columns["Gia"].FillWeight = 15;
            dgvChiTiet.Columns["ThanhTien"].FillWeight = 20;

        }

        //----hàm xuất file PDF (giả lập xuất bill cho khách hàng)
        public static void XuatPDF(DataGridView dgv, string tenFile, string tenHD, string ngayLap, string nhanVien,
                           string tongTien, string tienKhach, string tienThoi, string giamGia, System.Drawing.Image qrImage)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tenFile + ".pdf");

            // Style ô header
            Func<QContainer, QContainer> HeaderCellStyle = container =>
                container.DefaultTextStyle(x => x.SemiBold()).Padding(5).Background(Colors.Grey.Lighten3);

            // Style ô dữ liệu
            Func<QContainer, QContainer> DataCellStyle = container =>
                container.Padding(5);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Content().Column(col =>
                    {
                        // ─────────────────────────────────────────────────────
                        // HÀNG ĐẦU TIÊN: Địa chỉ ở giữa, QR bên phải - CÙNG HÀNG
                        col.Item().Row(row =>
                        {
                            // Trái: địa chỉ căn giữa
                            row.RelativeItem().Column(left =>
                            {
                                left.Item().AlignCenter().Text("🎬 OGC Cinema").FontSize(16).Bold();
                                left.Item().AlignCenter().Text("123 Lê Lợi, Q.1, TP.HCM");
                                left.Item().AlignCenter().Text("Hotline: 1900.0000");
                            });

                            // Phải: QR Code
                            if (qrImage != null)
                            {
                                using var ms = new MemoryStream();
                                qrImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                                row.ConstantItem(80).AlignRight().Element(qr =>
                                    qr.Height(80).Image(ms.ToArray())
                                );
                            }
                        });
                        // ─────────────────────────────────────────────────────

                        // Tiêu đề
                        col.Item().PaddingVertical(10).AlignCenter().Text("HÓA ĐƠN DỊCH VỤ").FontSize(14).Bold();

                        // Thông tin hóa đơn
                        col.Item().Text($"Mã hóa đơn: {tenHD}");
                        col.Item().Text($"Ngày lập: {ngayLap}");
                        col.Item().Text($"Nhân viên: {nhanVien}");

                        // Bảng dữ liệu
                        col.Item().PaddingVertical(10).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(30);   // ID
                                columns.RelativeColumn(2);    // Tên món ăn
                                columns.ConstantColumn(30);   // SL
                                columns.ConstantColumn(60);   // Đơn giá
                                columns.ConstantColumn(70);   // Thành tiền
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(HeaderCellStyle).Text("ID");
                                header.Cell().Element(HeaderCellStyle).Text("Tên món ăn");
                                header.Cell().Element(HeaderCellStyle).AlignCenter().Text("SL");
                                header.Cell().Element(HeaderCellStyle).AlignRight().Text("Đơn giá");
                                header.Cell().Element(HeaderCellStyle).AlignRight().Text("Thành tiền");
                            });

                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string id = row.Cells[0].Value?.ToString() ?? "";
                                string ten = row.Cells[1].Value?.ToString() ?? "";
                                int sl = int.TryParse(row.Cells[2].Value?.ToString(), out var parsedSL) ? parsedSL : 0;
                                decimal donGia = decimal.TryParse(row.Cells[3].Value?.ToString(), out var parsedDG) ? parsedDG : 0;
                                decimal thanhTien = decimal.TryParse(row.Cells[4].Value?.ToString(), out var parsedTT) ? parsedTT : (sl * donGia);

                                table.Cell().Element(DataCellStyle).Text(id);
                                table.Cell().Element(DataCellStyle).Text(ten);
                                table.Cell().Element(DataCellStyle).AlignCenter().Text(sl.ToString());
                                table.Cell().Element(DataCellStyle).AlignRight().Text(donGia.ToString("N0"));
                                table.Cell().Element(DataCellStyle).AlignRight().Text(thanhTien.ToString("N0"));
                            }
                        });

                        // Tổng kết
                        col.Item().PaddingTop(15).AlignRight().Text($"Tổng tiền: {tongTien} đ");
                        col.Item().AlignRight().Text($"Tiền khách đưa: {tienKhach} đ");
                        col.Item().AlignRight().Text($"Giảm giá: {giamGia}");
                        col.Item().AlignRight().Text($"Tiền thối lại: {tienThoi} đ").Bold();
                    });
                });
            }).GeneratePdf(filePath);


            MessageBox.Show("Đã xuất hóa đơn ra PDF tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer", filePath);
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTienKhachDua.Text))
            {
                MessageBox.Show("Tiền khách đưa rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTienKhachDua.Text = string.Empty;
                lblTienThoi_KetQua.Text = "-" + tongTien.ToString();
                return;
            }

            decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);
            decimal tongTienValue = decimal.Parse(lblTongTien_KetQua.Text, CultureInfo.InvariantCulture);
            decimal tienThoi = tienKhachDua - tongTienValue;

            // Gọi xuất PDF
            frmChiTietHoaDonMonAn.XuatPDF(
                dgvChiTiet,
                "HoaDonMonAn_" + iDHoaDon,
                lblTen.Text,
                lblNgayLap.Text,
                lblTenNhanVien.Text,
                tongTienValue.ToString("N0"),
                tienKhachDua.ToString("N0"),
                tienThoi.ToString("N0"),
                lblMucGiam_KetQua.Text,
                ptbMaQR.Image
            );

            DAO_CTHD_MONAN.Instance.CapNhatTrangThai("Đã in", iDHoaDon);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn này không?",
                                          "Xác nhận hủy",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool xoaChiTiet = DAO_CTHD_MONAN.Instance.XoaCTHDMonAnTheoIDHoaDon(iDHoaDon);
                bool xoaHoaDon = DAO_HD_MONAN.Instance.XoaHDMonAnTheoID(iDHoaDon);

                if (xoaChiTiet && xoaHoaDon)
                {
                    MessageBox.Show("Hóa đơn đã được hủy thành công!", "Thông báo");
                    this.Close(); // hoặc Reset form
                }
                else
                {
                    MessageBox.Show("Hủy hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTienKhachDua.Text))
            {
                try
                {
                    decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);
                    decimal tongTien = decimal.Parse(lblTongTien_KetQua.Text, CultureInfo.InvariantCulture);
                    decimal tienThoi = tienKhachDua - tongTien;

                    lblTienThoi_KetQua.Text = tienThoi.ToString("N0", CultureInfo.InvariantCulture);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTienKhachDua.Focus();
                }
            }
            else
            {
                lblTienThoi_KetQua.Text = "-" + tongTien.ToString();
            }
        }

        private void txbTienKhachDua_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTienKhachDua.Text))
            {
                try
                {
                    decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);
                    decimal tongTien = decimal.Parse(lblTongTien_KetQua.Text, CultureInfo.InvariantCulture);
                    decimal tienThoi = tienKhachDua - tongTien;

                    if (tienKhachDua < tongTien)
                    {
                        MessageBox.Show("Tiền khách đưa không đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbTienKhachDua.Text = string.Empty;
                        lblTienThoi_KetQua.Text = "-" + tongTien.ToString(); // Hoặc hiển thị số âm: tienThoi.ToString("N0")
                    }
                    else
                    {
                        lblTienThoi_KetQua.Text = tienThoi.ToString("N0", CultureInfo.InvariantCulture);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTienKhachDua.Focus();
                }
            }
            else
            {
                lblTienThoi_KetQua.Text = "0";
            }
        }

        //----tạo mã QR tự động dựa trên ID của CTHD
        public DrawingImage GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20); // 20 là độ phân giải
        }
    }
}
