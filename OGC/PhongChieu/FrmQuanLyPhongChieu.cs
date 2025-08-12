using DocumentFormat.OpenXml.Office2010.Excel;
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

namespace OGC.PhongChieu
{
    public partial class FrmQuanLyPhongChieu : Form
    {
        public FrmQuanLyPhongChieu()
        {
            InitializeComponent();
            Initialize();

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);

        }

        public void Initialize()
        {
            LoadPhongChieuToDataGridView();
            LoadDanhSachLoaiPhong();
            dtgPhongChieu.CellClick += dtgPhongChieu_CellClick;

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add(0);
            cbTrangThai.Items.Add(1);
        }

        public void ReloadDataGridView()
        {
            var danhSachPhong = DAO_PHONGCHIEU.Instance.DanhSachPhongChieu();
            dtgPhongChieu.DataSource = null;  // Reset trước khi gán lại để tránh lỗi
            dtgPhongChieu.DataSource = danhSachPhong;

            dtgPhongChieu.Columns["ID"].HeaderText = "Mã Phòng";
            dtgPhongChieu.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dtgPhongChieu.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgPhongChieu.Columns["MaLoaiPhong"].HeaderText = "Mã Loại Phòng";
            dtgPhongChieu.Columns["AnhPhong"].Visible = false;
        }

        private void LoadDanhSachLoaiPhong()
        {
            List<DTO_LOAIPHONG> danhSachLoaiPhong = DAO_LOAIPHONG.Instance.LoadAllTenLoaiPhong();

            cbLoaiPhong.DataSource = danhSachLoaiPhong;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "ID";
            cbLoaiPhong.SelectedIndex = -1; // chưa chọn gì
        }


        private void LoadSucChuaTheoMaLoaiPhong()
        {
            if (int.TryParse(tbMaLoaiPhong.Text.Trim(), out int idLoaiPhong))
            {
                int sucChua = DAO_LOAIPHONG.Instance.LaySucChuaTheoIDLoaiPhong(idLoaiPhong);
                if (sucChua >= 0)
                    tbSucChua.Text = sucChua.ToString();
                else
                    tbSucChua.Text = ""; // hoặc thông báo không tìm thấy
            }
            else
            {
                tbSucChua.Text = "";
            }
        }




        public void LoadPhongChieuToDataGridView()
        {
            var danhSachPhong = DAO_PHONGCHIEU.Instance.DanhSachPhongChieu();
            dtgPhongChieu.DataSource = danhSachPhong;

            dtgPhongChieu.Columns["ID"].HeaderText = "Mã Phòng";
            dtgPhongChieu.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dtgPhongChieu.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgPhongChieu.Columns["MaLoaiPhong"].HeaderText = "Mã Loại Phòng";
            dtgPhongChieu.Columns["AnhPhong"].Visible = false;
        }

        private void dtgPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgPhongChieu.Rows[e.RowIndex];
                tbID.Text = row.Cells["ID"].Value.ToString();
                tbTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                tbMaLoaiPhong.Text = row.Cells["MaLoaiPhong"].Value.ToString();
                int trangThai = Convert.ToInt32(row.Cells["TrangThai"].Value);
                cbTrangThai.SelectedIndex = cbTrangThai.Items.IndexOf(trangThai);

                // Đặt cbLoaiPhong chọn đúng loại phòng dựa vào MaLoaiPhong
                if (int.TryParse(tbMaLoaiPhong.Text, out int maLoaiPhong))
                {
                    cbLoaiPhong.SelectedValue = maLoaiPhong;
                }

                LoadSucChuaTheoMaLoaiPhong();
            }
        }





        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemPhongChieu frmThemPhongChieu = new FrmThemPhongChieu();
            if (frmThemPhongChieu.ShowDialog() == DialogResult.OK)
            {
                ReloadDataGridView();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn phòng chiếu nào chưa (có ID chưa)
                if (string.IsNullOrEmpty(tbID.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu để sửa.");
                    return;
                }

                // Lấy dữ liệu từ form
                int id = int.Parse(tbID.Text);
                string tenPhong = tbTenPhong.Text.Trim();
                int trangThai = cbTrangThai.SelectedItem != null ? Convert.ToInt32(cbTrangThai.SelectedItem) : 0;
                int maLoaiPhong = 0;
                if (!int.TryParse(tbMaLoaiPhong.Text, out maLoaiPhong))
                {
                    MessageBox.Show("Mã loại phòng không hợp lệ.");
                    return;
                }
                string anhPhong = ""; // Bạn có thể gán từ textbox ảnh nếu có

                // Tạo đối tượng DTO_PHONGCHIEU để sửa
                DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU
                {
                    ID = id,
                    TenPhong = tenPhong,
                    TrangThai = trangThai,
                    MaLoaiPhong = maLoaiPhong,
                    AnhPhong = anhPhong
                };

                // Gọi DAO để sửa
                bool result = DAO_PHONGCHIEU.Instance.SuaPhongChieu(phong);

                if (result)
                {
                    MessageBox.Show("Sửa phòng chiếu thành công!");
                    ReloadDataGridView(); // Load lại dữ liệu lên DataGridView
                }
                else
                {
                    MessageBox.Show("Sửa phòng chiếu thất bại!");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbID.Clear();
            tbTenPhong.Clear();
            tbMaLoaiPhong.Clear();
            tbSucChua.Clear();
            cbLoaiPhong.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbID.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu để xóa.");
                    return;
                }

                int id;
                if (!int.TryParse(tbID.Text, out id))
                {
                    MessageBox.Show("Mã phòng chiếu không hợp lệ.");
                    return;
                }

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bool result = DAO_PHONGCHIEU.Instance.XoaPhongChieu(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa phòng chiếu thành công!");
                        ReloadDataGridView();
                        ClearForm(); // Hàm xóa trắng form, bạn có thể tự định nghĩa
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng chiếu thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
