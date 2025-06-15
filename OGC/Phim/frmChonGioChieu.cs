using OGC.DAO;
using System;
using System.Collections.Generic;
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


        public frmChonGioChieu(string tenPhim, DateTime ngayChieu)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu.Date;

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
        private void LoadGioChieu()
        {
            flpGioChieu.Controls.Clear();

            // Lấy DataTable trực tiếp từ DAO
            DataTable dt = DAO_LICHCHIEU.Instance.GetGioChieuTheoPhimVaNgay(tenPhim, ngayChieu);

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
                btn.Tag = ngayGio; // giữ cả ngày và giờ để dùng sau
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

            DateTime ngayGio = (DateTime)btn.Tag;      // btn.Tag là DateTime
            TimeSpan gioChon = ngayGio.TimeOfDay;      // Lấy phần giờ

            string tenPhim = this.tenPhim;
            DateTime ngayChieu = this.ngayChieu;

            FrmChonGhe chonGheForm = new FrmChonGhe(tenPhim, ngayChieu, gioChon);
            chonGheForm.Show();
            this.Close();
        }
    }
}
