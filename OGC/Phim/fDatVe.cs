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
            LoadGioChieuLenFlowLayout(tenPhim, ngayChieu);
        }


        private void LoadGioChieuLenFlowLayout(string tenPhim, DateTime ngayChieu)
        {
            flpGioChieu.Controls.Clear();

            DataTable dt = DAO_LICHCHIEU.Instance.GetGioChieuTheoPhimVaNgay(tenPhim, ngayChieu);

            foreach (DataRow row in dt.Rows)
            {
                string gio = row["GioChieu"].ToString().Substring(0, 5); // Lấy định dạng HH:mm

                Button btnGio = new Button();
                btnGio.Text = gio;
                btnGio.Width = 80;
                btnGio.Height = 40;
                btnGio.BackColor = Color.LightSteelBlue;
                btnGio.Margin = new Padding(5);
                btnGio.Tag = row["ID"]; // Lưu lại ID lịch chiếu nếu cần

                btnGio.Click += BtnGio_Click;

                flpGioChieu.Controls.Add(btnGio);
            }
        }

       
        private void BtnGio_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string gioChieu = btn.Text;
            int idLichChieu = (int)btn.Tag;

            MessageBox.Show("Bạn đã chọn suất chiếu lúc: " + gioChieu);
            // Gọi tiếp chức năng hiển thị ghế ở đây nếu muốn
        }
    }
}
