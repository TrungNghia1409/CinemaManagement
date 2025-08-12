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
        private int idPhong;
        private string currentUser;
       

        // Thêm tham số parentForm vào constructor
        public frmChonNgayChieu(string tenPhim, string currentUser, frmChonPhim parentForm = null)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.currentUser = currentUser;
           
            this.Load += frmChonNgayChieu_Load;
        }

        private void frmChonNgayChieu_Load(object sender, EventArgs e)
        {
            phim = PhimDAO.Instance.GetPhimTheoTen(tenPhim);
            LoadThongTinPhim();
            LoadNgayChieu();
            LoadAnhPhim();
        }

        private void LoadThongTinPhim()
        {
            lbTenPhim.Text = tenPhim;

            idPhong = DAO_PHONGCHIEU.Instance.GetIDPhongTheoTenPhim(tenPhim) ?? 0;

            var dinhDang = DAO_DINHDANGPHIM.Instance.GetDinhDangPhimTheoTenPhim(tenPhim);
            lbDinhDang.Text = dinhDang != null ? dinhDang.TenDinhDang : "Không rõ";

            var doTuoi = DAO_DoTuoi.Instance.GetDoTuoiTheoTenPhim(tenPhim);
            lbDoTuoi.Text = doTuoi != null ? doTuoi.TenDoTuoi : "Không rõ";

            var theLoai = DAO_THELOAIPHIM.Instance.GetTheLoaiPhimTheoTenPhim(tenPhim);
            lbTheLoai.Text = theLoai != null ? theLoai.TenTheLoai : "Không rõ";

            if (idPhong != 0)
            {
                var tenLoaiPhong = DAO_PHONGCHIEU.Instance.GetTenLoaiPhongByIDPhong(idPhong);
                lbTenPhong.Text = !string.IsNullOrEmpty(tenLoaiPhong) ? tenLoaiPhong : "Không rõ";
            }
            else
            {
                lbTenPhong.Text = "Chưa chọn phòng";
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

            List<DTO_NGAYCHIEUPHONG> ngayChieus = DAO_LICHCHIEU.Instance.GetNgayChieuTheoPhim(tenPhim);

            if (ngayChieus == null || ngayChieus.Count == 0)
            {
                MessageBox.Show("Không có lịch chiếu cho phim này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            foreach (var item in ngayChieus)
            {
                Button btn = new Button();
                btn.Text = item.NgayChieu.ToString("dd/MM/yyyy") + " - " + item.TenPhong;
                btn.Tag = item;
                btn.Width = 160;
                btn.Height = 40;
                btn.BackColor = Color.LightSkyBlue;

                btn.Click += BtnGioChieu_Click;

                flpNgayChieu.Controls.Add(btn);
            }
        }

        private void BtnGioChieu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            DTO_NGAYCHIEUPHONG item = btn.Tag as DTO_NGAYCHIEUPHONG;
            if (item == null) return;

            frmChonGioChieu frm = new frmChonGioChieu(tenPhim, item.NgayChieu, item.IDPhong, currentUser, this);
            frm.Show();
            this.Hide(); // Ẩn frmChonNgayChieu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form frmChonNgayChieu
        }
    }
}
