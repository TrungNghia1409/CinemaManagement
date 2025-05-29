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
    public partial class frmThongKeVe : Form
    {
        public frmThongKeVe()
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
                int soVe = DAO_HD_VE.Instance.TongSoVeBan(ngayChon.Date, null, null);

                // Hiển thị kết quả
                txbNgay.Text = soVe.ToString("N0") + " vé";
                lblNgay.Text = $"Ngày {ngayChon.Day}/{ngayChon.Month}/{ngayChon.Year}";
                lblNgay.Visible = true;

            }
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {

            if (rdbThang.Checked)
            {
                DateTime ngayChon = dtpThang.Value;
                int soVe = DAO_HD_VE.Instance.TongSoVeBan(null, ngayChon.Month, ngayChon.Year);

                txbThang.Text = soVe.ToString("N0") + " vé";
                lblThang.Text = $"Tháng {ngayChon.Month}/{ngayChon.Year}";
                lblThang.Visible = true;
            }
        }

        private void dtpNam_ValueChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                DateTime ngayChon = dtpNam.Value;
                int soVe = DAO_HD_VE.Instance.TongSoVeBan(null, null, ngayChon.Year);

                txbNam.Text = soVe.ToString("N0") + " vé";
                lblNam.Text = $"Năm {ngayChon.Year}";
                lblNam.Visible = true;
            }
        }

        #endregion


        private void rdbVe_SuatChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVe_SuatChieu.Checked)
            {
                dgvKetQuaThongKe_Ve.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Ve.DataSource = DAO_THONGKE.Instance.SoVeTheoTungSuatChieu();
            }
        }

        private void rdbSoVe_Phim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSoVe_Phim.Checked)
            {
                dgvKetQuaThongKe_Ve.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Ve.DataSource = DAO_THONGKE.Instance.SoVeTheoTungPhim();
            }
        }

        private void rdbVe_LoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVe_LoaiPhong.Checked)
            {
                dgvKetQuaThongKe_Ve.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Ve.DataSource = DAO_THONGKE.Instance.SoVeTheoTungLoaiPhong();
            }
        }

        
    }
}
