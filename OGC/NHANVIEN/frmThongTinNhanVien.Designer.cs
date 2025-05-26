namespace OGC.NHANVIEN
{
    partial class frmThongTinNhanVien
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
            btnChonAnh = new Button();
            ptbAnhNV = new PictureBox();
            pnlPhai = new Panel();
            dtpNgaySinh = new DateTimePicker();
            btnDong = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblNgaySinh = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblGioiTinh = new Label();
            lblTenChucVu = new Label();
            lblID = new Label();
            lblDiaChi = new Label();
            lblHoTen = new Label();
            lblTaiKhoan = new Label();
            txbGioiTinh = new TextBox();
            txbSDT = new TextBox();
            txbChucVu = new TextBox();
            txbEmail = new TextBox();
            txbID = new TextBox();
            txbDiaChi = new TextBox();
            txbHoTen = new TextBox();
            txbTaiKhoan = new TextBox();
            pnlTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhNV).BeginInit();
            pnlPhai.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTrai
            // 
            pnlTrai.Controls.Add(btnChonAnh);
            pnlTrai.Controls.Add(ptbAnhNV);
            pnlTrai.Dock = DockStyle.Left;
            pnlTrai.Location = new Point(0, 0);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(208, 461);
            pnlTrai.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChonAnh.Location = new Point(56, 312);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(80, 24);
            btnChonAnh.TabIndex = 3;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbAnhNV
            // 
            ptbAnhNV.BorderStyle = BorderStyle.FixedSingle;
            ptbAnhNV.Location = new Point(24, 128);
            ptbAnhNV.Name = "ptbAnhNV";
            ptbAnhNV.Size = new Size(144, 168);
            ptbAnhNV.TabIndex = 2;
            ptbAnhNV.TabStop = false;
            // 
            // pnlPhai
            // 
            pnlPhai.Controls.Add(dtpNgaySinh);
            pnlPhai.Controls.Add(btnDong);
            pnlPhai.Controls.Add(btnXoa);
            pnlPhai.Controls.Add(btnSua);
            pnlPhai.Controls.Add(lblNgaySinh);
            pnlPhai.Controls.Add(lblSDT);
            pnlPhai.Controls.Add(lblEmail);
            pnlPhai.Controls.Add(lblGioiTinh);
            pnlPhai.Controls.Add(lblTenChucVu);
            pnlPhai.Controls.Add(lblID);
            pnlPhai.Controls.Add(lblDiaChi);
            pnlPhai.Controls.Add(lblHoTen);
            pnlPhai.Controls.Add(lblTaiKhoan);
            pnlPhai.Controls.Add(txbGioiTinh);
            pnlPhai.Controls.Add(txbSDT);
            pnlPhai.Controls.Add(txbChucVu);
            pnlPhai.Controls.Add(txbEmail);
            pnlPhai.Controls.Add(txbID);
            pnlPhai.Controls.Add(txbDiaChi);
            pnlPhai.Controls.Add(txbHoTen);
            pnlPhai.Controls.Add(txbTaiKhoan);
            pnlPhai.Dock = DockStyle.Right;
            pnlPhai.Location = new Point(208, 0);
            pnlPhai.Name = "pnlPhai";
            pnlPhai.Size = new Size(576, 461);
            pnlPhai.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(96, 216);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 5;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F);
            btnDong.Location = new Point(392, 408);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(176, 32);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F);
            btnXoa.Location = new Point(200, 408);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(176, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F);
            btnSua.Location = new Point(8, 408);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(176, 32);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 12F);
            lblNgaySinh.Location = new Point(8, 216);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(80, 24);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F);
            lblSDT.Location = new Point(320, 288);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(48, 24);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "SDT";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(304, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Font = new Font("Segoe UI", 12F);
            lblGioiTinh.Location = new Point(8, 352);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(88, 23);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenChucVu
            // 
            lblTenChucVu.Font = new Font("Segoe UI", 12F);
            lblTenChucVu.Location = new Point(8, 288);
            lblTenChucVu.Name = "lblTenChucVu";
            lblTenChucVu.Size = new Size(96, 23);
            lblTenChucVu.TabIndex = 2;
            lblTenChucVu.Text = "Tên chức vụ";
            lblTenChucVu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(296, 352);
            lblID.Name = "lblID";
            lblID.Size = new Size(88, 23);
            lblID.TabIndex = 2;
            lblID.Text = "Mã";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(64, 120);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(101, 21);
            lblDiaChi.TabIndex = 1;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(64, 72);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(101, 21);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaiKhoan.Location = new Point(64, 24);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(104, 23);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // txbGioiTinh
            // 
            txbGioiTinh.Location = new Point(112, 344);
            txbGioiTinh.Multiline = true;
            txbGioiTinh.Name = "txbGioiTinh";
            txbGioiTinh.Size = new Size(176, 32);
            txbGioiTinh.TabIndex = 0;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(392, 280);
            txbSDT.Multiline = true;
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(176, 32);
            txbSDT.TabIndex = 0;
            // 
            // txbChucVu
            // 
            txbChucVu.Location = new Point(112, 280);
            txbChucVu.Multiline = true;
            txbChucVu.Name = "txbChucVu";
            txbChucVu.Size = new Size(176, 32);
            txbChucVu.TabIndex = 0;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(392, 216);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(176, 32);
            txbEmail.TabIndex = 0;
            // 
            // txbID
            // 
            txbID.Location = new Point(392, 344);
            txbID.Multiline = true;
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(176, 32);
            txbID.TabIndex = 0;
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(208, 112);
            txbDiaChi.Multiline = true;
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.Size = new Size(304, 32);
            txbDiaChi.TabIndex = 0;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(208, 64);
            txbHoTen.Multiline = true;
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(304, 32);
            txbHoTen.TabIndex = 0;
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.Location = new Point(208, 16);
            txbTaiKhoan.Multiline = true;
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.ReadOnly = true;
            txbTaiKhoan.Size = new Size(304, 32);
            txbTaiKhoan.TabIndex = 0;
            // 
            // frmThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlPhai);
            Controls.Add(pnlTrai);
            Name = "frmThongTinNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongTinNhanVien";
            pnlTrai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAnhNV).EndInit();
            pnlPhai.ResumeLayout(false);
            pnlPhai.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTrai;
        private Panel pnlPhai;
        private Label lblDiaChi;
        private Label lblHoTen;
        private Label lblTaiKhoan;
        private TextBox txbGioiTinh;
        private TextBox txbSDT;
        private TextBox txbChucVu;
        private TextBox txbEmail;
        private TextBox txbID;
        private TextBox txbDiaChi;
        private TextBox txbHoTen;
        private TextBox txbTaiKhoan;
        private Label lblGioiTinh;
        private Label lblTenChucVu;
        private Label lblID;
        private Label lblNgaySinh;
        private Label lblSDT;
        private Label lblEmail;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
        private Button btnChonAnh;
        private PictureBox ptbAnhNV;
        private DateTimePicker dtpNgaySinh;
    }
}