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

namespace OGC.PhongChieu
{
    public partial class FrmQuanLyPhongChieu : Form
    {
        public FrmQuanLyPhongChieu()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            LoadPhongChieuToDataGridView(dtgPhongChieu);
            dtgPhongChieu.CellClick += dtgPhongChieu_CellClick;

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add(0);
            cbTrangThai.Items.Add(1);
        }

        public void LoadPhongChieuToDataGridView(DataGridView dtgPhongChieu)
        {
            var danhSachPhong = DAO_PHONGCHIEU.Instance.DanhSachPhongChieu();
            dtgPhongChieu.DataSource = danhSachPhong;

            dtgPhongChieu.Columns["ID"].HeaderText = "Mã Phòng";
            dtgPhongChieu.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dtgPhongChieu.Columns["SucChua"].HeaderText = "Sức Chứa";
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
                tbSucChua.Text = row.Cells["SucChua"].Value.ToString();
                tbMaLoaiPhong.Text = row.Cells["MaLoaiPhong"].Value.ToString();

                int trangThai = Convert.ToInt32(row.Cells["TrangThai"].Value);
                cbTrangThai.SelectedIndex = cbTrangThai.Items.IndexOf(trangThai);
            }
        }





        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
