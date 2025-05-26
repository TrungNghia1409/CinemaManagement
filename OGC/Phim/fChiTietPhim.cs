using System;
using System.Windows.Forms;
using OGC.DTO;

namespace OGC.Phim
{
    public partial class fChiTietPhim : Form
    {
        private PhimDTO phim;

        public fChiTietPhim(PhimDTO phim)
        {
            InitializeComponent();
            this.phim = phim;
            LoadChiTietPhim();
        }

        private void LoadChiTietPhim()
        {
            lbTenPhim.Text = phim.TenPhim;
            lbDaoDien.Text = phim.DaoDien;
            lbDienVien.Text = phim.DienVien;
            lbDoTuoi.Text = phim.IDDoTuoi ?? "Không Giới Hạn Độ Tuổi";
            lbThoiLuong.Text = $"{phim.ThoiLuong} phút";
            lbNgayKhoiChieu.Text = phim.NgayKhoiChieu.ToString("dd/MM/yyyy");
            lbMoTa.Text = phim.MoTa;
            lbTrangThai.Text = phim.TrangThai == 1 ? "Đang chiếu" : "Ngừng chiếu";

            // Hiển thị hình ảnh
            if (!string.IsNullOrEmpty(phim.Anh))
            {
                string fullPath = Path.Combine(Application.StartupPath, phim.Anh);
                if (System.IO.File.Exists(fullPath))
                {
                    AnhPhim.Image = Image.FromFile(fullPath);
                    AnhPhim.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    AnhPhim.Image = null; // hoặc ảnh mặc định
                }
            }
        }
    }
}
