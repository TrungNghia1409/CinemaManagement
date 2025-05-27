using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace OGC.Phim
{
    public partial class FrmThemPhim : Form
    {
        public FrmThemPhim()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            // Load thể loại phim
            cbTheLoaiPhim.DataSource = DAO_THELOAIPHIM.Instance.DanhSachTheLoaiPhim();
            cbTheLoaiPhim.DisplayMember = "TenTheLoai";
            cbTheLoaiPhim.ValueMember = "ID";

            // Load độ tuổi
            cbDoTuoi.DataSource = DAO_DoTuoi.Instance.DanhSachDoTuoi();
            cbDoTuoi.DisplayMember = "TenDoTuoi";
            cbDoTuoi.ValueMember = "ID";

            // Trạng thái
            cbTrangThai.DataSource = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Đang chiếu"),
                new KeyValuePair<int, string>(0, "Ngừng chiếu")
            };
            cbTrangThai.DisplayMember = "Value";
            cbTrangThai.ValueMember = "Key";

            // định dạng
            cbLoaiphong.DataSource = DAO_DINHDANGPHIM.Instance.DanhSachDinhDang();
            cbLoaiphong.DisplayMember = "TenDinhDang";
            cbLoaiphong.ValueMember = "ID";

        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string tenPhim = tbTenPhim.Text.Trim();
            string daoDien = tbDaoDien.Text.Trim();
            string dienVien = tbDienVien.Text.Trim();
            string moTa = tbMoTa.Text.Trim();
            string trailerUrl = "";       // textbox chứa link trailer
            string posterUrl = "";         // textbox chứa link poster
            string anh = "";                     // textbox chứa link ảnh hoặc đường dẫn ảnh



            // Kiểm tra thời lượng có phải số không
            if (!int.TryParse(tbThoiLuong.Text.Trim(), out int thoiLuong))
            {
                MessageBox.Show("Thời lượng phải là số.");
                return;
            }

            // Kiểm tra SelectedValue không null trước khi chuyển kiểu
            if (cbTheLoaiPhim.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại phim hợp lệ.");
                return;
            }
            if (cbDoTuoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độ tuổi hợp lệ.");
                return;
            }

            // Ép kiểu trực tiếp nếu chắc chắn kiểu dữ liệu là int
            int idTheLoai = 0;

            // Lấy idTheLoai an toàn
            if (cbTheLoaiPhim.SelectedValue == null || !int.TryParse(cbTheLoaiPhim.SelectedValue.ToString(), out idTheLoai))
            {
                MessageBox.Show("Vui lòng chọn thể loại phim hợp lệ.");
                return;
            }

            string doTuoiChon = DAO_DoTuoi.Instance.DanhSachIDDoTuoi(cbDoTuoi.Text);

            string idDoTuoi = doTuoiChon;

            if (string.IsNullOrEmpty(idDoTuoi))
            {
                MessageBox.Show("Vui lòng chọn độ tuổi hợp lệ.");
                return;
            }


            // Lấy trạng thái từ combobox trạng thái
            int trangThai = ((KeyValuePair<int, string>)cbTrangThai.SelectedItem).Key;

            // Lấy ngày khởi chiếu
            DateTime ngayKhoiChieu = dtpKhoiChieu.Value;

            // Tạo DTO và gọi insert
            bool result = PhimDAO.Instance.InsertPhim(new PhimDTO
            {
                TenPhim = tenPhim,
                DaoDien = daoDien,
                DienVien = dienVien,
                ThoiLuong = thoiLuong,
                NgayKhoiChieu = ngayKhoiChieu,
                IDDoTuoi = idDoTuoi.ToString(), 
                MoTa = moTa,
                TrangThai = trangThai,
                IDTheLoaiPhim = idTheLoai,
                Trailer_Url = trailerUrl, // nếu có
                Poster_Url = posterUrl,   // nếu có
                Anh = anh,         // nếu có
                // IDDinhDang = idDinhDang, nếu có
            });

            if (result)
            {
                MessageBox.Show("Thêm phim thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại!");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
