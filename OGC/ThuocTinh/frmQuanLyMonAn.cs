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
    public partial class frmQuanLyMonAn : Form
    {
        public frmQuanLyMonAn()
        {
            InitializeComponent();
            LoadDanhSachMonAn();
            HienThiMonAn();
            LoadLoaiMonAn();
            dtgvMonAn.CellClick += dtgvMonAn_CellClick;

        }

        private void LoadDanhSachMonAn()
        {
            HienThiMonAn();

            tbTenMonAn.Clear();
            tbGiaMonAn.Clear();
            tbMoTaMonAn.Clear();
            cbLoaiMonAn.SelectedIndex = -1;
            AnhDoAn.Image = null;
            AnhDoAn.Tag = null;
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

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Chọn ảnh món ăn"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    AnhDoAn.Image = Image.FromFile(filePath);
                    AnhDoAn.Tag = SaveImageToProjectFolder(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                }
            }
        }


        private void HienThiMonAn()
        {
            // Gọi DAO để lấy dữ liệu
            Dictionary<string, List<DTO_MONAN>> dsMonTheoLoai = DAO_MONAN.Instance.LayTatCaMonAnTheoLoai();

            // Tạo DataTable tạm để hiển thị lên DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tên Món Ăn", typeof(string));
            dt.Columns.Add("Thể Loại", typeof(string));
            dt.Columns.Add("Giá", typeof(decimal));
            dt.Columns.Add("Mô Tả", typeof(string));
            dt.Columns.Add("Ảnh", typeof(string));

            foreach (var pair in dsMonTheoLoai)
            {
                string tenLoai = pair.Key;
                foreach (var mon in pair.Value)
                {
                    dt.Rows.Add(mon.ID, mon.TenMonAn, tenLoai, mon.Gia, mon.MoTa, mon.Anh);
                }
            }

            dtgvMonAn.DataSource = dt;
        }
        private void LoadLoaiMonAn()
        {
            string query = "SELECT ID, TenLoai FROM LOAIMONAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            cbLoaiMonAn.DataSource = dt;
            cbLoaiMonAn.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cbLoaiMonAn.ValueMember = "ID";         // Giá trị thực là ID
        }


        private void dtgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvMonAn.Rows[e.RowIndex];

                tbTenMonAn.Text = row.Cells["Tên Món Ăn"].Value?.ToString();
                tbGiaMonAn.Text = row.Cells["Giá"].Value?.ToString();
                tbMoTaMonAn.Text = row.Cells["Mô Tả"].Value?.ToString();

                // Lấy tên loại món ăn từ cột "Thể Loại"
                string tenLoai = row.Cells["Thể Loại"].Value?.ToString();

                if (!string.IsNullOrEmpty(tenLoai))
                {
                    // Tìm item trong cbLoaiMonAn có DisplayMember bằng tenLoai và chọn nó
                    for (int i = 0; i < cbLoaiMonAn.Items.Count; i++)
                    {
                        DataRowView drv = cbLoaiMonAn.Items[i] as DataRowView;
                        if (drv != null && drv["TenLoai"].ToString() == tenLoai)
                        {
                            cbLoaiMonAn.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Xử lý ảnh
                string path = row.Cells["Ảnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, path);
                        if (File.Exists(fullPath))
                        {
                            AnhDoAn.Image = Image.FromFile(fullPath);
                        }
                        else
                        {
                            AnhDoAn.Image = null;
                        }
                    }
                    catch
                    {
                        AnhDoAn.Image = null;
                    }

                    AnhDoAn.Tag = path;
                }
                else
                {
                    AnhDoAn.Image = null;
                }
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            frmThemMonAn frm = new frmThemMonAn();
            frm.ShowDialog();
            LoadDanhSachMonAn();
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (dtgvMonAn.CurrentRow != null)
            {
                string tenCu = dtgvMonAn.CurrentRow.Cells["Tên Món Ăn"].Value?.ToString().Trim();

                string ten = tbTenMonAn.Text.Trim();
                string giaText = tbGiaMonAn.Text.Trim();
                string moTa = tbMoTaMonAn.Text.Trim();
                string anh = AnhDoAn.Tag?.ToString() ?? "";

                // Kiểm tra dữ liệu đầu vào
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
                    MessageBox.Show("Giá phải là số hợp lệ và lớn hơn hoặc bằng 0.");
                    return;
                }

                if (string.IsNullOrEmpty(moTa))
                {
                    MessageBox.Show("Vui lòng nhập mô tả món ăn.");
                    return;
                }

                // Kiểm tra có thay đổi dữ liệu không
                if (ten == tenCu
                    && decimal.TryParse(dtgvMonAn.CurrentRow.Cells["Giá"].Value?.ToString(), out decimal giaCu) && gia == giaCu
                    && moTa == dtgvMonAn.CurrentRow.Cells["Mô Tả"].Value?.ToString().Trim()
                    && anh == (dtgvMonAn.CurrentRow.Cells["Ảnh"].Value?.ToString() ?? ""))
                {
                    MessageBox.Show("Bạn chưa thay đổi gì!");
                    return;
                }

                if (!string.IsNullOrEmpty(anh) && !File.Exists(Path.Combine(Application.StartupPath, anh)) && File.Exists(anh))
                {
                    anh = SaveImageToProjectFolder(anh);
                }

                int id = (int)dtgvMonAn.CurrentRow.Cells["ID"].Value;
                int idLoai = (int)cbLoaiMonAn.SelectedValue;

                if (DAO_MONAN.Instance.SuaMonAn(id, ten, idLoai, gia, moTa, anh))
                {
                    MessageBox.Show("Sửa món ăn thành công!");
                    HienThiMonAn();
                    LoadDanhSachMonAn();
                }
                else
                {
                    MessageBox.Show("Sửa món ăn thất bại!");
                }
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (dtgvMonAn.CurrentRow != null)
            {
                int id = (int)dtgvMonAn.CurrentRow.Cells["ID"].Value;

                if (MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (DAO_MONAN.Instance.XoaMonAn(id))
                    {
                        MessageBox.Show("Xóa món ăn thành công!");
                        LoadDanhSachMonAn();
                        HienThiMonAn();
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn thất bại!");
                    }
                }
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
    }
}
