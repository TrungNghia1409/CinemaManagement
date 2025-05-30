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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();

        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
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

            cbTheoThangNam_Thang.Enabled = false;
            cbTheoThangNam_Nam.Enabled = false;

            cbTheoNam.Enabled = false;

            LoadNgay(); // Cập nhật số ngày dựa vào tháng và năm hiện tại nếu có sẵn
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Enabled = false;
            cbThang.Enabled = false;
            cbNgay.Enabled = false;

            cbTheoThangNam_Thang.Enabled = true;
            cbTheoThangNam_Nam.Enabled = true;

            cbTheoNam.Enabled = false;

            LoadComboBoxThang();
            LoadComboBoxNam();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Enabled = false;
            cbThang.Enabled = false;
            cbNgay.Enabled = false;

            cbTheoThangNam_Thang.Enabled = false;
            cbTheoThangNam_Nam.Enabled = false;

            cbTheoNam.Enabled = true;

            LoadComboBoxNam();
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
        private void LoadComboBoxThang()
        {
            cbTheoThangNam_Thang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbTheoThangNam_Thang.Items.Add(i);
            }
            cbTheoThangNam_Thang.SelectedIndex = 0;
        }

        private void LoadComboBoxNam()
        {
            cbTheoThangNam_Nam.Items.Clear();
            cbTheoNam.Items.Clear();

            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 10; i <= currentYear + 1; i++)
            {
                cbTheoThangNam_Nam.Items.Add(i);
                cbTheoNam.Items.Add(i);
            }

            cbTheoThangNam_Nam.SelectedIndex = 10; // năm hiện tại
            cbTheoNam.SelectedIndex = 10;
        }

        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbNgay.Checked)
            {
                LoadNgay();

                CapNhatDoanhThu();
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbNgay.Checked)
            {
                LoadNgay();

                CapNhatDoanhThu();
            }
        }

        private void cbTheoThangNam_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
        }

        private void cbTheoThangNam_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
        }

        private void cbTheoNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
        }


        private void CapNhatDoanhThu()
        {
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
                    txbNgay.Text = "Dữ liệu không hợp lệ";
                    return;
                }

                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(ngay, thang, nam);
                txbNgay.Text = doanhThu.ToString("N0") + " VNĐ";
                lblNgay.Text = $"Ngày {ngay}/{thang}/{nam}";
                lblNgay.Visible = true;
            }
            else if (rdbThang.Checked)
            {
                if (int.TryParse(cbTheoThangNam_Thang.Text, out int m) &&
                    int.TryParse(cbTheoThangNam_Nam.Text, out int y))
                {
                    thang = m;
                    nam = y;
                }
                else
                {
                    txbThang.Text = "Dữ liệu không hợp lệ";
                    return;
                }

                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(null, thang, nam);
                txbThang.Text = doanhThu.ToString("N0") + " VNĐ";
                lblThang.Text = $"Tháng {thang}/{nam}";
                lblThang.Visible = true;
            }
            else if (rdbNam.Checked)
            {
                if (int.TryParse(cbTheoNam.Text, out int y))
                {
                    nam = y;
                }
                else
                {
                    txbNam.Text = "Dữ liệu không hợp lệ";
                    return;
                }

                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(null, null, nam);
                txbNam.Text = doanhThu.ToString("N0") + " VNĐ";
                lblNam.Text = $"Năm {nam}";
                lblNam.Visible = true;
            }
        }

        #endregion

        private void rdbDoanhThu_NhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThu_NhanVien.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungNhanVien();
            }
        }

        private void rdbDoanhThu_Phim_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbDoanhThu_Phim.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungPhim();
            }
        }

        private void rdbDoanhThu_SuatChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThu_SuatChieu.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungSuatChieu();
            }
        }

 
    }
}
