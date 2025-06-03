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

namespace OGC.QuanLyDichVu
{
    public partial class ServiceItemUC : UserControl
    {
        private DTO_MONAN monAn;

        public ServiceItemUC(DTO_MONAN monAn)
        {
            InitializeComponent();

            this.monAn = monAn;
            this.Tag = monAn;

            LoadData();
        }

        private void LoadData()
        {
            if (monAn == null) return;

            lblTen.Text = monAn.TenMonAn;
            lblGia.Text = monAn.Gia.ToString("N0") + " VNĐ";

            try
            {
                // Load ảnh từ đường dẫn (dùng / thay cho \)
                ptbAnh.Image = Image.FromFile(monAn.Anh);
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;

                // GÁN TAG để xử lý click
                ptbGioHang.Tag = monAn;
            }
            catch
            {
                // Nếu không load được ảnh, có thể để ảnh mặc định hoặc để trống

            }
        }



        private void ptbGioHang_Click(object sender, EventArgs e)
        {
            DTO_MONAN food = (sender as PictureBox)?.Tag as DTO_MONAN;

            if (food == null) return;

            try
            {
                int soLuongTon = DAO_KHO.Instance.LaySoLuongTon(food.ID);
                if (soLuongTon <= 0)
                {
                    MessageBox.Show("❌ Món này hiện đã hết hàng trong kho, không thể thêm vào giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var frm = this.FindForm() as frmQuanLyDichVu;
                frm?.AddToCart(food);
                frm?.UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
