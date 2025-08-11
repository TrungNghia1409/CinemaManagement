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

namespace OGC.Phim
{
    public partial class FrmPhuongThucThanhToanVe : Form
    {
        private List<string> gheDaChon;
        private decimal tongTien;
        private int idNhanVien;
        private string tenPhim, suatChieu, phong, dinhDang;
        private decimal giaVe;
        private FrmChonGhe frmChonGhe;
       

        public FrmPhuongThucThanhToanVe(
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


        private void btnTienMat_Click(object sender, EventArgs e)
        {
            FrmXacNhanThanhToanVePhim frm = new FrmXacNhanThanhToanVePhim(
                    gheDaChon,
                    tongTien,
                    idNhanVien,
                    tenPhim,
                    suatChieu,
                    phong,
                    dinhDang,
                    giaVe,
                    frmChonGhe
         );

            frm.ShowDialog();
            this.Close();
        }

        private async void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                // Danh sách Item cho PayOS
                List<Item> items = new List<Item>();

                // Thêm từng vé vào danh sách thanh toán
                foreach (var maGhe in gheDaChon)
                {
                    items.Add(new Item
                    {
                        name = $"Vé {tenPhim} - Ghế {maGhe} - {dinhDang}",
                        quantity = 1,
                        price = giaVe
                    });
                }

                // Chuẩn bị mô tả (tối đa 25 ký tự)
                string moTa = $"TT {tenPhim}";
                if (moTa.Length > 25)
                    moTa = moTa.Substring(0, 25);

                // Tạo DTO gửi PayOS
                PayOSCreatePaymentRequestDTO dto = new PayOSCreatePaymentRequestDTO
                {
                    amount = tongTien,
                    orderCode = 0, // PayOSDAO sẽ tự gán
                    description = moTa,
                    items = items,
                    returnUrl = "https://www.google.com/", // Link giả để demo
                    cancelUrl = "https://www.google.com/",
                    expiredAt = 0 // PayOSDAO sẽ tự gán
                };

                // Gọi DAO để tạo thanh toán
                PayOSDAO payOS = new PayOSDAO();
                string url = await payOS.CreatePayment(dto);

                // Lưu mã đơn hàng để kiểm tra trạng thái sau này
                int orderCode = dto.orderCode;

                if (!string.IsNullOrEmpty(url))
                {
                    // Mở link thanh toán trên trình duyệt mặc định
                    System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

                    MessageBox.Show(
                        $"Link thanh toán đã mở. Mã đơn hàng: {orderCode}\nVui lòng ghi lại mã này để kiểm tra trạng thái trên PayOS.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Không tạo được link thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
