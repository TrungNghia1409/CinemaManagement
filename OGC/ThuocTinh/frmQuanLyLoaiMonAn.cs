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
    public partial class frmQuanLyLoaiMonAn : Form
    {
        public frmQuanLyLoaiMonAn()
        {
            InitializeComponent();

            LoadLoaiMonAn();

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);
        }

        //Thay đổi viền panel
        private void pnlTenLoaiMonAn_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTenLoaiMonAn, 15);
        }

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
            UIHelper.RoundPanelCorners(pnlSua, 30);
        }

        #region Events

        private void btnThem_loaimonan_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLoaiMonAn = txbTenLoaiMonAn.Text.Trim();

                //Kiểm tra nếu tài khoản rỗng
                if (tenLoaiMonAn == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên loại món ăn cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem tài khoản nhân viên đã tồn tại chưa
                if (DAO_LOAIMONAN.Instance.IsTenLoaiMonAnExists(tenLoaiMonAn))
                {
                    MessageBox.Show($"Tên loại '{tenLoaiMonAn}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (((tenLoaiMonAn == "Nước uống") || (tenLoaiMonAn == "Thức ăn") || (tenLoaiMonAn == "Khác")) &&
                    (DAO_LOAIMONAN.Instance.ThemLoaiMonAn(tenLoaiMonAn)))
                {
                    MessageBox.Show("Thêm tên loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách tên loại món ăn
                    frmQuanLyLoaiMonAn? f = Application.OpenForms["frmQuanLyLoaiMonAn"] as frmQuanLyLoaiMonAn;
                    f?.LoadLoaiMonAn();
                }
                else
                {
                    MessageBox.Show($"Tên loại '{tenLoaiMonAn}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_LoaiMonAn_Click(object sender, EventArgs e)
        {
            if (dgvLoaiMonAn.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiMonAn.SelectedRows[0];
            string tenLoaiMonAnCanXoa = selectedRow.Cells["TenLoai"].Value.ToString();   

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa '{tenLoaiMonAnCanXoa}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool xoaThanhCong = DAO_LOAIMONAN.Instance.XoaLoaiMonAn(tenLoaiMonAnCanXoa);
                    if (xoaThanhCong)
                    {
                        MessageBox.Show($"Xóa '{tenLoaiMonAnCanXoa}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Load lại danh sách tên loại món ăn
                        frmQuanLyLoaiMonAn? f = Application.OpenForms["frmQuanLyLoaiMonAn"] as frmQuanLyLoaiMonAn;
                        f?.LoadLoaiMonAn();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa! Có thể tên loại đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_LoaiMonAn_Click(object sender, EventArgs e)
        {
            string tenLoaiMonAn = txbTenLoaiMonAn.Text.Trim();

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvLoaiMonAn.SelectedRows[0];
            string tenLoaiMonAnCanSua = selectedRow.Cells["TenLoai"].Value.ToString();

            // Lấy ID cũ từ cột Mã chức vụ 
            int iD = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            try
            {
                if ((tenLoaiMonAn == "") || (dgvLoaiMonAn.SelectedRows.Count == 0))
                {
                    MessageBox.Show("Vui lòng nhập tên tên loại món ăn mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tenLoaiMonAn == tenLoaiMonAnCanSua)
                {
                    MessageBox.Show("Loại món ăn cần cập nhật phải khác Loại món ăn cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DAO_LOAIMONAN.Instance.IsTenLoaiMonAnExists(tenLoaiMonAn))
                {
                    MessageBox.Show($"Tên tên loại món ăn '{tenLoaiMonAn}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (((tenLoaiMonAn == "Nước uống") || (tenLoaiMonAn == "Thức ăn") || (tenLoaiMonAn == "Khác")) &&
                    (DAO_LOAIMONAN.Instance.SuaLoaiMonAn(iD, tenLoaiMonAn)))
                {
                    MessageBox.Show("Sửa tên loại món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách tên loại món ăn
                    frmQuanLyLoaiMonAn? f = Application.OpenForms["frmQuanLyLoaiMonAn"] as frmQuanLyLoaiMonAn;
                    f?.LoadLoaiMonAn();
                }
                else
                {
                    MessageBox.Show($"Tên tên loại món ăn '{tenLoaiMonAn}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods


        //Danh sach load loai mon an
        public void LoadLoaiMonAn()
        {
            DataTable dt = DAO_LOAIMONAN.Instance.DanhSachLoaiMonAn();
            dgvLoaiMonAn.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvLoaiMonAn.Columns["ID"].HeaderText = "Mã loại";
            dgvLoaiMonAn.Columns["TenLoai"].HeaderText = "Tên loại";

            dgvLoaiMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvLoaiMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiMonAn.ReadOnly = true;
            dgvLoaiMonAn.AllowUserToAddRows = false;
        }
        #endregion


    }
}
