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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OGC.QuanLyDichVu
{
    public partial class frmQuanLyDichVu : Form
    {
        public frmQuanLyDichVu()
        {
            InitializeComponent();

            LoadDichVu();
            LoadTenLoaiVaoComboBox();
        }


        #region Methods

        #region hiển thị danh sách món ăn
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


        //----- Hiển thị danh sách các món ăn
        private void LoadDichVu()
        {
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

        #region Giỏ hàng
        //--------Phương thức thêm sp vào giỏ hàng
        public void AddToCart(DTO_MONAN food)
        {
            foreach (Control control in flpCart.Controls)
            {
                if (control is Panel existingPanel)
                {
                    Label lblFoodName = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Font.Bold);
                    Label lblQuantity = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("SL:"));
                    Label lblPrice = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.ForeColor == Color.Red);


                    if (lblFoodName != null && lblFoodName.Text == food.TenMonAn)
                    {
                        int currentQuantity = int.Parse(lblQuantity.Text.Replace("SL: ", ""));
                        currentQuantity++;
                        lblQuantity.Text = "SL: " + currentQuantity;

                        decimal totalItemPrice = currentQuantity * food.Gia;
                        lblPrice.Text = totalItemPrice.ToString("N0");

                        UpdateTotalPrice();
                        return;
                    }
                }
            }

            // Nếu món chưa có trong giỏ, thêm mới như trước
            Panel panel = new Panel
            {
                Width = flpCart.Width - 5,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            Label lblFoodNameNew = new Label
            {
                Text = food.TenMonAn,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(5, 5)
            };

            Label lblQuantityNew = new Label
            {
                Text = "SL: 1",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(5, 25)
            };

            Label lblPriceNew = new Label
            {
                Text = food.Gia.ToString("N0"),
                Font = new Font("Arial", 10),
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(panel.Width - 100, 5)
            };

            Button btnRemove = new Button
            {
                Text = "X",
                Width = 30,
                Height = 30,
                Location = new Point(panel.Width - 40, 10),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnRemove.Click += (s, e) =>
            {
                int currentQuantity = int.Parse(lblQuantityNew.Text.Replace("SL: ", ""));

                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    lblQuantityNew.Text = "SL: " + currentQuantity;

                    // Cập nhật lại giá món này
                    decimal totalItemPrice = currentQuantity * food.Gia;
                    lblPriceNew.Text = totalItemPrice.ToString("N0");
                }
                else
                {
                    flpCart.Controls.Remove(panel);
                }

                UpdateTotalPrice();
            };

            panel.Controls.Add(lblFoodNameNew);
            panel.Controls.Add(lblQuantityNew);
            panel.Controls.Add(lblPriceNew);

            panel.Controls.Add(btnRemove);

            flpCart.Controls.Add(panel);
            UpdateTotalPrice();
        }

        //-------Phương thức cập nhật lại tổng tiền (Giỏ hàng)
        public void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (Control panel in flpCart.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Label lbl && lbl.ForeColor == Color.Red && !string.IsNullOrWhiteSpace(lbl.Text))
                    {
                        string priceText = lbl.Text.Replace(" VNĐ", "").Replace(",", "").Trim();

                        if (decimal.TryParse(priceText, out decimal price))
                        {
                            total += price;
                        }
                    }
                }
            }

            txbTongTien.Text = total.ToString("N0");
        }
        #endregion


        //--------- Phương thức tìm kiếm món ăn theo tên
        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbTimKiem.Text.Trim().ToLower();

            for (int i = 0; i < flpDichVu.Controls.Count - 1; i++)
            {
                // Tên loại (Label)
                if (flpDichVu.Controls[i] is Label lblLoai &&
                    flpDichVu.Controls[i + 1] is FlowLayoutPanel flpLoai)
                {
                    bool hasVisibleItem = false;

                    foreach (Control item in flpLoai.Controls)
                    {
                        if (item is ServiceItemUC uc && uc.Tag is DTO_MONAN mon)
                        {
                            bool match = mon.TenMonAn.ToLower().Contains(searchText);
                            uc.Visible = match;

                            if (match) hasVisibleItem = true;
                        }
                    }

                    // Ẩn/hiện cả nhóm
                    lblLoai.Visible = flpLoai.Visible = hasVisibleItem;
                }
            }
        }

        //---------- Phương thức xóa dữ liệu hiện tại của giỏ hàng
        private void btnResetGioHang_Click(object sender, EventArgs e)
        {
            if (flpCart.Controls.Count == 0)
            {
                return;
            }

            flpCart.Controls.Clear();
            txbTongTien.Text = "0 VNĐ";
        }
        //---------- Phương thức xóa dữ liệu hiện tại của thanh tìm kiếm
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }

        private void LoadTenLoaiVaoComboBox()
        {
            List<string> listLoai = DAO_LOAIMONAN.Instance.LayTatCaTenLoai();
            listLoai.Insert(0, "Tất cả"); // Thêm "Tất cả" vào đầu danh sách

            cbLoaiMonAn.DataSource = listLoai;
            cbLoaiMonAn.SelectedIndex = 0; // Chọn mặc định là "Tất cả"

        }

        #endregion


        #region Events


        //------lọc loại món ăn từ combobox
        private void cbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoai = cbLoaiMonAn.SelectedItem?.ToString();

            bool showAll = selectedLoai == "Tất cả";

            for (int i = 0; i < flpDichVu.Controls.Count - 1; i++)
            {
                Control control = flpDichVu.Controls[i];

                if (control is Label lbl)
                {
                    bool isMatch = showAll || lbl.Text.Equals(selectedLoai, StringComparison.OrdinalIgnoreCase);

                    lbl.Visible = isMatch;

                    // flp tiếp theo chính là FlowLayoutPanel con
                    if (i + 1 < flpDichVu.Controls.Count && flpDichVu.Controls[i + 1] is FlowLayoutPanel flpLoai)
                    {
                        flpLoai.Visible = isMatch;
                    }
                }
            }
        }

        //-------- sự kiện mở form phương thức thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmPhuongThucThanhToan f = new frmPhuongThucThanhToan();
            f.ShowDialog();
        }

        #endregion


    }
}
