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

namespace OGC.Phim
{
    public partial class frmQuanLyPhim : Form
    {
        public frmQuanLyPhim()
        {
            InitializeComponent();
            LoadDanhSachPhim();
        }

        private void LoadDanhSachPhim()
        {
            List<PhimDTO> dsPhim = PhimDAO.Instance.GetAllPhim();
            dtgvPhim.DataSource = dsPhim;
            DinhDangDataGridView();
        }

        private void DinhDangDataGridView()
        {
            dtgvPhim.Columns["ID"].HeaderText = "Mã phim";
            dtgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dtgvPhim.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dtgvPhim.Columns["DienVien"].HeaderText = "Diễn viên";
            dtgvPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng (phút)";
            dtgvPhim.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dtgvPhim.Columns["DoTuoi"].HeaderText = "Độ tuổi";
            dtgvPhim.Columns["Anh"].HeaderText = "Ảnh";
            dtgvPhim.Columns["Poster_Url"].HeaderText = "Poster";
            dtgvPhim.Columns["Trailer_Url"].HeaderText = "Trailer";
            dtgvPhim.Columns["MoTa"].HeaderText = "Mô tả";
            dtgvPhim.Columns["TrangThai"].HeaderText = "Trạng thái";
            dtgvPhim.Columns["IDTheLoaiPhim"].HeaderText = "Mã thể loại";
            dtgvPhim.Columns["IDDinhDang"].HeaderText = "Mã định dạng";

        }
    }
}
