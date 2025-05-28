using OGC.frmThuocTinh;
using OGC.NHANVIEN;
using OGC.LichChieu;
using OGC.Phim;
using OGC.QuanLyDichVu;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using OGC.QuanLyChung;
using OGC.ThongKe;

namespace OGC
{
    public partial class frmMain : Form
    {
        public string currentUser; // Biến lưu tài khoản nhân viên đăng nhập

        public frmMain(string username)
        {
            InitializeComponent();
            currentUser = username; // Lưu tài khoản nhân viên đang đăng nhập

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
            OpenChildForm(new frmQuanLyDichVu());
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


        #endregion



        // OpenChildForm(new fThuocTinh(currentUser));


    }
}