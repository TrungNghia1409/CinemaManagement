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


        // Constructor đầy đủ 4 tham số

        public FrmChonGhe(string tenPhim, DateTime ngayChieu, TimeSpan gioChieu, int idPhong, string currentUser)
        {
            InitializeComponent();

            this.tenPhim = tenPhim;
            this.ngayChieu = ngayChieu;
            this.gioChieu = gioChieu;
            this.idPhong = idPhong;
            this.currentUser = currentUser;

            this.idLichChieu = DAO_LICHCHIEU.Instance.GetIDLichChieu(tenPhim, ngayChieu, gioChieu, idPhong);

            LoadDinhDangPhong();
            LoadGiaVe();
            LoadGhe();
        }


        private void FrmChonGhe_Load(object sender, EventArgs e)
        {
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

                // 👇 Chỉ gọi cập nhật nếu có ghế được chọn
                if (gheDangChon.Count > 0)
                    CapNhatThongTinGheDangChon();
            }
            catch
            {
                giaVe = 0;
                lbGiaGhe.Text = "Không lấy được giá vé";
            }
        }

        private void LoadGhe()
        {

            // 🔍 Lấy thông tin phòng
            int idLoaiPhong = DAO_PHONGCHIEU.Instance.LayIDLoaiPhongTheoIDPhong(idPhong);
            string tenLoaiPhong = DAO_LOAIPHONG.Instance.GetTenLoaiPhongTheoID(idLoaiPhong);
            int sucChua = DAO_LOAIPHONG.Instance.LaySucChuaTheoIDLoaiPhong(idLoaiPhong);

            int soHang = (int)Math.Ceiling((double)sucChua / 10);
            int soCot = 10;

            // ✅ DÙ LÀ PHÒNG NÀO CŨNG CHỈ DÙNG HÀM NÀY
            DAO_Ghe.Instance.TaoGheTheoPhong(idPhong);

            // 📦 Lấy danh sách ghế
            var gheList = DAO_Ghe.Instance.GetListGheByIDPhong(idPhong);
            gheDaDat.Clear();
            dictGhe.Clear();
            gheVaMa.Clear();
            gheDangChon.Clear();

            foreach (var ghe in gheList)
            {
                int trangThai = DAO_Ghe.Instance.GetTrangThaiGheTheoMa(idPhong, ghe.MaGhe, ngayChieu, gioChieu);
                if (trangThai == 1)
                    gheDaDat.Add(ghe.MaGhe);
                dictGhe[ghe.MaGhe] = ghe;
            }

            // 🧱 Vẽ lên giao diện
            flpGhe.Controls.Clear();
            int gheMoiMotHang = 10;
            int soHangFinal = (int)Math.Ceiling((double)sucChua / gheMoiMotHang);

            for (int i = 0; i < soHangFinal; i++)
            {
                char hang = (char)('A' + i);

                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    Width = flpGhe.Width - 25,
                    Height = 60,
                    Margin = new Padding(0, 5, 0, 5),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false
                };

                var gheTrongHang = gheList
                    .Where(g => g.MaGhe.StartsWith(hang.ToString()))
                    .OrderBy(g => g.MaGhe)
                    .ToList();

                int tongWidth = gheTrongHang.Count * 55;
                int khoangTrong = (rowPanel.Width - tongWidth) / 2;
                if (khoangTrong > 0)
                    rowPanel.Padding = new Padding(khoangTrong, 0, 0, 0);

                foreach (var ghe in gheTrongHang)
                {
                    Button btnGhe = new Button
                    {
                        Text = ghe.MaGhe,
                        Width = (tenLoaiPhong == "Couple" ? 100 : 50), // ✅ Ghế đôi nếu là phòng couple
                        Height = 50,
                        Margin = new Padding(2)
                    };

                    if (gheDaDat.Contains(ghe.MaGhe))
                    {
                        btnGhe.BackColor = Color.Red;
                        btnGhe.Enabled = false;
                    }
                    else
                    {
                        btnGhe.BackColor = Color.LightGreen;
                        btnGhe.Click += BtnGhe_Click;
                    }

                    gheVaMa[btnGhe] = ghe.MaGhe;
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

            int idNhanVien = DAO_NHANVIEN.Instance.GetIDByUsername(currentUser); // Đảm bảo currentUser != null

            FrmPhuongThucThanhToanVe frm = new FrmPhuongThucThanhToanVe(
                            danhSachGhe,
                            tongTien,
                            idNhanVien,
                            tenPhim,
                            suatChieu,
                            phong,
                            dinhDang,
                            giaVe
                        );
            frm.ShowDialog();

        }

        // Nhận thông báo từ FrmChiTietHoaDonVePhim khi bill đã xuất
        public void CapNhatGheSauKhiXuatBill(List<string> gheDaMua)
        {
            foreach (var maGhe in gheDaMua)
            {
                // Tìm tất cả button ghế trùng tên
                var btn = this.Controls.Find(maGhe, true)
                                       .OfType<Button>()
                                       .FirstOrDefault();
                if (btn != null)
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
            }
        }



    }
}
