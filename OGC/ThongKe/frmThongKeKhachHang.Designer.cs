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
            dgvKetQuaThongKe_KhachHang = new DataGridView();
            rdbKhachHang_DatVe = new RadioButton();
            rdbKhachHang_ChuaTungDatVe = new RadioButton();
            rdbKhachHang_DiemThuong = new RadioButton();
            rdbKhachHang_Tong = new RadioButton();
            lblKetQuaThongKe = new Label();
            lblTieuChi = new Label();
            lblLoaiThongKe = new Label();
            pnlDoanhThu_ThoiGian = new Panel();
            btnThongKe = new Button();
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
            btnThongKe.Location = new Point(96, 216);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 30;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // txbKetQua
            // 
            txbKetQua.Location = new Point(8, 176);
            txbKetQua.Name = "txbKetQua";
            txbKetQua.Size = new Size(260, 23);
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
            Load += frmThongKeKhachHang_Load;
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
        private DataGridView dgvKetQuaThongKe_KhachHang;
        private RadioButton rdbKhachHang_DatVe;
        private RadioButton rdbKhachHang_ChuaTungDatVe;
        private RadioButton rdbKhachHang_DiemThuong;
        private RadioButton rdbKhachHang_Tong;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKeKhachHang;
        private Label lblThongKe;
        private Panel pnlTren;
        private Button btnThongKe;
        private TextBox txbKetQua;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private ComboBox cbNgay;
        private RadioButton rdbNam;
        private RadioButton rdbThang;
        private RadioButton rdbNgay;
    }
}