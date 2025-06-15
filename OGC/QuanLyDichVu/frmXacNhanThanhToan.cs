using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public int mucGiam;
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

        private void txbMaKhuyenMai_Leave(object sender, EventArgs e)
        {
            string maKM = txbMaKhuyenMai.Text.Trim();
            
            string loaiApDung = DAO_KHUYENMAI.Instance.GetLoaiApDungByMaKM(maKM);

            if (string.IsNullOrEmpty(loaiApDung) || loaiApDung != "Dịch vụ")
            {
                lblKhuyenMai.Text = "❌ Không hợp lệ";
                return;
            }
            else
            {
                lblKhuyenMai.Text = "✔ Hợp lệ";
            }

            //bool isValid = DAO_KHUYENMAI.Instance.KiemTraKhuyenMaiHopLe(maKM, loaiApDung);
            //if (isValid)
            //{
            //    lblKhuyenMai.Text = "✔ Hợp lệ";
            //}
            //else
            //{
            //    lblKhuyenMai.Text = "❌ Không hợp lệ";
            //}
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string maKM = txbMaKhuyenMai.Text.Trim();
                //truy vấn mức giảm dựa trên maKM
                int? mucGiam = DAO_KHUYENMAI.Instance.GetMucGiamByMaKM(maKM);
                if (mucGiam.HasValue)
                {
                    lblKhuyenMai.Text = mucGiam.Value + " %";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mức giảm cho mã khuyến mãi!");
                }

                string sdt = txbSDT.Text.Trim();
                int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

                if (idKhach == -1)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Hiển thị bill (load từ CTHD_MONAN)
                frmChiTietHoaDonMonAn frmChiTiet = new frmChiTietHoaDonMonAn(idNhanVien, idKhach, gioHang, tongTien, mucGiam.Value);
                frmChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi khi xác nhận thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
