namespace OGC.ThongKe
{
    partial class frmThongKeVe
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
            txbThang = new TextBox();
            txbNgay = new TextBox();
            rdbNam = new RadioButton();
            rdbNgay = new RadioButton();
            dgvKetQuaThongKe_Ve = new DataGridView();
            rdbVe_LoaiPhong = new RadioButton();
            rdbSoVe_Phim = new RadioButton();
            rdbVe_SuatChieu = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblThang = new Label();
            lblNgay = new Label();
            txbNam = new TextBox();
            lblTieuChi = new Label();
            lblLoaiThongKe = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            cbTheoNam = new ComboBox();
            cbTheoThangNam_Nam = new ComboBox();
            cbNam = new ComboBox();
            cbTheoThangNam_Thang = new ComboBox();
            cbThang = new ComboBox();
            cbNgay = new ComboBox();
            lblNam = new Label();
            rdbThang = new RadioButton();
            pnlDoanhThu_dgv = new Panel();
            pnlDuoi = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKeVe = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_Ve).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlTren.SuspendLayout();
            SuspendLayout();
            // 
            // txbThang
            // 
            txbThang.Location = new Point(104, 224);
            txbThang.Name = "txbThang";
            txbThang.Size = new Size(160, 23);
            txbThang.TabIndex = 2;
            // 
            // txbNgay
            // 
            txbNgay.Location = new Point(104, 104);
            txbNgay.Name = "txbNgay";
            txbNgay.Size = new Size(160, 23);
            txbNgay.TabIndex = 2;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(8, 288);
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
            rdbNgay.Location = new Point(8, 48);
            rdbNgay.Name = "rdbNgay";
            rdbNgay.Size = new Size(82, 19);
            rdbNgay.TabIndex = 0;
            rdbNgay.TabStop = true;
            rdbNgay.Text = "Theo Ngày";
            rdbNgay.UseVisualStyleBackColor = true;
            rdbNgay.CheckedChanged += rdbNgay_CheckedChanged;
            // 
            // dgvKetQuaThongKe_Ve
            // 
            dgvKetQuaThongKe_Ve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_Ve.Location = new Point(8, 136);
            dgvKetQuaThongKe_Ve.Name = "dgvKetQuaThongKe_Ve";
            dgvKetQuaThongKe_Ve.Size = new Size(504, 256);
            dgvKetQuaThongKe_Ve.TabIndex = 3;
            // 
            // rdbVe_LoaiPhong
            // 
            rdbVe_LoaiPhong.AutoSize = true;
            rdbVe_LoaiPhong.Location = new Point(24, 40);
            rdbVe_LoaiPhong.Name = "rdbVe_LoaiPhong";
            rdbVe_LoaiPhong.Size = new Size(168, 19);
            rdbVe_LoaiPhong.TabIndex = 2;
            rdbVe_LoaiPhong.TabStop = true;
            rdbVe_LoaiPhong.Text = "Số vé theo từng loại phòng";
            rdbVe_LoaiPhong.UseVisualStyleBackColor = true;
            rdbVe_LoaiPhong.CheckedChanged += rdbVe_LoaiPhong_CheckedChanged;
            // 
            // rdbSoVe_Phim
            // 
            rdbSoVe_Phim.AutoSize = true;
            rdbSoVe_Phim.Location = new Point(24, 72);
            rdbSoVe_Phim.Name = "rdbSoVe_Phim";
            rdbSoVe_Phim.Size = new Size(162, 19);
            rdbSoVe_Phim.TabIndex = 2;
            rdbSoVe_Phim.TabStop = true;
            rdbSoVe_Phim.Text = "Số vé bán theo từng phim";
            rdbSoVe_Phim.UseVisualStyleBackColor = true;
            rdbSoVe_Phim.CheckedChanged += rdbSoVe_Phim_CheckedChanged;
            // 
            // rdbVe_SuatChieu
            // 
            rdbVe_SuatChieu.AutoSize = true;
            rdbVe_SuatChieu.Location = new Point(264, 40);
            rdbVe_SuatChieu.Name = "rdbVe_SuatChieu";
            rdbVe_SuatChieu.Size = new Size(165, 19);
            rdbVe_SuatChieu.TabIndex = 2;
            rdbVe_SuatChieu.TabStop = true;
            rdbVe_SuatChieu.Text = "Số vé theo từng suất chiếu";
            rdbVe_SuatChieu.UseVisualStyleBackColor = true;
            rdbVe_SuatChieu.CheckedChanged += rdbVe_SuatChieu_CheckedChanged;
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
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Location = new Point(8, 229);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(38, 15);
            lblThang.TabIndex = 3;
            lblThang.Text = "label1";
            lblThang.Visible = false;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(8, 109);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(38, 15);
            lblNgay.TabIndex = 3;
            lblNgay.Text = "label1";
            lblNgay.Visible = false;
            // 
            // txbNam
            // 
            txbNam.Location = new Point(104, 344);
            txbNam.Name = "txbNam";
            txbNam.Size = new Size(160, 23);
            txbNam.TabIndex = 2;
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
            pnlDoanhThu_ThoiGian.Controls.Add(cbTheoNam);
            pnlDoanhThu_ThoiGian.Controls.Add(cbTheoThangNam_Nam);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(cbTheoThangNam_Thang);
            pnlDoanhThu_ThoiGian.Controls.Add(cbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(cbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(lblLoaiThongKe);
            pnlDoanhThu_ThoiGian.Controls.Add(lblNam);
            pnlDoanhThu_ThoiGian.Controls.Add(lblThang);
            pnlDoanhThu_ThoiGian.Controls.Add(lblNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(txbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(txbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(txbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNgay);
            pnlDoanhThu_ThoiGian.Location = new Point(0, 0);
            pnlDoanhThu_ThoiGian.Name = "pnlDoanhThu_ThoiGian";
            pnlDoanhThu_ThoiGian.Size = new Size(280, 400);
            pnlDoanhThu_ThoiGian.TabIndex = 0;
            // 
            // cbTheoNam
            // 
            cbTheoNam.FormattingEnabled = true;
            cbTheoNam.Location = new Point(216, 312);
            cbTheoNam.Name = "cbTheoNam";
            cbTheoNam.Size = new Size(48, 23);
            cbTheoNam.TabIndex = 21;
            cbTheoNam.SelectedIndexChanged += cbTheoNam_SelectedIndexChanged;
            // 
            // cbTheoThangNam_Nam
            // 
            cbTheoThangNam_Nam.FormattingEnabled = true;
            cbTheoThangNam_Nam.Location = new Point(216, 192);
            cbTheoThangNam_Nam.Name = "cbTheoThangNam_Nam";
            cbTheoThangNam_Nam.Size = new Size(48, 23);
            cbTheoThangNam_Nam.TabIndex = 21;
            cbTheoThangNam_Nam.SelectedIndexChanged += cbTheoThangNam_Nam_SelectedIndexChanged;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(216, 72);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(48, 23);
            cbNam.TabIndex = 21;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbTheoThangNam_Thang
            // 
            cbTheoThangNam_Thang.FormattingEnabled = true;
            cbTheoThangNam_Thang.Location = new Point(160, 192);
            cbTheoThangNam_Thang.Name = "cbTheoThangNam_Thang";
            cbTheoThangNam_Thang.Size = new Size(48, 23);
            cbTheoThangNam_Thang.TabIndex = 20;
            cbTheoThangNam_Thang.SelectedIndexChanged += cbTheoThangNam_Thang_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(160, 72);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(48, 23);
            cbThang.TabIndex = 20;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(104, 72);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(48, 23);
            cbNgay.TabIndex = 19;
            cbNgay.SelectedIndexChanged += cbNgay_SelectedIndexChanged;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new Point(8, 349);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(38, 15);
            lblNam.TabIndex = 3;
            lblNam.Text = "label1";
            lblNam.Visible = false;
            // 
            // rdbThang
            // 
            rdbThang.AutoSize = true;
            rdbThang.Location = new Point(8, 168);
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
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_Ve);
            pnlDoanhThu_dgv.Controls.Add(rdbVe_LoaiPhong);
            pnlDoanhThu_dgv.Controls.Add(rdbSoVe_Phim);
            pnlDoanhThu_dgv.Controls.Add(rdbVe_SuatChieu);
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
            // lblThongKeVe
            // 
            lblThongKeVe.AutoSize = true;
            lblThongKeVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeVe.Location = new Point(96, 8);
            lblThongKeVe.Name = "lblThongKeVe";
            lblThongKeVe.Size = new Size(105, 21);
            lblThongKeVe.TabIndex = 1;
            lblThongKeVe.Text = "Thống Kê Vé";
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
            pnlTren.Controls.Add(lblThongKeVe);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKeVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeVe";
            Load += frmThongKeVe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_Ve).EndInit();
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

        private TextBox txbThang;
        private TextBox txbNgay;
        private RadioButton rdbNam;
        private RadioButton rdbNgay;
        private DataGridView dgvKetQuaThongKe_Ve;
        private RadioButton rdbVe_LoaiPhong;
        private RadioButton rdbSoVe_Phim;
        private RadioButton rdbVe_SuatChieu;
        private Label lblKetQuaThongKe;
        private Label lblThang;
        private Label lblNgay;
        private TextBox txbNam;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private Label lblNam;
        private RadioButton rdbThang;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKeVe;
        private Label lblThongKe;
        private Panel pnlTren;
        private ComboBox cbNgay;
        private ComboBox cbThang;
        private ComboBox cbNam;
        private ComboBox cbTheoNam;
        private ComboBox cbTheoThangNam_Nam;
        private ComboBox cbTheoThangNam_Thang;
    }
}