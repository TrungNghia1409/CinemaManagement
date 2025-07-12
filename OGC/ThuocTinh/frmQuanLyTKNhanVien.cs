using OGC.DAO;
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

namespace OGC.ThuocTinh
{
    public partial class frmQuanLyTKNhanVien : Form
    {
        public string currentUser;

        public frmQuanLyTKNhanVien(string username)
        {
            InitializeComponent();

            LoadTKNhanVien();

            currentUser = username;

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);
        }

        //Thay đổi viền panel
        private void pnlTKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTKNhanVien, 15);
        }
        private void pnlMKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlMKNhanVien, 15);
        }

        private void pnlThemTKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThemTKNhanVien, 30);
        }

        private void pnlXoaTKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoaTKNhanVien, 30);
        }

        private void pnlSuaTKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlSuaTKNhanVien, 30);
        }

        #region Methods

        public void LoadTKNhanVien()
        {
            try
            {
                DataTable dt = DAO_TKNHANVIEN.Instance.DanhSachTaiKhoan();

                // Kiểm tra dữ liệu
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu tài khoản");
                    return;
                }

                // Tắt các tính năng tự động
                dgvTKNhanVien.AutoGenerateColumns = false;
                dgvTKNhanVien.Columns.Clear();

                // Tạo cột với Name và DataPropertyName giống nhau
                dgvTKNhanVien.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Username",
                    DataPropertyName = "Username", // Phải khớp với tên cột trong DataTable
                    HeaderText = "Tài khoản",
                    Width = 150
                });

                dgvTKNhanVien.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Password",
                    DataPropertyName = "Password",
                    HeaderText = "Mật khẩu",
                    Width = 200
                });

                // Gán dữ liệu SAU KHI đã thêm cột
                dgvTKNhanVien.DataSource = dt;

                // Cấu hình hiển thị
                dgvTKNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTKNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTKNhanVien.ReadOnly = true;
                dgvTKNhanVien.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải tài khoản: {ex.Message}");
            }
        }

        #endregion




        #region Events

        private void btnThemTKNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string taikhoan = txbTKNhanVien.Text.Trim();
                string matkhau = txbMKNhanVien.Text.Trim();


                //Kiểm tra nếu tài khoản rỗng
                if ((taikhoan == "") || (matkhau == ""))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem tài khoản nhân viên đã tồn tại chưa
                else if (DAO_TKNHANVIEN.Instance.IsUsernameExists(taikhoan))
                {
                    MessageBox.Show($"Tên tài khoản '{taikhoan}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((DAO_NHANVIEN.Instance.ThemNhanVien(taikhoan, matkhau)))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách tài khoản
                    frmQuanLyTKNhanVien? f = Application.OpenForms["frmQuanLyTKNhanVien"] as frmQuanLyTKNhanVien;
                    f?.LoadTKNhanVien();
                }
                else
                {
                    MessageBox.Show($"Tên tài khoản '{taikhoan}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTKNhanVien_Click(object sender, EventArgs e)
        {
            // Lấy tài khoản hiện tại của user đăng nhập
            string taikhoanHienTai = currentUser;
            // Lấy dòng đầu tiên được chọn (không cần dòng thứ 2)
            DataGridViewRow selectedRow = dgvTKNhanVien.SelectedRows[0];
            string taikhoanCanXoa = selectedRow.Cells["Username"].Value?.ToString();

            // Kiểm tra có dòng nào được chọn không
            if (dgvTKNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra null
            else if (string.IsNullOrEmpty(taikhoanCanXoa))
            {
                MessageBox.Show("Không thể xác định tài khoản cần xóa.", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (taikhoanCanXoa == taikhoanHienTai)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản của chính mình đang đăng nhập!",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản '{taikhoanCanXoa}' không?",
                                                "Xác nhận",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool xoaThanhCong = DAO_TKNHANVIEN.Instance.XoaTKNhanVien(taikhoanCanXoa);

                    if (xoaThanhCong)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại danh sách tài khoản
                        LoadTKNhanVien(); // Gọi trực tiếp phương thức load lại
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa! Có thể tài khoản đang được sử dụng.",
                                      "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa tài khoản: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaTKNhanVien_Click(object sender, EventArgs e)
        {
            string taikhoan = txbTKNhanVien.Text.Trim();
            string matkhau = txbMKNhanVien.Text.Trim();

            // Lấy dòng đang chọn
            if (dgvTKNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang chọn
            DataGridViewRow selectedRow = dgvTKNhanVien.SelectedRows[0];
            string tenTaiKhoanCanSua = selectedRow.Cells["Username"].Value.ToString();

            try
            {
                if (string.IsNullOrWhiteSpace(taikhoan) || string.IsNullOrWhiteSpace(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (taikhoan == currentUser)
                {
                    MessageBox.Show($"Bạn đang đăng nhập bằng tài khoản '{taikhoan}'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (taikhoan == tenTaiKhoanCanSua)
                {
                    MessageBox.Show("Tên tài khoản cần cập nhật phải khác tên tài khoản cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DAO_TKNHANVIEN.Instance.IsUsernameExists(taikhoan))
                {
                    MessageBox.Show($"Tên tài khoản '{taikhoan}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tenTaiKhoanCanSua.StartsWith("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Không thể thay đổi mật khẩu của tài khoản quản trị (admin).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if ((DAO_TKNHANVIEN.Instance.SuaTKNhanVien(taikhoan, matkhau)))
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách chức vụ
                    frmQuanLyTKNhanVien? f = Application.OpenForms["frmQuanLyTKNhanVien"] as frmQuanLyTKNhanVien;
                    f?.LoadTKNhanVien();
                }
                else
                {
                    MessageBox.Show($"Tên tài khoản '{taikhoan}' không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
