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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OGC.NHANVIEN
{
    public partial class frmThongTinNhanVien : Form
    {
        private string duongDanAnh = ""; // Lưu đường dẫn ảnh được chọn
        public frmThongTinNhanVien(DTO_NHANVIEN nhanVien)
        {
            InitializeComponent();


            // Hiển thị thông tin ra các control
            txbID.Text = nhanVien.ID.ToString();
            txbTaiKhoan.Text = nhanVien.Username;
            txbChucVu.Text = nhanVien.TenChucVu;
            txbHoTen.Text = nhanVien.HoTen;
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            txbGioiTinh.Text = nhanVien.GioiTinh;
            txbSDT.Text = nhanVien.SDT;
            txbEmail.Text = nhanVien.Email;
            txbDiaChi.Text = nhanVien.DiaChi;


        }

        #region Methods
        //------- Phương thức sửa thông tin nhân viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> danhSachChucVu = DAO_CHUCVU.Instance.DanhSachChucVu_List();

                if (!danhSachChucVu.Contains(txbChucVu.Text))
                {
                    MessageBox.Show("Chức vụ không tồn tại. Vui lòng nhập đúng tên chức vụ có trong hệ thống.");
                    return;
                }

                // Kiểm tra số điện thoại
                string sDT = txbSDT.Text;
                if (sDT.Length != 10 || !sDT.StartsWith("0"))
                {
                    MessageBox.Show("Số điện thoại phải có 10 ký tự và bắt đầu bằng số 0.");
                    return;
                }

                // Kiểm tra email
                string email = txbEmail.Text;
                if (!email.EndsWith("@gmail.com") || email.IndexOf('@') != email.LastIndexOf('@'))
                {
                    MessageBox.Show("Email phải có định dạng @gmail.com và chỉ chứa một ký tự @.");
                    return;
                }

                // Kiểm tra ngày sinh
                DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
                if (ngaySinh.Year > 2005)
                {
                    MessageBox.Show("Ngày sinh phải từ năm 2005 trở về trước.");
                    return;
                }

                // Nếu hợp lệ thì mới tiếp tục sửa nhân viên
                string username = txbTaiKhoan.Text;
                string hoTen = txbHoTen.Text;

                string gioiTinh = txbGioiTinh.Text;

                string diaChi = txbDiaChi.Text;
                string tenChucVu = txbChucVu.Text;

                // Gọi DAO để cập nhật thông tin
                bool isUpdated = DAO_NHANVIEN.Instance.SuaNhanVien(username, hoTen, ngaySinh, gioiTinh, sDT, email, diaChi, tenChucVu, duongDanAnh);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                    frmNhanVien.Instance?.LoadNhanVien();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy tài khoản nhân viên đăng nhập từ frmMain
            frmMain mainForm = Application.OpenForms["frmMain"] as frmMain;
            string tklogin = mainForm.GetUsername();

            string username = txbTaiKhoan.Text;

            int id = int.Parse(txbID.Text);

            if (txbTaiKhoan.Text == tklogin)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    // Gọi DAO để xóa nhân viên
                    bool isDeleted = DAO_NHANVIEN.Instance.XoaNhanVien(username);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        frmNhanVien.Instance?.LoadNhanVien();
                        this.Close(); // Đóng form thông tin sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
#endregion

        #region Events
        //-------- sự kiện chọn ảnh nhân viên
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\";

            // Kiểm tra thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo hộp thoại chọn file
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Thiết lập thư mục mở ban đầu
                openFileDialog.InitialDirectory = folderPath;

                // Bộ lọc file (chỉ hiện các file ảnh)
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Tiêu đề của hộp thoại
                openFileDialog.Title = "Chọn ảnh";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    string selectedFilePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    ptbAnhNV.Image = Image.FromFile(selectedFilePath);
                    ptbAnhNV.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh vừa với khung

                    duongDanAnh = selectedFilePath; // Gán vào biến toàn cục
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở thư mục. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
