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
    public partial class UC_Log_NhanVien : UserControl
    {
        private DTO_LogNhanVien log;
        public UC_Log_NhanVien(DTO_LogNhanVien log)
        {
            InitializeComponent();

            this.log = log ?? new DTO_LogNhanVien();

            // Gán dữ liệu vào label
            lblID.Text = log.ID.ToString();
            lblUsername.Text = log.Username;
            lblChucVu.Text = log.TenChucVu;
            lblThaoTac.Text = log.ThaoTac;
            lblGio.Text = log.Gio;
            lblNgay.Text = log.Ngay;
            lblChucNang.Text = log.ChucNang;

            this.Dock = DockStyle.Top;
        }

        
    }
}
