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
        }
        //private void LoadComboBoxLoaiPhong()
        //{
        //    // Load danh sách loại phòng vào combobox
        //    cbLoaiPhong.DataSource = DAO_LOAIPHONG.Instance.LayDanhSachLoaiPhong();
        //    cbLoaiPhong.DisplayMember = "Value";
        //    cbLoaiPhong.ValueMember = "Key";

        //    // Gán giá trị SelectedValue theo id loại phòng
        //    cbLoaiPhong.SelectedValue = phong.MaLoaiPhong;
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    string tenPhong = tbTenPhong.Text.Trim();
        //    int sucChua = int.Parse(tbSucChua.Text);
        //    int trangThai = cbTrangThai.SelectedIndex; // 0: Trống, 1: Đang chiếu
        //    int maLoaiPhong = (int)bl1.SelectedValue;
        //    string anhPhong = tbAnhPhong.Text.Trim();

        //    if (string.IsNullOrEmpty(tenPhong))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    DTO_PHONGCHIEU phong = new DTO_PHONGCHIEU
        //    {
        //        TenPhong = tenPhong,
        //        SucChua = sucChua,
        //        TrangThai = trangThai,
        //        MaLoaiPhong = maLoaiPhong,
        //        AnhPhong = anhPhong
        //    };

        //    bool thanhCong = DAO_PHONGCHIEU.Instance.ThemPhongChieu(phong);
        //    if (thanhCong)
        //    {
        //        MessageBox.Show("Thêm phòng chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Close(); // hoặc gọi sự kiện Load lại danh sách
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm phòng chiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
