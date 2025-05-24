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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();

            LoadLoaiPhong();
        }

        //Thay đổi viền panel
        private void pnlTenLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTenLoaiPhong, 15);
        }

        private void pnlThemLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThemLoaiPhong, 30);
        }

        private void pnlXoaLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoaLoaiPhong, 30);
        }

        private void pnlSuaLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlSuaLoaiPhong, 30);
        }

        #region Methods
        //Load danh sách các loại phòng
        public void LoadLoaiPhong()
        {
            DataTable dt = DAO_LOAIPHONG.Instance.DanhSachLoaiPhong();
            dgvLoaiPhong.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvLoaiPhong.Columns["ID"].HeaderText = "Mã loại phòng";
            dgvLoaiPhong.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";

            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.AllowUserToAddRows = false;
        }
        #endregion





        #region Events

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLoaiPhong = txbTenLoaiPhong.Text.Trim();

                //Kiểm tra nếu loại phòng rỗng
                if (tenLoaiPhong == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem loại phòng đã tồn tại chưa
                if (DAO_LOAIPHONG.Instance.IsTenLoaiPhongExists(tenLoaiPhong))
                {
                    MessageBox.Show($"Tên loại phòng '{tenLoaiPhong}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (((tenLoaiPhong == "Thường") || (tenLoaiPhong == "VIP") || (tenLoaiPhong == "Couple")) &&
                    (DAO_LOAIPHONG.Instance.ThemLoaiPhong(tenLoaiPhong)))
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách loại phòng
                    frmLoaiPhong? f = Application.OpenForms["frmLoaiPhong"] as frmLoaiPhong;
                    f?.LoadLoaiPhong();
                }
                else
                {
                    MessageBox.Show($"Tên loại phòng '{tenLoaiPhong}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiPhong.SelectedRows[0];
            string tenLoaiPhongCanXoa = selectedRow.Cells["TenLoaiPhong"].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa loại phòng '{tenLoaiPhongCanXoa}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool xoaThanhCong = DAO_LOAIPHONG.Instance.XoaLoaiPhong(tenLoaiPhongCanXoa);
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load lại danh sách loại phòng
                    frmLoaiPhong? f = Application.OpenForms["frmLoaiPhong"] as frmLoaiPhong;
                    f?.LoadLoaiPhong();
                }
                else
                {
                    MessageBox.Show("Không thể xóa! Có thể loại phòng đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            string tenLoaiPhong = txbTenLoaiPhong.Text.Trim();

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiPhong.SelectedRows[0];
            string tenLoaiPhongCanSua = selectedRow.Cells["TenLoaiPhong"].Value.ToString();

            // Lấy ID cũ từ cột Mã loại phòng 
            int iD = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            try
            {
                if ((tenLoaiPhong == "") || (dgvLoaiPhong.SelectedRows.Count == 0))
                {
                    MessageBox.Show("Vui lòng nhập tên loại phòng mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tenLoaiPhong == tenLoaiPhongCanSua)
                {
                    MessageBox.Show("Loại phòng cần cập nhật phải khác loại phòng cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DAO_LOAIPHONG.Instance.IsTenLoaiPhongExists(tenLoaiPhong))
                {
                    MessageBox.Show($"Tên loại phòng '{tenLoaiPhong}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (((tenLoaiPhong == "Nhân viên bán vé") || (tenLoaiPhong == "Nhân viên dịch vụ") || (tenLoaiPhong == "Quản lý") || (tenLoaiPhong == "Chủ rạp")) &&
                    (DAO_LOAIPHONG.Instance.SuaLoaiPhong(iD, tenLoaiPhong)))
                {
                    MessageBox.Show("Sửa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách loại phòng
                    frmThemChucVu? f = Application.OpenForms["frmThemChucVu"] as frmThemChucVu;
                    f?.LoadChucVu();
                }
                else
                {
                    MessageBox.Show($"Tên loại phòng '{tenLoaiPhong}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
