using OGC.frmThuocTinh;
using OGC.NHANVIEN;
using OGC.LichChieu;
using OGC.Phim;
using OGC.QuanLyDichVu;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using OGC.QuanLyChung;
using OGC.ThongKe;
using OGC.DAO;

namespace OGC
{
    public partial class frmMain : Form
    {
        public string currentUser; // Biến lưu tài khoản nhân viên đăng nhập

        public frmMain(string username)
        {
            InitializeComponent();
            currentUser = username; // Lưu tài khoản nhân viên đang đăng nhập

            DAO_LogNhanVien.Instance.SetContext_Username(currentUser);

            DAO_TKNHANVIEN.Instance.SetTrangThaiDangDangNhap(currentUser);

            string tenChucVu = DAO_NHANVIEN.Instance.GetTenChucVuByUsername(currentUser);

            PhanQuyenTheoTenChucVu(tenChucVu); //gọi hàm phân quyền

            LoadlblUser(); //hiển thị tên tài khoản của nhân viên đăng nhập
        }



        #region Trung Nghia

        private Form currentFromChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            label1.Text = "Home";
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChonPhim());
            label1.Text = btnDatVe.Text;
        }
        private void btnQuanLyPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyPhim());
            label1.Text = btnQuanLyPhim.Text;
        }
        #endregion




        #region Hoang Nghia
        // Hàm lấy tài khoản nhân viên đang đăng nhập
        public string GetUsername()
        {
            return currentUser;
        }

        public void LoadlblUser()
        {
            lblUser.Text = "Xin chào " + currentUser;

            lblUser.Visible = true;
        }

        //mở các form con

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyDichVu(currentUser));
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyLichChieu());
        }

        private void btnQuanLyChung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyChung(currentUser));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        //-------phân quyền chức năng dựa trên chức vụ của nhân viên
        private void PhanQuyenTheoTenChucVu(string tenChucVu)
        {
            // Đặt tất cả button ẩn trước
            btnQuanLyChung.Visible = false;
            btnDatVe.Visible = false;
            btnDichVu.Visible = false;
            btnThongKe.Visible = false;
            btnQuanLyPhim.Visible = false;

            switch (tenChucVu)
            {
                case "Chủ rạp":
                case "Quản lý":
                    // Mở toàn bộ chức năng
                    btnQuanLyChung.Visible = true;
                    btnDatVe.Visible = true;
                    btnDichVu.Visible = true;
                    btnThongKe.Visible = true;
                    btnQuanLyPhim.Visible = true;
                    break;

                case "Nhân viên bán vé":
                    btnDatVe.Visible = true;
                    break;

                case "Nhân viên dịch vụ":
                    btnDichVu.Visible = true;
                    break;

                case "Kế toán":
                    btnThongKe.Visible = true;
                    break;

                default:
                    // Không rõ chức vụ => khóa toàn bộ
                    break;
            }
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            // Xóa username đang đăng nhập trong bảng tạm
            DAO_TKNHANVIEN.Instance.ResetTrangThaiDangNhap();
            DAO_TKNHANVIEN.Instance.XoaUsernameDangNhap();

            //Quay về form login
            this.Close();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAO_TKNHANVIEN.Instance.ResetTrangThaiDangNhap();
            DAO_TKNHANVIEN.Instance.XoaUsernameDangNhap();
        }



        #endregion



        // OpenChildForm(new fThuocTinh(currentUser));


    }
}