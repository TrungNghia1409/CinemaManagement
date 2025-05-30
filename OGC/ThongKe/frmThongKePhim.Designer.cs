namespace OGC.ThongKe
{
    partial class frmThongKePhim
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
            dgvKetQuaThongKe_Phim = new DataGridView();
            rdbPhim_DoanhThu_Thap = new RadioButton();
            rdbPhim_DatVe_NhieuNhat = new RadioButton();
            rdbPhim_DoanhThu_Cao = new RadioButton();
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
            rdbPhim_ThongKe = new RadioButton();
            pnlDuoi = new Panel();
            btnXuatExcel = new Button();
            btnTaiBieuDo = new Button();
            lblThongKePhim = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_Phim).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlTren.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKetQuaThongKe_Phim
            // 
            dgvKetQuaThongKe_Phim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_Phim.Location = new Point(8, 136);
            dgvKetQuaThongKe_Phim.Name = "dgvKetQuaThongKe_Phim";
            dgvKetQuaThongKe_Phim.Size = new Size(504, 256);
            dgvKetQuaThongKe_Phim.TabIndex = 3;
            // 
            // rdbPhim_DoanhThu_Thap
            // 
            rdbPhim_DoanhThu_Thap.AutoSize = true;
            rdbPhim_DoanhThu_Thap.Location = new Point(264, 72);
            rdbPhim_DoanhThu_Thap.Name = "rdbPhim_DoanhThu_Thap";
            rdbPhim_DoanhThu_Thap.Size = new Size(223, 19);
            rdbPhim_DoanhThu_Thap.TabIndex = 2;
            rdbPhim_DoanhThu_Thap.TabStop = true;
            rdbPhim_DoanhThu_Thap.Text = "Danh sách phim doanh thu thấp nhất";
            rdbPhim_DoanhThu_Thap.UseVisualStyleBackColor = true;
            // 
            // rdbPhim_DatVe_NhieuNhat
            // 
            rdbPhim_DatVe_NhieuNhat.AutoSize = true;
            rdbPhim_DatVe_NhieuNhat.Location = new Point(24, 72);
            rdbPhim_DatVe_NhieuNhat.Name = "rdbPhim_DatVe_NhieuNhat";
            rdbPhim_DatVe_NhieuNhat.Size = new Size(236, 19);
            rdbPhim_DatVe_NhieuNhat.TabIndex = 2;
            rdbPhim_DatVe_NhieuNhat.TabStop = true;
            rdbPhim_DatVe_NhieuNhat.Text = "Danh sách phim được đặt vé nhiều nhất";
            rdbPhim_DatVe_NhieuNhat.UseVisualStyleBackColor = true;
            // 
            // rdbPhim_DoanhThu_Cao
            // 
            rdbPhim_DoanhThu_Cao.AutoSize = true;
            rdbPhim_DoanhThu_Cao.Location = new Point(264, 40);
            rdbPhim_DoanhThu_Cao.Name = "rdbPhim_DoanhThu_Cao";
            rdbPhim_DoanhThu_Cao.Size = new Size(218, 19);
            rdbPhim_DoanhThu_Cao.TabIndex = 2;
            rdbPhim_DoanhThu_Cao.TabStop = true;
            rdbPhim_DoanhThu_Cao.Text = "Danh sách phim doanh thu cao nhất";
            rdbPhim_DoanhThu_Cao.UseVisualStyleBackColor = true;
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
            btnThongKe.TabIndex = 39;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // txbKetQua
            // 
            txbKetQua.Location = new Point(8, 176);
            txbKetQua.Name = "txbKetQua";
            txbKetQua.Size = new Size(260, 23);
            txbKetQua.TabIndex = 37;
            txbKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(168, 136);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(81, 23);
            cbNam.TabIndex = 34;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(168, 88);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(81, 23);
            cbThang.TabIndex = 35;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(168, 40);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(81, 23);
            cbNgay.TabIndex = 36;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(64, 136);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(80, 19);
            rdbNam.TabIndex = 31;
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
            rdbThang.TabIndex = 32;
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
            rdbNgay.TabIndex = 33;
            rdbNgay.TabStop = true;
            rdbNgay.Text = "Theo Ngày";
            rdbNgay.UseVisualStyleBackColor = true;
            rdbNgay.CheckedChanged += rdbNgay_CheckedChanged;
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_Phim);
            pnlDoanhThu_dgv.Controls.Add(rdbPhim_ThongKe);
            pnlDoanhThu_dgv.Controls.Add(rdbPhim_DoanhThu_Thap);
            pnlDoanhThu_dgv.Controls.Add(rdbPhim_DatVe_NhieuNhat);
            pnlDoanhThu_dgv.Controls.Add(rdbPhim_DoanhThu_Cao);
            pnlDoanhThu_dgv.Controls.Add(lblKetQuaThongKe);
            pnlDoanhThu_dgv.Controls.Add(lblTieuChi);
            pnlDoanhThu_dgv.Location = new Point(280, 0);
            pnlDoanhThu_dgv.Name = "pnlDoanhThu_dgv";
            pnlDoanhThu_dgv.Size = new Size(520, 400);
            pnlDoanhThu_dgv.TabIndex = 1;
            // 
            // rdbPhim_ThongKe
            // 
            rdbPhim_ThongKe.AutoSize = true;
            rdbPhim_ThongKe.Location = new Point(24, 40);
            rdbPhim_ThongKe.Name = "rdbPhim_ThongKe";
            rdbPhim_ThongKe.Size = new Size(105, 19);
            rdbPhim_ThongKe.TabIndex = 2;
            rdbPhim_ThongKe.TabStop = true;
            rdbPhim_ThongKe.Text = "Thống kê phim";
            rdbPhim_ThongKe.UseVisualStyleBackColor = true;
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
            // lblThongKePhim
            // 
            lblThongKePhim.AutoSize = true;
            lblThongKePhim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKePhim.Location = new Point(96, 8);
            lblThongKePhim.Name = "lblThongKePhim";
            lblThongKePhim.Size = new Size(126, 21);
            lblThongKePhim.TabIndex = 1;
            lblThongKePhim.Text = "Thống Kê Phim";
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
            pnlTren.Controls.Add(lblThongKePhim);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKePhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKePhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKePhim";
            Load += frmThongKePhim_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_Phim).EndInit();
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
        private DataGridView dgvKetQuaThongKe_Phim;
        private RadioButton rdbPhim_DoanhThu_Thap;
        private RadioButton rdbPhim_DatVe_NhieuNhat;
        private RadioButton rdbPhim_DoanhThu_Cao;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKePhim;
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
        private RadioButton rdbPhim_ThongKe;
    }
}