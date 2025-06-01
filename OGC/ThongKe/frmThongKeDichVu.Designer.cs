namespace OGC.ThongKe
{
    partial class frmThongKeDichVu
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
            dgvKetQuaThongKe_DichVu = new DataGridView();
            rdbDoanhThu_DichVu_Loai = new RadioButton();
            rdbDoanhThu_DichVu = new RadioButton();
            rdbDichVu_SoLuongBan = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblTieuChi = new Label();
            lblLoaiThongKe = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            btnThongKe = new Button();
            lblngayChon = new Label();
            txbKetQua = new TextBox();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            cbNgay = new ComboBox();
            rdbNam = new RadioButton();
            rdbThang = new RadioButton();
            rdbNgay = new RadioButton();
            pnlDoanhThu_dgv = new Panel();
            pnlDuoi = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKeDichVu = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_DichVu).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlTren.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKetQuaThongKe_DichVu
            // 
            dgvKetQuaThongKe_DichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_DichVu.Location = new Point(8, 136);
            dgvKetQuaThongKe_DichVu.Name = "dgvKetQuaThongKe_DichVu";
            dgvKetQuaThongKe_DichVu.Size = new Size(504, 256);
            dgvKetQuaThongKe_DichVu.TabIndex = 3;
            // 
            // rdbDoanhThu_DichVu_Loai
            // 
            rdbDoanhThu_DichVu_Loai.AutoSize = true;
            rdbDoanhThu_DichVu_Loai.Location = new Point(24, 72);
            rdbDoanhThu_DichVu_Loai.Name = "rdbDoanhThu_DichVu_Loai";
            rdbDoanhThu_DichVu_Loai.Size = new Size(172, 19);
            rdbDoanhThu_DichVu_Loai.TabIndex = 2;
            rdbDoanhThu_DichVu_Loai.TabStop = true;
            rdbDoanhThu_DichVu_Loai.Text = "Doanh thu dịch vụ theo loại";
            rdbDoanhThu_DichVu_Loai.UseVisualStyleBackColor = true;
            // 
            // rdbDoanhThu_DichVu
            // 
            rdbDoanhThu_DichVu.AutoSize = true;
            rdbDoanhThu_DichVu.Location = new Point(264, 40);
            rdbDoanhThu_DichVu.Name = "rdbDoanhThu_DichVu";
            rdbDoanhThu_DichVu.Size = new Size(178, 19);
            rdbDoanhThu_DichVu.TabIndex = 2;
            rdbDoanhThu_DichVu.TabStop = true;
            rdbDoanhThu_DichVu.Text = "Doanh thu theo từng dịch vụ";
            rdbDoanhThu_DichVu.UseVisualStyleBackColor = true;
            // 
            // rdbDichVu_SoLuongBan
            // 
            rdbDichVu_SoLuongBan.AutoSize = true;
            rdbDichVu_SoLuongBan.Location = new Point(24, 38);
            rdbDichVu_SoLuongBan.Name = "rdbDichVu_SoLuongBan";
            rdbDichVu_SoLuongBan.Size = new Size(153, 19);
            rdbDichVu_SoLuongBan.TabIndex = 2;
            rdbDichVu_SoLuongBan.TabStop = true;
            rdbDichVu_SoLuongBan.Text = "Số lượng dịch vụ đã bán";
            rdbDichVu_SoLuongBan.UseVisualStyleBackColor = true;
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
            lblLoaiThongKe.Location = new Point(32, 16);
            lblLoaiThongKe.Name = "lblLoaiThongKe";
            lblLoaiThongKe.Size = new Size(79, 15);
            lblLoaiThongKe.TabIndex = 0;
            lblLoaiThongKe.Text = "Loại thống kê";
            // 
            // pnlDoanhThu_ThoiGian
            // 
            pnlDoanhThu_ThoiGian.Controls.Add(btnThongKe);
            pnlDoanhThu_ThoiGian.Controls.Add(lblngayChon);
            pnlDoanhThu_ThoiGian.Controls.Add(txbKetQua);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(cbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(lblLoaiThongKe);
            pnlDoanhThu_ThoiGian.Location = new Point(0, 0);
            pnlDoanhThu_ThoiGian.Name = "pnlDoanhThu_ThoiGian";
            pnlDoanhThu_ThoiGian.Size = new Size(280, 400);
            pnlDoanhThu_ThoiGian.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(144, 216);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 30;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblngayChon
            // 
            lblngayChon.AutoSize = true;
            lblngayChon.Location = new Point(8, 180);
            lblngayChon.Name = "lblngayChon";
            lblngayChon.Size = new Size(38, 15);
            lblngayChon.TabIndex = 29;
            lblngayChon.Text = "label1";
            // 
            // txbKetQua
            // 
            txbKetQua.Location = new Point(112, 176);
            txbKetQua.Name = "txbKetQua";
            txbKetQua.Size = new Size(156, 23);
            txbKetQua.TabIndex = 28;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(168, 136);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(81, 23);
            cbNam.TabIndex = 25;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(168, 88);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(81, 23);
            cbThang.TabIndex = 26;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(168, 40);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(81, 23);
            cbNgay.TabIndex = 27;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(64, 136);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(80, 19);
            rdbNam.TabIndex = 22;
            rdbNam.TabStop = true;
            rdbNam.Text = "Theo Năm";
            rdbNam.UseVisualStyleBackColor = true;
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
            // 
            // rdbThang
            // 
            rdbThang.AutoSize = true;
            rdbThang.Location = new Point(64, 88);
            rdbThang.Name = "rdbThang";
            rdbThang.Size = new Size(87, 19);
            rdbThang.TabIndex = 23;
            rdbThang.TabStop = true;
            rdbThang.Text = "Theo Tháng";
            rdbThang.UseVisualStyleBackColor = true;
            rdbThang.CheckedChanged += rdbThang_CheckedChanged;
            // 
            // rdbNgay
            // 
            rdbNgay.AutoSize = true;
            rdbNgay.Location = new Point(64, 40);
            rdbNgay.Name = "rdbNgay";
            rdbNgay.Size = new Size(82, 19);
            rdbNgay.TabIndex = 24;
            rdbNgay.TabStop = true;
            rdbNgay.Text = "Theo Ngày";
            rdbNgay.UseVisualStyleBackColor = true;
            rdbNgay.CheckedChanged += rdbNgay_CheckedChanged;
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_DichVu);
            pnlDoanhThu_dgv.Controls.Add(rdbDoanhThu_DichVu_Loai);
            pnlDoanhThu_dgv.Controls.Add(rdbDoanhThu_DichVu);
            pnlDoanhThu_dgv.Controls.Add(rdbDichVu_SoLuongBan);
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
            btnXuatExcel.Click += btnXuatExcel_Click;
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
            // lblThongKeDichVu
            // 
            lblThongKeDichVu.AutoSize = true;
            lblThongKeDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeDichVu.Location = new Point(96, 8);
            lblThongKeDichVu.Name = "lblThongKeDichVu";
            lblThongKeDichVu.Size = new Size(146, 21);
            lblThongKeDichVu.TabIndex = 1;
            lblThongKeDichVu.Text = "Thống Kê Dịch Vụ";
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
            pnlTren.Controls.Add(lblThongKeDichVu);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKeDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeDichVu";
            Load += frmThongKeDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_DichVu).EndInit();
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
        private DataGridView dgvKetQuaThongKe_DichVu;
        private RadioButton rdbDoanhThu_DichVu_Loai;
        private RadioButton rdbDoanhThu_DichVu;
        private RadioButton rdbDichVu_SoLuongBan;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKeDichVu;
        private Label lblThongKe;
        private Panel pnlTren;
        private Button btnThongKe;
        private Label lblngayChon;
        private TextBox txbKetQua;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private ComboBox cbNgay;
        private RadioButton rdbNam;
        private RadioButton rdbThang;
        private RadioButton rdbNgay;
    }
}