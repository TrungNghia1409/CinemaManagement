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
            NgayLap = new Label();
            label2 = new Label();
            lblTenNhanVien = new Label();
            MaHoaDon = new Label();
            lblMaHoaDon = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaQR).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(8, 256);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(320, 208);
            dgvChiTiet.TabIndex = 0;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Location = new Point(8, 608);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(152, 23);
            btnXuatHoaDon.TabIndex = 1;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Image = Properties.Resources.filmsmall;
            lblTen.ImageAlign = ContentAlignment.MiddleLeft;
            lblTen.Location = new Point(48, 8);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(184, 40);
            lblTen.TabIndex = 2;
            lblTen.Text = " OGC Cinema";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTongTien.Location = new Point(40, 480);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(80, 21);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTienKhachDua
            // 
            lblTienKhachDua.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTienKhachDua.Location = new Point(40, 512);
            lblTienKhachDua.Name = "lblTienKhachDua";
            lblTienKhachDua.Size = new Size(88, 21);
            lblTienKhachDua.TabIndex = 2;
            lblTienKhachDua.Text = "Tiền khách đưa";
            lblTienKhachDua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTienThoi
            // 
            lblTienThoi.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTienThoi.Location = new Point(40, 576);
            lblTienThoi.Name = "lblTienThoi";
            lblTienThoi.Size = new Size(80, 21);
            lblTienThoi.TabIndex = 2;
            lblTienThoi.Text = "Tiền thối lại";
            lblTienThoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien_KetQua
            // 
            lblTongTien_KetQua.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTongTien_KetQua.Location = new Point(216, 480);
            lblTongTien_KetQua.Name = "lblTongTien_KetQua";
            lblTongTien_KetQua.Size = new Size(80, 21);
            lblTongTien_KetQua.TabIndex = 2;
            lblTongTien_KetQua.Text = "Tổng tiền";
            lblTongTien_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTienThoi_KetQua
            // 
            lblTienThoi_KetQua.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTienThoi_KetQua.Location = new Point(216, 576);
            lblTienThoi_KetQua.Name = "lblTienThoi_KetQua";
            lblTienThoi_KetQua.Size = new Size(80, 21);
            lblTienThoi_KetQua.TabIndex = 2;
            lblTienThoi_KetQua.Text = "Tiền thối lại";
            lblTienThoi_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayLap.Location = new Point(216, 192);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(80, 21);
            lblNgayLap.TabIndex = 2;
            lblNgayLap.Text = "Ngày lập";
            lblNgayLap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTienKhachDua
            // 
            txbTienKhachDua.Font = new Font("Microsoft Sans Serif", 8.25F);
            txbTienKhachDua.Location = new Point(208, 512);
            txbTienKhachDua.Name = "txbTienKhachDua";
            txbTienKhachDua.Size = new Size(88, 20);
            txbTienKhachDua.TabIndex = 3;
            txbTienKhachDua.TextChanged += txbTienKhachDua_TextChanged;
            txbTienKhachDua.Leave += txbTienKhachDua_Leave;
            // 
            // ptbMaQR
            // 
            ptbMaQR.Location = new Point(240, 8);
            ptbMaQR.Name = "ptbMaQR";
            ptbMaQR.Size = new Size(90, 114);
            ptbMaQR.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMaQR.TabIndex = 4;
            ptbMaQR.TabStop = false;
            // 
            // lblMucGiam
            // 
            lblMucGiam.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMucGiam.Location = new Point(40, 544);
            lblMucGiam.Name = "lblMucGiam";
            lblMucGiam.Size = new Size(80, 21);
            lblMucGiam.TabIndex = 2;
            lblMucGiam.Text = "Giảm giá";
            lblMucGiam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMucGiam_KetQua
            // 
            lblMucGiam_KetQua.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMucGiam_KetQua.ForeColor = Color.Red;
            lblMucGiam_KetQua.Location = new Point(216, 544);
            lblMucGiam_KetQua.Name = "lblMucGiam_KetQua";
            lblMucGiam_KetQua.Size = new Size(80, 21);
            lblMucGiam_KetQua.TabIndex = 2;
            lblMucGiam_KetQua.Text = "Giảm giá";
            lblMucGiam_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(176, 608);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(152, 23);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // NgayLap
            // 
            NgayLap.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayLap.Location = new Point(40, 192);
            NgayLap.Name = "NgayLap";
            NgayLap.Size = new Size(80, 21);
            NgayLap.TabIndex = 2;
            NgayLap.Text = "Ngày lập";
            NgayLap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 224);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenNhanVien.Location = new Point(216, 224);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(80, 21);
            lblTenNhanVien.TabIndex = 2;
            lblTenNhanVien.Text = "Tên nhân viên";
            lblTenNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaHoaDon
            // 
            MaHoaDon.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaHoaDon.Location = new Point(40, 160);
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.Size = new Size(80, 21);
            MaHoaDon.TabIndex = 2;
            MaHoaDon.Text = "Mã hóa đơn";
            MaHoaDon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaHoaDon.Location = new Point(216, 160);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(80, 21);
            lblMaHoaDon.TabIndex = 2;
            lblMaHoaDon.Text = "Mã hóa đơn";
            lblMaHoaDon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 128);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 2;
            label1.Text = "Hóa đơn dịch vụ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 56);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 2;
            label3.Text = " 123 Lê Lợi, Q.1, TP.HCM   ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 88);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 2;
            label4.Text = " Hotline: 1900.0000      ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChiTietHoaDonMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 631);
            Controls.Add(ptbMaQR);
            Controls.Add(txbTienKhachDua);
            Controls.Add(lblMucGiam_KetQua);
            Controls.Add(lblTienThoi_KetQua);
            Controls.Add(lblMucGiam);
            Controls.Add(lblTienThoi);
            Controls.Add(lblTienKhachDua);
            Controls.Add(lblTenNhanVien);
            Controls.Add(label2);
            Controls.Add(lblMaHoaDon);
            Controls.Add(MaHoaDon);
            Controls.Add(NgayLap);
            Controls.Add(lblNgayLap);
            Controls.Add(lblTongTien_KetQua);
            Controls.Add(lblTongTien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
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
        private Label NgayLap;
        private Label label2;
        private Label lblTenNhanVien;
        private Label MaHoaDon;
        private Label lblMaHoaDon;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}