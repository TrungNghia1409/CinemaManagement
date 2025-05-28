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
            txbThang = new TextBox();
            txbNgay = new TextBox();
            dtpNam = new DateTimePicker();
            dtpThang = new DateTimePicker();
            dtpNgay = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNgay = new RadioButton();
            dgvKetQuaThongKe_DichVu = new DataGridView();
            rdbDoanhThu_DichVu_Loai = new RadioButton();
            rdbDoanhThu_DichVu = new RadioButton();
            rdbDichVu_SoLuongBan = new RadioButton();
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

        private TextBox txbThang;
        private TextBox txbNgay;
        private DateTimePicker dtpNam;
        private DateTimePicker dtpThang;
        private DateTimePicker dtpNgay;
        private RadioButton rdbNam;
        private RadioButton rdbNgay;
        private DataGridView dgvKetQuaThongKe_DichVu;
        private RadioButton rdbDoanhThu_DichVu_Loai;
        private RadioButton rdbDoanhThu_DichVu;
        private RadioButton rdbDichVu_SoLuongBan;
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
        private Label lblThongKeDichVu;
        private Label lblThongKe;
        private Panel pnlTren;
    }
}