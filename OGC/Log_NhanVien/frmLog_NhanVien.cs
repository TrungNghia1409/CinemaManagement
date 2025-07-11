using OGC.DAO;
using OGC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.Log_NhanVien
{
    public partial class frmLog_NhanVien : Form
    {
        private string currentUser;

        public frmLog_NhanVien(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void frmLog_NhanVien_Load(object sender, EventArgs e)
        {
            // Load năm từ 2020 đến năm hiện tại
            int currentYear = DateTime.Now.Year;
            for (int year = 2020; year <= currentYear; year++)
            {
                cbNam.Items.Add(year);
            }

            // Load tháng từ 1 đến 12
            for (int month = 1; month <= 12; month++)
            {
                cbThang.Items.Add(month);
            }

            Load_LogNhanVien();

        }

        //load ngày dựa trên tháng và năm chọn trên combobox
        private void LoadNgay()
        {
            if (cbThang.SelectedItem != null && cbNam.SelectedItem != null)
            {
                int month = Convert.ToInt32(cbThang.SelectedItem);
                int year = Convert.ToInt32(cbNam.SelectedItem);

                int daysInMonth = DateTime.DaysInMonth(year, month);
                cbNgay.Items.Clear();
                for (int day = 1; day <= daysInMonth; day++)
                {
                    cbNgay.Items.Add(day);
                }
            }
        }
        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
            LocLogTheoNgay();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
            LocLogTheoNgay();
        }
        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocLogTheoNgay();
        }

        private void ckbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LocLogTheoNgay();
        }

        //hiển thị nhật ký hoạt động của nv
        private void Load_LogNhanVien()
        {
            // 1. Gọi UC tiêu đề (chỉ gọi 1 lần duy nhất)
            if (pnlTieuDe_Log_NhanVien.Controls.Count == 0)
            {
                UC_TieuDe_Log_NhanVien ucTieuDe = new UC_TieuDe_Log_NhanVien();
                pnlTieuDe_Log_NhanVien.Controls.Add(ucTieuDe);
            }

            // 2. Xoá cũ và load danh sách log
            pnlLog_NhanVien.Controls.Clear();

            List<DTO_LogNhanVien> danhSachLog = DAO_LogNhanVien.Instance.LayTatCaLog();

            foreach (DTO_LogNhanVien log in danhSachLog)
            {
                UC_Log_NhanVien ucLog = new UC_Log_NhanVien(log);
                pnlLog_NhanVien.Controls.Add(ucLog);
            }
        }

        //----Lọc nhật ký hoạt động theo thời gian
        private void LocLogTheoNgay()
        {
            int? ngay = cbNgay.SelectedItem != null ? (int?)Convert.ToInt32(cbNgay.SelectedItem) : null;
            int? thang = cbThang.SelectedItem != null ? (int?)Convert.ToInt32(cbThang.SelectedItem) : null;
            int? nam = cbNam.SelectedItem != null ? (int?)Convert.ToInt32(cbNam.SelectedItem) : null;

            List<DTO_LogNhanVien> danhSachLog;

            if (ckbTatCa.Checked || (ngay == null && thang == null && nam == null))
            {
                // TH1: Hiển thị toàn bộ nếu chưa chọn gì hoặc check vào "Tất cả"
                danhSachLog = DAO_LogNhanVien.Instance.LayTatCaLog();
            }
            else
            {
                // TH2: Lọc theo từng mức
                danhSachLog = DAO_LogNhanVien.Instance.LayLogTheoNgay(ngay, thang, nam);
            }

            // Xoá các UC_Log cũ
            pnlLog_NhanVien.Controls.Clear();

            foreach (DTO_LogNhanVien log in danhSachLog)
            {
                UC_Log_NhanVien ucLog = new UC_Log_NhanVien(log);
                pnlLog_NhanVien.Controls.Add(ucLog);
            }
        }

       
    }
}
