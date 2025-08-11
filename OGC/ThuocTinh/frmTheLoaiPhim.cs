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
    public partial class frmTheLoaiPhim : Form
    {
        public frmTheLoaiPhim()
        {
            InitializeComponent();

            LoadLoaiPhim();

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);
        }

        //Thay đổi viền panel
        private void pnlTenLoaiPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTenLoaiPhim, 30);
        }

        private void pnlThemLoaiPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThemLoaiPhim, 30);
        }

        private void pnlXoaLoaiPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoaLoaiPhim, 30);
        }

        private void pnlSuaLoaiPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlSuaLoaiPhim, 30);
        }


        #region Methods

        //Load danh sách thể loại phim
        public void LoadLoaiPhim()
        {
            DataTable dt = DAO_THELOAIPHIM.Instance.DanhSachTheLoaiPhim();
            dgvLoaiPhim.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvLoaiPhim.Columns["ID"].HeaderText = "Mã loại phim";
            dgvLoaiPhim.Columns["TenTheLoai"].HeaderText = "Tên loại phim";

            dgvLoaiPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvLoaiPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhim.ReadOnly = true;
            dgvLoaiPhim.AllowUserToAddRows = false;
        }

        #endregion




        #region Events
        private void btnThemLoaiPhim_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLoaiPhim = txbTenLoaiPhim.Text.Trim();

                //Kiểm tra nếu tài khoản rỗng
                if (tenLoaiPhim == "")
                {
                    MessageBox.Show("Bạn chưa nhập loại phim", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Kiểm tra loại phim đó đã tồn tại chưa
                else if (DAO_THELOAIPHIM.Instance.IsTheLoaiPhimExists(tenLoaiPhim))
                {
                    MessageBox.Show($"Loại phim '{tenLoaiPhim}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (((tenLoaiPhim == "Kinh dị") || (tenLoaiPhim == "Hài hước") || (tenLoaiPhim == "Tình cảm") || (tenLoaiPhim == "Khoa học viễn tưởng")) &&
                    (DAO_THELOAIPHIM.Instance.ThemTheLoaiPhim(tenLoaiPhim)))
                {
                    MessageBox.Show("Thêm loại phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách Loại phim
                    frmTheLoaiPhim? f = Application.OpenForms["frmTheLoaiPhim"] as frmTheLoaiPhim;
                    f?.LoadLoaiPhim();
                }
                else
                {
                    MessageBox.Show($"Tên loại phim '{tenLoaiPhim}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoaiPhim_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại phim để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiPhim.SelectedRows[0];
            string tenLoaiPhimCanXoa = selectedRow.Cells["TenTheLoai"].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa loại phim '{tenLoaiPhimCanXoa}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool xoaThanhCong = DAO_THELOAIPHIM.Instance.XoaTheLoaiPhim(tenLoaiPhimCanXoa);
                    if (xoaThanhCong)
                    {
                        MessageBox.Show("Xóa loại phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Load lại danh sách loại phim
                        frmTheLoaiPhim? f = Application.OpenForms["frmTheLoaiPhim"] as frmTheLoaiPhim;
                        f?.LoadLoaiPhim();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa! Có thể loại phim đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaLoaiPhim_Click(object sender, EventArgs e)
        {
            string tenLoaiPhim = txbTenLoaiPhim.Text.Trim();

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiPhim.SelectedRows[0];
            string tenTheLoaiCanSua = selectedRow.Cells["TenTheLoai"].Value.ToString();

            try
            {
                if ((tenLoaiPhim == "") || (dgvLoaiPhim.SelectedRows.Count == 0))
                {
                    MessageBox.Show("Vui lòng nhập thể loại phim mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tenLoaiPhim == tenTheLoaiCanSua)
                {
                    MessageBox.Show("Thể loại phim cần cập nhật phải khác thể loại phim cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DAO_THELOAIPHIM.Instance.IsTheLoaiPhimExists(tenLoaiPhim))
                {
                    MessageBox.Show($"Thể loại phim '{tenLoaiPhim}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (((tenLoaiPhim == "Kinh dị") || (tenLoaiPhim == "Hài hước") || (tenLoaiPhim == "Tình cảm") || (tenLoaiPhim == "Khoa học viễn tưởng")) &&
                    (DAO_THELOAIPHIM.Instance.SuaTheLoaiPhim(tenLoaiPhim)))
                {
                    MessageBox.Show("Sửa loại phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách chức vụ
                    frmTheLoaiPhim? f = Application.OpenForms["frmTheLoaiPhim"] as frmTheLoaiPhim;
                    f?.LoadLoaiPhim();
                }
                else
                {
                    MessageBox.Show($"Tên loại phim '{tenLoaiPhim}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
