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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //// Tạo biểu đồ mới
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill; // Cho biểu đồ chiếm toàn bộ panel

            //// Khu vực vẽ biểu đồ
            //ChartArea area = new ChartArea("MainArea");
            //chart.ChartAreas.Add(area);

            //// Series dữ liệu
            //Series series = new Series("Doanh thu");
            //series.ChartType = SeriesChartType.Column;

            //// Dữ liệu giả lập doanh thu 7 ngày
            //series.Points.AddXY("T2", 1000000);
            //series.Points.AddXY("T3", 1500000);
            //series.Points.AddXY("T4", 1800000);
            //series.Points.AddXY("T5", 1700000);
            //series.Points.AddXY("T6", 1300000);
            //series.Points.AddXY("T7", 1600000);
            //series.Points.AddXY("CN", 1900000);

            //chart.Series.Add(series);

            //// Thêm biểu đồ vào panelPhai
            //pnlPhai.Controls.Clear();        // Xóa control cũ nếu có
            //pnlPhai.Controls.Add(chart);     // Thêm biểu đồ vào panel
        }
    }
}
