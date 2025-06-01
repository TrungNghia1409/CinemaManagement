using ClosedXML.Excel;
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

namespace OGC.ThongKe
{
    public partial class frmThongKeDichVu : Form
    {
        public frmThongKeDichVu()
        {
            InitializeComponent();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeDichVu_Load(object sender, EventArgs e)
        {
            // Load năm từ 2020 đến năm hiện tại
            int currentYear = DateTime.Now.Year;
            for (int year = 2020; year <= currentYear; year++)
            {
                cbNam.Items.Add(year);
            }

            // Load tháng từ 1 đến 12
            for (int month = 1; month <= 12; month++)
            {
                cbThang.Items.Add(month);
            }

            // Mặc định disable hết các ComboBox
            cbNgay.Enabled = false;
            cbThang.Enabled = false;
            cbNam.Enabled = false;
        }


        #region sự kiện load ngày tháng năm

        private void rdbNgay_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Enabled = true;
            cbThang.Enabled = true;
            cbNgay.Enabled = true;

            LoadNgay(); // Cập nhật số ngày dựa vào tháng và năm hiện tại nếu có sẵn
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Enabled = true;
            cbThang.Enabled = true;
            cbNgay.Enabled = false;
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Enabled = true;
            cbThang.Enabled = false;
            cbNgay.Enabled = false;
        }

        private void LoadNgay()
        {
            if (cbThang.SelectedItem != null && cbNam.SelectedItem != null)
            {
                int month = Convert.ToInt32(cbThang.SelectedItem);
                int year = Convert.ToInt32(cbNam.SelectedItem);

                int daysInMonth = DateTime.DaysInMonth(year, month);
                cbNgay.Items.Clear();
                for (int day = 1; day <= daysInMonth; day++)
                {
                    cbNgay.Items.Add(day);
                }
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rdbNgay.Checked)
                LoadNgay();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbNgay.Checked)
                LoadNgay();
        }

        #endregion


        #region xử lý thống kê
        private void XuLyThongKe()
        {
            string tenProc = "";

            // Xác định proc cần gọi dựa trên tiêu chí
            if (rdbDichVu_SoLuongBan.Checked)
                tenProc = "EXEC usp_ThongKeSoLuongDichVu";
            else if (rdbDoanhThu_DichVu.Checked)
                tenProc = "EXEC usp_ThongKeDoanhThuDichVu";
            else if (rdbDoanhThu_DichVu_Loai.Checked)
                tenProc = "EXEC usp_ThongKeDoanhThuTheoLoai";
            else
                return;

            // Xác định các giá trị thời gian dựa theo lựa chọn
            int? ngay = null, thang = null, nam = null;

            if (rdbNgay.Checked)
            {
                if (int.TryParse(cbNgay.Text, out int d) &&
                    int.TryParse(cbThang.Text, out int m) &&
                    int.TryParse(cbNam.Text, out int y))
                {
                    ngay = d;
                    thang = m;
                    nam = y;

                    lblngayChon.Text = $" Ngày {ngay}/{thang}/{nam}";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày/tháng/năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rdbThang.Checked)
            {
                if (int.TryParse(cbThang.Text, out int m) &&
                    int.TryParse(cbNam.Text, out int y))
                {
                    thang = m;
                    nam = y;

                    lblngayChon.Text = $"Tháng {thang}/{nam}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng tháng và năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rdbNam.Checked)
            {
                if (int.TryParse(cbNam.Text, out int y))
                {
                    nam = y;

                    lblngayChon.Text = $"Năm {nam}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Gọi DAO static method
            DataTable dt = DAO_THONGKE.Instance.ThucThiProc_ThongKe_DichVu(tenProc, ngay, thang, nam);
            dgvKetQuaThongKe_DichVu.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                txbKetQua.Text = "0";
                return;
            }
            double tong = 0;

            if (rdbDichVu_SoLuongBan.Checked)
            {
                // Trường hợp tính tổng số lượng món đã bán
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongDaBan"] != DBNull.Value)
                    {
                        tong += Convert.ToDouble(row["SoLuongDaBan"]);
                    }
                }
                txbKetQua.Text = tong.ToString("0.##") + " món";
            }
            else if (rdbDoanhThu_DichVu.Checked || rdbDoanhThu_DichVu_Loai.Checked)
            {
                // Trường hợp tính tổng doanh thu dịch vụ hoặc doanh thu theo loại
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DoanhThu"] != DBNull.Value)
                    {
                        tong += Convert.ToDouble(row["DoanhThu"]);
                    }
                }

                // Hiển thị doanh thu với dấu phân cách hàng nghìn (format: 1,000,000 VNĐ)
                txbKetQua.Text = tong.ToString("#,##0") + " VNĐ";
            }

        }
        #endregion



        private void btnThongKe_Click(object sender, EventArgs e)
        {
            XuLyThongKe();
        }


        private void XuatExcelTuDataGridView(DataGridView dgv, string tenFile)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ThongKe");

                // Ghi tiêu đề cột
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                    worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                // Ghi dữ liệu
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        var value = dgv.Rows[row].Cells[col].Value;
                        worksheet.Cell(row + 2, col + 1).Value = value?.ToString();
                    }
                }

                worksheet.Columns().AdjustToContents();

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tenFile + ".xlsx");
                workbook.SaveAs(path);

                MessageBox.Show($"Xuất thành công tại:\n{path}", "Xuất Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string tenFile = "ThongKeDichVu";

            if (rdbDichVu_SoLuongBan.Checked)
            {
                tenFile = "ThongKeDichVu_SoLuongBan";
            }
            else if (rdbDoanhThu_DichVu.Checked)
            {
                tenFile = "ThongKeDichVu_DoanhThu";
            }
            else if (rdbDoanhThu_DichVu_Loai.Checked)
            {
                tenFile = "ThongKeDichVu_DoanhThuTheoLoai";
            }

            XuatExcelTuDataGridView(dgvKetQuaThongKe_DichVu, tenFile);
        }
    }
}
