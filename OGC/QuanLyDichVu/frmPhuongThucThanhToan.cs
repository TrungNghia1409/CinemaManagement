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

namespace OGC.QuanLyDichVu
{
    public partial class frmPhuongThucThanhToan : Form
    {
        private long tongTien;
        private int orderCode; // Lưu orderCode để kiểm tra trạng thái thủ công
        public frmPhuongThucThanhToan(long tongTien)
        {
            InitializeComponent();

            this.tongTien = tongTien;
        }

        private async void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                PayOSCreatePaymentRequestDTO dto = new PayOSCreatePaymentRequestDTO
                {
                    amount = tongTien,
                    orderCode = 0, // Để PayOSDAO tạo
                    description = "Thanh toán dịch vụ",
                    items = new List<Item>
                    {
                        new Item
                        {
                            name = "Dịch vụ",
                            quantity = 1,
                            price = tongTien
                        }
                    },
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
    }
}
