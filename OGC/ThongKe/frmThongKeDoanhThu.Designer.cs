namespace OGC.ThongKe
{
    partial class frmThongKeDoanhThu
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
            pnlTren = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKeDoanhThu = new Label();
            lblThongKe = new Label();
            pnlDuoi = new Panel();
            pnlDoanhThu_dgv = new Panel();
            dgvKetQuaThongKe_DoanhThu = new DataGridView();
            rdbDoanhThu_NhanVien = new RadioButton();
            rdbDoanhThu_SuatChieu = new RadioButton();
            rdbDoanhThu_Phim = new RadioButton();
            rdbTongDoanhThu = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblTieuChi = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            lblLoaiThongKe = new Label();
            lblNam = new Label();
            lblThang = new Label();
            lblNgay = new Label();
            txbNam = new TextBox();
            txbThang = new TextBox();
            txbNgay = new TextBox();
            dtpNam = new DateTimePicker();
            dtpThang = new DateTimePicker();
            dtpNgay = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbThang = new RadioButton();
            rdbNgay = new RadioButton();
            pnlTren.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_DoanhThu).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTren
            // 
            pnlTren.Controls.Add(btnXuatExcel);
            pnlTren.Controls.Add(btnTaiBieuDo);
            pnlTren.Controls.Add(lblThongKeDoanhThu);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 0;
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
            // lblThongKeDoanhThu
            // 
            lblThongKeDoanhThu.AutoSize = true;
            lblThongKeDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeDoanhThu.Location = new Point(96, 8);
            lblThongKeDoanhThu.Name = "lblThongKeDoanhThu";
            lblThongKeDoanhThu.Size = new Size(170, 21);
            lblThongKeDoanhThu.TabIndex = 1;
            lblThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
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
            // pnlDuoi
            // 
            pnlDuoi.Controls.Add(pnlDoanhThu_dgv);
            pnlDuoi.Controls.Add(pnlDoanhThu_ThoiGian);
            pnlDuoi.Dock = DockStyle.Top;
            pnlDuoi.Location = new Point(0, 50);
            pnlDuoi.Name = "pnlDuoi";
            pnlDuoi.Size = new Size(800, 408);
            pnlDuoi.TabIndex = 1;
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_DoanhThu);
            pnlDoanhThu_dgv.Controls.Add(rdbDoanhThu_NhanVien);
            pnlDoanhThu_dgv.Controls.Add(rdbDoanhThu_SuatChieu);
            pnlDoanhThu_dgv.Controls.Add(rdbDoanhThu_Phim);
            pnlDoanhThu_dgv.Controls.Add(rdbTongDoanhThu);
            pnlDoanhThu_dgv.Controls.Add(lblKetQuaThongKe);
            pnlDoanhThu_dgv.Controls.Add(lblTieuChi);
            pnlDoanhThu_dgv.Location = new Point(280, 0);
            pnlDoanhThu_dgv.Name = "pnlDoanhThu_dgv";
            pnlDoanhThu_dgv.Size = new Size(520, 400);
            pnlDoanhThu_dgv.TabIndex = 1;
            // 
            // dgvKetQuaThongKe_DoanhThu
            // 
            dgvKetQuaThongKe_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_DoanhThu.Location = new Point(8, 136);
            dgvKetQuaThongKe_DoanhThu.Name = "dgvKetQuaThongKe_DoanhThu";
            dgvKetQuaThongKe_DoanhThu.Size = new Size(504, 256);
            dgvKetQuaThongKe_DoanhThu.TabIndex = 3;
            // 
            // rdbDoanhThu_NhanVien
            // 
            rdbDoanhThu_NhanVien.AutoSize = true;
            rdbDoanhThu_NhanVien.Location = new Point(264, 72);
            rdbDoanhThu_NhanVien.Name = "rdbDoanhThu_NhanVien";
            rdbDoanhThu_NhanVien.Size = new Size(191, 19);
            rdbDoanhThu_NhanVien.TabIndex = 2;
            rdbDoanhThu_NhanVien.TabStop = true;
            rdbDoanhThu_NhanVien.Text = "Doanh thu theo từng nhân viên";
            rdbDoanhThu_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbDoanhThu_SuatChieu
            // 
            rdbDoanhThu_SuatChieu.AutoSize = true;
            rdbDoanhThu_SuatChieu.Location = new Point(24, 72);
            rdbDoanhThu_SuatChieu.Name = "rdbDoanhThu_SuatChieu";
            rdbDoanhThu_SuatChieu.Size = new Size(196, 19);
            rdbDoanhThu_SuatChieu.TabIndex = 2;
            rdbDoanhThu_SuatChieu.TabStop = true;
            rdbDoanhThu_SuatChieu.Text = "Doanh thu  theo từng suất chiếu";
            rdbDoanhThu_SuatChieu.UseVisualStyleBackColor = true;
            // 
            // rdbDoanhThu_Phim
            // 
            rdbDoanhThu_Phim.AutoSize = true;
            rdbDoanhThu_Phim.Location = new Point(264, 40);
            rdbDoanhThu_Phim.Name = "rdbDoanhThu_Phim";
            rdbDoanhThu_Phim.Size = new Size(167, 19);
            rdbDoanhThu_Phim.TabIndex = 2;
            rdbDoanhThu_Phim.TabStop = true;
            rdbDoanhThu_Phim.Text = "Doanh thu theo từng phim";
            rdbDoanhThu_Phim.UseVisualStyleBackColor = true;
            // 
            // rdbTongDoanhThu
            // 
            rdbTongDoanhThu.AutoSize = true;
            rdbTongDoanhThu.Location = new Point(24, 38);
            rdbTongDoanhThu.Name = "rdbTongDoanhThu";
            rdbTongDoanhThu.Size = new Size(110, 19);
            rdbTongDoanhThu.TabIndex = 2;
            rdbTongDoanhThu.TabStop = true;
            rdbTongDoanhThu.Text = "Tổng doanh thu";
            rdbTongDoanhThu.UseVisualStyleBackColor = true;
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
            // pnlDoanhThu_ThoiGian
            // 
            pnlDoanhThu_ThoiGian.Controls.Add(lblLoaiThongKe);
            pnlDoanhThu_ThoiGian.Controls.Add(lblNam);
            pnlDoanhThu_ThoiGian.Controls.Add(lblThang);
            pnlDoanhThu_ThoiGian.Controls.Add(lblNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(txbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(txbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(txbNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(dtpNam);
            pnlDoanhThu_ThoiGian.Controls.Add(dtpThang);
            pnlDoanhThu_ThoiGian.Controls.Add(dtpNgay);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNam);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbThang);
            pnlDoanhThu_ThoiGian.Controls.Add(rdbNgay);
            pnlDoanhThu_ThoiGian.Location = new Point(0, 0);
            pnlDoanhThu_ThoiGian.Name = "pnlDoanhThu_ThoiGian";
            pnlDoanhThu_ThoiGian.Size = new Size(280, 400);
            pnlDoanhThu_ThoiGian.TabIndex = 0;
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
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new Point(8, 349);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(38, 15);
            lblNam.TabIndex = 3;
            lblNam.Text = "label1";
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Location = new Point(8, 229);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(38, 15);
            lblThang.TabIndex = 3;
            lblThang.Text = "label1";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(8, 109);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(38, 15);
            lblNgay.TabIndex = 3;
            lblNgay.Text = "label1";
            // 
            // txbNam
            // 
            txbNam.Location = new Point(64, 344);
            txbNam.Name = "txbNam";
            txbNam.Size = new Size(200, 23);
            txbNam.TabIndex = 2;
            // 
            // txbThang
            // 
            txbThang.Location = new Point(64, 224);
            txbThang.Name = "txbThang";
            txbThang.Size = new Size(200, 23);
            txbThang.TabIndex = 2;
            // 
            // txbNgay
            // 
            txbNgay.Location = new Point(64, 104);
            txbNgay.Name = "txbNgay";
            txbNgay.Size = new Size(200, 23);
            txbNgay.TabIndex = 2;
            // 
            // dtpNam
            // 
            dtpNam.Location = new Point(64, 312);
            dtpNam.Name = "dtpNam";
            dtpNam.Size = new Size(200, 23);
            dtpNam.TabIndex = 1;
            // 
            // dtpThang
            // 
            dtpThang.Location = new Point(64, 192);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(200, 23);
            dtpThang.TabIndex = 1;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(64, 72);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(200, 23);
            dtpNgay.TabIndex = 1;
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
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeDoanhThu";
            pnlTren.ResumeLayout(false);
            pnlTren.PerformLayout();
            pnlDuoi.ResumeLayout(false);
            pnlDoanhThu_dgv.ResumeLayout(false);
            pnlDoanhThu_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_DoanhThu).EndInit();
            pnlDoanhThu_ThoiGian.ResumeLayout(false);
            pnlDoanhThu_ThoiGian.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTren;
        private Label lblThongKeDoanhThu;
        private Label lblThongKe;
        private Panel pnlDuoi;
        private Panel pnlDoanhThu_ThoiGian;
        private Panel pnlDoanhThu_dgv;
        private Label lblNgay;
        private TextBox txbNgay;
        private DateTimePicker dtpNgay;
        private RadioButton rdbNgay;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Label lblNam;
        private Label lblThang;
        private TextBox txbNam;
        private TextBox txbThang;
        private DateTimePicker dtpNam;
        private DateTimePicker dtpThang;
        private RadioButton rdbNam;
        private RadioButton rdbThang;
        private RadioButton rdbDoanhThu_Phim;
        private RadioButton rdbTongDoanhThu;
        private RadioButton rdbDoanhThu_NhanVien;
        private RadioButton rdbDoanhThu_SuatChieu;
        private DataGridView dgvKetQuaThongKe_DoanhThu;
        private Label lblKetQuaThongKe;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
    }
}