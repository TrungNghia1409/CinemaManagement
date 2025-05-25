using OGC.NHANVIEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.ThuocTinh
{
    public partial class frmLuaChon : Form
    {
        public string currentUser;
        public frmLuaChon(string username)
        {
            InitializeComponent();

            currentUser = username;
        }

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyTKNhanVien f = new frmQuanLyTKNhanVien(currentUser);
            f.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien(currentUser);
            f.ShowDialog();
        }
    }
}
