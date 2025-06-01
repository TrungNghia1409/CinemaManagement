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
using static OGC.DTO.DTO_CartItem;

namespace OGC.QuanLyDichVu
{
    public partial class frmChiTietHoaDonMonAn : Form
    {
        public int iDHoaDon;
        List<CartItem> gioHang;
        public frmChiTietHoaDonMonAn(int iDHoaDon, List<CartItem> gioHang)
        {
            InitializeComponent();

            this.iDHoaDon = iDHoaDon;
            this.gioHang = gioHang;
        }

        private void frmChiTietHoaDonMonAn_Load(object sender, EventArgs e)
        {


            foreach (var item in gioHang)
            {
                int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(item.TenMonAn); // bạn cần phương thức này
                DAO_CTHD_MONAN.Instance.ThemChiTietHoaDonMonAn(iDHoaDon, idMonAn, item.SoLuong, item.DonGia);
            }

            dgvChiTiet.DataSource = DAO_CTHD_MONAN.Instance.LayDSByIDHoaDon(iDHoaDon);
        }

        //----hàm xuất file excel (giả lập xuất bill cho khách hàng
        private void XuatExcelTuDataGridView(DataGridView dgv, string tenFile)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ChiTietHoaDon");

                // Ghi tiêu đề cột
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                    worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                // Ghi dữ liệu từng dòng
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        object cellValue = dgv.Rows[row].Cells[col].Value;
                        worksheet.Cell(row + 2, col + 1).Value = cellValue?.ToString();
                    }
                }

                // Tự động điều chỉnh độ rộng
                worksheet.Columns().AdjustToContents();

                // Lưu file ra Desktop
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tenFile + ".xlsx");
                workbook.SaveAs(filePath);

                MessageBox.Show("Đã xuất hóa đơn ra Excel tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            XuatExcelTuDataGridView(dgvChiTiet, "HoaDonMonAn_" + iDHoaDon);
        }
    }
}
