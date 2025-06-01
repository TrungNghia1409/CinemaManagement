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
using static OGC.DTO.DTO_CartItem;

namespace OGC.QuanLyDichVu
{
    public partial class frmChiTietHoaDonMonAn : Form
    {
        public int iDHoaDon;
        List<CartItem> gioHang;
        public frmChiTietHoaDonMonAn(int iDHoaDon, List<CartItem> gioHang)
        {
            InitializeComponent();

            this.iDHoaDon = iDHoaDon;
            this.gioHang = gioHang;
        }

        private void frmChiTietHoaDonMonAn_Load(object sender, EventArgs e)
        {


            foreach (var item in gioHang)
            {
                int idMonAn = DAO_MONAN.Instance.LayIDMonAnTheoTen(item.TenMonAn); // bạn cần phương thức này
                DAO_CTHD_MONAN.Instance.ThemChiTietHoaDonMonAn(iDHoaDon, idMonAn, item.SoLuong, item.DonGia);
            }

            dgvChiTiet.DataSource = DAO_CTHD_MONAN.Instance.LayDSByIDHoaDon(iDHoaDon);
        }
    }
}
