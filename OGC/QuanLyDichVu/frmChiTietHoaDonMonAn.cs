using OGC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;
using QRCoder;
using System.Drawing;
using static OGC.DTO.DTO_CartItem;

namespace OGC.QuanLyDichVu
{
    public partial class frmChiTietHoaDonMonAn : Form
    {
        public int iDHoaDon;
        List<CartItem> gioHang;
        public decimal tongTien;
        public frmChiTietHoaDonMonAn(int iDHoaDon, List<CartItem> gioHang, decimal tongTien)
        {
            InitializeComponent();

            this.iDHoaDon = iDHoaDon;
            this.gioHang = gioHang;
            this.tongTien = tongTien;

            lblTongTien_KetQua.Text = tongTien.ToString("N0", CultureInfo.InvariantCulture);
            decimal tienKhachDua = string.IsNullOrEmpty(txbTienKhachDua.Text) ? 0 :
                       decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);
            decimal tienThoi = tienKhachDua - decimal.Parse(lblTongTien_KetQua.Text, CultureInfo.InvariantCulture);
            lblTienThoi_KetQua.Text = tienThoi.ToString();
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            ptbMaQR.Image = GenerateQRCode(iDHoaDon.ToString());

        }

        private void frmChiTietHoaDonMonAn_Load(object sender, EventArgs e)
        {


            foreach (var item in gioHang)
            {
                int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(item.TenMonAn); // bạn cần phương thức này
                decimal gia = DAO_MONAN.Instance.GetGiaMonAnByID(idMonAn);
                DAO_CTHD_MONAN.Instance.ThemChiTietHoaDonMonAn(iDHoaDon, idMonAn, item.SoLuong, gia);
            }

            dgvChiTiet.DataSource = DAO_CTHD_MONAN.Instance.LayDSByIDHoaDon(iDHoaDon);
        }

        //----hàm xuất file excel (giả lập xuất bill cho khách hàng
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

                worksheet.Cell(currentRow, 1).Value = "Tiền Khách Đưa:";
                worksheet.Cell(currentRow, 2).Value = txbTienKhachDua.Text;
                currentRow++;

                worksheet.Cell(currentRow, 1).Value = "Tiền Thối:";
                worksheet.Cell(currentRow, 2).Value = lblTienThoi_KetQua.Text;
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

                DAO_CTHD_MONAN.Instance.CapNhatTrangThai("Đã in", iDHoaDon);
                MessageBox.Show("Đã xuất hóa đơn ra Excel tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            decimal tienKhachDua = string.IsNullOrEmpty(txbTienKhachDua.Text) ? 0 :
                       decimal.Parse(txbTienKhachDua.Text, CultureInfo.InvariantCulture);
            decimal tienThoi = tienKhachDua - decimal.Parse(lblTongTien_KetQua.Text, CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(txbTienKhachDua.Text))
            {
                XuatExcelTuDataGridView(dgvChiTiet, "HoaDonMonAn_" + iDHoaDon);
            }
            else
            {
                MessageBox.Show("Tiền khách đưa rỗng" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTienKhachDua.Text = string.Empty;
                lblTienThoi_KetQua.Text = "-" + tongTien.ToString(); // Hoặc hiển thị số âm: tienThoi.ToString("N0")
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
        public Image GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20); // 20 là độ phân giải
        }
    }
}
