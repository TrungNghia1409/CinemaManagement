namespace OGC.ThongKe
{
    partial class frmThongKeKhachHang
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
            dgvKetQuaThongKe_KhachHang = new DataGridView();
            rdbKhachHang_DatVe = new RadioButton();
            rdbKhachHang_ChuaTungDatVe = new RadioButton();
            rdbKhachHang_DiemThuong = new RadioButton();
            rdbKhachHang_Tong = new RadioButton();
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
            lblThongKeKhachHang = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_KhachHang).BeginInit();
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
            // dtpNam
            // 
            dtpNam.Location = new Point(104, 312);
            dtpNam.Name = "dtpNam";
            dtpNam.Size = new Size(160, 23);
            dtpNam.TabIndex = 1;
            dtpNam.ValueChanged += dtpNam_ValueChanged;
            // 
            // dtpThang
            // 
            dtpThang.Location = new Point(104, 192);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(160, 23);
            dtpThang.TabIndex = 1;
            dtpThang.ValueChanged += dtpThang_ValueChanged;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(104, 72);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(160, 23);
            dtpNgay.TabIndex = 1;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
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
            // dgvKetQuaThongKe_KhachHang
            // 
            dgvKetQuaThongKe_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_KhachHang.Location = new Point(8, 136);
            dgvKetQuaThongKe_KhachHang.Name = "dgvKetQuaThongKe_KhachHang";
            dgvKetQuaThongKe_KhachHang.Size = new Size(504, 256);
            dgvKetQuaThongKe_KhachHang.TabIndex = 3;
            // 
            // rdbKhachHang_DatVe
            // 
            rdbKhachHang_DatVe.AutoSize = true;
            rdbKhachHang_DatVe.Location = new Point(232, 72);
            rdbKhachHang_DatVe.Name = "rdbKhachHang_DatVe";
            rdbKhachHang_DatVe.Size = new Size(240, 19);
            rdbKhachHang_DatVe.TabIndex = 2;
            rdbKhachHang_DatVe.TabStop = true;
            rdbKhachHang_DatVe.Text = "Danh sách khách hàng đặt vé nhiều nhất";
            rdbKhachHang_DatVe.UseVisualStyleBackColor = true;
            rdbKhachHang_DatVe.CheckedChanged += rdbKhachHang_DatVe_CheckedChanged;
            // 
            // rdbKhachHang_ChuaTungDatVe
            // 
            rdbKhachHang_ChuaTungDatVe.AutoSize = true;
            rdbKhachHang_ChuaTungDatVe.Location = new Point(16, 72);
            rdbKhachHang_ChuaTungDatVe.Name = "rdbKhachHang_ChuaTungDatVe";
            rdbKhachHang_ChuaTungDatVe.Size = new Size(207, 19);
            rdbKhachHang_ChuaTungDatVe.TabIndex = 2;
            rdbKhachHang_ChuaTungDatVe.TabStop = true;
            rdbKhachHang_ChuaTungDatVe.Text = "Danh sách khách chưa từng đặt vé";
            rdbKhachHang_ChuaTungDatVe.UseVisualStyleBackColor = true;
            rdbKhachHang_ChuaTungDatVe.CheckedChanged += rdbKhachHang_ChuaTungDatVe_CheckedChanged;
            // 
            // rdbKhachHang_DiemThuong
            // 
            rdbKhachHang_DiemThuong.AutoSize = true;
            rdbKhachHang_DiemThuong.Location = new Point(232, 40);
            rdbKhachHang_DiemThuong.Name = "rdbKhachHang_DiemThuong";
            rdbKhachHang_DiemThuong.Size = new Size(282, 19);
            rdbKhachHang_DiemThuong.TabIndex = 2;
            rdbKhachHang_DiemThuong.TabStop = true;
            rdbKhachHang_DiemThuong.Text = "Danh sách khách hàng có điểm thưởng cao nhất";
            rdbKhachHang_DiemThuong.UseVisualStyleBackColor = true;
            rdbKhachHang_DiemThuong.CheckedChanged += rdbKhachHang_DiemThuong_CheckedChanged;
            // 
            // rdbKhachHang_Tong
            // 
            rdbKhachHang_Tong.AutoSize = true;
            rdbKhachHang_Tong.Location = new Point(16, 38);
            rdbKhachHang_Tong.Name = "rdbKhachHang_Tong";
            rdbKhachHang_Tong.Size = new Size(203, 19);
            rdbKhachHang_Tong.TabIndex = 2;
            rdbKhachHang_Tong.TabStop = true;
            rdbKhachHang_Tong.Text = "Số khách hàng theo từng khu vực";
            rdbKhachHang_Tong.UseVisualStyleBackColor = true;
            rdbKhachHang_Tong.CheckedChanged += rdbKhachHang_Tong_CheckedChanged;
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
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_KhachHang);
            pnlDoanhThu_dgv.Controls.Add(rdbKhachHang_DatVe);
            pnlDoanhThu_dgv.Controls.Add(rdbKhachHang_ChuaTungDatVe);
            pnlDoanhThu_dgv.Controls.Add(rdbKhachHang_DiemThuong);
            pnlDoanhThu_dgv.Controls.Add(rdbKhachHang_Tong);
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
            // lblThongKeKhachHang
            // 
            lblThongKeKhachHang.AutoSize = true;
            lblThongKeKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeKhachHang.Location = new Point(96, 8);
            lblThongKeKhachHang.Name = "lblThongKeKhachHang";
            lblThongKeKhachHang.Size = new Size(178, 21);
            lblThongKeKhachHang.TabIndex = 1;
            lblThongKeKhachHang.Text = "Thống Kê Khách Hàng";
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
            pnlTren.Controls.Add(lblThongKeKhachHang);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKeKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_KhachHang).EndInit();
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
        private DataGridView dgvKetQuaThongKe_KhachHang;
        private RadioButton rdbKhachHang_DatVe;
        private RadioButton rdbKhachHang_ChuaTungDatVe;
        private RadioButton rdbKhachHang_DiemThuong;
        private RadioButton rdbKhachHang_Tong;
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
        private Label lblThongKeKhachHang;
        private Label lblThongKe;
        private Panel pnlTren;
    }
}