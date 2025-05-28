using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        // Lưu ảnh vào thư mục Images trong dự án
        private string SaveImageToProjectFolder(string sourceFilePath)
        {
            string folder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string fileName = Path.GetFileName(sourceFilePath);
            string destPath = Path.Combine(folder, fileName);

            int count = 1;
            while (File.Exists(destPath))
            {
                string fileNameOnly = Path.GetFileNameWithoutExtension(fileName);
                string extension = Path.GetExtension(fileName);
                string newFileName = $"{fileNameOnly}({count}){extension}";
                destPath = Path.Combine(folder, newFileName);
                count++;
            }

            File.Copy(sourceFilePath, destPath);

            return "Images\\" + Path.GetFileName(destPath);
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
            string trailerUrl = tbTrailer.Text.Trim();
            //string posterUrl = tbPoster.Text.Trim();   
            string anh = AnhPhim.Text.Trim();



            // Kiểm tra thời lượng có phải số không
            if (!int.TryParse(tbThoiLuong.Text.Trim(), out int thoiLuong))
            {
                MessageBox.Show("Thời lượng phải là số.");
                return;
            }

            if (thoiLuong <= 60 || thoiLuong > 240)
            {
                MessageBox.Show("Thời lượng phim phải trên 60 phút và không vượt quá 240 phút.");
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

            if (cbLoaiphong.SelectedValue == null || !int.TryParse(cbLoaiphong.SelectedValue.ToString(), out int idDinhDang))
            {
                MessageBox.Show("Vui lòng chọn định dạng phim hợp lệ.");
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
                IDDinhDang = idDinhDang,
                Trailer_Url = trailerUrl, // nếu có
                /*Poster_Url = posterUrl,*/
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

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4;*.avi)|*.mp4;*.avi";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbTrailer.Text = openFileDialog.FileName;
            }
        }

        private void btnXemTrailer_Click(object sender, EventArgs e)
        {
            string trailerPath = tbTrailer.Text.Trim();

            if (!string.IsNullOrEmpty(trailerPath) && File.Exists(trailerPath))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = trailerPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Không tìm thấy trailer. Vui lòng kiểm tra lại đường dẫn.");
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string relativePath = SaveImageToProjectFolder(openFileDialog.FileName);

                // Hiển thị ảnh
                string fullPath = Path.Combine(Application.StartupPath, relativePath);
                AnhPhim.Image = Image.FromFile(fullPath);

                // Gắn đường dẫn tương đối vào Tag để lưu sau này
                AnhPhim.Tag = relativePath;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
