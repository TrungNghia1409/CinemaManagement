using OGC.DAO;
using OGC.DTO;
using OGC.LichChieu;
using OGC.NHANVIEN;
using OGC.QuanLyDichVu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.LichChieu
{
    public partial class frmThongTinLichChieu : Form
    {
        public frmThongTinLichChieu(DTO_LICHCHIEU lichChieu)
        {
            InitializeComponent();

            // ComboBox tên phim
            cbTenPhim.DataSource = PhimDAO.Instance.GetAllPhim();
            cbTenPhim.DisplayMember = "TenPhim";

            // ComboBox tên phòng
            cbTenPhong.DataSource = DAO_LOAIPHONG.Instance.DanhSachTenPhong_List();
            cbTenPhong.DisplayMember = "TenPhong";


            // Hiển thị thông tin ra các control
            txbID.Text = lichChieu.ID.ToString();
            txbIDPhim.Text = lichChieu.IDPhim.ToString();
            txbIDPhong.Text = lichChieu.IDPhong.ToString();
            cbTenPhim.Text = lichChieu.TenPhim;
            cbTenPhong.Text = lichChieu.TenPhong;
            dtpNgayGio.Value = lichChieu.NgayGio;
            txbGiaVe.Text = lichChieu.GiaVe.ToString();
            txbDiaDiem.Text = lichChieu.DiaDiem;
            ptbAnh.Image = Image.FromFile(lichChieu.Anh);
            ptbAnhPhong.Image = Image.FromFile(lichChieu.AnhPhong);

        }


        #region Events
        // bắt sự kiện khi combobox thay đổi thì Text của textbox cũng thay đỏi theo
        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhim.SelectedItem != null)
            {
                PhimDTO phim = cbTenPhim.SelectedItem as PhimDTO;
                try
                {
                    if (phim != null)
                    {
                        txbIDPhim.Text = phim.ID.ToString();
                        ptbAnh.Load(phim.Anh); // load ảnh từ đường dẫn URL
                    }
                }
                catch
                {
                    ptbAnh.Image = null;
                    MessageBox.Show("Không thể tải ảnh từ đường dẫn.");
                }
            }
            else
            {
                ptbAnh.Image = null;
            }
        }
        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhong.SelectedItem != null)
            {
                DTO_LOAIPHONG phong = cbTenPhong.SelectedItem as DTO_LOAIPHONG;
                if (phong != null)
                {
                    txbIDPhong.Text = phong.ID.ToString();
                }
            }
        }
        #endregion

        #region Methods
        private void btnSuaLC_Click(object sender, EventArgs e)
        {
            try
            {
                List<PhimDTO> danhSachPhim = PhimDAO.Instance.GetAllPhim();
                List<string> danhSachPhong = DAO_LOAIPHONG.Instance.DanhSachTenPhong_List();

                // Nếu hợp lệ thì mới tiếp tục sửa lịch chiếu
                int iD = int.Parse(txbID.Text);
                string tenPhim = cbTenPhim.Text;
                string tenPhong = cbTenPhong.Text;
                DateTime ngayGio = DateTime.Parse(dtpNgayGio.Text);
                decimal giaVe = decimal.Parse(txbGiaVe.Text);
                string diaDiem = txbDiaDiem.Text;

                bool phimTonTai = danhSachPhim.Any(p => p.TenPhim == cbTenPhim.Text);
                bool phongTonTai = danhSachPhong.Contains(cbTenPhong.Text);

                if (!phimTonTai || !phongTonTai)
                {
                    MessageBox.Show("Tên phim hoặc phòng không tồn tại. Vui lòng nhập đúng tên có trong hệ thống.");
                    return;
                }
                if (giaVe < 50000)
                {
                    MessageBox.Show("Giá vé phải lớn hơn 50000 VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Gọi DAO để cập nhật thông tin
                bool isUpdated = DAO_LICHCHIEU.Instance.SuaLichChieu(iD, tenPhim, tenPhong, ngayGio, giaVe, diaDiem);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin lịch chiếu thành công!");

                    frmQuanLyLichChieu.Instance?.LoadLichChieu();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaLC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            // Lấy đối tượng DTO_LICHCHIEU theo id
            DTO_LICHCHIEU dto = DAO_LICHCHIEU.Instance.GetLichChieuByID(id);

            if (dto == null)
            {
                MessageBox.Show("Lịch chiếu không tồn tại.");
                return;
            }

            if (dto.TrangThai == "Sắp chiếu")
            {
                // Xác nhận xóa
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa lịch chiếu này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        // Gọi DAO để xóa lịch chiếu
                        bool isDeleted = DAO_LICHCHIEU.Instance.XoaLichChieu(id);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa lịch chiếu thành công!");
                            frmQuanLyLichChieu.Instance?.LoadLichChieu();
                            this.Close(); // Đóng form thông tin sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại. Vui lòng thử lại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lịch chiếu đã diễn ra, không được xóa.");
            }



        }
        #endregion


       
    }
}
