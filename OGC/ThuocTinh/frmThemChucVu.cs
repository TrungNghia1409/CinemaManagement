using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.frmThuocTinh
{
    public partial class frmThemChucVu : Form
    {
        public string currentUser;
        public frmThemChucVu(string username)
        {
            InitializeComponent();

            currentUser = username;

            LoadChucVu(); //Load danh sách chức vụ

        }

        //Thay đổi viền panel
        private void pnlThem_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThem, 30);
        }

        private void pnlXoa_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoa, 30);
        }

        private void pnlSua_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoa, 30);
        }
        private void pnlTenChucVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTenChucVu, 30);
        }


        #region Events

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenChucVu = txbTenChucVu.Text.Trim();

                //Kiểm tra nếu tài khoản rỗng
                if (tenChucVu == "")
                {
                    MessageBox.Show($" {currentUser} ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Bạn chưa nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem tài khoản nhân viên đã tồn tại chưa
                if (DAO_CHUCVU.Instance.IsTenChucVuExists(tenChucVu))
                {
                    MessageBox.Show($"Tên chức vụ '{tenChucVu}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (((tenChucVu == "Nhân viên bán vé") || (tenChucVu == "Nhân viên dịch vụ") || (tenChucVu == "Quản lý") || (tenChucVu == "Chủ rạp")) &&
                    (DAO_CHUCVU.Instance.ThemChucVu(tenChucVu)))
                {
                    MessageBox.Show("Thêm chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách chức vụ
                    frmThemChucVu? f = Application.OpenForms["frmThemChucVu"] as frmThemChucVu;
                    f?.LoadChucVu();
                }
                else
                {
                    MessageBox.Show($"Tên chức vụ '{tenChucVu}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvChucVu.SelectedRows[0];
            string tenChucVuCanXoa = selectedRow.Cells["TenChucVu"].Value.ToString();

            // Lấy chức vụ hiện tại của user đăng nhập
            string chucVuHienTai = DAO_CHUCVU.Instance.LayTenChucVuTheoUsername(currentUser);

            if (tenChucVuCanXoa == chucVuHienTai)
            {
                MessageBox.Show("Bạn không thể xóa chức vụ của chính mình đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa chức vụ '{tenChucVuCanXoa}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool xoaThanhCong = DAO_CHUCVU.Instance.XoaChucVu(tenChucVuCanXoa);
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load lại danh sách chức vụ
                    frmThemChucVu? f = Application.OpenForms["frmThemChucVu"] as frmThemChucVu;
                    f?.LoadChucVu();
                }
                else
                {
                    MessageBox.Show("Không thể xóa! Có thể chức vụ đang được sử dụng bởi nhân viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenChucVu = txbTenChucVu.Text.Trim();
            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvChucVu.SelectedRows[0];
            // Lấy ID cũ từ cột Mã chức vụ 
            int iD = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            try
            {
                if ((txbTenChucVu.Text == "") || (dgvChucVu.SelectedRows.Count == 0))
                {
                    MessageBox.Show("Vui lòng nhập tên chức vụ mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DAO_CHUCVU.Instance.IsTenChucVuExists(tenChucVu))
                {
                    MessageBox.Show($"Tên chức vụ '{tenChucVu}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (((tenChucVu == "Nhân viên bán vé") || (tenChucVu == "Nhân viên dịch vụ") || (tenChucVu == "Quản lý") || (tenChucVu == "Chủ rạp")) &&
                    (DAO_CHUCVU.Instance.SuaChucVu(iD, tenChucVu)))
                {
                    MessageBox.Show("Sửa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách chức vụ
                    frmThemChucVu? f = Application.OpenForms["frmThemChucVu"] as frmThemChucVu;
                    f?.LoadChucVu();
                }
                else
                {
                    MessageBox.Show($"Tên chức vụ '{tenChucVu}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion





        #region Methods

        public void LoadChucVu()
        {
            DataTable dt = DAO_CHUCVU.Instance.DanhSachChucVu();
            dgvChucVu.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvChucVu.Columns["ID"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";

            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvChucVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChucVu.ReadOnly = true;
            dgvChucVu.AllowUserToAddRows = false;
        }

        #endregion


        
    }
}
