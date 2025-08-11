using OGC.DAO;
using OGC.DTO;
using System;
using QRCoder;
using ZXing;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace OGC.Phim
{
    public partial class FrmChonGhe : Form
    {
        private Dictionary<Button, string> gheVaMa = new Dictionary<Button, string>();
        private List<Button> gheDangChon = new List<Button>();
        private List<string> gheDaDat = new List<string>();
        private Dictionary<string, GheDTO> dictGhe = new Dictionary<string, GheDTO>();
        private string currentUser;

        private decimal giaVe;

        private string tenPhim;
        private DateTime ngayChieu;
        private TimeSpan gioChieu;
        private string dinhDang;
        private int idPhong;
        private int idLichChieu = -1;



        public FrmChonGhe(string tenPhim, DateTime ngayChieu, TimeSpan gioChieu, int idPhong, string currentUser)
        {
            InitializeComponent();

            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu.Date;
            this.gioChieu = new TimeSpan(gioChieu.Hours, gioChieu.Minutes, 0); // chuẩn hóa ở đây, giữ nguyên về sau
            this.idPhong = idPhong;
            this.currentUser = currentUser;

            this.idLichChieu = DAO_LICHCHIEU.Instance.GetIDLichChieu(tenPhim, this.ngayChieu, this.gioChieu, idPhong);

            LoadDinhDangPhong();
            LoadGiaVe();
            LoadGhe();
        }


        private void FrmChonGhe_Load(object sender, EventArgs e)
        {
            string imagePath = @"C:\DoAn\QuanLyRapPhimOGC3\OGC\Image\AnhPhongChieu\AnhManHinh.png";

            if (System.IO.File.Exists(imagePath))
            {
                ptrbManHinh.Image = Image.FromFile(imagePath);
                ptrbManHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh màn hình: " + imagePath);
            }

            LoadDinhDangPhong();
        }

        private void LoadDinhDangPhong()
        {
            dinhDang = DAO_DINHDANGPHIM.Instance.GetDinhDangPhimTheoTenPhim(tenPhim)?.TenDinhDang;

            lbDinhDang.Text = $"Định dạng: {dinhDang ?? "Không rõ"}";
            lbTenPhim.Text = $"Phim: {tenPhim}";
            lbNgayChieu.Text = $"Ngày chiếu: {ngayChieu:dd/MM/yyyy}";
            lbGioChieu.Text = $"Giờ chiếu: {gioChieu:hh\\:mm}";
        }
        private void LoadGiaVe()
        {
            try
            {
                if (idLichChieu != -1)
                {
                    giaVe = DAO_LICHCHIEU.Instance.GetGiaVeTheoID(idLichChieu);
                }
                else
                {
                    giaVe = DAO_LICHCHIEU.Instance.LayGiaVe(tenPhim, ngayChieu, gioChieu, idPhong);
                }


                if (gheDangChon.Count > 0)
                    CapNhatThongTinGheDangChon();
            }
            catch
            {
                giaVe = 0;
                lbGiaGhe.Text = "Không lấy được giá vé";
            }
        }

        private int ExtractSeatNumber(string maGhe)
        {
            var m = Regex.Match(maGhe ?? "", @"\d+");
            if (m.Success && int.TryParse(m.Value, out int n))
                return n;
            return int.MaxValue; // nếu không có số, để cuối cùng
        }



        private void LoadGhe()
        {
            // Lấy thông tin loại phòng
            int idLoaiPhong = DAO_PHONGCHIEU.Instance.LayIDLoaiPhongTheoIDPhong(idPhong);
            string tenLoaiPhong = DAO_LOAIPHONG.Instance.GetTenLoaiPhongTheoID(idLoaiPhong);
            int sucChua = DAO_LOAIPHONG.Instance.LaySucChuaTheoIDLoaiPhong(idLoaiPhong);

            // Lấy danh sách ghế
            var gheList = DAO_Ghe.Instance.GetListGheByIDPhong(idPhong);

            // Xóa dữ liệu cũ
            gheDaDat.Clear();
            dictGhe.Clear();
            gheVaMa.Clear();
            gheDangChon.Clear();
            flpGhe.Controls.Clear();

            flpGhe.SuspendLayout();

            // Số ghế mỗi hàng (logical)
            int gheMoiMotHang = 10;
            int soHangFinal = (int)Math.Ceiling((double)sucChua / gheMoiMotHang);

            for (int i = 0; i < soHangFinal; i++)
            {
                char hang = (char)('A' + i);

                // Panel cho mỗi hàng
                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    Width = Math.Max(0, flpGhe.ClientSize.Width - 25),
                    Height = 60,
                    Margin = new Padding(0, 5, 0, 5),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false,
                    AutoSize = false
                };

                // Lọc ghế trong hàng và SẮP XẾP THEO SỐ (khắc phục A10 trước A2)
                var gheTrongHang = gheList
                    .Where(g => g.MaGhe != null && g.MaGhe.StartsWith(hang.ToString(), StringComparison.OrdinalIgnoreCase))
                    .OrderBy(g => ExtractSeatNumber(g.MaGhe))
                    .ToList();

                if (gheTrongHang.Count == 0)
                {
                    // nếu hàng trống thì bỏ qua
                    continue;
                }

                // Tính chiều rộng thực tế cho mỗi nút (bao gồm margin)
                int btnWidth = (tenLoaiPhong == "Couple" ? 100 : 50);
                int btnHorizontalMargin = 2 + 2; // Margin Left + Right (vì new Padding(2))
                int perBtnTotal = btnWidth + btnHorizontalMargin;
                int tongWidth = gheTrongHang.Count * perBtnTotal;

                // Canh giữa hàng
                int khoangTrong = (rowPanel.Width - tongWidth) / 2;
                if (khoangTrong > 0)
                    rowPanel.Padding = new Padding(khoangTrong, 0, 0, 0);
                else
                    rowPanel.Padding = new Padding(0);

                foreach (var ghe in gheTrongHang)
                {
                    Button btnGhe = new Button
                    {
                        Text = ghe.MaGhe,
                        Width = btnWidth,
                        Height = 50,
                        Margin = new Padding(2),
                        FlatStyle = FlatStyle.Flat
                    };
                    btnGhe.FlatAppearance.BorderSize = 2;

                    // Lấy trạng thái ghế bằng ID
                    int trangThai = DAO_Ghe.Instance.GetTrangThaiGheTheoID(ghe.ID, ngayChieu, gioChieu);

                    if (trangThai == 1) // Ghế đã đặt
                    {
                        btnGhe.BackColor = Color.Red;
                        btnGhe.Enabled = false;
                        gheDaDat.Add(ghe.MaGhe);
                    }
                    else // Ghế trống
                    {
                        btnGhe.BackColor = Color.LightGreen;
                        btnGhe.Click += BtnGhe_Click;
                    }

                    gheVaMa[btnGhe] = ghe.MaGhe;
                    dictGhe[ghe.MaGhe] = ghe;

                    rowPanel.Controls.Add(btnGhe);
                }

                flpGhe.Controls.Add(rowPanel);
            }

            flpGhe.ResumeLayout();
        }

        private void FrmChonGhe_Activated(object sender, EventArgs e)
        {
            LoadGhe();
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

        private void CapNhatThongTinGheDangChon()
        {
            var danhSach = gheDangChon
        .Select(btn => btn.Text)
        .OrderBy(g => GetHangGhe(g))
        .ThenBy(g => GetSoGhe(g))
        .ToList();

            if (danhSach.Count == 0)
            {
                lbGheDaChon.Text = "Ghế đã chọn: ";
                lbGiaGhe.Text = "Tổng tiền: 0 đ";
                return;
            }

            decimal tong = danhSach.Count * giaVe;

            lbGheDaChon.Text = "Ghế đã chọn: " + string.Join(", ", danhSach);
            lbGiaGhe.Text = "Tổng tiền: " + tong.ToString("N0") + " đ";

        }

        private char GetHangGhe(string maGhe)
        {
            // Nếu là ghế đôi như "A6-A7", tách lấy ký tự đầu
            return string.IsNullOrEmpty(maGhe) ? 'Z' : maGhe[0];
        }

        private int GetSoGhe(string maGhe)
        {
            try
            {
                // Nếu là ghế đôi như "A6-A7", lấy số đầu tiên (sau chữ A)
                if (maGhe.Contains("-"))
                {
                    string[] parts = maGhe.Split('-');
                    return int.Parse(new string(parts[0].Skip(1).ToArray()));
                }
                else
                {
                    return int.Parse(new string(maGhe.Skip(1).ToArray()));
                }
            }
            catch
            {
                return 9999; // nếu lỗi format thì đưa về cuối danh sách
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (gheDangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào.");
                return;
            }

            bool datThatBai = false;
            var danhSachGheDaDat = gheDangChon.Select(g => g.Text).ToList();

            foreach (var btn in gheDangChon.ToList())
            {
                string maGhe = btn.Text;
                if (dictGhe.TryGetValue(maGhe, out var ghe))
                {
                    bool ok = DAO_Ghe.Instance.DatGhe(ghe.ID, ngayChieu, gioChieu);

                    if (ok)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        datThatBai = true;
                        break;
                    }
                }
            }

            gheDangChon.Clear();
            CapNhatThongTinGheDangChon();

            if (datThatBai)
            {
                MessageBox.Show("Có lỗi khi đặt một số ghế. Vui lòng thử lại.");
            }
            else
            {
                MessageBox.Show("Đặt ghế thành công!");
                LoadGhe();

                // Tạo nội dung mã vạch, sử dụng LoaiBoDau từ DAO_Ghe
                string noiDungQR = $"Film: {DAO_Ghe.LoaiBoDau(tenPhim)} - Ngay chieu: {ngayChieu:dd/MM/yyyy} - Gio: {gioChieu} - Ghe: {string.Join(", ", danhSachGheDaDat)}";
                Console.WriteLine("Nội dung mã vạch: " + noiDungQR);

                string suatChieu = $"{ngayChieu:dd/MM/yyyy} - {gioChieu:hh\\:mm}";
                string phong = "Phòng " + idPhong.ToString();
                string ghe = string.Join(", ", danhSachGheDaDat);
                decimal tongTien = danhSachGheDaDat.Count * giaVe;



            }
        }

        private void btnChonHinhThucThanhToan_Click(object sender, EventArgs e)
        {
            if (gheDangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào.");
                return;
            }

            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Không tìm thấy tên đăng nhập nhân viên. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> danhSachGhe = gheDangChon.Select(btn => btn.Text).ToList();
            decimal tongTien = danhSachGhe.Count * giaVe;
            string suatChieu = $"{ngayChieu:dd/MM/yyyy} - {gioChieu:hh\\:mm}";
            string phong = "Phòng " + idPhong.ToString();

            int idNhanVien = DAO_NHANVIEN.Instance.GetIDByUsername(currentUser);

            FrmPhuongThucThanhToanVe frm = new FrmPhuongThucThanhToanVe(
                            danhSachGhe,
                            tongTien,
                            idNhanVien,
                            tenPhim,
                            suatChieu,
                            phong,
                            dinhDang,
                            giaVe,
                            this
                        );
            frm.ShowDialog();
        }
    }
}
