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

namespace OGC.KHO
{
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();

            int currentYear = DateTime.Now.Year;

            for (int year = 2020; year <= currentYear; year++)
            {
                cbNamCapNhat.Items.Add(year);
            }

            // Load tháng từ 1 đến 12
            for (int month = 1; month <= 12; month++)
            {
                cbThangCapNhat.Items.Add(month);
            }

            LoadKho();
        }
        #region đổ dữ liệu ngày tháng vào combobox

        private void LoadNgay()
        {
            if (cbThangCapNhat.SelectedItem != null && cbNamCapNhat.SelectedItem != null)
            {
                int month = Convert.ToInt32(cbThangCapNhat.SelectedItem);
                int year = Convert.ToInt32(cbNamCapNhat.SelectedItem);

                int daysInMonth = DateTime.DaysInMonth(year, month);
                cbNgayCapNhat.Items.Clear();
                for (int day = 1; day <= daysInMonth; day++)
                {
                    cbNgayCapNhat.Items.Add(day);
                }
            }
        }

        private void cbThangCapNhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
        }

        private void cbNamCapNhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
        }

        #endregion


        public void LoadKho()
        {
            DataTable dt = DAO_KHO.Instance.LoadKho();
            dgvKho.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvKho.Columns["ID"].HeaderText = "Mã kho";
            dgvKho.Columns["IDMonAn"].HeaderText = "Mã món ăn";
            dgvKho.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dgvKho.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";

            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.ReadOnly = true;
            dgvKho.AllowUserToAddRows = false;
        }

        #region Events
        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];

                txbIDKho.Text = row.Cells["ID"].Value.ToString();
                txbIDMonAn.Text = row.Cells["IDMonAn"].Value.ToString();
                txbTenMonAn.Text = row.Cells["TenMonAn"].Value.ToString();
                txbSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();
                lblTrangThai.Text = "Đã chọn";

                // Lấy NgayCapNhat từ DataGridView
                DateTime ngayCapNhat = Convert.ToDateTime(row.Cells["NgayCapNhat"].Value);

                // Gán từng phần vào ComboBox
                cbNgayCapNhat.SelectedItem = ngayCapNhat.Day.ToString();
                cbThangCapNhat.SelectedItem = ngayCapNhat.Month.ToString();
                cbNamCapNhat.SelectedItem = ngayCapNhat.Year.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMonAn = txbTenMonAn.Text.Trim();

            if (string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn.");
                return;
            }

            // Lấy IDMonAn từ bảng MONAN
            int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(tenMonAn);

            if (idMonAn == -1)
            {
                // Không tồn tại trong MONAN
                MessageBox.Show("Tên món ăn không tồn tại trong hệ thống (MONAN). \n Không thể thêm vào kho.");
                return;
            }

            // Gán IDMonAn vào textbox
            txbIDMonAn.Text = idMonAn.ToString();

            // Kiểm tra xem món ăn đã có trong kho chưa
            if (DAO_KHO.Instance.KiemTraMonAnTrongKho(idMonAn))
            {
                lblTrangThai.Text = "Đã tồn tại trong kho";
                MessageBox.Show("Món ăn đã tồn tại trong kho. Không thể thêm lại.");
                return;
            }

            // Gán trạng thái là chưa tồn tại trong kho
            lblTrangThai.Text = "Chưa có trong kho";

            // Lấy IDKho tiếp theo
            int newIDKho = DAO_KHO.Instance.LayMaxIDKho() + 1;
            txbIDKho.Text = newIDKho.ToString();

            // Lấy ngày cập nhật từ 3 ComboBox
            if (cbNgayCapNhat.SelectedItem == null || cbThangCapNhat.SelectedItem == null || cbNamCapNhat.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ngày cập nhật.");
                return;
            }

            int ngay = int.Parse(cbNgayCapNhat.SelectedItem.ToString());
            int thang = int.Parse(cbThangCapNhat.SelectedItem.ToString());
            int nam = int.Parse(cbNamCapNhat.SelectedItem.ToString());
            DateTime ngayCapNhat = new DateTime(nam, thang, ngay);

            // Thêm vào kho (số lượng mặc định là 0)
            bool result = DAO_KHO.Instance.ThemKho(idMonAn,tenMonAn, 0, ngayCapNhat);

            if (result)
            {
                MessageBox.Show("Thêm món vào kho thành công.");
                LoadKho(); // Load lại danh sách
            }
            else
            {
                MessageBox.Show("Thêm món vào kho thất bại.");
            }
        }


        //-------Sửa thông tin món
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenMonAn = txbTenMonAn.Text.Trim();

            if (string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần sửa.");
                return;
            }

            // Kiểm tra số lượng thêm
            if (!int.TryParse(txbSoLuongThem.Text, out int soLuongThem))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ để thêm vào kho.");
                return;
            }

            int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(tenMonAn);
            if (idMonAn == -1)
            {
                MessageBox.Show("Món ăn không tồn tại.");
                return;
            }

            // Gọi DAO để sửa kho
            bool result = DAO_KHO.Instance.SuaKho(tenMonAn, soLuongThem);

            if (result)
            {
                MessageBox.Show("Cập nhật kho thành công.");
                LoadKho(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Cập nhật kho thất bại. Vui lòng kiểm tra lại tên món ăn.");
            }
        }

        //---- xóa món khỏi KHO
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenMonAn = txbTenMonAn.Text.Trim();

            if (string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa món '{tenMonAn}' khỏi kho?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool isDeleted = DAO_KHO.Instance.XoaKho(tenMonAn);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa kho thành công.");
                    LoadKho(); // Reload lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa kho thất bại. Kiểm tra lại tên món ăn.");
                }
            }
        }
        #endregion





        private void btnReset_Click(object sender, EventArgs e)
        {
            txbIDKho.Text = string.Empty;
            txbIDMonAn.Text = string.Empty;
            txbTenMonAn.Text = string.Empty;
            txbSoLuong.Text = string.Empty;
        }
    }
}
