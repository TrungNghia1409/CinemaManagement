using OGC.DAO;
using OGC.DTO;
using OGC.NHANVIEN;
using OGC.Phim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OGC
{
    public partial class frmChonPhim : Form
    {
        public frmChonPhim()
        {
            InitializeComponent();
            LoadPhimList(); // Gọi hàm LoadPhimList để tải danh sách phim
            LoadPhimTheoNgayChieu(dtpNgayChieu.Value.Date);
            LoadDinhDangPhimToComboBox();
            LoadTheLoaiPhim(); // Tải thể loại phim vào ComboBox

        }

        public void LoadPhimList()
        {
            fplHienThiPhim.Controls.Clear();
            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetAllPhim();

            foreach (PhimDTO phim in danhSachPhim)
            {
                AddPhimToFlowLayout(phim);
            }
        }



        private void LoadTheLoaiPhim()
        {
            List<DTO_THELOAIPHIM> list = DAO_THELOAIPHIM.Instance.ListTheLoaiPhim();

            // Thêm tùy chọn "Tất cả"
            list.Insert(0, new DTO_THELOAIPHIM { ID = 0, TenTheLoai = "Tất cả" });

            cbtheloaiphim.DataSource = list;
            cbtheloaiphim.DisplayMember = "TenTheLoai";
            cbtheloaiphim.ValueMember = "ID";

        }

        private void LoadDinhDangPhimToComboBox()
        {
            List<DTO_DINHDANGPHIM> list = DAO_DINHDANGPHIM.Instance.ListDinhDangPhim();

            // Thêm tùy chọn "Tất cả"
            list.Insert(0, new DTO_DINHDANGPHIM { ID = 0, TenDinhDang = "Tất cả" });

            cbdinhdang.DataSource = list;
            cbdinhdang.DisplayMember = "TenDinhDang";
            cbdinhdang.ValueMember = "ID";
        }





        #region Hiện phim lên fplHienThiPhim
        public void AddPhimToFlowLayout(PhimDTO phim)
        {
            Panel phimPanel = new Panel
            {
                Width = 180,
                Height = 270,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Tag = phim
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = 160,
                Height = 100,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };

            // Nối đường dẫn ảnh với thư mục chạy ứng dụng
            string fullPath = Path.Combine(Application.StartupPath, phim.Anh);

            if (!string.IsNullOrEmpty(phim.Anh) && File.Exists(fullPath))
            {
                using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(fs);
                }
            }
            else
            {
                pictureBox.Image = null;
                // hoặc pictureBox.Image = Properties.Resources.NoImage; // ảnh mặc định nếu có
            }



            fplHienThiPhim.Controls.Add(phimPanel);

            Label lblTenPhim = new Label
            {
                Text = phim.TenPhim,
                AutoSize = false,
                Width = 160,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            Label lblThoiLuong = new Label
            {
                Text = $"Thời lượng: {phim.ThoiLuong} phút",
                AutoSize = false,
                Width = 160,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9)
            };

            Label lblNgayKhoiChieu = new Label
            {
                Text = phim.NgayKhoiChieu > DateTime.MinValue
                    ? $"Khởi chiếu: {phim.NgayKhoiChieu:dd/MM/yyyy}"
                    : "Khởi chiếu: N/A",
                AutoSize = false,
                Width = 160,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(30, 30, 30)
            };

            Button btnChiTiet = new Button
            {
                Text = "Chi tiết",
                Width = 75,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Tag = phim
            };

            Button btnDatVe = new Button
            {
                Text = "Đặt vé",
                Width = 75,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGreen,
                Cursor = Cursors.Hand,
                Tag = phim
            };

            btnChiTiet.Click += btnChiTiet_Click;
            btnDatVe.Click += btnDatVe_Click;

            btnChiTiet.MouseEnter += (s, e) => btnChiTiet.BackColor = Color.Gray;
            btnChiTiet.MouseLeave += (s, e) => btnChiTiet.BackColor = Color.LightGray;

            btnDatVe.MouseEnter += (s, e) => btnDatVe.BackColor = Color.Green;
            btnDatVe.MouseLeave += (s, e) => btnDatVe.BackColor = Color.LightGreen;

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Width = 160,
                Height = 35,
                AutoSize = false,
                WrapContents = false
            };

            buttonPanel.Controls.Add(btnChiTiet);
            buttonPanel.Controls.Add(btnDatVe);

            FlowLayoutPanel container = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Width = 170,
                Height = 260,
                AutoSize = false,
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            container.Controls.Add(pictureBox);
            container.Controls.Add(lblTenPhim);
            container.Controls.Add(lblThoiLuong);
            container.Controls.Add(lblNgayKhoiChieu);
            container.Controls.Add(buttonPanel);

            phimPanel.Controls.Add(container);
            fplHienThiPhim.Controls.Add(phimPanel);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            PhimDTO phim = btn?.Tag as PhimDTO;

            if (phim != null)
            {
                fChiTietPhim formChiTiet = new fChiTietPhim(phim);
                formChiTiet.ShowDialog();
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            PhimDTO phim = btn?.Tag as PhimDTO;

            if (phim != null)
            {
                fDatVe formDatVe = new fDatVe();
                formDatVe.ShowDialog();
            }
        }


        #endregion

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbTimKiem.Text.Trim().ToLower();

            foreach (Control control in fplHienThiPhim.Controls)
            {
                if (control is Panel panel)
                {
                    // Tìm FlowLayoutPanel bên trong Panel (giả sử là nơi chứa Label tên phim)
                    FlowLayoutPanel innerPanel = panel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                    if (innerPanel != null)
                    {
                        // Tìm Label tên phim bên trong
                        Label lblTenPhim = innerPanel.Controls.OfType<Label>().FirstOrDefault();
                        if (lblTenPhim != null)
                        {
                            panel.Visible = lblTenPhim.Text.ToLower().Contains(searchText);
                        }
                    }
                }
            }
        }

        private void LoadPhimTheoNgayChieu(DateTime ngayChieu)
        {
            fplHienThiPhim.Controls.Clear();

            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetPhimByNgayChieu(ngayChieu);

            foreach (PhimDTO phim in danhSachPhim)
            {
            
                AddPhimToFlowLayout(phim);
            }
        }


        private void cbtheloaiphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (DTO_THELOAIPHIM)cbtheloaiphim.SelectedItem;
            if (selected.ID == 0) // Tất cả
            {
                LoadPhimList();
            }
            else
            {
                LoadPhimTheoIDTheLoai(selected.ID);
            }
        }
        private void LoadPhimTheoIDTheLoai(int idTheLoai)
        {
            fplHienThiPhim.Controls.Clear();

            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetPhimByIDTheLoai(idTheLoai);

            foreach (PhimDTO phim in danhSachPhim)
            {
                AddPhimToFlowLayout(phim); // Giả sử bạn có phương thức này
            }
        }

        private void cbdinhdang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dinhDang = (DTO_DINHDANGPHIM)cbdinhdang.SelectedItem;
            if (dinhDang.ID == 0) // Tất cả
            {
                LoadPhimList();
            }
            else
            {
                LoadPhimTheoIDDinhDang(dinhDang.ID);
            }
        }

        private void LoadPhimTheoIDDinhDang(int idTheLoai)
        {
            fplHienThiPhim.Controls.Clear();

            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetPhimByIDDinhDang(idTheLoai);

            foreach (PhimDTO phim in danhSachPhim)
            {
                AddPhimToFlowLayout(phim); // Giả sử bạn có phương thức này
            }
        }
    }
}


