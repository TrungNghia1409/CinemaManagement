﻿using OGC.DAO;  // nhớ import DAO để dùng
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;       // dùng cho File.Exists
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace OGC.Phim
{
    public partial class frmQuanLyPhim : Form
    {
        private int currentPhimID;

        public frmQuanLyPhim()
        {
            InitializeComponent();

            dtgvPhim.CellClick += dtgvPhim_CellClick;

            LoadTheLoaiPhim();

            LoadDanhSachPhim();

            LoadDoTuoiToComboBox();

            LoadTrangThaiToComboBox();

            LoadDinhDangPhimToComboBox();

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);

        }

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


        // Load thể loại phim vào combo box
        private void LoadTheLoaiPhim()
        {
            DataTable dt = DAO_THELOAIPHIM.Instance.DanhSachTheLoaiPhim();

            List<DTO_THELOAIPHIM> list = new List<DTO_THELOAIPHIM>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO_THELOAIPHIM(row));
            }

            cbTheLoaiPhim.DataSource = list;
            cbTheLoaiPhim.DisplayMember = "TenTheLoai";
            cbTheLoaiPhim.ValueMember = "ID";
        }

        // Load độ tuổi vào combo box
        private void LoadDoTuoiToComboBox()
        {
            List<DTO_DoTuoi> ds = DAO_DoTuoi.Instance.DanhSachDoTuoi();
            cbDoTuoi.DataSource = ds;
            cbDoTuoi.DisplayMember = "TenDoTuoi";
            cbDoTuoi.ValueMember = "ID";
            cbDoTuoi.SelectedIndex = -1;
        }


        private void LoadTrangThaiToComboBox()
        {
            // Tạo danh sách các trạng thái
            var trangThaiList = new List<KeyValuePair<int, string>>
    {
        new KeyValuePair<int, string>(1, "Đang chiếu"),
        new KeyValuePair<int, string>(0, "Ngừng chiếu")
    };

            cbTrangThai.DataSource = new BindingSource(trangThaiList, null);
            cbTrangThai.DisplayMember = "Value";
            cbTrangThai.ValueMember = "Key";
        }

        private void LoadDinhDangPhimToComboBox()
        {
            DataTable dt = DAO_DINHDANGPHIM.Instance.DanhSachDinhDang();
            cbLoaiphong.DataSource = dt;
            cbLoaiphong.DisplayMember = "TenDinhDang";
            cbLoaiphong.ValueMember = "ID";
        }



        private void LoadDanhSachPhim()
        {
            List<PhimDTO> dsPhim = PhimDAO.Instance.GetAllPhim();
            dtgvPhim.DataSource = dsPhim;
            DinhDangDataGridView();
        }

        private void dtgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvPhim.Rows[e.RowIndex];

                currentPhimID = Convert.ToInt32(row.Cells["ID"].Value);
                tbTenPhim.Text = row.Cells["TenPhim"].Value?.ToString();
                tbThoiLuong.Text = row.Cells["ThoiLuong"].Value?.ToString();
                tbDaoDien.Text = row.Cells["DaoDien"].Value?.ToString();
                tbDienVien.Text = row.Cells["DienVien"].Value?.ToString();
                tbMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                if (row.Cells["IDDoTuoi"].Value != null)
                    cbDoTuoi.SelectedValue = row.Cells["IDDoTuoi"].Value.ToString();

                if (row.Cells["IDTheLoaiPhim"].Value != null)
                    cbTheLoaiPhim.SelectedValue = Convert.ToInt32(row.Cells["IDTheLoaiPhim"].Value);

                if (row.Cells["IDDinhDang"].Value != null)
                    cbLoaiphong.SelectedValue = Convert.ToInt32(row.Cells["IDDinhDang"].Value);

                if (row.Cells["NgayKhoiChieu"].Value != DBNull.Value)
                    dtpKhoiChieu.Value = Convert.ToDateTime(row.Cells["NgayKhoiChieu"].Value);
                else
                    dtpKhoiChieu.Value = DateTime.Now;

                if (row.Cells["TrangThai"].Value != null)
                {
                    int trangThai = Convert.ToInt32(row.Cells["TrangThai"].Value);
                    cbTrangThai.SelectedValue = trangThai;
                }

                if (row.Cells["IDDinhDang"].Value != null)
                {
                    cbLoaiphong.SelectedValue = Convert.ToInt32(row.Cells["IDDinhDang"].Value);
                }

                if (row.Cells["Trailer_Url"].Value != null)
                    tbTrailer.Text = row.Cells["Trailer_Url"].Value.ToString();

                // Hiển thị ảnh
                try
                {
                    string path = row.Cells["Anh"].Value?.ToString();
                    if (!string.IsNullOrEmpty(path))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, path);
                        if (File.Exists(fullPath))
                        {
                            using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            {
                                AnhPhim.Image = Image.FromStream(fs);
                            }
                        }
                        else
                        {
                            AnhPhim.Image = null;
                        }
                    }
                    else
                    {
                        AnhPhim.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                }

            }
        }

        private void DinhDangDataGridView()
        {
            dtgvPhim.Columns["ID"].HeaderText = "Mã phim";
            dtgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dtgvPhim.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dtgvPhim.Columns["DienVien"].HeaderText = "Diễn viên";
            dtgvPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng (phút)";
            dtgvPhim.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dtgvPhim.Columns["IDDoTuoi"].HeaderText = "Độ tuổi";
            dtgvPhim.Columns["Anh"].HeaderText = "Ảnh";
            dtgvPhim.Columns["Poster_Url"].HeaderText = "Poster";
            dtgvPhim.Columns["Trailer_Url"].HeaderText = "Trailer";
            dtgvPhim.Columns["MoTa"].HeaderText = "Mô tả";
            dtgvPhim.Columns["TrangThai"].HeaderText = "Trạng thái";
            dtgvPhim.Columns["IDTheLoaiPhim"].HeaderText = "Mã thể loại";
            dtgvPhim.Columns["IDDinhDang"].HeaderText = "Mã định dạng";
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool result = PhimDAO.Instance.DeletePhim(currentPhimID);
                if (result)
                {
                    MessageBox.Show("Xóa phim thành công");
                    LoadDanhSachPhim();
                }
                else
                {
                    MessageBox.Show("Xóa phim thất bại");
                }
            }
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            FrmThemPhim frmThemPhim = new FrmThemPhim();
            if (frmThemPhim.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachPhim();
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

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video files (*.mp4;*.avi)|*.mp4;*.avi";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbTrailer.Text = ofd.FileName;
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Chọn ảnh Poster";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    // Lưu ảnh vào thư mục dự án (Images) và lấy đường dẫn tương đối
                    string relativePath = SaveImageToProjectFolder(sourcePath);

                    // Hiển thị ảnh lên PictureBox
                    string fullPath = Path.Combine(Application.StartupPath, relativePath);
                    AnhPhim.Image = Image.FromFile(fullPath);

                    // Gắn đường dẫn ảnh (tương đối) vào Tag để lưu vào DB
                    AnhPhim.Tag = relativePath;
                }
            }
        }


        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            if (currentPhimID <= 0)
            {
                MessageBox.Show("Vui lòng chọn một phim để sửa.");
                return;
            }

            // Lấy phim cũ từ DB
            PhimDTO phimCu = PhimDAO.Instance.GetPhimByID(currentPhimID);
            if (phimCu == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phim cũ.");
                return;
            }

            // Lấy thông tin mới từ form
            string tenPhim = tbTenPhim.Text.Trim();
            string daoDien = tbDaoDien.Text.Trim();
            string dienVien = tbDienVien.Text.Trim();
            string moTa = tbMoTa.Text.Trim();
            string trailerUrl = tbTrailer.Text.Trim();
            string anh = AnhPhim.Tag != null ? AnhPhim.Tag.ToString() : "";

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

            if (cbTheLoaiPhim.SelectedValue == null || !int.TryParse(cbTheLoaiPhim.SelectedValue.ToString(), out int idTheLoai))
            {
                MessageBox.Show("Vui lòng chọn thể loại phim hợp lệ.");
                return;
            }

            if (cbDoTuoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độ tuổi hợp lệ.");
                return;
            }

            string idDoTuoi = cbDoTuoi.SelectedValue.ToString();

            if (cbLoaiphong.SelectedValue == null || !int.TryParse(cbLoaiphong.SelectedValue.ToString(), out int idDinhDang))
            {
                MessageBox.Show("Vui lòng chọn định dạng phim hợp lệ.");
                return;
            }

            int trangThai = ((KeyValuePair<int, string>)cbTrangThai.SelectedItem).Key;
            DateTime ngayKhoiChieu = dtpKhoiChieu.Value;

            PhimDTO phimMoi = new PhimDTO
            {
                ID = currentPhimID,
                TenPhim = tenPhim,
                DaoDien = daoDien,
                DienVien = dienVien,
                ThoiLuong = thoiLuong,
                NgayKhoiChieu = ngayKhoiChieu,
                IDDoTuoi = idDoTuoi,
                MoTa = moTa,
                TrangThai = trangThai,
                IDTheLoaiPhim = idTheLoai,
                Trailer_Url = trailerUrl,
                Anh = anh,
                IDDinhDang = idDinhDang
            };

            // So sánh và hiển thị sự thay đổi
            StringBuilder changes = new StringBuilder("Bạn đã thay đổi:\n");

            void SoSanhVaThem(string tenTruong, object cu, object moi)
            {
                if (!Equals(cu?.ToString().Trim(), moi?.ToString().Trim()))
                {
                    changes.AppendLine($"- {tenTruong}: \"{cu}\" → \"{moi}\"");
                }
            }

            SoSanhVaThem("Tên phim", phimCu.TenPhim, tenPhim);
            SoSanhVaThem("Đạo diễn", phimCu.DaoDien, daoDien);
            SoSanhVaThem("Diễn viên", phimCu.DienVien, dienVien);
            SoSanhVaThem("Thời lượng", phimCu.ThoiLuong, thoiLuong);
            SoSanhVaThem("Ngày khởi chiếu", phimCu.NgayKhoiChieu.ToShortDateString(), ngayKhoiChieu.ToShortDateString());
            SoSanhVaThem("Độ tuổi", phimCu.IDDoTuoi, idDoTuoi);
            SoSanhVaThem("Mô tả", phimCu.MoTa, moTa);
            SoSanhVaThem("Trạng thái", phimCu.TrangThai, trangThai);
            SoSanhVaThem("Thể loại", phimCu.IDTheLoaiPhim, idTheLoai);
            SoSanhVaThem("Trailer", phimCu.Trailer_Url, trailerUrl);
            SoSanhVaThem("Định dạng", phimCu.IDDinhDang, idDinhDang);

            // Xử lý riêng ảnh: nếu ảnh mới KHÁC ảnh cũ và ảnh mới KHÔNG RỖNG thì mới thêm dòng
            if (!string.IsNullOrWhiteSpace(anh) && !Equals(phimCu.Anh?.Trim(), anh.Trim()))
            {
                changes.AppendLine($"- Ảnh: \"{phimCu.Anh}\" → \"{anh}\"");
            }

            if (changes.ToString().Trim() == "Bạn đã thay đổi:")
            {
                MessageBox.Show("Không có thay đổi nào để lưu.");
                return;
            }

            // Hỏi xác nhận trước khi lưu
            DialogResult confirm = MessageBox.Show(changes.ToString() + "\n\nBạn có muốn lưu thay đổi không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Lưu thay đổi
            bool result = PhimDAO.Instance.UpdatePhim(phimMoi);

            if (result)
            {
                MessageBox.Show("Cập nhật phim thành công!");
                LoadDanhSachPhim();
            }
            else
            {
                MessageBox.Show("Cập nhật phim thất bại!");
            }
        }




    }
}
