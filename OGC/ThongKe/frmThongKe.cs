using LiveCharts.Definitions.Charts;
using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OGC.ThongKe
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();

            LoadThongKe();
        }
        

        #region Thay đổi viền panel
        private void pnlForm_DoanhThu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_DoanhThu, 30);
        }

        private void pnlForm_Ve_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_Ve, 30);
        }

        private void pnlForm_KhachHang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_KhachHang, 30);
        }

        private void pnlForm_Phim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_Phim, 30);
        }

        private void pnlForm_NhanVien_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_NhanVien, 30);
        }

        private void pnlForm_PhongChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_PhongChieu, 30);
        }

        private void pnlForm_LichChieu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_LichChieu, 30);
        }

        private void pnlForm_DichVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlForm_DichVu, 30);
        }

        private void pnlDoanhThu_Ngay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDoanhThu_Ngay, 25);
        }

        private void pnlDoanhThu_Thang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlDoanhThu_Thang, 25);
        }

        private void pnlVe_Ngay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlVe_Ngay, 25);
        }

        private void pnlNhanVienDichVu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlNhanVienDichVu, 25);
        }

        private void pnlNhanVienBanVe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlNhanVienBanVe, 25);
        }

        private void pnlVe_Thang_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlVe_Thang, 25);
        }

        private void pnlPhimChieuNhieuNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimChieuNhieuNhat, 25);
        }

        private void pnlPhimChieuItNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimChieuItNhat, 25);
        }

        private void pnlPhimDoanhThuCaoNhat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlPhimDoanhThuCaoNhat, 25);
        }

        #endregion

        #region sự kiện gọi form
        private void btnForm_DoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.ShowDialog();
        }
        private void btnForm_Ve_Click(object sender, EventArgs e)
        {
            frmThongKeVe f = new frmThongKeVe();
            f.ShowDialog();
        }
        private void btnForm_KhachHang_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang f = new frmThongKeKhachHang();
            f.ShowDialog();
        }
        private void btnForm_Phim_Click(object sender, EventArgs e)
        {
            frmThongKePhim f = new frmThongKePhim();
            f.ShowDialog();
        }
        private void btnForm_NhanVien_Click(object sender, EventArgs e)
        {
            frmThongKeNhanVien f = new frmThongKeNhanVien();
            f.ShowDialog();
        }

        private void btnForm_PhongChieu_Click(object sender, EventArgs e)
        {
            frmThongKePhongChieu f = new frmThongKePhongChieu();
            f.ShowDialog();
        }

        private void btnForm_LichChieu_Click(object sender, EventArgs e)
        {
            frmThongKeLichChieu f = new frmThongKeLichChieu();
            f.ShowDialog();
        }

        private void btnForm_DichVu_Click(object sender, EventArgs e)
        {
            frmThongKeDichVu f = new frmThongKeDichVu();
            f.ShowDialog();
        }
        #endregion

        #region Methods
        //------ Phương thức hiển thị doanh thu theo ngày, tháng
        private void LoadThongKe()
        {

            // ------Lấy doanh thu ngày
            double doanhThuNgay = DAO_HD_VE.Instance.GetDoanhThuNgay() + DAO_HD_MONAN.Instance.GetDoanhThuNgay();
            lbl_KetQua_DoanhThuNgay.Text = doanhThuNgay.ToString("N0") + " VNĐ";

            //------ Lấy doanh thu tháng
            double doanhThuThang = DAO_HD_VE.Instance.GetDoanhThuThang() + DAO_HD_MONAN.Instance.GetDoanhThuThang();
            lbl_KetQua_DoanhThuThang.Text = doanhThuThang.ToString("N0") + " VNĐ";

            //------Số vé bán trong ngày
            int soVeNgay = DAO_HD_VE.Instance.GetSoVeBanTrongNgay();
            lbl_KetQua_SoVeNgay.Text = soVeNgay.ToString("N0") + " vé";

            //-------Số vé bán trong tháng
            int soVeThang = DAO_HD_VE.Instance.GetSoVeBanTrongThang();
            lbl_KetQua_SoVeThang.Text = soVeThang.ToString("N0") + " vé";

            //-------Nhân viên bán vé nổi trội
            List<string> danhSachNhanVienBanVe = DAO_HD_VE.Instance.GetDanhSachNhanVienBanVeNoiTroi();

            if (danhSachNhanVienBanVe.Count == 0)
            {
                lbl_KetQua_NhanVienBanVe.Text = "Không có dữ liệu";
            }
            else
            {
                // Gộp tên các nhân viên, cách nhau bằng dấu phẩy
                lbl_KetQua_NhanVienBanVe.Text = string.Join(", ", danhSachNhanVienBanVe);
            }

            //-------Nhân viên dịch vụ nổi trội
            List<string> danhSachNhanVienDichVu = DAO_HD_MONAN.Instance.GetDanhSachNhanVienDichVuNoiTroi();

            if (danhSachNhanVienDichVu.Count == 0)
            {
                lbl_KetQua_NhanVienDichVu.Text = "Không có dữ liệu";
            }
            else
            {
                // Gộp tên các nhân viên, cách nhau bằng dấu phẩy
                lbl_KetQua_NhanVienDichVu.Text = string.Join(", ", danhSachNhanVienDichVu);
            }

            //--------Phim được chiếu nhiều nhất
            var dsPhimChieuNhieu = DAO_LICHCHIEU.Instance.GetPhimChieuNhieuNhat();
            if (dsPhimChieuNhieu.Count > 0)
            {
                lbl_KetQua_PhimChieuNhieuNhat.Text = dsPhimChieuNhieu[0]; // chỉ hiển thị cột TenPhim của dòng đầu tiên
            }
            else
            {
                lbl_KetQua_PhimChieuNhieuNhat.Text = "Không có phim nào";
            }

            //------------Phim được chiếu ít nhất
            var dsPhimChieuIt = DAO_LICHCHIEU.Instance.GetPhimChieuItNhat();
            if (dsPhimChieuIt.Count > 0)
            {
                lbl_KetQua_PhimChieuItNhat.Text = dsPhimChieuIt[0]; // chỉ hiển thị cột TenPhim của dòng đầu tiên
            }
            else
            {
                lbl_KetQua_PhimChieuItNhat.Text = "Không có phim nào";
            }
            //------------Phim có doanh thu cao nhất
            var dsPhimDoanhThuCao = PhimDAO.Instance.GetPhimDoanhThuCaoNhatThang();
            if (dsPhimDoanhThuCao.Count > 0)
            {
                lbl_KetQua_PhimDoanhThuCaoNhat.Text = dsPhimDoanhThuCao[0]; // chỉ hiển thị cột TenPhim của dòng đầu tiên
            }
            else
            {
                lbl_KetQua_PhimDoanhThuCaoNhat.Text = "Không có phim nào";
            }
        }
        #endregion



    }
}
