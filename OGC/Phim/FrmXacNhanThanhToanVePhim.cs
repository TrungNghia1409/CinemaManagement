using DocumentFormat.OpenXml.Office2010.CustomUI;
using OGC.DAO;
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
    public partial class FrmXacNhanThanhToanVePhim : Form
    {
        private List<string> gheDaChon;
        private decimal tongTien;
        private int idNhanVien;
        private decimal giaVe;
        private string tenPhim, suatChieu, phong, dinhDang;
        private FrmChonGhe frmChonGhe;


        public FrmXacNhanThanhToanVePhim(
            List<string> gheDaChon,
            decimal tongTien,
            int idNhanVien,
            string tenPhim,
            string suatChieu,
            string phong,
            string dinhDang,
            decimal giaVe,
            FrmChonGhe frmChonGhe
 

        )
        {
            InitializeComponent();
            this.gheDaChon = gheDaChon;
            this.tongTien = tongTien;
            this.idNhanVien = idNhanVien;
            this.tenPhim = tenPhim;
            this.suatChieu = suatChieu;
            this.phong = phong;
            this.dinhDang = dinhDang;
            this.giaVe = giaVe;
            this.frmChonGhe = frmChonGhe;

        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            string sdt = txbSDT.Text.Trim();
            int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

            if (idKhach > 0)
            {
                lblTrangThai.Text = "Đã tìm thấy!";
            }
            else
            {
                lblTrangThai.Text = "Không tìm thấy";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sdt = txbSDT.Text.Trim();
            int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

            // Xử lý số tiền khách đưa
            string cleaned = new string(tbTienKhachDua.Text.Where(char.IsDigit).ToArray());
            decimal.TryParse(cleaned, out decimal tienKhachDua);

            // Kiểm tra nếu tiền khách đưa không đủ
            if (tienKhachDua < tongTien)
            {
                MessageBox.Show("Tiền khách đưa không đủ để thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tienThoi = tienKhachDua - tongTien;

            FrmChiTietHoaDonVePhim frm = new FrmChiTietHoaDonVePhim(
                idNhanVien,
                idKhach,
                tenPhim,
                suatChieu,
                phong,
                gheDaChon,
                dinhDang,
                giaVe,
                tienKhachDua,
                tienThoi,
                tongTien
            );

            frm.ShowDialog();
            this.Close();
        }

        // Nhấn ESC để xóa
        private void tbTienKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbTienKhachDua.Clear();
                tbTienThoi.Clear();
                e.SuppressKeyPress = true; // Không phát ra tiếng beep
            }
        }

        // Double click để xóa
        private void tbTienKhachDua_DoubleClick(object sender, EventArgs e)
        {
            tbTienKhachDua.Clear();
            tbTienThoi.Clear();
        }

        private void FrmXacNhanThanhToanVePhim_Load(object sender, EventArgs e)
        {
            //// Gán số điện thoại để người dùng nhập (nếu có sẵn thì truyền vào)
            //txtSoDienThoai.Text = ""; // hoặc truyền từ form trước

            // Ghế đã chọn
            lbGheDaChon.Text = string.Join(", ", gheDaChon);

            // Tổng tiền
            lbTongTien.Text = tongTien.ToString("N0") + " VNĐ";

            // Ngày thanh toán (hiện tại)
            lbNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Tên Nhân Viên
            string tenNV = DAO_NHANVIEN.Instance.GetTenByID(idNhanVien);
            tbTenNhanVien.Text = tenNV;

            tbTienKhachDua.KeyDown += tbTienKhachDua_KeyDown;
            tbTienKhachDua.DoubleClick += tbTienKhachDua_DoubleClick;
        }

        private void tbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (tbTienKhachDua.Text == "")
            {
                tbTienThoi.Text = "";
                return;
            }

            // Lưu lại vị trí con trỏ
            int selectionStart = tbTienKhachDua.SelectionStart;
            int length = tbTienKhachDua.Text.Length;

            // Bỏ các ký tự không phải số
            string cleaned = new string(tbTienKhachDua.Text.Where(char.IsDigit).ToArray());

            if (decimal.TryParse(cleaned, out decimal tienKhachDua))
            {
                // Hiển thị lại với định dạng hàng nghìn
                tbTienKhachDua.Text = tienKhachDua.ToString("N0") + " VND";
                tbTienKhachDua.SelectionStart = Math.Min(tbTienKhachDua.Text.Length, selectionStart + tbTienKhachDua.Text.Length - length);

                // Tính tiền thối
                decimal tienThoi = tienKhachDua - tongTien; // Sử dụng biến `tongTien` bạn đã có
                tbTienThoi.Text = tienThoi >= 0 ? tienThoi.ToString("N0") + " VND" : "0 VND";
            }
            else
            {
                tbTienThoi.Text = "";
            }
        }

        private void btnXoaTienKhachDua_Click(object sender, EventArgs e)
        {
            tbTienKhachDua.Clear();
            tbTienThoi.Clear();
            tbTienKhachDua.Focus();
        }
    }
}

