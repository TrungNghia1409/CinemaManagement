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
    public partial class FrmPhuongThucThanhToanVe : Form
    {
        private List<string> gheDaChon;
        private decimal tongTien;
        private int idNhanVien;
        private string tenPhim, suatChieu, phong, dinhDang;
        private decimal giaVe;
        private FrmChonGhe frmChonGhe;
       

        public FrmPhuongThucThanhToanVe(
            List<string> gheDaChon,
            decimal tongTien,
            int idNhanVien,
            string tenPhim,
            string suatChieu,
            string phong,
            string dinhDang,
            decimal giaVe,
            FrmChonGhe frmChonGhe
            
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
            this.frmChonGhe = frmChonGhe;
          
        }


        private void btnTienMat_Click(object sender, EventArgs e)
        {
            FrmXacNhanThanhToanVePhim frm = new FrmXacNhanThanhToanVePhim(
                    gheDaChon,
                    tongTien,
                    idNhanVien,
                    tenPhim,
                    suatChieu,
                    phong,
                    dinhDang,
                    giaVe,
                    frmChonGhe
         );

            frm.ShowDialog();
            this.Close();
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
