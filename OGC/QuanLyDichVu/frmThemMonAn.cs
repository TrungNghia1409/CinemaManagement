using OGC.DAO;
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
    public partial class frmThemMonAn : Form
    {
        public frmThemMonAn()
        {
            InitializeComponent();
            LoadLoaiMonAn();
        }

        private void LoadLoaiMonAn()
        {
            string query = "SELECT ID, TenLoai FROM LOAIMONAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            cbLoaiMonAn.DataSource = dt;
            cbLoaiMonAn.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cbLoaiMonAn.ValueMember = "ID";         // Giá trị thực là ID
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = tbTenMonAn.Text.Trim();
            string giaText = tbGiaMonAn.Text.Trim();
            string moTa = tbMoTaMonAn.Text.Trim();
            string anh = AnhDoAn.Tag?.ToString() ?? "";

            // Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn.");
                return;
            }

            if (string.IsNullOrEmpty(giaText))
            {
                MessageBox.Show("Vui lòng nhập giá món ăn.");
                return;
            }

            if (!decimal.TryParse(giaText, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Giá món ăn phải là một số hợp lệ và lớn hơn hoặc bằng 0.");
                return;
            }

            if (string.IsNullOrEmpty(moTa))
            {
                MessageBox.Show("Vui lòng nhập mô tả món ăn.");
                return;
            }

            if (string.IsNullOrEmpty(anh) || !File.Exists(anh))
            {
                MessageBox.Show("Vui lòng tải ảnh món ăn.");
                return;
            }

            int idLoai = (int)cbLoaiMonAn.SelectedValue;

            // Copy ảnh vào thư mục dự án nếu cần
            string anhRelative = SaveImageToProjectFolder(anh);

            // Gọi DAO thêm món
            if (DAO_MONAN.Instance.ThemMonAn(ten, idLoai, gia, moTa, anhRelative))
            {
                MessageBox.Show("Thêm món ăn thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!");
            }
        }

        private void btnTaiAnhMonAn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string relativePath = SaveImageToProjectFolder(openFileDialog.FileName);

                // Hiển thị ảnh
                string fullPath = Path.Combine(Application.StartupPath, relativePath);
                AnhDoAn.Image = Image.FromFile(fullPath);

                // Gắn đường dẫn tương đối vào Tag để lưu sau này
                AnhDoAn.Tag = relativePath;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
