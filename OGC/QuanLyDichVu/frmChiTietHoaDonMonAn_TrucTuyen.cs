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
    public partial class frmChiTietHoaDonMonAn_TrucTuyen : Form
    {
        public int iD;
        public frmChiTietHoaDonMonAn_TrucTuyen(int iD)
        {
            InitializeComponent();
            this.iD = iD;

            decimal tongTien = DAO_CTHD_MONAN.Instance.GetTongTienVeTheoIDHoaDon(iD);

            lblTongTien_KetQua.Text = tongTien.ToString();
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ptbMaQR.Image = GenerateQRCode(iD.ToString());
        }

        private void frmChiTietHoaDonMonAn_TrucTuyen_Load(object sender, EventArgs e)
        {
            dgvChiTiet.DataSource = DAO_CTHD_MONAN.Instance.LayDSByIDHoaDon(iD);
        }

        private void XuatPdfTuDataGridView(DataGridView dgv, string tenFile)
        {
            string tenHoaDon = "HD1412" + iD;
            string ngayLap = lblNgayLap.Text;
            string tongTien = lblTongTien_KetQua.Text;
            string tenNhanVien = "Không rõ"; // Nếu có label tên nhân viên thì lấy từ đó

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tenFile + ".pdf");

            DrawingImage qrImg = ptbMaQR.Image;

            Func<QContainer, QContainer> HeaderCellStyle = container =>
                container.DefaultTextStyle(x => x.SemiBold()).Padding(5).Background(Colors.Grey.Lighten3);

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
                        // Hàng đầu tiên: Địa chỉ ở giữa, QR bên phải
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(center =>
                            {
                                center.Item().AlignCenter().Text("🎬 OGC Cinema").FontSize(16).Bold();
                                center.Item().AlignCenter().Text("123 Lê Lợi, Q.1, TP.HCM");
                                center.Item().AlignCenter().Text("Hotline: 1900.0000");
                            });

                            if (qrImg != null)
                            {
                                using var ms = new MemoryStream();
                                qrImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                                row.ConstantItem(80).AlignRight().Element(qr =>
                                    qr.Height(80).Image(ms.ToArray())
                                );
                            }
                        });

                        // ─────────────────────────────────────────────────────
                        col.Item().PaddingVertical(10).AlignCenter().Text("HÓA ĐƠN DỊCH VỤ").FontSize(14).Bold();
                        col.Item().Text($"Mã hóa đơn:     {tenHoaDon}");
                        col.Item().Text($"Ngày lập:       {ngayLap}");

                        // Bảng dữ liệu
                        col.Item().PaddingVertical(10).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(30);   // ID
                                columns.RelativeColumn(2);    // Tên món ăn
                                columns.ConstantColumn(30);   // SL
                                columns.ConstantColumn(60);   // Giá
                                columns.ConstantColumn(70);   // Thành tiền
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(HeaderCellStyle).Text("ID");
                                header.Cell().Element(HeaderCellStyle).Text("Tên món ăn");
                                header.Cell().Element(HeaderCellStyle).AlignCenter().Text("SL");
                                header.Cell().Element(HeaderCellStyle).AlignRight().Text("Giá");
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

                        col.Item().PaddingTop(15).AlignRight().Text($"Tổng tiền: {tongTien} đ").Bold();
                    });
                });
            }).GeneratePdf(filePath);

            DAO_CTHD_MONAN.Instance.CapNhatTrangThai("Đã in", iD);
            MessageBox.Show("Đã xuất hóa đơn ra PDF tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer", filePath);
        }


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                XuatPdfTuDataGridView(dgvChiTiet, "HoaDonMonAn_" + iD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message);
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
