using OGC.DAO;
using OGC.DTO;
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
    public partial class FrmChonGhe : Form
    {

        private string tenPhim;
        private DateTime ngayChieu;
        private TimeSpan gioChieu;
        private string dinhDang;
        private int idPhong;
        private List<Button> selectedSeats = new List<Button>();

        public FrmChonGhe(string tenPhim, DateTime ngayChieu, TimeSpan gioChieu)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu;
            this.gioChieu = gioChieu;

            int idPhong = DAO_LICHCHIEU.Instance.GetIDPhong(tenPhim, ngayChieu, gioChieu);

            if (idPhong != -1)
            {
                List<GheDTO> danhSachGhe = DAO_Ghe.Instance.GetListGheByIDPhong(idPhong);

                // Load lên flpGhe bằng button
                foreach (GheDTO ghe in danhSachGhe)
                {
                    Button btnGhe = new Button();
                    btnGhe.Text = ghe.MaGhe;
                    btnGhe.Width = 50;
                    btnGhe.Height = 50;

                    btnGhe.BackColor = (ghe.TrangThai == 1) ? Color.Red : Color.LightGreen;

                    flpGhe.Controls.Add(btnGhe);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID phòng chiếu.");
            }

            //this.Load += FrmChonGhe_Load;
        }

        private void FrmChonGhe_Load(object sender, EventArgs e)
        {
            LoadDinhDangPhong();
            //LoadPhong();
           // LoadGhe();
        }


        private void LoadDinhDangPhong()
        {
            dinhDang = DAO_DINHDANGPHIM.Instance.GetDinhDangPhimTheoTenPhim(tenPhim)?.TenDinhDang;

            if (string.IsNullOrEmpty(dinhDang))
            {
                MessageBox.Show("Không lấy được định dạng phim.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbDinhDang.Text = $"Định dạng: {dinhDang}";
            lbTenPhim.Text = $"Phim: {tenPhim}";
            lbNgayChieu.Text = $"Ngày chiếu: {ngayChieu:dd/MM/yyyy}";
            lbGioChieu.Text = $"Giờ chiếu: {gioChieu:hh\\:mm}";
        }

        //private void LoadPhong()
        //{
        //    var phongList = DAO_PHONGCHIEU.Instance.GetPhongTheoDinhDang(dinhDang);
        //    if (phongList == null || phongList.Count == 0)
        //    {
        //        MessageBox.Show($"Không có phòng chiếu cho định dạng {dinhDang}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.Close();
        //        return;
        //    }

        //    idPhong = phongList[0].ID;
        //    // Nếu bạn có label tên phòng thì gán ở đây, ví dụ lbPhong.Text = ...
        //}

        private void LoadGhe()
        {
            flpGhe.Controls.Clear();
            selectedSeats.Clear();

            DataTable dtGhe = DAO_Ghe.Instance.GetGheTheoPhong(idPhong);
            if (dtGhe == null || dtGhe.Rows.Count == 0)
            {
                MessageBox.Show("Không có ghế trong phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataRow row in dtGhe.Rows)
            {
                int idGhe = Convert.ToInt32(row["ID"]);
                string maGhe = row["MaGhe"].ToString();

                int trangThai = DAO_Ghe.Instance.GetTrangThaiGhe(idPhong, maGhe, ngayChieu, gioChieu);

                Button btnGhe = new Button
                {
                    Text = maGhe,
                    Width = 50,
                    Height = 50,
                    Margin = new Padding(5),
                    Tag = new { ID = idGhe, MaGhe = maGhe, TrangThai = trangThai }
                };

                if (trangThai == 1)
                {
                    btnGhe.BackColor = Color.Red;
                    btnGhe.Enabled = false;
                }
                else
                {
                    btnGhe.BackColor = Color.LightGreen;
                    btnGhe.Enabled = true;
                    //btnGhe.Click += BtnGhe_Click;
                }

                flpGhe.Controls.Add(btnGhe);
            }
        }

    }
}
