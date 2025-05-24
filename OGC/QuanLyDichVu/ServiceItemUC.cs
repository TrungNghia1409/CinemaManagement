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

            LoadData();
        }

        private void LoadData()
        {
            lblTen.Text = monAn.TenMonAn;
            lblGia.Text = monAn.Gia.ToString("N0") + " VNĐ";

            try
            {
                // Load ảnh từ đường dẫn (dùng / thay cho \)
                ptbAnh.Image = Image.FromFile(monAn.Anh);
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                // Nếu không load được ảnh, có thể để ảnh mặc định hoặc để trống
               
            }
        }

    }
}
