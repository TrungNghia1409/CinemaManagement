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
            lbDoTuoi.Text = phim.DoTuoi ?? "Không Giới Hạn Độ Tuổi";
            lbThoiLuong.Text = $"{phim.ThoiLuong} phút";
            lbNgayKhoiChieu.Text = phim.NgayKhoiChieu.ToString("dd/MM/yyyy");
            lbMoTa.Text = phim.MoTa;
            lbTrangThai.Text = phim.TrangThai == 1 ? "Đang chiếu" : "Ngừng chiếu";

            // Nếu có link ảnh, bạn có thể load vào PictureBox
            //if (!string.IsNullOrEmpty(phim.Anh) && File.Exists(phim.Anh))
            //{
            //    picPoster.Image = Image.FromFile(phim.Anh);
            //}
        }
    }
}
