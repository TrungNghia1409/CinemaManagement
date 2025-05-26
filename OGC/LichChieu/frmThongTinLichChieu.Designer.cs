namespace OGC.LichChieu
{
    partial class frmThongTinLichChieu
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
            pnlTrai = new Panel();
            txbDiaDiem = new TextBox();
            txbGiaVe = new TextBox();
            dtpNgayGio = new DateTimePicker();
            cbTenphong = new ComboBox();
            cbTenPhim = new ComboBox();
            txbID = new TextBox();
            lblDiaDiem = new Label();
            lblGiaVe = new Label();
            lblNgayGio = new Label();
            lblTenPhong = new Label();
            lblTenPhim = new Label();
            lblIDPhong = new Label();
            lblIDPhim = new Label();
            lblID = new Label();
            pmlPhai = new Panel();
            ptbAnhPhong = new PictureBox();
            ptbAnh = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            btnSuaLC = new Button();
            btnXoaLC = new Button();
            btnDongLC = new Button();
            cbIDPhim = new ComboBox();
            cbIDPhong = new ComboBox();
            pnlTrai.SuspendLayout();
            pmlPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // pnlTrai
            // 
            pnlTrai.Controls.Add(txbDiaDiem);
            pnlTrai.Controls.Add(txbGiaVe);
            pnlTrai.Controls.Add(dtpNgayGio);
            pnlTrai.Controls.Add(cbTenphong);
            pnlTrai.Controls.Add(cbIDPhong);
            pnlTrai.Controls.Add(cbIDPhim);
            pnlTrai.Controls.Add(cbTenPhim);
            pnlTrai.Controls.Add(txbID);
            pnlTrai.Controls.Add(lblDiaDiem);
            pnlTrai.Controls.Add(lblGiaVe);
            pnlTrai.Controls.Add(lblNgayGio);
            pnlTrai.Controls.Add(lblTenPhong);
            pnlTrai.Controls.Add(lblTenPhim);
            pnlTrai.Controls.Add(lblIDPhong);
            pnlTrai.Controls.Add(lblIDPhim);
            pnlTrai.Controls.Add(lblID);
            pnlTrai.Location = new Point(0, 0);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(344, 352);
            pnlTrai.TabIndex = 0;
            // 
            // txbDiaDiem
            // 
            txbDiaDiem.Location = new Point(128, 312);
            txbDiaDiem.Name = "txbDiaDiem";
            txbDiaDiem.Size = new Size(200, 23);
            txbDiaDiem.TabIndex = 11;
            // 
            // txbGiaVe
            // 
            txbGiaVe.Location = new Point(128, 272);
            txbGiaVe.Name = "txbGiaVe";
            txbGiaVe.Size = new Size(200, 23);
            txbGiaVe.TabIndex = 10;
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(128, 232);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(200, 23);
            dtpNgayGio.TabIndex = 9;
            // 
            // cbTenphong
            // 
            cbTenphong.FormattingEnabled = true;
            cbTenphong.Location = new Point(128, 192);
            cbTenphong.Name = "cbTenphong";
            cbTenphong.Size = new Size(200, 23);
            cbTenphong.TabIndex = 8;
            // 
            // cbTenPhim
            // 
            cbTenPhim.FormattingEnabled = true;
            cbTenPhim.Location = new Point(128, 152);
            cbTenPhim.Name = "cbTenPhim";
            cbTenPhim.Size = new Size(200, 23);
            cbTenPhim.TabIndex = 8;
            // 
            // txbID
            // 
            txbID.Location = new Point(128, 24);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(200, 23);
            txbID.TabIndex = 7;
            // 
            // lblDiaDiem
            // 
            lblDiaDiem.AutoSize = true;
            lblDiaDiem.Font = new Font("Segoe UI", 12F);
            lblDiaDiem.Location = new Point(45, 312);
            lblDiaDiem.Name = "lblDiaDiem";
            lblDiaDiem.Size = new Size(72, 21);
            lblDiaDiem.TabIndex = 2;
            lblDiaDiem.Text = "Địa điểm";
            // 
            // lblGiaVe
            // 
            lblGiaVe.AutoSize = true;
            lblGiaVe.Font = new Font("Segoe UI", 12F);
            lblGiaVe.Location = new Point(64, 272);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(53, 21);
            lblGiaVe.TabIndex = 2;
            lblGiaVe.Text = "Giá vé";
            // 
            // lblNgayGio
            // 
            lblNgayGio.AutoSize = true;
            lblNgayGio.Font = new Font("Segoe UI", 12F);
            lblNgayGio.Location = new Point(43, 232);
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(74, 21);
            lblNgayGio.TabIndex = 2;
            lblNgayGio.Text = "Ngày giờ";
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Font = new Font("Segoe UI", 12F);
            lblTenPhong.Location = new Point(35, 192);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(82, 21);
            lblTenPhong.TabIndex = 2;
            lblTenPhong.Text = "Tên phòng";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Segoe UI", 12F);
            lblTenPhim.Location = new Point(44, 152);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(73, 21);
            lblTenPhim.TabIndex = 2;
            lblTenPhim.Text = "Tên phim";
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Font = new Font("Segoe UI", 12F);
            lblIDPhong.Location = new Point(36, 104);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(81, 21);
            lblIDPhong.TabIndex = 2;
            lblIDPhong.Text = "Mã phòng";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Font = new Font("Segoe UI", 12F);
            lblIDPhim.Location = new Point(45, 64);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(72, 21);
            lblIDPhim.TabIndex = 3;
            lblIDPhim.Text = "Mã phim";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(16, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 21);
            lblID.TabIndex = 4;
            lblID.Text = "Mã lịch chiếu";
            // 
            // pmlPhai
            // 
            pmlPhai.Controls.Add(ptbAnhPhong);
            pmlPhai.Controls.Add(ptbAnh);
            pmlPhai.Controls.Add(label3);
            pmlPhai.Controls.Add(label1);
            pmlPhai.Location = new Point(344, 0);
            pmlPhai.Name = "pmlPhai";
            pmlPhai.Size = new Size(192, 408);
            pmlPhai.TabIndex = 1;
            // 
            // ptbAnhPhong
            // 
            ptbAnhPhong.Location = new Point(64, 240);
            ptbAnhPhong.Name = "ptbAnhPhong";
            ptbAnhPhong.Size = new Size(104, 136);
            ptbAnhPhong.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnhPhong.TabIndex = 0;
            ptbAnhPhong.TabStop = false;
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(64, 40);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(104, 136);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 0;
            ptbAnh.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 216);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1;
            label3.Text = "Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Phim";
            // 
            // btnSuaLC
            // 
            btnSuaLC.Font = new Font("Segoe UI", 12F);
            btnSuaLC.Location = new Point(16, 368);
            btnSuaLC.Name = "btnSuaLC";
            btnSuaLC.Size = new Size(83, 32);
            btnSuaLC.TabIndex = 2;
            btnSuaLC.Text = "Sửa";
            btnSuaLC.UseVisualStyleBackColor = true;
            btnSuaLC.Click += btnSuaLC_Click;
            // 
            // btnXoaLC
            // 
            btnXoaLC.Font = new Font("Segoe UI", 12F);
            btnXoaLC.Location = new Point(128, 368);
            btnXoaLC.Name = "btnXoaLC";
            btnXoaLC.Size = new Size(83, 32);
            btnXoaLC.TabIndex = 2;
            btnXoaLC.Text = "Xóa";
            btnXoaLC.UseVisualStyleBackColor = true;
            btnXoaLC.Click += btnXoaLC_Click;
            // 
            // btnDongLC
            // 
            btnDongLC.Font = new Font("Segoe UI", 12F);
            btnDongLC.Location = new Point(240, 368);
            btnDongLC.Name = "btnDongLC";
            btnDongLC.Size = new Size(83, 32);
            btnDongLC.TabIndex = 2;
            btnDongLC.Text = "Đóng";
            btnDongLC.UseVisualStyleBackColor = true;
            // 
            // cbIDPhim
            // 
            cbIDPhim.FormattingEnabled = true;
            cbIDPhim.Location = new Point(128, 64);
            cbIDPhim.Name = "cbIDPhim";
            cbIDPhim.Size = new Size(200, 23);
            cbIDPhim.TabIndex = 8;
            // 
            // cbIDPhong
            // 
            cbIDPhong.FormattingEnabled = true;
            cbIDPhong.Location = new Point(128, 104);
            cbIDPhong.Name = "cbIDPhong";
            cbIDPhong.Size = new Size(200, 23);
            cbIDPhong.TabIndex = 8;
            // 
            // frmThongTinLichChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 408);
            Controls.Add(btnDongLC);
            Controls.Add(btnXoaLC);
            Controls.Add(btnSuaLC);
            Controls.Add(pmlPhai);
            Controls.Add(pnlTrai);
            Name = "frmThongTinLichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongTinLichChieu";
            pnlTrai.ResumeLayout(false);
            pnlTrai.PerformLayout();
            pmlPhai.ResumeLayout(false);
            pmlPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTrai;
        private TextBox txbID;
        private Label lblIDPhong;
        private Label lblIDPhim;
        private Label lblID;
        private Label lblDiaDiem;
        private Label lblGiaVe;
        private Label lblNgayGio;
        private Label lblTenPhong;
        private Label lblTenPhim;
        private TextBox txbDiaDiem;
        private TextBox txbGiaVe;
        private DateTimePicker dtpNgayGio;
        private ComboBox cbTenphong;
        private ComboBox cbTenPhim;
        private Panel pmlPhai;
        private Label label3;
        private Label label1;
        private PictureBox ptbAnhPhong;
        private PictureBox ptbAnh;
        private Button btnSuaLC;
        private Button btnXoaLC;
        private Button btnDongLC;
        private ComboBox cbIDPhong;
        private ComboBox cbIDPhim;
    }
}