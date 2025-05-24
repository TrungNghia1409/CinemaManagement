using OGC.DAO;
using OGC.frmThuocTinh;
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

namespace OGC.ThuocTinh
{
    public partial class frmDinhDangPhim : Form
    {
        public frmDinhDangPhim()
        {
            InitializeComponent();

            LoadDinhDangPhim();
        }


        //Thay đổi viền panel
        private void pnlDinhDangPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDinhDangPhim, 15);
        }

        private void pnlThemDinhDangPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThemDinhDangPhim, 30);
        }

        private void pnlXoaDinhDangPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoaDinhDangPhim, 30);
        }

        private void pnlSuaDinhDangPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlSuaDinhDangPhim, 30);
        }


        #region Methods

        public void LoadDinhDangPhim()
        {
            DataTable dt = DAO_DINHDANGPHIM.Instance.DanhSachDinhDang();
            dgvDinhDangPhim.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvDinhDangPhim.Columns["ID"].HeaderText = "Mã định dạng";
            dgvDinhDangPhim.Columns["TenDinhDang"].HeaderText = "Tên định dạng";

            dgvDinhDangPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvDinhDangPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDinhDangPhim.ReadOnly = true;
            dgvDinhDangPhim.AllowUserToAddRows = false;
        }

        #endregion


        #region Events

        private void btnThemDinhDangPhim_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDinhDang = txbDinhDangPhim.Text.Trim();

                //Kiểm tra nếu định dạng rỗng
                if (tenDinhDang == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem định dạng đã tồn tại chưa
                if (DAO_DINHDANGPHIM.Instance.IsTenDinhDangExists(tenDinhDang))
                {
                    MessageBox.Show($"Tên định dạng '{tenDinhDang}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (((tenDinhDang == "2D") || (tenDinhDang == "3D") || (tenDinhDang == "IMAX") || (tenDinhDang == "4DX")) &&
                    (DAO_DINHDANGPHIM.Instance.ThemDinhDang(tenDinhDang)))
                {
                    MessageBox.Show("Thêm định dạng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách định dạng
                    frmDinhDangPhim? f = Application.OpenForms["frmDinhDangPhim"] as frmDinhDangPhim;
                    f?.LoadDinhDangPhim();
                }
                else
                {
                    MessageBox.Show($"Tên định dạng '{tenDinhDang}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDinhDangPhim_Click(object sender, EventArgs e)
        {
            if (dgvDinhDangPhim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một định dạng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvDinhDangPhim.SelectedRows[0];
            string tenDinhDangCanXoa = selectedRow.Cells["TenDinhDang"].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa định dạng '{tenDinhDangCanXoa}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool xoaThanhCong = DAO_DINHDANGPHIM.Instance.XoaDinhDang(tenDinhDangCanXoa);
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa định dạng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load lại danh sách định dạng
                    frmDinhDangPhim? f = Application.OpenForms["frmDinhDangPhim"] as frmDinhDangPhim;
                    f?.LoadDinhDangPhim();
                }
                else
                {
                    MessageBox.Show("Không thể xóa! Có thể định dạng đang được sử dụng bởi nhân viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaDinhDangPhim_Click(object sender, EventArgs e)
        {
            string tenDinhDang = txbDinhDangPhim.Text.Trim();
            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvDinhDangPhim.SelectedRows[0];
            string tenDinhDangCanSua = selectedRow.Cells["TenDinhDang"].Value.ToString();

            // Lấy ID cũ từ cột Mã định dạng 
            int iD = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            try
            {   
                if ((tenDinhDang == "") || (dgvDinhDangPhim.SelectedRows.Count == 0))
                {
                    MessageBox.Show("Vui lòng nhập tên định dạng mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(tenDinhDang == tenDinhDangCanSua)
                {
                    MessageBox.Show("Tên định dạng cần cập nhật phải khác tên định dạng cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DAO_DINHDANGPHIM.Instance.IsTenDinhDangExists(tenDinhDang))
                {
                    MessageBox.Show($"Tên định dạng '{tenDinhDang}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (((tenDinhDang == "2D") || (tenDinhDang == "3D") || (tenDinhDang == "IMAX") || (tenDinhDang == "4DX")) &&
                    (DAO_DINHDANGPHIM.Instance.SuaDINHDANG(iD, tenDinhDang)))
                {
                    MessageBox.Show("Sửa định dạng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách định dạng
                    frmDinhDangPhim? f = Application.OpenForms["frmDinhDangPhim"] as frmDinhDangPhim;
                    f?.LoadDinhDangPhim();
                }
                else
                {
                    MessageBox.Show($"Tên định dạng '{tenDinhDang}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
