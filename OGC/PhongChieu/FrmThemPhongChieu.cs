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
    public partial class FrmThemPhongChieu : Form
    {
        public FrmThemPhongChieu()
        {
            InitializeComponent();

            string currentUsername = DAO_TKNHANVIEN.Instance.LayUsernameDangDangNhap();
            DAO_LogNhanVien.Instance.SetContext_Username(currentUsername);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenPhong = tbTenPhong.Text.Trim();

                if (cbLoaiPhong.SelectedItem == null || cbTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                    return;
                }

                DTO_LOAIPHONG selectedLoai = cbLoaiPhong.SelectedItem as DTO_LOAIPHONG;

                DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU
                {
                    TenPhong = tenPhong,
                    MaLoaiPhong = selectedLoai.ID,
                    TrangThai = Convert.ToInt32(cbTrangThai.SelectedItem),
                    AnhPhong = "" // Hoặc gán từ tbAnh nếu có
                };

                bool result = DAO_PHONGCHIEU.Instance.ThemPhongChieu(phong);

                if (result)
                {
                    MessageBox.Show("Thêm phòng chiếu thành công!");
                    this.DialogResult = DialogResult.OK;  // Quan trọng để báo cho form cha biết
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phòng chiếu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmThemPhongChieu_Load(object sender, EventArgs e)
        {
            cbLoaiPhong.DataSource = DAO_LOAIPHONG.Instance.LoadAllTenLoaiPhong(); // List<DTO_LOAIPHONG>
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "ID";

            cbTrangThai.Items.Add("0"); // 0 = Tạm ngưng
            cbTrangThai.Items.Add("1"); // 1 = Đang hoạt động
            cbTrangThai.SelectedIndex = 0;
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedItem != null)
            {
                DTO_LOAIPHONG selectedLoai = cbLoaiPhong.SelectedItem as DTO_LOAIPHONG;

                if (selectedLoai != null)
                {
                    tbMaLoaiPhong.Text = selectedLoai.ID.ToString();
                    tbSucChua.Text = selectedLoai.SucChua.ToString();
                }
            }
        }
    }
}
