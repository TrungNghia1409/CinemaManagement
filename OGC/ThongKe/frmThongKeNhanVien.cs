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
    public partial class frmThongKeNhanVien : Form
    {
        public frmThongKeNhanVien()
        {
            InitializeComponent();

            rdbNgay.Enabled = false;
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeNhanVien_Load(object sender, EventArgs e)
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



        #region sự kiện load ngày tháng năm, và hiển thị danh sách nhân viên mới
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
            //if (rdbNgay.Checked)
            //    LoadNgay();
            if (rdbThang.Checked)
                LoadNhanVienMoiTheoThangNam();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (rdbNgay.Checked)
            //    LoadNgay();
            if (rdbThang.Checked)
                LoadNhanVienMoiTheoThangNam();
            else if (rdbNam.Checked)
                LoadNhanVienMoiTheoNam();
        }

        private void LoadNhanVienMoiTheoThangNam()
        {
            int nam, thang;
            if (int.TryParse(cbThang.Text, out thang) && int.TryParse(cbNam.Text, out nam))
            {
                DataTable dt = DAO_THONGKE.Instance.DanhSachNhanVienMoi(thang, nam);

                dgvKetQuaThongKe_NhanVien.DataSource = dt;

                lblngayChon.Text = $" Tháng {thang}/{nam}";

                txbSoLuongNhanVienMoi.Text = dt.Rows.Count.ToString() + " người";
            }
            else if (rdbThang.Enabled == false && (int.TryParse(cbNam.Text, out nam)))
            {
                DataTable dt = DAO_THONGKE.Instance.DanhSachNhanVienMoi(null, nam);

                dgvKetQuaThongKe_NhanVien.DataSource = dt;

                txbSoLuongNhanVienMoi.Text = dt.Rows.Count.ToString() + " người";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng tháng và năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void LoadNhanVienMoiTheoNam()
        {
            int nam;
            if (int.TryParse(cbNam.Text, out nam))
            {
                DataTable dt = DAO_THONGKE.Instance.DanhSachNhanVienMoi(null, nam);
                dgvKetQuaThongKe_NhanVien.DataSource = dt;
                lblngayChon.Text = $" Năm {nam}";
                txbSoLuongNhanVienMoi.Text = dt.Rows.Count.ToString() + " người";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


        #region các tiêu chí lọc
        private void rdbNhanVien_LapVe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNhanVien_LapVe.Checked)
            {
                dgvKetQuaThongKe_NhanVien.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_NhanVien.DataSource = DAO_THONGKE.Instance.SoLuongVeCuaTungNhanVien();
            }
        }

        private void rdbNhanVien_LapDichVu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNhanVien_LapDichVu.Checked)
            {
                dgvKetQuaThongKe_NhanVien.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_NhanVien.DataSource = DAO_THONGKE.Instance.SoLuongDichVuCuaTungNhanVien();
            }
        }

        private void rdbNhanVien_DoanhThuCaoNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNhanVien_DoanhThuCaoNhat.Checked)
            {
                dgvKetQuaThongKe_NhanVien.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_NhanVien.DataSource = DAO_THONGKE.Instance.NhanVienMangLaiDoanhThuCaoNhat();
            }
        }
        #endregion

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
            string tenFile = "ThongKeNhanVien";

            if (rdbNhanVien_DoanhThuCaoNhat.Checked)
            {
                tenFile = "ThongKeNhanVien_DemLaiDoanhThuCaoNhat";
            }
            else if (rdbNhanVien_LapVe.Checked)
            {
                tenFile = "ThongKeNhanVien_LapVeNhieuNhat";    
            }
            else if (rdbNhanVien_LapDichVu.Checked)
            {
                tenFile = "ThongKeNhanVien_LapDichVuNhieuNhat";
            }

            XuatExcelTuDataGridView(dgvKetQuaThongKe_NhanVien, tenFile);
        }
    }
}
