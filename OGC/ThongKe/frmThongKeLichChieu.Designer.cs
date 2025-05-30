namespace OGC.ThongKe
{
    partial class frmThongKeLichChieu
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
            dgvKetQuaThongKe_LichChieu = new DataGridView();
            rdbLichChieu_DongKhach = new RadioButton();
            rdbLichChieu_SoLuongPhim = new RadioButton();
            rdbLichChieu_VangKhach = new RadioButton();
            rdbLichChieu_SoLuongKhach = new RadioButton();
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
            lblThongKeLichChieu = new Label();
            lblThongKe = new Label();
            pnlTren = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_LichChieu).BeginInit();
            pnlDoanhThu_ThoiGian.SuspendLayout();
            pnlDoanhThu_dgv.SuspendLayout();
            pnlDuoi.SuspendLayout();
            pnlTren.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKetQuaThongKe_LichChieu
            // 
            dgvKetQuaThongKe_LichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThongKe_LichChieu.Location = new Point(8, 136);
            dgvKetQuaThongKe_LichChieu.Name = "dgvKetQuaThongKe_LichChieu";
            dgvKetQuaThongKe_LichChieu.Size = new Size(504, 256);
            dgvKetQuaThongKe_LichChieu.TabIndex = 3;
            // 
            // rdbLichChieu_DongKhach
            // 
            rdbLichChieu_DongKhach.AutoSize = true;
            rdbLichChieu_DongKhach.Location = new Point(264, 72);
            rdbLichChieu_DongKhach.Name = "rdbLichChieu_DongKhach";
            rdbLichChieu_DongKhach.Size = new Size(229, 19);
            rdbLichChieu_DongKhach.TabIndex = 2;
            rdbLichChieu_DongKhach.TabStop = true;
            rdbLichChieu_DongKhach.Text = "Danh sách lịch chiếu nhiều khách nhất";
            rdbLichChieu_DongKhach.UseVisualStyleBackColor = true;
            // 
            // rdbLichChieu_SoLuongPhim
            // 
            rdbLichChieu_SoLuongPhim.AutoSize = true;
            rdbLichChieu_SoLuongPhim.Location = new Point(24, 72);
            rdbLichChieu_SoLuongPhim.Name = "rdbLichChieu_SoLuongPhim";
            rdbLichChieu_SoLuongPhim.Size = new Size(181, 19);
            rdbLichChieu_SoLuongPhim.TabIndex = 2;
            rdbLichChieu_SoLuongPhim.TabStop = true;
            rdbLichChieu_SoLuongPhim.Text = "Số lượng phim mỗi lịch chiếu";
            rdbLichChieu_SoLuongPhim.UseVisualStyleBackColor = true;
            // 
            // rdbLichChieu_VangKhach
            // 
            rdbLichChieu_VangKhach.AutoSize = true;
            rdbLichChieu_VangKhach.Location = new Point(264, 40);
            rdbLichChieu_VangKhach.Name = "rdbLichChieu_VangKhach";
            rdbLichChieu_VangKhach.Size = new Size(206, 19);
            rdbLichChieu_VangKhach.TabIndex = 2;
            rdbLichChieu_VangKhach.TabStop = true;
            rdbLichChieu_VangKhach.Text = "Danh sách lịch chiếu ít khách nhất";
            rdbLichChieu_VangKhach.UseVisualStyleBackColor = true;
            // 
            // rdbLichChieu_SoLuongKhach
            // 
            rdbLichChieu_SoLuongKhach.AutoSize = true;
            rdbLichChieu_SoLuongKhach.Location = new Point(24, 38);
            rdbLichChieu_SoLuongKhach.Name = "rdbLichChieu_SoLuongKhach";
            rdbLichChieu_SoLuongKhach.Size = new Size(185, 19);
            rdbLichChieu_SoLuongKhach.TabIndex = 2;
            rdbLichChieu_SoLuongKhach.TabStop = true;
            rdbLichChieu_SoLuongKhach.Text = "Số lượng khách mỗi lịch chiếu";
            rdbLichChieu_SoLuongKhach.UseVisualStyleBackColor = true;
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
            btnThongKe.Location = new Point(144, 224);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 21;
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
            lblngayChon.TabIndex = 20;
            lblngayChon.Text = "label1";
            // 
            // txbKetQua
            // 
            txbKetQua.Location = new Point(96, 184);
            txbKetQua.Name = "txbKetQua";
            txbKetQua.Size = new Size(172, 23);
            txbKetQua.TabIndex = 19;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(168, 144);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(81, 23);
            cbNam.TabIndex = 16;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(168, 96);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(81, 23);
            cbThang.TabIndex = 17;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(168, 48);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(81, 23);
            cbNgay.TabIndex = 18;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(64, 144);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(80, 19);
            rdbNam.TabIndex = 13;
            rdbNam.TabStop = true;
            rdbNam.Text = "Theo Năm";
            rdbNam.UseVisualStyleBackColor = true;
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
            // 
            // rdbThang
            // 
            rdbThang.AutoSize = true;
            rdbThang.Location = new Point(64, 96);
            rdbThang.Name = "rdbThang";
            rdbThang.Size = new Size(87, 19);
            rdbThang.TabIndex = 14;
            rdbThang.TabStop = true;
            rdbThang.Text = "Theo Tháng";
            rdbThang.UseVisualStyleBackColor = true;
            rdbThang.CheckedChanged += rdbThang_CheckedChanged;
            // 
            // rdbNgay
            // 
            rdbNgay.AutoSize = true;
            rdbNgay.Location = new Point(64, 48);
            rdbNgay.Name = "rdbNgay";
            rdbNgay.Size = new Size(82, 19);
            rdbNgay.TabIndex = 15;
            rdbNgay.TabStop = true;
            rdbNgay.Text = "Theo Ngày";
            rdbNgay.UseVisualStyleBackColor = true;
            rdbNgay.CheckedChanged += rdbNgay_CheckedChanged;
            // 
            // pnlDoanhThu_dgv
            // 
            pnlDoanhThu_dgv.Controls.Add(dgvKetQuaThongKe_LichChieu);
            pnlDoanhThu_dgv.Controls.Add(rdbLichChieu_DongKhach);
            pnlDoanhThu_dgv.Controls.Add(rdbLichChieu_SoLuongPhim);
            pnlDoanhThu_dgv.Controls.Add(rdbLichChieu_VangKhach);
            pnlDoanhThu_dgv.Controls.Add(rdbLichChieu_SoLuongKhach);
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
            // lblThongKeLichChieu
            // 
            lblThongKeLichChieu.AutoSize = true;
            lblThongKeLichChieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeLichChieu.Location = new Point(96, 8);
            lblThongKeLichChieu.Name = "lblThongKeLichChieu";
            lblThongKeLichChieu.Size = new Size(165, 21);
            lblThongKeLichChieu.TabIndex = 1;
            lblThongKeLichChieu.Text = "Thống Kê Lịch Chiếu";
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
            pnlTren.Controls.Add(lblThongKeLichChieu);
            pnlTren.Controls.Add(lblThongKe);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(800, 50);
            pnlTren.TabIndex = 2;
            // 
            // frmThongKeLichChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmThongKeLichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeLichChieu";
            Load += frmThongKeLichChieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThongKe_LichChieu).EndInit();
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
        private DataGridView dgvKetQuaThongKe_LichChieu;
        private RadioButton rdbLichChieu_DongKhach;
        private RadioButton rdbLichChieu_SoLuongPhim;
        private RadioButton rdbLichChieu_VangKhach;
        private RadioButton rdbLichChieu_SoLuongKhach;
        private Label lblKetQuaThongKe;
        private Label lblTieuChi;
        private Label lblLoaiThongKe;
        private Panel pnlDoanhThu_ThoiGian;
        private Panel pnlDoanhThu_dgv;
        private Panel pnlDuoi;
        private Button btnXuatExcel;
        private Button btnTaiBieuDo;
        private Label lblThongKeLichChieu;
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