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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();

        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
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

        #region Load combobox theo ngày, tháng, năm

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


        #region xử lý thốg kê

        private void XuLyThongKe()
        {
            string tenProc = "";
            DataTable dt = new DataTable();
            // Xác định các giá trị thời gian dựa theo lựa chọn
            int? ngay = null, thang = null, nam = null;

            // Xác định proc cần gọi dựa trên tiêu chí
            if (rdbKhachHang_Tong.Checked)
            {
                dt = DAO_THONGKE.Instance.KhachHangTheoTungKhuVuc();
            }
            else if (rdbKhachHang_DiemThuong.Checked)
            {
                dt = DAO_THONGKE.Instance.DanhSachKhachHangCoDiemThuongCaoNhat();

            }
            else if (rdbKhachHang_ChuaTungDatVe.Checked)
            {
                dt = DAO_THONGKE.Instance.DanhSachKhachHangChuaTungDatVe();
            }
            else if(rdbKhachHang_DatVe.Checked)
            {
                tenProc = "EXEC usp_DanhSachKhachHangDatVeNhieuNhat ";
                dt = DAO_THONGKE.Instance.ThucThiProc_ThongKe_KhachHang(tenProc, ngay, thang, nam);
            }

            dgvKetQuaThongKe_KhachHang.DataSource = dt;

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

            if (dt.Rows.Count == 0)
            {
                txbKetQua.Text = "0";
                return;
            }

            else if (rdbKhachHang_Tong.Checked)
            {
                // Khu vực có nhiều khách nhất
                string khuVuc = "";
                int max = int.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuongKhach"] != DBNull.Value)
                    {
                        int value = Convert.ToInt32(row["SoLuongKhach"]);
                        if (value > max)
                        {
                            max = value;
                            khuVuc = row["DiaChi"].ToString(); // hoặc ["KhuVuc"] nếu tên cột là vậy
                        }
                    }
                }

                txbKetQua.Text = $"{khuVuc} - {max} khách";
            }

            else if (rdbKhachHang_DiemThuong.Checked)
            {
                // Điểm thưởng cao nhất
                int max = int.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["DiemThuong"] != DBNull.Value)
                    {
                        int value = Convert.ToInt32(row["DiemThuong"]);
                        if (value > max)
                            max = value;
                    }
                }

                txbKetQua.Text = max == int.MinValue ? "0 điểm" : max + " điểm";
            }

            else if (rdbKhachHang_DatVe.Checked)
            {
                // Tên người đặt vé nhiều nhất
                string ten = "";
                int max = int.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["SoLuotDatVe"] != DBNull.Value)
                    {
                        int value = Convert.ToInt32(row["SoLuotDatVe"]);
                        if (value > max)
                        {
                            max = value;
                            ten = row["HoTen"].ToString(); // hoặc "TenKhachHang" tuỳ cấu trúc bảng
                        }
                    }
                }

                txbKetQua.Text = ten + $" ({max} vé)";
            }

            else if (rdbKhachHang_ChuaTungDatVe.Checked)
            {
                txbKetQua.Text = dt.Rows.Count + " khách chưa từng đặt vé";
            }
        }



        #endregion






        private void btnThongKe_Click(object sender, EventArgs e)
        {
            XuLyThongKe();
        }
    }
}
