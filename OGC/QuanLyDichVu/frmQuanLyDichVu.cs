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
    public partial class frmQuanLyDichVu : Form
    {
        public frmQuanLyDichVu()
        {
            InitializeComponent();

            LoadDichVu();

        }


        #region Methods


        // Hàm lấy tên loại dịch vụ theo IDLoaiMonAn (bạn có thể đổi lấy từ DB)
        private string GetCategoryName(int categoryId)
        {
            return categoryId switch
            {
                1 => "Thức ăn",
                2 => "Nước uống",
                3 => "Combo",
                _ => "Khác",
            };
        }

        private void LoadDichVu()
        {
            //// Bước 1: Lấy tất cả món ăn
            //List<DTO_MONAN> allProducts = DAO_MONAN.Instance.LayTatCaMonAn();

            //if (allProducts == null)
            //    return;

            //// Bước 2: Nhóm theo IDLoaiMonAn
            //var productsByCategory = allProducts
            //    .GroupBy(p => p.IDLoaiMonAn)
            //    .ToList();

            //flpDichVu.Controls.Clear(); // Xóa hết control cũ

            //// Bước 3: Duyệt từng nhóm
            //foreach (var categoryGroup in productsByCategory)
            //{
            //    // Tạo panel cho từng loại món
            //    Panel categoryPanel = new Panel();
            //    categoryPanel.Width = flpDichVu.Width - 25; // để lề
            //    categoryPanel.AutoSize = true;
            //    categoryPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //    categoryPanel.Margin = new Padding(0, 10, 0, 10);

            //    // Tạo label tiêu đề loại món
            //    Label categoryLabel = new Label();
            //    categoryLabel.Text = GetCategoryName(categoryGroup.Key); // lấy tên loại
            //    categoryLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            //    categoryLabel.Dock = DockStyle.Top;
            //    categoryLabel.Height = 30;
            //    categoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            //    categoryPanel.Controls.Add(categoryLabel);

            //    // Tạo FlowLayoutPanel con chứa món ăn trong loại
            //    FlowLayoutPanel categoryFlowPanel = new FlowLayoutPanel();
            //    categoryFlowPanel.Dock = DockStyle.Fill;
            //    categoryFlowPanel.AutoSize = true;
            //    categoryFlowPanel.WrapContents = true;
            //    categoryFlowPanel.FlowDirection = FlowDirection.LeftToRight;

            //    // Thêm các món ăn vào panel con
            //    foreach (var product in categoryGroup)
            //    {
            //        var serviceItem = new ServiceItemUC(product);
            //        categoryFlowPanel.Controls.Add(serviceItem);
            //    }

            //    categoryPanel.Controls.Add(categoryFlowPanel);

            //    // Thêm panel loại món vào flowlayoutpanel chính
            //    flpDichVu.Controls.Add(categoryPanel);
            //}

            flpDichVu.Controls.Clear();

            var productsByCategory = DAO_MONAN.Instance.LayTatCaMonAnTheoLoai();

            foreach (var category in productsByCategory)
            {
                // ----- Label hiển thị tên loại -----
                Label lblLoai = new Label();
                lblLoai.Text = category.Key; // Ví dụ: "Combo", "Thức ăn", "Nước uống"
                lblLoai.Font = new Font("Arial", 14, FontStyle.Bold);
                lblLoai.AutoSize = false;
                lblLoai.Width = flpDichVu.Width - 25;
                lblLoai.Height = 30;
                lblLoai.TextAlign = ContentAlignment.MiddleLeft;
                flpDichVu.Controls.Add(lblLoai);

                // ----- FlowLayoutPanel con chứa sản phẩm -----
                FlowLayoutPanel flpLoai = new FlowLayoutPanel();
                flpLoai.AutoSize = true;
                flpLoai.WrapContents = true;
                flpLoai.Margin = new Padding(10, 0, 10, 20); // Khoảng cách giữa các loại
                flpLoai.Width = flpDichVu.Width - 40;

                foreach (var mon in category.Value)
                {
                    var item = new ServiceItemUC(mon);
                    flpLoai.Controls.Add(item);
                }

                flpDichVu.Controls.Add(flpLoai);
            }
        }



        #endregion
    }
}
