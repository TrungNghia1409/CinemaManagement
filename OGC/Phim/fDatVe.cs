using OGC.DAO;
using OGC.DTO;
using OGC.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.Phim
{
    public partial class fDatVe : Form
    {
        private List<DTO_LICHCHIEU> lichChieuList;
        public DTO_LICHCHIEU SelectedLichChieu { get; private set; }

        public fDatVe(string tenPhim, DateTime ngayChieu, string theLoai, string dinhDang)
        {
            InitializeComponent();
            lbTenPhim.Text = tenPhim;
            lbNgayChieu.Text = ngayChieu.ToString("dd/MM/yyyy");
            lbDinhDang.Text = dinhDang;
            LoadGioChieu(tenPhim, ngayChieu, dinhDang);
        }


        public void LoadGioChieu(string tenPhim, DateTime ngayChieu, string dinhDang)
        {
            lichChieuList = DAO_LICHCHIEU.Instance.GetLichChieuTheoPhimNgayDinhDang(tenPhim, ngayChieu, dinhDang);

            flpGioChieu.Controls.Clear();

            foreach (var lc in lichChieuList)
            {
                Button btn = new Button();
                btn.Text = lc.NgayGio.ToString("HH:mm");
                btn.Tag = lc;
                btn.Width = 70;
                btn.Height = 30;
                btn.Click += BtnGio_Click;

                flpGioChieu.Controls.Add(btn);
            }
        }


        private void BtnGio_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                SelectedLichChieu = btn.Tag as DTO_LICHCHIEU;
                if (SelectedLichChieu != null)
                {
                    // Ví dụ: bạn có thể mở form đặt ghế hoặc lưu thông tin giờ chiếu
                    MessageBox.Show($"Bạn chọn giờ chiếu: {SelectedLichChieu.NgayGio:hh\\:mm} tại phòng {SelectedLichChieu.TenPhong}");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
