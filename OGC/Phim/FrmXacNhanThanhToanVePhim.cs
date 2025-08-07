using DocumentFormat.OpenXml.Office2010.CustomUI;
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

namespace OGC.Phim
{
    public partial class FrmXacNhanThanhToanVePhim : Form
    {
        private List<string> gheDaChon;
        private decimal tongTien;
        private int idNhanVien;
        private decimal giaVe;
        private string tenPhim, suatChieu, phong, dinhDang, hinhThuc;
        public FrmXacNhanThanhToanVePhim(
            List<string> gheDaChon,
            decimal tongTien,
            int idNhanVien,
            string tenPhim,
            string suatChieu,
            string phong,
            string dinhDang,
            decimal giaVe
            )
        {
            InitializeComponent();
            this.gheDaChon = gheDaChon;
            this.tongTien = tongTien;
            this.idNhanVien = idNhanVien;
            this.tenPhim = tenPhim;
            this.suatChieu = suatChieu;
            this.phong = phong;
            this.dinhDang = dinhDang;
            this.giaVe = giaVe;
            this.hinhThuc = hinhThuc;
        }




        private void textBox1_Leave(object sender, EventArgs e)
        {
            string sdt = txbSDT.Text.Trim();
            int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

            if (idKhach > 0)
            {
                lblTrangThai.Text = "Đã tìm thấy!";
            }
            else
            {
                lblTrangThai.Text = "Không tìm thấy";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sdt = txbSDT.Text.Trim();
            int idKhach = DAO_KHACHHANG.Instance.LayIDBySDT(sdt);

            if (idKhach <= 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng.");
                return;
            }

            
                FrmChiTietHoaDonVePhim frm = new FrmChiTietHoaDonVePhim(
                    idNhanVien,
                    idKhach,
                    tenPhim,
                    suatChieu,
                    phong,
                    gheDaChon,
                    dinhDang,
                    giaVe,
                    tongTien
                );
                frm.ShowDialog();


            this.Close();
        }

        private void FrmXacNhanThanhToanVePhim_Load(object sender, EventArgs e)
        {
            //// Gán số điện thoại để người dùng nhập (nếu có sẵn thì truyền vào)
            //txtSoDienThoai.Text = ""; // hoặc truyền từ form trước

            // Ghế đã chọn
            lbGheDaChon.Text = string.Join(", ", gheDaChon);

            // Tổng tiền
            lbTongTien.Text = tongTien.ToString("N0") + " VNĐ";

            // Ngày thanh toán (hiện tại)
            lbNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Mã nhân viên
            tbMaNhanVien.Text = idNhanVien.ToString();
        }
    }
}

