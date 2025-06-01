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

        public frmChonGioChieu(string tenPhim, DateTime ngayChieu)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu;

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
                if (TimeSpan.TryParse(row["GioChieu"].ToString(), out TimeSpan gio))
                {
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
        }


        private void BtnGioChieu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            TimeSpan gioChon = (TimeSpan)btn.Tag;

            // TODO: Xử lý logic khi người dùng chọn giờ chiếu
            // Ví dụ mở form chọn ghế hoặc lưu lại thông tin chọn giờ chiếu
            MessageBox.Show($"Bạn đã chọn giờ chiếu: {gioChon:hh\\:mm}", "Giờ chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form hoặc tiếp tục xử lý
            this.Close();
        }
    }
}
