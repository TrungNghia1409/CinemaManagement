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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OGC.DoiMatKhau
{
    public partial class frmNhapThongTin : Form
    {
        public string currentUser;
        public frmNhapThongTin(string username)
        {
            InitializeComponent();

            currentUser = username;
        }

        #region Methods

        //Hàm kiểm tra tính hợp lệ của sđt và email
        private bool KiemTraThongTinHopLe()
        {
            string sdt = txbSDT.Text.Trim();
            string email = txbEmail.Text.Trim();

            // Kiểm tra số điện thoại
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSDT.Focus();
                return false;
            }

            // Kiểm tra email
            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmail.Focus();
                return false;
            }

            return true; // Nếu không có lỗi
        }

        #endregion

        #region Events
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinHopLe())
            {
                string hoTenNhap = txbHoTen.Text.Trim();
                string emailNhap = txbEmail.Text.Trim();
                string sdtNhap = txbSDT.Text.Trim();

                DataTable dt = DAO_NHANVIEN.Instance.LayThongTinNhanVien(currentUser);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];
                string hoTenDB = row["HoTen"].ToString();
                string emailDB = row["Email"].ToString();
                string sdtDB = row["SDT"].ToString();

                if (!hoTenNhap.Equals(hoTenDB, StringComparison.OrdinalIgnoreCase) ||
                    !emailNhap.Equals(emailDB, StringComparison.OrdinalIgnoreCase) ||
                    !sdtNhap.Equals(sdtDB))
                {
                    MessageBox.Show("Thông tin không trùng khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đúng thông tin, tạo OTP và chuyển form
                DAO_OTPXN.Instance.TaoOTP(currentUser);
                frmOTPDoiMatKhau frm = new frmOTPDoiMatKhau(currentUser);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
        #endregion


    }
}
