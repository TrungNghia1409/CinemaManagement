using OGC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.ThuocTinh
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();

            LoadLoaiPhong();
        }

        //Thay đổi viền panel
        private void pnlTenLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTenLoaiPhong, 15);
        }

        private void pnlThemLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlThemLoaiPhong, 30);
        }

        private void pnlXoaLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlXoaLoaiPhong, 30);
        }

        private void pnlSuaLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlSuaLoaiPhong, 30);
        }

        #region Methods
        //Load danh sách các loại phòng
        public void LoadLoaiPhong()
        {
            DataTable dt = DAO_LOAIPHONG.Instance.DanhSachLoaiPhong();
            dgvLoaiPhong.DataSource = dt;

            // Tùy chỉnh để hiển thị đẹp hơn
            dgvLoaiPhong.Columns["ID"].HeaderText = "Mã loại phòng";
            dgvLoaiPhong.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";

            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Căn đều cột
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.AllowUserToAddRows = false;
        }
        #endregion





        #region Events


        #endregion
    }
}
