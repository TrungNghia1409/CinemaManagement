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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
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
                int soKhach = DAO_HD_VE.Instance.TongSoKhachHang(ngayChon.Date, null, null);

                // Hiển thị kết quả
                txbNgay.Text = soKhach.ToString("N0") + " Khách";
                lblNgay.Text = $"Ngày {ngayChon.Day}/{ngayChon.Month}/{ngayChon.Year}";
                lblNgay.Visible = true;

            }
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            if (rdbThang.Checked)
            {
                DateTime ngayChon = dtpThang.Value;
                int soKhach = DAO_HD_VE.Instance.TongSoKhachHang(null, ngayChon.Month, ngayChon.Year);

                // Hiển thị kết quả
                txbThang.Text = soKhach.ToString("N0") + " Khách";
                lblThang.Text = $"Tháng {ngayChon.Month}/{ngayChon.Year}";
                lblThang.Visible = true;

            }
        }

        private void dtpNam_ValueChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                DateTime ngayChon = dtpNam.Value;
                int soKhach = DAO_HD_VE.Instance.TongSoKhachHang(null, null, ngayChon.Year);

                txbNam.Text = soKhach.ToString("N0") + " Khách";
                lblNam.Text = $"Năm {ngayChon.Year}";
                lblNam.Visible = true;
            }

        }

        #endregion


        private void rdbKhachHang_Tong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHang_Tong.Checked)
            {
                dgvKetQuaThongKe_KhachHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_KhachHang.DataSource = DAO_THONGKE.Instance.KhachHangTheoTungKhuVuc();
            }
        }

        private void rdbKhachHang_ChuaTungDatVe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHang_ChuaTungDatVe.Checked)
            {
                dgvKetQuaThongKe_KhachHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_KhachHang.DataSource = DAO_THONGKE.Instance.DanhSachKhachHangChuaTungDatVe();
            }
        }

        private void rdbKhachHang_DiemThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHang_DiemThuong.Checked)
            {
                dgvKetQuaThongKe_KhachHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_KhachHang.DataSource = DAO_THONGKE.Instance.DanhSachKhachHangCoDiemThuongCaoNhat();
            }
        }

        private void rdbKhachHang_DatVe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHang_DatVe.Checked)
            {
                dgvKetQuaThongKe_KhachHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvKetQuaThongKe_KhachHang.DataSource = DAO_THONGKE.Instance.DanhSachKhachHangDatVeNhieuNhat();
            }
        }
    }
}
