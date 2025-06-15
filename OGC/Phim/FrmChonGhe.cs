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

        // ánh xạ giữa Button và mã ghế (VD: Button A1 → "A1")
        private Dictionary<Button, string> gheVaMa = new Dictionary<Button, string>();

        // danh sách các button ghế đang được chọn
        private List<Button> gheDangChon = new List<Button>();

        // danh sách mã ghế đã đặt (bị disable)
        private List<string> gheDaDat = new List<string>();

        private int giaVe = 50000; // có thể tùy chỉnh theo loại phòng

        // ánh xạ mã ghế → đối tượng GheDTO (để lấy ID khi đặt)
        private Dictionary<string, GheDTO> dictGhe = new Dictionary<string, GheDTO>();



        private string tenPhim;
        private DateTime ngayChieu;
        private TimeSpan gioChieu;
        private string dinhDang;
        private int idPhong;
        private List<Button> selectedSeats = new List<Button>();



        private void CapNhatThongTinGheDangChon()
        {
            var danhSach = gheDangChon
                .Select(btn => btn.Text)
                .OrderBy(g => g[0]) // theo hàng A, B, C,...
                .ThenBy(g => int.Parse(g.Substring(1))) // theo số thứ tự
                .ToList();

            lbGheDaChon.Text = "Ghế đã chọn: " + string.Join(", ", danhSach);
            lbGiaGhe.Text = "Tổng tiền: " + (danhSach.Count * giaVe).ToString("N0") + " đ";
        }

        public FrmChonGhe(string tenPhim, DateTime ngayChieu, TimeSpan gioChieu)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu;
            this.gioChieu = gioChieu;

            LoadDinhDangPhong(); // giữ nguyên dòng này nếu cần

            LoadGhe();
        }

        private void LoadGhe()
        {
            int idPhong = DAO_LICHCHIEU.Instance.GetIDPhong(tenPhim, ngayChieu);
            int idLoaiPhong = DAO_PHONGCHIEU.Instance.LayIDLoaiPhongTheoIDPhong(idPhong);
            int sucChua = DAO_LOAIPHONG.Instance.LaySucChuaTheoIDLoaiPhong(idLoaiPhong);
            MessageBox.Show($"idPhong: {idPhong}");
            MessageBox.Show($"idLoaiPhong: {idLoaiPhong}");
            MessageBox.Show($"sucChua: {sucChua}");

            gheDaDat.Clear();
            dictGhe.Clear();
            gheVaMa.Clear();
            gheDangChon.Clear();

            var gheList = DAO_Ghe.Instance.GetListGheByIDPhong(idPhong);
            foreach (var ghe in gheList)
            {
                int trangThai = DAO_Ghe.Instance.GetTrangThaiGheTheoID(ghe.ID, ngayChieu, gioChieu);
                if (trangThai == 1)
                    gheDaDat.Add(ghe.MaGhe);
                dictGhe[ghe.MaGhe] = ghe;
            }

            flpGhe.Controls.Clear();
            int gheMoiMotHang = 10;
            int soHang = (int)Math.Ceiling((double)sucChua / gheMoiMotHang);
            int soThuTu = 1;

            for (int i = 0; i < soHang; i++)
            {
                char hang = (char)('A' + i);

                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    Width = flpGhe.Width - 25,
                    Height = 60,
                    Margin = new Padding(0, 5, 0, 5),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false,
                    AutoSize = false,
                    Anchor = AnchorStyles.None
                };

                int soLuongTrongHang = Math.Min(gheMoiMotHang, sucChua - soThuTu + 1);
                int tongWidth = soLuongTrongHang * 55;
                int khoangTrong = (rowPanel.Width - tongWidth) / 2;
                if (khoangTrong > 0)
                    rowPanel.Padding = new Padding(khoangTrong, 0, 0, 0);

                for (int j = 1; j <= gheMoiMotHang && soThuTu <= sucChua; j++, soThuTu++)
                {
                    string maGhe = $"{hang}{j}";

                    Button btnGhe = new Button
                    {
                        Text = maGhe,
                        Width = 50,
                        Height = 50,
                        Margin = new Padding(2)
                    };

                    if (gheDaDat.Contains(maGhe))
                    {
                        btnGhe.BackColor = Color.Red;
                        btnGhe.Enabled = false;
                    }
                    else
                    {
                        btnGhe.BackColor = Color.LightGreen;
                        btnGhe.Click += BtnGhe_Click;
                    }

                    gheVaMa[btnGhe] = maGhe;
                    rowPanel.Controls.Add(btnGhe);
                }

                flpGhe.Controls.Add(rowPanel);
            }
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.Gold;
                gheDangChon.Add(btn);
            }
            else if (btn.BackColor == Color.Gold)
            {
                btn.BackColor = Color.LightGreen;
                gheDangChon.Remove(btn);
            }

            CapNhatThongTinGheDangChon();
        }

        private void FrmChonGhe_Load(object sender, EventArgs e)
        {
            LoadDinhDangPhong();
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (gheDangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào.");
                return;
            }

            bool datThatBai = false;

            foreach (var btn in gheDangChon.ToList())
            {
                string maGhe = btn.Text;
                if (dictGhe.TryGetValue(maGhe, out var ghe))
                {
                    bool ok = DAO_Ghe.Instance.DatGhe(ghe.ID, ngayChieu, gioChieu);

                    if (ok)
                    {
                        // thành công → để yên, load lại sau
                    }
                    else
                    {
                        datThatBai = true;
                        break;
                    }
                }
            }

            LoadGhe(); // luôn load lại toàn bộ trạng thái sau xác nhận

            gheDangChon.Clear();
            CapNhatThongTinGheDangChon();

            if (datThatBai)
            {
                MessageBox.Show("Có lỗi khi đặt một số ghế. Vui lòng thử lại.");
            }
            else
            {
                MessageBox.Show("Đặt ghế thành công!");
            }
        }
    }
}