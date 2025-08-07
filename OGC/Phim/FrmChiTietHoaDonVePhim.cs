using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using OGC.DAO;
using System.Globalization;
using System.Diagnostics;

namespace OGC.Phim
{
    public partial class FrmChiTietHoaDonVePhim : Form
    {
        private int idNhanVien;
        private int idKhach;
        private int idHoaDon;
        private decimal tongTien;
        private int idVe;
        private decimal giaVe;

        public FrmChiTietHoaDonVePhim(
            int idNhanVien,
            int idKhach,
            string tenPhim,
            string suatChieu,
            string phong,
            List<string> ghe,
            string dinhDang,
            decimal giaVe,
            decimal tongTien)
        {
            InitializeComponent();

            this.idNhanVien = idNhanVien;
            this.idKhach = idKhach;
            this.giaVe = giaVe;
            this.tongTien = tongTien;

            // Gộp danh sách ghế thành chuỗi
            string gheDaChon = string.Join(", ", ghe);

            // Hiển thị thông tin lên Label
            lbTenPhim.Text = tenPhim;
            lbSuatChieu.Text = suatChieu;
            lbPhong.Text = phong;
            lbGhe.Text = gheDaChon;
            lbDinhDang.Text = dinhDang;
            lbGiaVe.Text = giaVe.ToString("N0") + " đ";
            lbTongTien.Text = tongTien.ToString("N0") + " đ";

            // Thêm hóa đơn vào DB
            idHoaDon = DAO_HD_VE.Instance.ThemHoaDonVe(idNhanVien, idKhach, tongTien);

            // Thêm chi tiết hóa đơn vào DB
            DAO_CTHD_VE.Instance.ThemChiTietHoaDonVe(
                idHoaDon,
                tenPhim,
                dinhDang,
                phong,
                suatChieu,
                DateTime.Now,
                gheDaChon,
                giaVe,
                "Đã thanh toán"
            );

            // Sinh mã vạch
            string noiDungMaVach = $"HDVE-{idHoaDon}-{idVe}";
            HienThiMaVach(noiDungMaVach);
        }

        private void HienThiMaVach(string noiDung)
        {
            if (string.IsNullOrEmpty(noiDung)) return;

            if (noiDung.Length > 80)
                noiDung = noiDung.Substring(0, 80);

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 600,
                    Height = 200,
                    Margin = 10
                }
            };

            Bitmap barcodeBitmap = writer.Write(noiDung);
            ptbQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            ptbQRCode.Image = barcodeBitmap;
        }
    }
}
