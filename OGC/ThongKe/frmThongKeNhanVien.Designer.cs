namespace OGC.ThongKe
{
    partial class frmThongKeNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdbNam = new RadioButton();
            rdbNgay = new RadioButton();
            dgvKetQuaThongKe_NhanVien = new DataGridView();
            rdbNhanVien_LapDichVu = new RadioButton();
            rdbNhanVien_DoanhThuCaoNhat = new RadioButton();
            rdbNhanVien_LapVe = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblTieuChi = new Label();
            lblLoaiThongKe = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            lblngayChon = new Label();
            txbSoLuongNhanVienMoi = new TextBox();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            cbNgay = new ComboBox();
            rdbThang = new RadioButton();
            pnlDoanhThu_dgv = new Panel();
            pnlDuoi = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKeNhanVien = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_NhanVien).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlTren.SuspendLayout();
            SuspendLayout();
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(56, 144);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(80, 19);
            rdbNam.TabIndex = 0;
            rdbNam.TabStop = true;
            rdbNam.Text = "Theo Năm";
            rdbNam.UseVisualStyleBackColor = true;
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
            // 
            // rdbNgay
            // 
            rdbNgay.AutoSize = true;
            rdbNgay.Location = new Point(56, 48);
            rdbNgay.Name = "rdbNgay";
            rdbNgay.Size = new Size(82, 19);
            rdbNgay.TabIndex = 0;
            rdbNgay.TabStop = true;
            rdbNgay.Text = "Theo Ngày";
            rdbNgay.UseVisualStyleBackColor = true;
            rdbNgay.CheckedChanged += rdbNgay_CheckedChanged;
            // 
            // dgvKetQuaThongKe_NhanVien
            // 
            dgvKetQuaThongKe_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_NhanVien.Location = new Point(8, 136);
            dgvKetQuaThongKe_NhanVien.Name = "dgvKetQuaThongKe_NhanVien";
            dgvKetQuaThongKe_NhanVien.Size = new Size(504, 256);
            dgvKetQuaThongKe_NhanVien.TabIndex = 3;
            // 
            // rdbNhanVien_LapDichVu
            // 
            rdbNhanVien_LapDichVu.AutoSize = true;
            rdbNhanVien_LapDichVu.Location = new Point(248, 72);
            rdbNhanVien_LapDichVu.Name = "rdbNhanVien_LapDichVu";
            rdbNhanVien_LapDichVu.Size = new Size(266, 19);
            rdbNhanVien_LapDichVu.TabIndex = 2;
            rdbNhanVien_LapDichVu.TabStop = true;
            rdbNhanVien_LapDichVu.Text = "Số lượng hóa đơn dịch vụ của từng nhân viên";
            rdbNhanVien_LapDichVu.UseVisualStyleBackColor = true;
            rdbNhanVien_LapDichVu.CheckedChanged += rdbNhanVien_LapDichVu_CheckedChanged;
            // 
            // rdbNhanVien_DoanhThuCaoNhat
            // 
            rdbNhanVien_DoanhThuCaoNhat.Location = new Point(8, 32);
            rdbNhanVien_DoanhThuCaoNhat.Name = "rdbNhanVien_DoanhThuCaoNhat";
            rdbNhanVien_DoanhThuCaoNhat.Size = new Size(320, 40);
            rdbNhanVien_DoanhThuCaoNhat.TabIndex = 2;
            rdbNhanVien_DoanhThuCaoNhat.TabStop = true;
            rdbNhanVien_DoanhThuCaoNhat.Text = "Danh sách nhân viên mang về doanh thu cao nhất";
            rdbNhanVien_DoanhThuCaoNhat.UseVisualStyleBackColor = true;
            rdbNhanVien_DoanhThuCaoNhat.CheckedChanged += rdbNhanVien_DoanhThuCaoNhat_CheckedChanged;
            // 
            // rdbNhanVien_LapVe
            // 
            rdbNhanVien_LapVe.AutoSize = true;
            rdbNhanVien_LapVe.Location = new Point(8, 72);
            rdbNhanVien_LapVe.Name = "rdbNhanVien_LapVe";
            rdbNhanVien_LapVe.Size = new Size(239, 19);
            rdbNhanVien_LapVe.TabIndex = 2;
            rdbNhanVien_LapVe.TabStop = true;
            rdbNhanVien_LapVe.Text = "Số lượng hóa đơn vé của từng nhân viên";
            rdbNhanVien_LapVe.UseVisualStyleBackColor = true;
            rdbNhanVien_LapVe.CheckedChanged += rdbNhanVien_LapVe_CheckedChanged;
            // 
            // lblKetQuaThongKe
            // 
            lblKetQuaThongKe.AutoSize = true;
            lblKetQuaThongKe.Location = new Point(16, 104);
            lblKetQuaThongKe.Name = "lblKetQuaThongKe";
            lblKetQuaThongKe.Size = new Size(97, 15);
            lblKetQuaThongKe.TabIndex = 0;
            lblKetQuaThongKe.Text = "Kết quả thống kê";
            // 
            // lblTieuChi
            // 
            lblTieuChi.AutoSize = true;
            lblTieuChi.Location = new Point(16, 16);
            lblTieuChi.Name = "lblTieuChi";
            lblTieuChi.Size = new Size(100, 15);
            lblTieuChi.TabIndex = 0;
            lblTieuChi.Text = "Hãy chọn tiêu chí";
            // 
            // lblLoaiThongKe
            // 
            lblLoaiThongKe.AutoSize = true;
            lblLoaiThongKe.Location = new Point(8, 16);
            lblLoaiThongKe.Name = "lblLoaiThongKe";
            lblLoaiThongKe.Size = new Size(79, 15);
            lblLoaiThongKe.TabIndex = 0;
            lblLoaiThongKe.Text = "Loại thống kê";
            // 
            // pnlDoanhThu_ThoiGian
            // 
            pnlDoanhThu_ThoiGian.Controls.Add(lblngayChon);
            pnlDoanhThu_ThoiGian.Controls.Add(txbSoLuongNhanVienMoi);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(cbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(lblLoaiThongKe);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNgay);
            pnlDoanhThu_ThoiGian.Location = new Point(0, 0);
            pnlDoanhThu_ThoiGian.Name = "pnlDoanhThu_ThoiGian";
            pnlDoanhThu_ThoiGian.Size = new Size(280, 400);
            pnlDoanhThu_ThoiGian.TabIndex = 0;
            // 
            // lblngayChon
            // 
            lblngayChon.AutoSize = true;
            lblngayChon.Location = new Point(16, 187);
            lblngayChon.Name = "lblngayChon";
            lblngayChon.Size = new Size(38, 15);
            lblngayChon.TabIndex = 6;
            lblngayChon.Text = "label1";
            // 
            // txbSoLuongNhanVienMoi
            // 
            txbSoLuongNhanVienMoi.Location = new Point(96, 184);
            txbSoLuongNhanVienMoi.Name = "txbSoLuongNhanVienMoi";
            txbSoLuongNhanVienMoi.Size = new Size(172, 23);
            txbSoLuongNhanVienMoi.TabIndex = 5;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(160, 144);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(81, 23);
            cbNam.TabIndex = 4;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(160, 96);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(81, 23);
            cbThang.TabIndex = 4;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(160, 48);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(81, 23);
            cbNgay.TabIndex = 4;
            // 
            // rdbThang
            // 
            rdbThang.AutoSize = true;
            rdbThang.Location = new Point(56, 96);
            rdbThang.Name = "rdbThang";
            rdbThang.Size = new Size(87, 19);
            rdbThang.TabIndex = 0;
            rdbThang.TabStop = true;
            rdbThang.Text = "Theo Tháng";
            rdbThang.UseVisualStyleBackColor = true;
            rdbThang.CheckedChanged += rdbThang_CheckedChanged;
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_NhanVien);
            pnlDoanhThu_dgv.Controls.Add(rdbNhanVien_LapDichVu);
            pnlDoanhThu_dgv.Controls.Add(rdbNhanVien_DoanhThuCaoNhat);
            pnlDoanhThu_dgv.Controls.Add(rdbNhanVien_LapVe);
            pnlDoanhThu_dgv.Controls.Add(lblKetQuaThongKe);
            pnlDoanhThu_dgv.Controls.Add(lblTieuChi);
            pnlDoanhThu_dgv.Location = new Point(280, 0);
            pnlDoanhThu_dgv.Name = "pnlDoanhThu_dgv";
            pnlDoanhThu_dgv.Size = new Size(520, 400);
            pnlDoanhThu_dgv.TabIndex = 1;
            // 
            // pnlDuoi
            // 
            pnlDuoi.Controls.Add(pnlDoanhThu_dgv);
            pnlDuoi.Controls.Add(pnlDoanhThu_ThoiGian);
            pnlDuoi.Dock = DockStyle.Top;
            pnlDuoi.Location = new Point(0, 50);
            pnlDuoi.Name = "pnlDuoi";
            pnlDuoi.Size = new Size(800, 408);
            pnlDuoi.TabIndex = 3;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(512, 8);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(123, 23);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnTaiBieuDo
            // 
            btnTaiBieuDo.Location = new Point(656, 8);
            btnTaiBieuDo.Name = "btnTaiBieuDo";
            btnTaiBieuDo.Size = new Size(123, 23);
            btnTaiBieuDo.TabIndex = 2;
            btnTaiBieuDo.Text = "Tải biểu đồ";
            btnTaiBieuDo.UseVisualStyleBackColor = true;
            // 
            // lblThongKeNhanVien
            // 
            lblThongKeNhanVien.AutoSize = true;
            lblThongKeNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeNhanVien.Location = new Point(96, 8);
            lblThongKeNhanVien.Name = "lblThongKeNhanVien";
            lblThongKeNhanVien.Size = new Size(167, 21);
            lblThongKeNhanVien.TabIndex = 1;
            lblThongKeNhanVien.Text = "Thống Kê Nhân Viên";
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Segoe UI", 12F);
            lblThongKe.Location = new Point(8, 8);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(89, 21);
            lblThongKe.TabIndex = 0;
            lblThongKe.Text = "Thống Kê / ";
            lblThongKe.Click += lblThongKe_Click;
            // 
            // pnlTren
            // 
            pnlTren.Controls.Add(btnXuatExcel);
            pnlTren.Controls.Add(btnTaiBieuDo);
            pnlTren.Controls.Add(lblThongKeNhanVien);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKeNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeNhanVien";
            Load += frmThongKeNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_NhanVien).EndInit();
            pnlDoanhThu_ThoiGian.ResumeLayout(false);
            pnlDoanhThu_ThoiGian.PerformLayout();
            pnlDoanhThu_dgv.ResumeLayout(false);
            pnlDoanhThu_dgv.PerformLayout();
            pnlDuoi.ResumeLayout(false);
            pnlTren.ResumeLayout(false);
            pnlTren.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton rdbNam;
        private RadioButton rdbNgay;
        private DataGridView dgvKetQuaThongKe_NhanVien;
        private RadioButton rdbNhanVien_LapDichVu;
        private RadioButton rdbNhanVien_DoanhThuCaoNhat;
        private RadioButton rdbNhanVien_LapVe;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private RadioButton rdbThang;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKeNhanVien;
        private Label lblThongKe;
        private Panel pnlTren;
        private ComboBox cbNgay;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private Label lblngayChon;
        private TextBox txbSoLuongNhanVienMoi;
    }
}