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
            txbThang = new TextBox();
            txbNgay = new TextBox();
            dtpNam = new DateTimePicker();
            dtpThang = new DateTimePicker();
            dtpNgay = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNgay = new RadioButton();
            dgvKetQuaThongKe_Phim = new DataGridView();
            rdbPhim_DoanhThu_Thap = new RadioButton();
            rdbPhim_DatVe_NhieuNhat = new RadioButton();
            rdbPhim_DoanhThu_Cao = new RadioButton();
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
            rdbPhim_DoanhThu_Thap.Location = new Point(24, 40);
            rdbPhim_DoanhThu_Thap.Name = "rdbPhim_DoanhThu_Thap";
            rdbPhim_DoanhThu_Thap.Size = new Size(223, 19);
            rdbPhim_DoanhThu_Thap.TabIndex = 2;
            rdbPhim_DoanhThu_Thap.TabStop = true;
            rdbPhim_DoanhThu_Thap.Text = "Danh sách phim doanh thu thấp nhất";
            rdbPhim_DoanhThu_Thap.UseVisualStyleBackColor = true;
            rdbPhim_DoanhThu_Thap.CheckedChanged += rdbPhim_DoanhThu_Thap_CheckedChanged;
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
            rdbPhim_DatVe_NhieuNhat.CheckedChanged += rdbPhim_DatVe_NhieuNhat_CheckedChanged;
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
            rdbPhim_DoanhThu_Cao.CheckedChanged += rdbPhim_DoanhThu_Cao_CheckedChanged;
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
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_Phim);
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

        private TextBox txbThang;
        private TextBox txbNgay;
        private DateTimePicker dtpNam;
        private DateTimePicker dtpThang;
        private DateTimePicker dtpNgay;
        private RadioButton rdbNam;
        private RadioButton rdbNgay;
        private DataGridView dgvKetQuaThongKe_Phim;
        private RadioButton rdbPhim_DoanhThu_Thap;
        private RadioButton rdbPhim_DatVe_NhieuNhat;
        private RadioButton rdbPhim_DoanhThu_Cao;
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
        private Label lblThongKePhim;
        private Label lblThongKe;
        private Panel pnlTren;
    }
}