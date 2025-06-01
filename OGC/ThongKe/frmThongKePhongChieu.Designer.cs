namespace OGC.ThongKe
{
    partial class frmThongKePhongChieu
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
            dgvKetQuaThongKe_PhongChieu = new DataGridView();
            rdbPhongChieu_TyLeSuDung = new RadioButton();
            rdbPhongChieu_SoLuongSuatChieu = new RadioButton();
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
            rdbThang = new RadioButton();
            pnlDoanhThu_dgv = new Panel();
            rdbPhongChieu_SoLuongVe = new RadioButton();
            pnlDuoi = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKePhongChieu = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_PhongChieu).BeginInit();
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
            // dgvKetQuaThongKe_PhongChieu
            // 
            dgvKetQuaThongKe_PhongChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_PhongChieu.Location = new Point(8, 128);
            dgvKetQuaThongKe_PhongChieu.Name = "dgvKetQuaThongKe_PhongChieu";
            dgvKetQuaThongKe_PhongChieu.Size = new Size(504, 264);
            dgvKetQuaThongKe_PhongChieu.TabIndex = 3;
            // 
            // rdbPhongChieu_TyLeSuDung
            // 
            rdbPhongChieu_TyLeSuDung.AutoSize = true;
            rdbPhongChieu_TyLeSuDung.Location = new Point(264, 40);
            rdbPhongChieu_TyLeSuDung.Name = "rdbPhongChieu_TyLeSuDung";
            rdbPhongChieu_TyLeSuDung.Size = new Size(163, 19);
            rdbPhongChieu_TyLeSuDung.TabIndex = 2;
            rdbPhongChieu_TyLeSuDung.TabStop = true;
            rdbPhongChieu_TyLeSuDung.Text = "Tỷ lệ phòng được sử dụng";
            rdbPhongChieu_TyLeSuDung.UseVisualStyleBackColor = true;
            // 
            // rdbPhongChieu_SoLuongSuatChieu
            // 
            rdbPhongChieu_SoLuongSuatChieu.AutoSize = true;
            rdbPhongChieu_SoLuongSuatChieu.Location = new Point(24, 38);
            rdbPhongChieu_SoLuongSuatChieu.Name = "rdbPhongChieu_SoLuongSuatChieu";
            rdbPhongChieu_SoLuongSuatChieu.Size = new Size(222, 19);
            rdbPhongChieu_SoLuongSuatChieu.TabIndex = 2;
            rdbPhongChieu_SoLuongSuatChieu.TabStop = true;
            rdbPhongChieu_SoLuongSuatChieu.Text = "Số lượng suất chiếu theo từng phòng";
            rdbPhongChieu_SoLuongSuatChieu.UseVisualStyleBackColor = true;
            // 
            // lblKetQuaThongKe
            // 
            lblKetQuaThongKe.AutoSize = true;
            lblKetQuaThongKe.Location = new Point(16, 96);
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
            lblLoaiThongKe.Location = new Point(16, 16);
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
            pnlDoanhThu_ThoiGian.Controls.Add(lblLoaiThongKe);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNgay);
            pnlDoanhThu_ThoiGian.Location = new Point(0, 0);
            pnlDoanhThu_ThoiGian.Name = "pnlDoanhThu_ThoiGian";
            pnlDoanhThu_ThoiGian.Size = new Size(280, 400);
            pnlDoanhThu_ThoiGian.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(136, 224);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblngayChon
            // 
            lblngayChon.AutoSize = true;
            lblngayChon.Location = new Point(8, 187);
            lblngayChon.Name = "lblngayChon";
            lblngayChon.Size = new Size(38, 15);
            lblngayChon.TabIndex = 11;
            lblngayChon.Text = "label1";
            // 
            // txbKetQua
            // 
            txbKetQua.Location = new Point(104, 184);
            txbKetQua.Name = "txbKetQua";
            txbKetQua.Size = new Size(172, 23);
            txbKetQua.TabIndex = 10;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(160, 144);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(81, 23);
            cbNam.TabIndex = 7;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(160, 96);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(81, 23);
            cbThang.TabIndex = 8;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged_1;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(160, 48);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(81, 23);
            cbNgay.TabIndex = 9;
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
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_PhongChieu);
            pnlDoanhThu_dgv.Controls.Add(rdbPhongChieu_TyLeSuDung);
            pnlDoanhThu_dgv.Controls.Add(rdbPhongChieu_SoLuongVe);
            pnlDoanhThu_dgv.Controls.Add(rdbPhongChieu_SoLuongSuatChieu);
            pnlDoanhThu_dgv.Controls.Add(lblKetQuaThongKe);
            pnlDoanhThu_dgv.Controls.Add(lblTieuChi);
            pnlDoanhThu_dgv.Location = new Point(280, 0);
            pnlDoanhThu_dgv.Name = "pnlDoanhThu_dgv";
            pnlDoanhThu_dgv.Size = new Size(520, 400);
            pnlDoanhThu_dgv.TabIndex = 1;
            // 
            // rdbPhongChieu_SoLuongVe
            // 
            rdbPhongChieu_SoLuongVe.AutoSize = true;
            rdbPhongChieu_SoLuongVe.Location = new Point(24, 64);
            rdbPhongChieu_SoLuongVe.Name = "rdbPhongChieu_SoLuongVe";
            rdbPhongChieu_SoLuongVe.Size = new Size(180, 19);
            rdbPhongChieu_SoLuongVe.TabIndex = 2;
            rdbPhongChieu_SoLuongVe.TabStop = true;
            rdbPhongChieu_SoLuongVe.Text = "Số lượng vé theo từng phòng";
            rdbPhongChieu_SoLuongVe.UseVisualStyleBackColor = true;
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
            // lblThongKePhongChieu
            // 
            lblThongKePhongChieu.AutoSize = true;
            lblThongKePhongChieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKePhongChieu.Location = new Point(96, 8);
            lblThongKePhongChieu.Name = "lblThongKePhongChieu";
            lblThongKePhongChieu.Size = new Size(184, 21);
            lblThongKePhongChieu.TabIndex = 1;
            lblThongKePhongChieu.Text = "Thống Kê Phòng Chiếu";
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
            pnlTren.Controls.Add(lblThongKePhongChieu);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKePhongChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKePhongChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKePhongChieu";
            Load += frmThongKePhongChieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_PhongChieu).EndInit();
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
        private DataGridView dgvKetQuaThongKe_PhongChieu;
        private RadioButton rdbPhongChieu_TyLeSuDung;
        private RadioButton rdbPhongChieu_SoLuongSuatChieu;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private RadioButton rdbThang;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKePhongChieu;
        private Label lblThongKe;
        private Panel pnlTren;
        private Label lblngayChon;
        private TextBox txbKetQua;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private ComboBox cbNgay;
        private RadioButton rdbPhongChieu_SoLuongVe;
        private Button btnThongKe;
    }
}