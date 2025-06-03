namespace OGC.QuanLyDichVu
{
    partial class frmChiTietHoaDonMonAn_TrucTuyen
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
            ptbMaQR = new PictureBox();
            lblNgayLap = new Label();
            lblTongTien = new Label();
            lblTen = new Label();
            btnXuatHoaDon = new Button();
            dgvChiTiet = new DataGridView();
            lblTongTien_KetQua = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbMaQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // ptbMaQR
            // 
            ptbMaQR.Location = new Point(444, 42);
            ptbMaQR.Name = "ptbMaQR";
            ptbMaQR.Size = new Size(90, 90);
            ptbMaQR.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMaQR.TabIndex = 15;
            ptbMaQR.TabStop = false;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayLap.Location = new Point(200, 88);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(160, 21);
            lblNgayLap.TabIndex = 10;
            lblNgayLap.Text = "Ngày lập";
            lblNgayLap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(20, 50);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(160, 21);
            lblTongTien.TabIndex = 12;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(12, 10);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(376, 23);
            lblTen.TabIndex = 13;
            lblTen.Text = "Phiếu thanh toán OGC Cinema";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Location = new Point(220, 394);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(152, 23);
            btnXuatHoaDon.TabIndex = 6;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(12, 146);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(568, 240);
            dgvChiTiet.TabIndex = 5;
            // 
            // lblTongTien_KetQua
            // 
            lblTongTien_KetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien_KetQua.Location = new Point(196, 50);
            lblTongTien_KetQua.Name = "lblTongTien_KetQua";
            lblTongTien_KetQua.Size = new Size(160, 21);
            lblTongTien_KetQua.TabIndex = 11;
            lblTongTien_KetQua.Text = "Tổng tiền";
            lblTongTien_KetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 88);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 10;
            label1.Text = "Ngày lập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChiTietHoaDonMonAn_TrucTuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 426);
            Controls.Add(ptbMaQR);
            Controls.Add(label1);
            Controls.Add(lblNgayLap);
            Controls.Add(lblTongTien_KetQua);
            Controls.Add(lblTongTien);
            Controls.Add(lblTen);
            Controls.Add(btnXuatHoaDon);
            Controls.Add(dgvChiTiet);
            Name = "frmChiTietHoaDonMonAn_TrucTuyen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChiTietHoaDonMonAn_TrucTuyen";
            Load += frmChiTietHoaDonMonAn_TrucTuyen_Load;
            ((System.ComponentModel.ISupportInitialize)ptbMaQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbMaQR;
        private Label lblNgayLap;
        private Label lblTongTien;
        private Label lblTen;
        private Button btnXuatHoaDon;
        private DataGridView dgvChiTiet;
        private Label lblTongTien_KetQua;
        private Label label1;
    }
}