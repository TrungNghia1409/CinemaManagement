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
            txbThang = new TextBox();
            txbNgay = new TextBox();
            dtpNam = new DateTimePicker();
            dtpThang = new DateTimePicker();
            dtpNgay = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNgay = new RadioButton();
            dgvKetQuaThongKe_PhongChieu = new DataGridView();
            rdbPhongChieu_TyLeSuDung = new RadioButton();
            rdbPhongChieu_SoLuong = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblThang = new Label();
            lblNgay = new Label();
            txbNam = new TextBox();
            lblTieuChi = new Label();
            lblLoaiThongKe = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            lblNam = new Label();
            rdbThang = new RadioButton();
            pnlDoanhThu_dgv = new Panel();
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
            // dgvKetQuaThongKe_PhongChieu
            // 
            dgvKetQuaThongKe_PhongChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_PhongChieu.Location = new Point(8, 96);
            dgvKetQuaThongKe_PhongChieu.Name = "dgvKetQuaThongKe_PhongChieu";
            dgvKetQuaThongKe_PhongChieu.Size = new Size(504, 296);
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
            // rdbPhongChieu_SoLuong
            // 
            rdbPhongChieu_SoLuong.AutoSize = true;
            rdbPhongChieu_SoLuong.Location = new Point(24, 38);
            rdbPhongChieu_SoLuong.Name = "rdbPhongChieu_SoLuong";
            rdbPhongChieu_SoLuong.Size = new Size(222, 19);
            rdbPhongChieu_SoLuong.TabIndex = 2;
            rdbPhongChieu_SoLuong.TabStop = true;
            rdbPhongChieu_SoLuong.Text = "Số lượng suất chiếu theo từng phòng";
            rdbPhongChieu_SoLuong.UseVisualStyleBackColor = true;
            // 
            // lblKetQuaThongKe
            // 
            lblKetQuaThongKe.AutoSize = true;
            lblKetQuaThongKe.Location = new Point(16, 72);
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
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new Point(8, 349);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(38, 15);
            lblNam.TabIndex = 3;
            lblNam.Text = "label1";
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
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_PhongChieu);
            pnlDoanhThu_dgv.Controls.Add(rdbPhongChieu_TyLeSuDung);
            pnlDoanhThu_dgv.Controls.Add(rdbPhongChieu_SoLuong);
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

        private TextBox txbThang;
        private TextBox txbNgay;
        private DateTimePicker dtpNam;
        private DateTimePicker dtpThang;
        private DateTimePicker dtpNgay;
        private RadioButton rdbNam;
        private RadioButton rdbNgay;
        private DataGridView dgvKetQuaThongKe_PhongChieu;
        private RadioButton rdbPhongChieu_TyLeSuDung;
        private RadioButton rdbPhongChieu_SoLuong;
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
        private Label lblThongKePhongChieu;
        private Label lblThongKe;
        private Panel pnlTren;
    }
}