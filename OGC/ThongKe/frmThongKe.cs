using LiveCharts.Definitions.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OGC.ThongKe
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();

           
        }
        

        #region Thay đổi viền panel
        private void pnlForm_DoanhThu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_DoanhThu, 30);
        }

        private void pnlForm_Ve_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_Ve, 30);
        }

        private void pnlForm_KhachHang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_KhachHang, 30);
        }

        private void pnlForm_Phim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_Phim, 30);
        }

        private void pnlForm_NhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_NhanVien, 30);
        }

        private void pnlForm_PhongChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_PhongChieu, 30);
        }

        private void pnlForm_LichChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_LichChieu, 30);
        }

        private void pnlForm_DichVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_DichVu, 30);
        }

        private void pnlDoanhThu_Ngay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDoanhThu_Ngay, 25);
        }

        private void pnlDoanhThu_Thang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDoanhThu_Thang, 25);
        }

        private void pnlVe_Ngay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlVe_Ngay, 25);
        }

        private void pnlNhanVienDichVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlNhanVienDichVu, 25);
        }

        private void pnlNhanVienBanVe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlNhanVienBanVe, 25);
        }

        private void pnlVe_Thang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlVe_Thang, 25);
        }

        private void pnlPhimChieuNhieuNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimChieuNhieuNhat, 25);
        }

        private void pnlPhimChieuItNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimChieuItNhat, 25);
        }

        private void pnlPhimDoanhThuCaoNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimDoanhThuCaoNhat, 25);
        }

        #endregion

        #region sự kiện gọi form
        private void btnForm_DoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.ShowDialog();
        }
        private void btnForm_Ve_Click(object sender, EventArgs e)
        {
            frmThongKeVe f = new frmThongKeVe();
            f.ShowDialog();
        }
        private void btnForm_KhachHang_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang f = new frmThongKeKhachHang();
            f.ShowDialog();
        }
        private void btnForm_Phim_Click(object sender, EventArgs e)
        {
            frmThongKePhim f = new frmThongKePhim();
            f.ShowDialog();
        }
        private void btnForm_NhanVien_Click(object sender, EventArgs e)
        {
            frmThongKeNhanVien f = new frmThongKeNhanVien();
            f.ShowDialog();
        }

        private void btnForm_PhongChieu_Click(object sender, EventArgs e)
        {
            frmThongKePhongChieu f = new frmThongKePhongChieu();
            f.ShowDialog();
        }

        private void btnForm_LichChieu_Click(object sender, EventArgs e)
        {
            frmThongKeLichChieu f = new frmThongKeLichChieu();
            f.ShowDialog();
        }

        private void btnForm_DichVu_Click(object sender, EventArgs e)
        {
            frmThongKeDichVu f = new frmThongKeDichVu();
            f.ShowDialog();
        }
        #endregion

      

    }
}
