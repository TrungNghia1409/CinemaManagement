using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace OGC.Phim
{
    public partial class FrmThemPhim : Form
    {
        public FrmThemPhim()
        {
            InitializeComponent();
        }
        private void frmThemPhim_Load(object sender, EventArgs e)
        {
            // Thiết lập ngôn ngữ và định dạng là tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            // Cấu hình DateTimePicker
            dtpKhoiChieu.Format = DateTimePickerFormat.Custom;
            dtpKhoiChieu.CustomFormat = "dddd, dd/MM/yyyy";
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            //PhimDTO phim = new PhimDTO(
            //        id: 0, // ID sẽ tự tăng trong CSDL
            //        tenPhim: tbTenPhim.Text,
            //        daoDien: tbDaoDien.Text,
            //        dienVien: tbDienVien.Text,
            //        //iDTheLoaiPhim: (int)cbTheLoai.SelectedValue,
            //        //iDDinhDang: (int)cbDinhDang.SelectedValue,
            //        thoiLuong: int.Parse(tbThoiLuong.Text),
            //        moTa: tbMoTa.Text,
            //        ngayKhoiChieu: dtpKhoiChieu.Value,
            //        trangThai: (int)cbTrangThai.SelectedValue,
            //        //trailer_Url: tbTrailer.Text,
            //        //poster_Url: tbPoster.Text,
            //        /*nh: txbAnh.Text,*/
            //        doTuoi: cbDoTuoi.SelectedItem?.ToString()
            //    );

            //bool result = PhimDAO.Instance.InsertPhim(phim);
            //if (result)
            //{
            //    MessageBox.Show("Thêm phim thành công");
            //    
            //}
            //else
            //{
            //    MessageBox.Show("Thêm phim thất bại");
            //}

        }

    }
}

