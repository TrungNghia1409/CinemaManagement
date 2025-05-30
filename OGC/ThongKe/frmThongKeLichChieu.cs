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
    public partial class frmThongKeLichChieu : Form
    {
        public frmThongKeLichChieu()
        {
            InitializeComponent();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeLichChieu_Load(object sender, EventArgs e)
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

        //----------- phương thức xử lý thống kê lịch chiếu
        private void XuLyThongKe()
        {
            string tenProc = "";

            // Xác định proc cần gọi dựa trên tiêu chí
            if (rdbLichChieu_SoLuongKhach.Checked)
                tenProc = "EXEC usp_ThongKeSoLuongKhach_MoiLichChieu";
            else if (rdbLichChieu_VangKhach.Checked)
                tenProc = "EXEC usp_ThongKeLichChieu_VangKhach";
            else if (rdbLichChieu_DongKhach.Checked)
                tenProc = "EXEC usp_ThongKeLichChieu_DongKhach";
            else if (rdbLichChieu_SoLuongPhim.Checked)
                tenProc = "EXEC usp_ThongKeSoLuongPhim_MoiLichChieu";
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

                    lblngayChon.Text = $" Tháng {thang}/{nam}";
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

                    lblngayChon.Text = $"Năm /{nam}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Gọi DAO static method
            DataTable dt = DAO_THONGKE.Instance.ThucThiProc_ThongKe_LichChieu(tenProc, ngay, thang, nam);
            dgvKetQuaThongKe_LichChieu.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                txbKetQua.Text = "0";
                return;
            }

            else if (rdbLichChieu_VangKhach.Checked)
            {
                int min = int.MaxValue;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongKhach"] != DBNull.Value)
                    {
                        int value = Convert.ToInt32(row["SoLuongKhach"]);
                        if (value < min)
                            min = value;
                    }
                }
                txbKetQua.Text = (min == int.MaxValue ? "0" : min.ToString()) + " khách";
            }
            else if (rdbLichChieu_DongKhach.Checked)
            {
                int max = int.MinValue;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongKhach"] != DBNull.Value)
                    {
                        int value = Convert.ToInt32(row["SoLuongKhach"]);
                        if (value > max)
                            max = value;
                    }
                }
                txbKetQua.Text = (max == int.MinValue ? "0" : max.ToString()) + " khách";
            }
            else if (rdbLichChieu_SoLuongKhach.Checked)
            {
                // Trường hợp tính trung bình số lượng khách mỗi lịch chiếu
                double tong = 0;
                int dem = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongKhach"] != DBNull.Value)
                    {
                        tong += Convert.ToDouble(row["SoLuongKhach"]);
                        dem++;
                    }
                }
                double trungBinh = dem > 0 ? tong / dem : 0;
                txbKetQua.Text = trungBinh.ToString("0.##") + " khách/lịch";
            }
            else if (rdbLichChieu_SoLuongPhim.Checked)
            {
                // Trường hợp tính trung bình số lượng phim mỗi lịch chiếu
                double tong = 0;
                int dem = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongPhim"] != DBNull.Value)
                    {
                        tong += Convert.ToDouble(row["SoLuongPhim"]);
                        dem++;
                    }
                }
                double trungBinh = dem > 0 ? tong / dem : 0;
                txbKetQua.Text = trungBinh.ToString("0.##") + " phim/lịch";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            XuLyThongKe();
        }
    }
}
