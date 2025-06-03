using ClosedXML.Excel;
using OGC.DAO;
using QRCoder;
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

        private void XuatExcelTuDataGridView(DataGridView dgv, string tenFile)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ChiTietHoaDon");

                int currentRow = 1;

                // --- Ghi thông tin các label / textbox ---
                worksheet.Cell(currentRow, 1).Value = "Tên hóa đơn:";
                worksheet.Cell(currentRow, 2).Value = lblTen.Text;
                currentRow++;

                worksheet.Cell(currentRow, 1).Value = "Ngày lập:";
                worksheet.Cell(currentRow, 2).Value = lblNgayLap.Text;
                currentRow++;

                worksheet.Cell(currentRow, 1).Value = "Tổng Tiền:";
                worksheet.Cell(currentRow, 2).Value = lblTongTien_KetQua.Text;
                currentRow++;


                worksheet.Cell(currentRow, 1).Value = "Mã:";
                // Chèn hình từ PictureBox vào Excel
                if (ptbMaQR.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        ptbMaQR.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Position = 0;

                        var picture = worksheet.AddPicture(ms)
                            .MoveTo(worksheet.Cell(currentRow, 2)); // Ô B (cột 2)

                        // Đặt kích thước cố định (width, height) theo pixel
                        picture.Width = 100;  // Chiều rộng 100px
                        picture.Height = 100; // Chiều cao 100px
                    }
                }

                // Đặt chiều rộng cột và chiều cao dòng để chứa vừa hình
                worksheet.Column(2).Width = 15; // Đơn vị: ký tự (~100px)
                worksheet.Row(currentRow).Height = 50; // Đơn vị: điểm (points, ~100px)
                currentRow++;

                // --- Ghi tiêu đề cột của DataGridView ---
                int headerRow = currentRow;
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cell(headerRow, col + 1).Value = dgv.Columns[col].HeaderText;
                    worksheet.Cell(headerRow, col + 1).Style.Font.Bold = true;
                    worksheet.Cell(headerRow, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }
                currentRow++;

                // --- Ghi dữ liệu từng dòng từ DataGridView ---
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        object cellValue = dgv.Rows[row].Cells[col].Value;
                        worksheet.Cell(currentRow + row, col + 1).Value = cellValue?.ToString();
                    }
                }

                // --- Tự động điều chỉnh độ rộng cột ---
                worksheet.Columns().AdjustToContents();

                // --- Lưu file ra Desktop ---
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    tenFile + ".xlsx"
                );
                workbook.SaveAs(filePath);

                DAO_CTHD_MONAN.Instance.CapNhatTrangThai("Đã in", iD);
                MessageBox.Show("Đã xuất hóa đơn ra Excel tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            XuatExcelTuDataGridView(dgvChiTiet, "HoaDonMonAn_" + iD);
        }

        //----tạo mã QR tự động dựa trên ID của CTHD
        public Image GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20); // 20 là độ phân giải
        }


    }
}
