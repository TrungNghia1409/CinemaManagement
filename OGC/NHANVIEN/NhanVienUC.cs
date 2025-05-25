using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OGC.NHANVIEN
{
    public partial class NhanVienUC : UserControl
    {
        public NhanVienUC()
        {
            InitializeComponent();
        }

        public string ID
        {
            get => lblID.Text;
            set => lblID.Text = value;
        }

        public string Username
        {
            get => lblTaiKhoan.Text;
            set => lblTaiKhoan.Text = value;
        }

        public string HoTen
        {
            get => lblHoTen.Text;
            set => lblHoTen.Text = value;
        }

        public string ChucVu
        {
            get => lblChucVu.Text;
            set => lblChucVu.Text = value;
        }
        public string NgaySinh
        {
            get => lblNgaySinh.Text;
            set => lblNgaySinh.Text = value;
        }

        public string GioiTinh
        {
            get => lblGioiTinh.Text;
            set => lblGioiTinh.Text = value;
        }

        public string SDT
        {
            get => lblSDT.Text;
            set => lblSDT.Text = value;
        }

        public string Email
        {
            get => lblEmail.Text;
            set => lblEmail.Text = value;
        }

        public string DiaChi
        {
            get => lblDiaChi.Text;
            set => lblDiaChi.Text = value;
        }

        //private int borderRadius = 20; // Bo tròn góc 20px

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = SmoothingMode.AntiAlias;

        //    // Vẽ khung bo tròn
        //    Rectangle bounds = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        //    GraphicsPath path = GetRoundedRectPath(bounds, borderRadius);

        //    // Đổ bóng đổ (nếu muốn)
        //    DrawDropShadow(g, path);

        //    // Vẽ border bo tròn
        //    using (Pen pen = new Pen(Color.LightGray, 1))
        //    {
        //        g.DrawPath(pen, path);
        //    }
        //}

        //private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    int diameter = radius * 2;

        //    path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        //    path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        //    path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        //    path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        //    path.CloseFigure();

        //    return path;
        //}

        //private void DrawDropShadow(Graphics g, GraphicsPath path)
        //{
        //    using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // Đổ bóng đen nhạt
        //    {
        //        Matrix original = g.Transform;
        //        g.TranslateTransform(3, 3); // Dịch xuống phải tạo hiệu ứng đổ bóng
        //        g.FillPath(shadowBrush, path);
        //        g.Transform = original;
        //    }
        //}

        private void pnlNhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlNhanVien, 15);
        }

    }
}
