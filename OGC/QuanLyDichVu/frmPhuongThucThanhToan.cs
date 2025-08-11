using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OGC.DTO.DTO_CartItem;

namespace OGC.QuanLyDichVu
{
    public partial class frmPhuongThucThanhToan : Form
    {
        private decimal tongTien;
        public string currentUser;
        public int idNhanVien;
        private int orderCode; // Lưu orderCode để kiểm tra trạng thái thủ công
        List<CartItem> gioHang;
        public frmPhuongThucThanhToan(long tongTien, string username, int idNhanVien, List<CartItem> gioHang)
        {
            InitializeComponent();

            this.tongTien = tongTien;
            this.currentUser = username;
            this.idNhanVien = idNhanVien;
            this.gioHang = gioHang;
        }

        private async void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                List<Item> items = new List<Item>();

                // Duyệt từng món trong giỏ hàng để thêm vào danh sách thanh toán
                foreach (var cartItem in gioHang)
                {
                    items.Add(new Item
                    {
                        name = cartItem.TenMonAn,
                        quantity = cartItem.SoLuong,
                        price = cartItem.DonGia  // Tính tổng tiền cho món này
                    });
                }
                PayOSCreatePaymentRequestDTO dto = new PayOSCreatePaymentRequestDTO
                {
                    amount = tongTien,
                    orderCode = 0, // Để PayOSDAO tạo
                    description = "Thanh toán dịch vụ",
                    items = items,
                    returnUrl = "https://www.google.com/", // Thay null bằng chuỗi dummy
                    cancelUrl = "https://www.google.com/",   // Thay null bằng chuỗi dummy
                    expiredAt = 0 // Để PayOSDAO tạo
                };

                PayOSDAO payOS = new PayOSDAO();
                string url = await payOS.CreatePayment(dto);
                orderCode = dto.orderCode; // Lưu orderCode (PayOSDAO gán giá trị)

                if (!string.IsNullOrEmpty(url))
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    MessageBox.Show($"Link thanh toán đã mở. Mã đơn hàng: {orderCode}\nVui lòng ghi lại mã này để kiểm tra trạng thái trên PayOS.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            if (tongTien > 0)
            {
                int idNhanVien = DAO_NHANVIEN.Instance.GetIDByUsername(currentUser);

                frmXacNhanThanhToan frm = new frmXacNhanThanhToan(tongTien, idNhanVien, gioHang);
                frm.ShowDialog(); // hoặc frm.Show()
            }
            else
            {
                MessageBox.Show("Số tiền phải lớn hơn 0!");
                return;
            }
        }
    }
}


