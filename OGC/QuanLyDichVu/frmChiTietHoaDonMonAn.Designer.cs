namespace OGC.QuanLyDichVu
{
    partial class frmChiTietHoaDonMonAn
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
            dgvChiTiet = new DataGridView();
            btnXuatHoaDon = new Button();
            lblTen = new Label();
            lblTongTien = new Label();
            lblTienKhachDua = new Label();
            lblTienThoi = new Label();
            lblTongTien_KetQua = new Label();
            lblTienThoi_KetQua = new Label();
            lblNgayLap = new Label();
            txbTienKhachDua = new TextBox();
            ptbMaQR = new PictureBox();
            lblMucGiam = new Label();
            lblMucGiam_KetQua = new Label();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaQR).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(8, 176);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(568, 208);
            dgvChiTiet.TabIndex = 0;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Location = new Point(112, 392);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(152, 23);
            btnXuatHoaDon.TabIndex = 1;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(8, 8);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(376, 23);
            lblTen.TabIndex = 2;
            lblTen.Text = "Phiếu thanh toán OGC Cinema";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(16, 48);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(160, 21);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTienKhachDua
            // 
            lblTienKhachDua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienKhachDua.Location = new Point(16, 80);
            lblTienKhachDua.Name = "lblTienKhachDua";
            lblTienKhachDua.Size = new Size(160, 21);
            lblTienKhachDua.TabIndex = 2;
            lblTienKhachDua.Text = "Tiền khách đưa";
            lblTienKhachDua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTienThoi
            // 
            lblTienThoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienThoi.Location = new Point(16, 144);
            lblTienThoi.Name = "lblTienThoi";
            lblTienThoi.Size = new Size(160, 21);
            lblTienThoi.TabIndex = 2;
            lblTienThoi.Text = "Tiền thối lại";
            lblTienThoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien_KetQua
            // 
            lblTongTien_KetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien_KetQua.Location = new Point(192, 48);
            lblTongTien_KetQua.Name = "lblTongTien_KetQua";
            lblTongTien_KetQua.Size = new Size(160, 21);
            lblTongTien_KetQua.TabIndex = 2;
            lblTongTien_KetQua.Text = "Tổng tiền";
            lblTongTien_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTienThoi_KetQua
            // 
            lblTienThoi_KetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienThoi_KetQua.Location = new Point(192, 144);
            lblTienThoi_KetQua.Name = "lblTienThoi_KetQua";
            lblTienThoi_KetQua.Size = new Size(160, 21);
            lblTienThoi_KetQua.TabIndex = 2;
            lblTienThoi_KetQua.Text = "Tiền thối lại";
            lblTienThoi_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayLap.Location = new Point(408, 8);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(160, 21);
            lblNgayLap.TabIndex = 2;
            lblNgayLap.Text = "Ngày lập";
            lblNgayLap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTienKhachDua
            // 
            txbTienKhachDua.Location = new Point(184, 80);
            txbTienKhachDua.Name = "txbTienKhachDua";
            txbTienKhachDua.Size = new Size(168, 23);
            txbTienKhachDua.TabIndex = 3;
            txbTienKhachDua.TextChanged += txbTienKhachDua_TextChanged;
            txbTienKhachDua.Leave += txbTienKhachDua_Leave;
            // 
            // ptbMaQR
            // 
            ptbMaQR.Location = new Point(440, 40);
            ptbMaQR.Name = "ptbMaQR";
            ptbMaQR.Size = new Size(90, 90);
            ptbMaQR.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMaQR.TabIndex = 4;
            ptbMaQR.TabStop = false;
            // 
            // lblMucGiam
            // 
            lblMucGiam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMucGiam.Location = new Point(16, 112);
            lblMucGiam.Name = "lblMucGiam";
            lblMucGiam.Size = new Size(160, 21);
            lblMucGiam.TabIndex = 2;
            lblMucGiam.Text = "Giảm giá";
            lblMucGiam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMucGiam_KetQua
            // 
            lblMucGiam_KetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMucGiam_KetQua.ForeColor = Color.Red;
            lblMucGiam_KetQua.Location = new Point(192, 112);
            lblMucGiam_KetQua.Name = "lblMucGiam_KetQua";
            lblMucGiam_KetQua.Size = new Size(160, 21);
            lblMucGiam_KetQua.TabIndex = 2;
            lblMucGiam_KetQua.Text = "Giảm giá";
            lblMucGiam_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(312, 392);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(152, 23);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmChiTietHoaDonMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 426);
            Controls.Add(ptbMaQR);
            Controls.Add(txbTienKhachDua);
            Controls.Add(lblMucGiam_KetQua);
            Controls.Add(lblTienThoi_KetQua);
            Controls.Add(lblMucGiam);
            Controls.Add(lblTienThoi);
            Controls.Add(lblTienKhachDua);
            Controls.Add(lblNgayLap);
            Controls.Add(lblTongTien_KetQua);
            Controls.Add(lblTongTien);
            Controls.Add(lblTen);
            Controls.Add(btnHuy);
            Controls.Add(btnXuatHoaDon);
            Controls.Add(dgvChiTiet);
            Name = "frmChiTietHoaDonMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChiTietHoaDonMonAn";
            Load += frmChiTietHoaDonMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvChiTiet;
        private Button btnXuatHoaDon;
        private Label lblTen;
        private Label lblTongTien;
        private Label lblTienKhachDua;
        private Label lblTienThoi;
        private Label lblTongTien_KetQua;
        private Label lblTienThoi_KetQua;
        private Label lblNgayLap;
        private TextBox txbTienKhachDua;
        private PictureBox ptbMaQR;
        private Label lblMucGiam;
        private Label lblMucGiam_KetQua;
        private Button btnHuy;
    }
}