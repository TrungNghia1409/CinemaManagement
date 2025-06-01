using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OGC.Phim
{
    public partial class frmChonNgayChieu : Form
    {
        private string tenPhim;
        private PhimDTO phim;

        public frmChonNgayChieu(string tenPhim)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;

            // Đăng ký sự kiện Load form
            this.Load += frmChonNgayChieu_Load;
        }

        private void frmChonNgayChieu_Load(object sender, EventArgs e)
        {
            LoadThongTinPhim();
            LoadNgayChieu();
            LoadAnhPhim();
        }

        private void LoadThongTinPhim()
        {
            lbTenPhim.Text = tenPhim;

            // Gọi stored procedure lấy định dạng phim theo tên phim
            var dinhDang = DAO_DINHDANGPHIM.Instance.GetDinhDangPhimTheoTenPhim(tenPhim);

            if (dinhDang != null)
            {
                lbDinhDang.Text = dinhDang.TenDinhDang;
            }
            else
            {
                lbDinhDang.Text = "Không rõ";
            }
        }

        private void LoadAnhPhim()
        {
            if (phim != null && !string.IsNullOrEmpty(phim.Anh))
            {
                string fullPath = System.IO.Path.Combine(Application.StartupPath, phim.Anh);
                if (System.IO.File.Exists(fullPath))
                {
                    ptbAnhPhim.Image = Image.FromFile(fullPath);
                    ptbAnhPhim.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    ptbAnhPhim.Image = null; 
                }
            }
            else
            {
                ptbAnhPhim.Image = null;
            }
        }

        private void LoadNgayChieu()
        {
            flpNgayChieu.Controls.Clear();

            List<DateTime> ngayChieus = DAO_LICHCHIEU.Instance.GetNgayChieuTheoPhim(tenPhim);

            if (ngayChieus == null || ngayChieus.Count == 0)
            {
                MessageBox.Show("Không có lịch chiếu cho phim này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DateTime ngay in ngayChieus)
            {
                Button btn = new Button();
                btn.Text = ngay.ToString("dd/MM/yyyy");
                btn.Tag = ngay;
                btn.Width = 100;
                btn.Height = 40;
                btn.BackColor = Color.LightSkyBlue;

                //Đăng ký sự kiện click cho nút ngày chiếu
                btn.Click += BtnGioChieu_Click;

                flpNgayChieu.Controls.Add(btn);
            }
        }

        private void BtnGioChieu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            DateTime ngayChon = (DateTime)btn.Tag;

            // Mở form chọn giờ chiếu truyền theo tên phim và ngày chọn
            frmChonGioChieu frm = new frmChonGioChieu(tenPhim, ngayChon);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
