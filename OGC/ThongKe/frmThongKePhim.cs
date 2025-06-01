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
    public partial class frmThongKePhim : Form
    {
        public frmThongKePhim()
        {
            InitializeComponent();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKePhim_Load(object sender, EventArgs e)
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

        #region Doanh thu theo ngày, tháng, năm

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
            if (rdbPhim_ThongKe.Checked)
                tenProc = "EXEC usp_ThongKePhim";
            else if (rdbPhim_DoanhThu_Cao.Checked)
                tenProc = "EXEC usp_PhimDoanhThuCaoNhat";
            else if (rdbPhim_DoanhThu_Thap.Checked)
                tenProc = "EXEC PhimDoanhThuThapNhat";
            else if (rdbPhim_DatVe_NhieuNhat.Checked)
                tenProc = "EXEC usp_PhimDuocDatVeNhieuNhat";
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
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Gọi DAO static method
            DataTable dt = DAO_THONGKE.Instance.ThucThiProc_ThongKe_Phim(tenProc, ngay, thang, nam);
            dgvKetQuaThongKe_Phim.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                txbKetQua.Text = "0";
                return;
            }

            else if (rdbPhim_ThongKe.Checked)
            {
                txbKetQua.Text = dt.Rows.Count.ToString() + " phim";
            }

            // 2. Doanh thu cao nhất
            else if (rdbPhim_DoanhThu_Cao.Checked)
            {
                decimal maxDoanhThu = decimal.MinValue;
                string tenPhimMax = "Không xác định";

                foreach (DataRow row in dt.Rows)
                {
                    if (row["DoanhThu"] != DBNull.Value)
                    {
                        decimal value = Convert.ToDecimal(row["DoanhThu"]);
                        if (value > maxDoanhThu)
                        {
                            maxDoanhThu = value;
                            tenPhimMax = row["TenPhim"].ToString();
                        }
                    }
                }

                if (maxDoanhThu == decimal.MinValue)
                    txbKetQua.Text = "0 VNĐ";
                else
                    txbKetQua.Text = $"Phim: {tenPhimMax} - {maxDoanhThu:#,##0} VNĐ";
            }

            // 3. Doanh thu thấp nhất
            else if (rdbPhim_DoanhThu_Thap.Checked)
            {
                decimal minDoanhThu = decimal.MaxValue;
                string tenPhimMin = "Không xác định";

                foreach (DataRow row in dt.Rows)
                {
                    if (row["DoanhThu"] != DBNull.Value)
                    {
                        decimal value = Convert.ToDecimal(row["DoanhThu"]);
                        if (value < minDoanhThu)
                        {
                            minDoanhThu = value;
                            tenPhimMin = row["TenPhim"].ToString();
                        }
                    }
                }

                if (minDoanhThu == decimal.MaxValue)
                    txbKetQua.Text = "0 VNĐ";
                else
                    txbKetQua.Text = $"Phim: {tenPhimMin} - {minDoanhThu:#,##0} VNĐ";
            }

            // 4. Tên phim được đặt vé nhiều nhất (dựa trên số lượng vé)
            else if (rdbPhim_DatVe_NhieuNhat.Checked)
            {
                int maxSoLuong = int.MinValue;
                string tenPhimMax = "Không xác định";

                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoVe"] != DBNull.Value)
                    {
                        int sl = Convert.ToInt32(row["SoVe"]);
                        if (sl > maxSoLuong)
                        {
                            maxSoLuong = sl;
                            tenPhimMax = row["TenPhim"].ToString();
                        }
                    }
                }

                if (maxSoLuong == int.MinValue)
                    txbKetQua.Text = "0 vé";
                else
                    txbKetQua.Text = $"Phim: {tenPhimMax} - {maxSoLuong} vé";
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
            string tenFile = "ThongKePhim";

            if (rdbPhim_ThongKe.Checked)
            {
                tenFile = "ThongKePhim_";
            }
            else if (rdbPhim_DatVe_NhieuNhat.Checked)
            {
                tenFile = "ThongKePhim_DuocDatVeNhieuNhat";
            }
            else if (rdbPhim_DoanhThu_Cao.Checked)
            {
                tenFile = "ThongKePhim_DoanhThuCaoNhat";
            }
            else if (rdbPhim_DoanhThu_Thap.Checked)
            {
                tenFile = "ThongKePhim_DoanhThuThapNhat";
            }

            XuatExcelTuDataGridView(dgvKetQuaThongKe_Phim, tenFile);
        }
    }
}
