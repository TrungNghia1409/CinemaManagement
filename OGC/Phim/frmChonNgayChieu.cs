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

            // Lấy idPhong dựa trên tenPhim
            idPhong = DAO_PHONGCHIEU.Instance.GetIDPhongTheoTenPhim(tenPhim) ?? 0;

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


            // Lấy độ tuổi phim
            var doTuoi = DAO_DoTuoi.Instance.GetDoTuoiTheoTenPhim(tenPhim);
            lbDoTuoi.Text = doTuoi != null ? doTuoi.TenDoTuoi : "Không rõ";


            // Lấy thông tin thể loại phim
            var theLoai = DAO_THELOAIPHIM.Instance.GetTheLoaiPhimTheoTenPhim(tenPhim);
            lbTheLoai.Text = theLoai != null ? theLoai.TenTheLoai : "Không rõ";


            // Lấy thông tin phòng chiếu
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
                btn.Tag = item; // Gán DTO luôn
                btn.Width = 160;
                btn.Height = 40;
                btn.BackColor = Color.LightSkyBlue;

                // Đăng ký sự kiện click cho nút ngày chiếu
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

            // Mở form chọn giờ chiếu truyền theo tên phim, ngày chiếu và phòng chiếu
            frmChonGioChieu frm = new frmChonGioChieu(tenPhim, item.NgayChieu, item.IDPhong);
            this.Close();
            frm.ShowDialog();
            this.Show();
        }
    }
}
