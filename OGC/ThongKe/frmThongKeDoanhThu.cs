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

namespace OGC.ThongKe
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();

            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.CustomFormat = "MM/yyyy";

            dtpNam.Format = DateTimePickerFormat.Custom;
            dtpNam.CustomFormat = "yyyy";


        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Doanh thu theo ngày, tháng, năm
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi RadioButton được CHỌN (không cần gán Checked = true)
            if (rdbNgay.Checked)
            {
                DateTime ngayChon = dtpNgay.Value;
                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(ngayChon.Date, null, null);

                // Hiển thị kết quả
                txbNgay.Text = doanhThu.ToString("N0") + " VNĐ";
                lblNgay.Text = $"Ngày {ngayChon.Day}/{ngayChon.Month}/{ngayChon.Year}";
                lblNgay.Visible = true;

            }

        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            if (rdbThang.Checked)
            {
                DateTime ngayChon = dtpThang.Value;
                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(null, ngayChon.Month, ngayChon.Year);

                // Hiển thị kết quả
                txbThang.Text = doanhThu.ToString("N0") + " VNĐ";
                lblThang.Text = $"Tháng {ngayChon.Month}/{ngayChon.Year}";
                lblThang.Visible = true;

            }
        }

        private void dtpNam_ValueChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                DateTime ngayChon = dtpNam.Value;
                decimal doanhThu = DAO_HD_VE.Instance.TinhTongDoanhThu(null, null, ngayChon.Year);

                txbNam.Text = doanhThu.ToString("N0") + " VNĐ";
                lblNam.Text = $"Năm {ngayChon.Year}";
                lblNam.Visible = true;
            }
        }
        #endregion

        private void rdbDoanhThu_NhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThu_NhanVien.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungNhanVien();
            }
        }

        private void rdbDoanhThu_Phim_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbDoanhThu_Phim.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungPhim();
            }
        }

        private void rdbDoanhThu_SuatChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThu_SuatChieu.Checked)
            {
                dgvKetQuaThongKe_DoanhThu.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_DoanhThu.DataSource = DAO_THONGKE.Instance.DoanhThuTheoTungSuatChieu();
            }
        }
    }
}
