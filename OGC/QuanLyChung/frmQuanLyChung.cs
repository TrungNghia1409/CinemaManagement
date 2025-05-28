using OGC.frmThuocTinh;
using OGC.LichChieu;
using OGC.Phim;
using OGC.ThuocTinh;
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

namespace OGC.QuanLyChung
{
    public partial class frmQuanLyChung : Form
    {
        public string currentUser;
        public frmQuanLyChung(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        #region Thay đổi  viền panel
        private void pnlPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhim, 30);
        }

        private void pnlPhongChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhongChieu, 30);
        }

        private void pnlThuocTinh_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThuocTinh, 30);
        }

        private void pnlLichChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlLichChieu, 30);
        }
        #endregion


        #region Methods

        #endregion


        #region Events
        //-----Mở các form con
        private void btnPhim_Click(object sender, EventArgs e)
        {
            frmQuanLyPhim f = new frmQuanLyPhim();
            f.ShowDialog();
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {

        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            frmQuanLyLichChieu f = new frmQuanLyLichChieu();
            f.ShowDialog();
        }
        private void btnThuocTinh_Click(object sender, EventArgs e)
        {
            fThuocTinh f = new fThuocTinh(currentUser);
            f.ShowDialog();
        }





        #endregion








    }
}
