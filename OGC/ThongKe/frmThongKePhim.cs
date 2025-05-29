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
    public partial class frmThongKePhim : Form
    {
        public frmThongKePhim()
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
                DataTable phim = DAO_THONGKE.Instance.ThongKePhim(ngayChon.Date, null, null);

                // Hiển thị kết quả
                txbNgay.Text = phim.Rows.Count.ToString() + " phim";
                lblNgay.Text = $"Ngày {ngayChon.Day}/{ngayChon.Month}/{ngayChon.Year}";
                lblNgay.Visible = true;

                dgvKetQuaThongKe_Phim.DataSource = phim;

            }
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            if (rdbThang.Checked)
            {
                DateTime ngayChon = dtpThang.Value;
                DataTable phim = DAO_THONGKE.Instance.ThongKePhim(null, ngayChon.Month, ngayChon.Year);


                // Hiển thị kết quả
                txbThang.Text = phim.Rows.Count.ToString() + " phim";
                lblThang.Text = $"Tháng {ngayChon.Month}/{ngayChon.Year}";
                lblThang.Visible = true;

                dgvKetQuaThongKe_Phim.DataSource = phim;

            }
        }

        private void dtpNam_ValueChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                DateTime ngayChon = dtpNam.Value;
                DataTable phim = DAO_THONGKE.Instance.ThongKePhim(null, null, ngayChon.Year);

                // Hiển thị kết quả
                txbNam.Text = phim.Rows.Count.ToString() + " phim";
                lblNam.Text = $"Năm {ngayChon.Year}";
                lblNam.Visible = true;

                dgvKetQuaThongKe_Phim.DataSource = phim;
            }
        }



        #endregion


        private void rdbPhim_DoanhThu_Thap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhim_DoanhThu_Thap.Checked)
            {
                dgvKetQuaThongKe_Phim.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Phim.DataSource = DAO_THONGKE.Instance.PhimDoanhThuThapNhat();
            }
        }

        private void rdbPhim_DoanhThu_Cao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhim_DoanhThu_Cao.Checked)
            {
                dgvKetQuaThongKe_Phim.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Phim.DataSource = DAO_THONGKE.Instance.PhimDoanhThuCaoNhat();
            }
        }

        private void rdbPhim_DatVe_NhieuNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhim_DatVe_NhieuNhat.Checked)
            {
                dgvKetQuaThongKe_Phim.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_Phim.DataSource = DAO_THONGKE.Instance.PhimDuocDatVeNhieuNhat();
            }
        }
    }
}
