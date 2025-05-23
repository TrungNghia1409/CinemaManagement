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
using OGC.frmThuocTinh;
using OGC.ThuocTinh;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.frmThuocTinh
{
    public partial class fThuocTinh : Form
    {
        public string currentUser;

        public fThuocTinh(string username)
        {
            InitializeComponent();

            currentUser = username;
        }


        //Thay đổi viền panel
        private void pnlChucVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlChucVu, 30);
        }

        private void pnlTKNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTKNhanVien, 30);
        }

        private void pnlLoaiMonAn_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlLoaiMonAn, 30);
        }

        private void pnlLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlLoaiPhong, 30);
        }

        private void pnlTheLoaiPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTheLoaiPhim, 30);
        }

        private void pnlDinhDangPhim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDinhDangPhim, 30);
        }



        //sự kiện mở các form con
        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmThemChucVu f = new frmThemChucVu(currentUser);
            f.ShowDialog();
        }

        private void btnLoaiMonAn_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiMonAn f = new frmQuanLyLoaiMonAn();
            f.ShowDialog();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong f = new frmLoaiPhong();
            f.ShowDialog();
        }

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyTKNhanVien f = new frmQuanLyTKNhanVien(currentUser);
            f.ShowDialog();
        }
    }
}
