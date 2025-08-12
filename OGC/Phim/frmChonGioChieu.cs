using OGC.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OGC.Phim
{
    public partial class frmChonGioChieu : Form
    {
        private string tenPhim;
        private DateTime ngayChieu;
        private int idPhong;
        private string currentUser;
        private frmChonNgayChieu frmChonNgayChieu; // Biến lưu tham chiếu form cha

        // Thêm tham số parentForm vào constructor
        public frmChonGioChieu(string tenPhim, DateTime ngayChieu, int idPhong, string currentUser, frmChonNgayChieu parentForm = null)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu.Date;
            this.idPhong = idPhong;
            this.currentUser = currentUser;
            this.frmChonNgayChieu = parentForm; // Lưu tham chiếu form cha

            this.Load += FrmChonGioChieu_Load;
        }

        private void FrmChonGioChieu_Load(object sender, EventArgs e)
        {
            LoadGioChieu();
            LoadThongTinPhim();
        }

        private void LoadThongTinPhim()
        {
            lbTenPhim.Text = tenPhim;
            lbNgayChieu.Text = ngayChieu.ToString("dd/MM/yyyy");

            var dinhDang = DAO_DINHDANGPHIM.Instance.GetDinhDangPhimTheoTenPhim(tenPhim);
            lbDinhDang.Text = dinhDang != null ? dinhDang.TenDinhDang : "Không rõ";

            var doTuoi = DAO_DoTuoi.Instance.GetDoTuoiTheoTenPhim(tenPhim);
            lbDoTuoi.Text = doTuoi != null ? doTuoi.TenDoTuoi : "Không rõ";

            var theLoai = DAO_THELOAIPHIM.Instance.GetTheLoaiPhimTheoTenPhim(tenPhim);
            lbTheLoai.Text = theLoai != null ? theLoai.TenTheLoai : "Không rõ";

            var tenLoaiPhong = DAO_PHONGCHIEU.Instance.GetTenLoaiPhongByIDPhong(idPhong);
            lbTenPhong.Text = !string.IsNullOrEmpty(tenLoaiPhong) ? tenLoaiPhong : "Không rõ";

            var phim = PhimDAO.Instance.GetPhimTheoTen(tenPhim);
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

        private void LoadGioChieu()
        {
            flpGioChieu.Controls.Clear();

            DataTable dt = DAO_LICHCHIEU.Instance.GetGioChieuTheoPhimVaNgay(tenPhim, ngayChieu, idPhong);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có giờ chiếu cho phim này vào ngày đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayGio = Convert.ToDateTime(row["NgayGio"]);
                TimeSpan gio = ngayGio.TimeOfDay;

                Button btn = new Button();
                btn.Text = gio.ToString(@"hh\:mm");
                btn.Tag = gio;
                btn.Width = 80;
                btn.Height = 40;
                btn.BackColor = Color.LightGreen;

                btn.Click += BtnGioChieu_Click;

                flpGioChieu.Controls.Add(btn);
            }
        }

        private void BtnGioChieu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            TimeSpan gioChon = (TimeSpan)btn.Tag;

            // Truyền tham chiếu this vào FrmChonGhe
            FrmChonGhe chonGheForm = new FrmChonGhe(tenPhim, ngayChieu, gioChon, idPhong, currentUser, this);
            chonGheForm.Show();
            this.Hide(); // Ẩn frmChonGioChieu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (frmChonNgayChieu != null)
            {
                frmChonNgayChieu.Show(); // Hiển thị lại form frmChonNgayChieu
            }
            else
            {
                // Nếu không có tham chiếu, tạo instance mới với các tham số cần thiết
                frmChonNgayChieu frm = new frmChonNgayChieu(tenPhim, currentUser);
                frm.Show();
            }
            this.Close();
        }
    }
}
