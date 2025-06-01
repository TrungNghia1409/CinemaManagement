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
using static OGC.DTO.DTO_CartItem;

namespace OGC.QuanLyDichVu
{
    public partial class frmXacNhanThanhToan : Form
    {
        public decimal tongTien;
        public int idNhanVien;
        private List<CartItem> gioHang;
        public frmXacNhanThanhToan(decimal tongTien, int idNhanVien, List<CartItem> gioHang)
        {
            InitializeComponent();

            this.tongTien = tongTien;
            this.idNhanVien = idNhanVien;
            this.gioHang = gioHang;

            txbTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            txbIDNhanVien.Text = idNhanVien.ToString();
            txbNgayMua.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void txbSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txbSDT.Text.Trim();
            int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

            if (idKhach > 0)
            {
                lblTrangThai.Text = "Đã tìm thấy!";
                txbIDKhachHang.Text = idKhach.ToString();
            }
            else
            {
                lblTrangThai.Text = "Không tìm thấy";
                txbIDKhachHang.Text = string.Empty;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string sdt = txbSDT.Text.Trim();
                int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

                if (idKhach == -1)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idHD = DAO_HD_MONAN.Instance.ThemHoaDonMonAn(idNhanVien, idKhach, tongTien);

                // Hiển thị bill (load từ CTHD_MONAN)
                frmChiTietHoaDonMonAn frmChiTiet = new frmChiTietHoaDonMonAn(idHD, gioHang, tongTien);
                frmChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi khi xác nhận thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
