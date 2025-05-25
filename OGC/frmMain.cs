using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using OGC.frmThuocTinh;

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
        private void btnThuocTinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThuocTinh(currentUser));
        }


        #endregion



    }
}