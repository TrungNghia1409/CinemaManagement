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
        private string currentUser;

        public frmChonPhim(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadPhimList(); // Gọi hàm LoadPhimList để tải danh sách phim
            LoadPhimTheoNgayChieu(dtpChonNgayChieu.Value.Date);
            LoadDinhDangPhimToComboBox();
            LoadTheLoaiPhim();
            LoadPhimTheoBoLoc(); // Tải thể loại phim vào ComboBox
        }

        public void LoadPhimList()
        {
            fplHienThiPhim.Controls.Clear();
            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetAllPhim();

            if (danhSachPhim == null || danhSachPhim.Count == 0)
            {
                AddNoShowMessage();
            }
            else
            {
                foreach (PhimDTO phim in danhSachPhim)
                {
                    AddPhimToFlowLayout(phim);
                }
            }
        }

        private void LoadPhimTheoBoLoc()
        {
            fplHienThiPhim.Controls.Clear();

            DateTime ngayChieu = chbTatCaNgay.Checked ? DateTime.MinValue : dtpChonNgayChieu.Value.Date;
            int idTheLoai = (cbtheloaiphim.SelectedItem as DTO_THELOAIPHIM)?.ID ?? 0;
            int idDinhDang = (cbdinhdang.SelectedItem as DTO_DINHDANGPHIM)?.ID ?? 0;
            string tuKhoa = txbTimKiem.Text.Trim().ToLower();

            List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetPhimTheoBoLoc(ngayChieu, idTheLoai, idDinhDang, tuKhoa);

            if (danhSachPhim == null || danhSachPhim.Count == 0)
            {
                AddNoShowMessage();
            }
            else
            {
                foreach (PhimDTO phim in danhSachPhim)
                {
                    AddPhimToFlowLayout(phim);
                }
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
            }

            Label lblTenPhim = new Label
            {
                Text = phim.TenPhim,
                AutoSize = false,
                Width = 160,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)  // chữ xám đậm, dễ nhìn
            };

            Label lblThoiLuong = new Label
            {
                Text = $"Thời lượng: {phim.ThoiLuong} phút",
                AutoSize = false,
                Width = 160,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(90, 90, 90)  // chữ xám vừa phải
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
                ForeColor = Color.FromArgb(110, 110, 110) // xám nhạt hơn
            };

            // Tạo nút Chi tiết & Đặt vé giống nhau về kích thước, font, flatstyle, cursor
            Button btnChiTiet = new Button
            {
                Text = "Chi tiết",
                Width = 75,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = phim,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                BackColor = Color.FromArgb(220, 220, 220), // xám sáng
                ForeColor = Color.FromArgb(50, 50, 50)     // chữ xám đậm
            };
            btnChiTiet.FlatAppearance.BorderSize = 0;

            Button btnDatVe = new Button
            {
                Text = "Đặt vé",
                Width = 75,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = phim,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(135, 196, 86), // xanh lá sáng hơn lightgreen
                ForeColor = Color.White
            };
            btnDatVe.FlatAppearance.BorderSize = 0;

            // Hover effect giống nhau cho 2 nút
            btnChiTiet.MouseEnter += (s, e) => btnChiTiet.BackColor = Color.FromArgb(200, 200, 200);
            btnChiTiet.MouseLeave += (s, e) => btnChiTiet.BackColor = Color.FromArgb(220, 220, 220);

            btnDatVe.MouseEnter += (s, e) => btnDatVe.BackColor = Color.FromArgb(110, 160, 50); // đậm hơn chút khi hover
            btnDatVe.MouseLeave += (s, e) => btnDatVe.BackColor = Color.FromArgb(135, 196, 86);

            btnChiTiet.Click += btnChiTiet_Click;
            btnDatVe.Click += btnDatVe_Click;

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

        private void AddNoShowMessage()
        {
            Label lblNoShow = new Label
            {
                Text = "Không có suất chiếu nào",
                AutoSize = false,
                Width = 300,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 128, 128) 
            };

            // Tạo một panel để căn giữa thông báo trong FlowLayoutPanel
            Panel messagePanel = new Panel
            {
                Width = fplHienThiPhim.Width,
                Height = 100,
                AutoSize = false
            };
            messagePanel.Controls.Add(lblNoShow);
            lblNoShow.Location = new Point((messagePanel.Width - lblNoShow.Width) / 2, (messagePanel.Height - lblNoShow.Height) / 2);

            fplHienThiPhim.Controls.Add(messagePanel);
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
                string tenPhim = phim.TenPhim;
                frmChonNgayChieu frm = new frmChonNgayChieu(tenPhim, currentUser);

                // Đưa frmChonPhim ra sau
                this.SendToBack();

                // Khi form mới đóng thì đưa frmChonPhim lên lại
                frm.FormClosed += (s, ev) =>
                {
                    this.BringToFront();
                };

                frm.Show(); // Không set owner, không ShowDialog
            }
        }


        #endregion

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadPhimTheoBoLoc();
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


        private void dtpChonNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            LoadPhimTheoNgayChieu(dtpChonNgayChieu.Value.Date);
        }

        private void cbdinhdang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadPhimTheoBoLoc();
        }

        private void cbtheloaiphim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadPhimTheoBoLoc();
        }

        private void chbTatCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhimTheoBoLoc();
        }
    }
}


