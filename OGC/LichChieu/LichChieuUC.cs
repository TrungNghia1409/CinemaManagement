using OGC.DTO;
using OGC.NHANVIEN;
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

namespace OGC.LichChieu
{
    public partial class LichChieuUC : UserControl
    {
        public DTO_LICHCHIEU LichChieuData { get; set; } // Thuộc tính lưu thông tin lịch chiếu
        public LichChieuUC(DTO_LICHCHIEU lc)
        {
            InitializeComponent();
            this.LichChieuData = lc ?? new DTO_LICHCHIEU();

            //gán gia trị hiển thị
            this.TenPhim = lc.TenPhim;
            this.TenPhong = lc.TenPhong;
            this.NgayGio = this.NgayGio = lc.NgayGio != null ? lc.NgayGio.ToString("dd/MM/yyyy hh:mm") : "N/A";
            this.GiaVe = lc.GiaVe;
            this.TrangThai = lc.TrangThai;
            
            

            RegisterClickEvents(this);
        }

        public void RegisterClickEvents(Control parent)
        {
            parent.Click += tlpLichChieuUC_Click;
            foreach (Control ctrl in parent.Controls)
            {
                RegisterClickEvents(ctrl); // đệ quy để bắt mọi control con
            }
        }
        public string Anh {  get; set; }
        public string AnhPhong { get; set; }

        public string TenPhim
        {
            get => lblTenPhim.Text;
            set => lblTenPhim.Text = value;
        }

        public string TenPhong
        {
            get => lblTenPhong.Text;
            set => lblTenPhong.Text = value;
        }

        public string NgayGio
        {
            get => lblNgayGio.Text;
            set => lblNgayGio.Text = value;
        }

        public decimal GiaVe
        {
            get => decimal.Parse(lblGiaVe.Text);
            set => lblGiaVe.Text = value.ToString();
        }
        public string DiaDiem
        {
            get => lblDiaDiem.Text;
            set => lblDiaDiem.Text = value;
        }

        public string TrangThai
        {
            get => lblTrangThai.Text;
            set => lblTrangThai.Text = value;
        }


        private void pnlLichChieuUC_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlLichChieuUC, 15);
        }

        private void tlpLichChieuUC_Click(object sender, EventArgs e)
        {
            try
            {
                if (LichChieuData != null)
                {
                    frmThongTinLichChieu frm = new frmThongTinLichChieu(LichChieuData);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhân viên chưa được gán.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xem lịch chiếu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
