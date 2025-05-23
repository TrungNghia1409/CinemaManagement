namespace OGC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


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
            OpenChildForm(new ChonPhim());
            label1.Text = btnDatVe.Text;
        }


    }
}