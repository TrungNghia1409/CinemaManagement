namespace OGC.NHANVIEN
{
    partial class NhanVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNhanVien = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblID = new Label();
            lblTaiKhoan = new Label();
            lblChucVu = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            ptbXoa = new PictureBox();
            ptbSua = new PictureBox();
            pnlNhanVien.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSua).BeginInit();
            SuspendLayout();
            // 
            // pnlNhanVien
            // 
            pnlNhanVien.BackColor = Color.LightGray;
            pnlNhanVien.Controls.Add(tableLayoutPanel1);
            pnlNhanVien.Dock = DockStyle.Fill;
            pnlNhanVien.Location = new Point(0, 0);
            pnlNhanVien.Name = "pnlNhanVien";
            pnlNhanVien.Size = new Size(1750, 50);
            pnlNhanVien.TabIndex = 0;
            pnlNhanVien.Paint += pnlNhanVien_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.LightGray;
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3653851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.63461F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 274F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTaiKhoan, 1, 0);
            tableLayoutPanel1.Controls.Add(lblChucVu, 2, 0);
            tableLayoutPanel1.Controls.Add(lblHoTen, 3, 0);
            tableLayoutPanel1.Controls.Add(lblNgaySinh, 4, 0);
            tableLayoutPanel1.Controls.Add(lblGioiTinh, 5, 0);
            tableLayoutPanel1.Controls.Add(lblSDT, 6, 0);
            tableLayoutPanel1.Controls.Add(lblEmail, 7, 0);
            tableLayoutPanel1.Controls.Add(lblDiaChi, 8, 0);
            tableLayoutPanel1.Controls.Add(ptbXoa, 10, 0);
            tableLayoutPanel1.Controls.Add(ptbSua, 9, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.68182F));
            tableLayoutPanel1.Size = new Size(1750, 50);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(4, 0);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(54, 50);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Dock = DockStyle.Fill;
            lblTaiKhoan.Location = new Point(66, 0);
            lblTaiKhoan.Margin = new Padding(4, 0, 4, 0);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(148, 50);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài khoản";
            lblTaiKhoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Dock = DockStyle.Fill;
            lblChucVu.Location = new Point(222, 0);
            lblChucVu.Margin = new Padding(4, 0, 4, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(191, 50);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức vụ";
            lblChucVu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Dock = DockStyle.Fill;
            lblHoTen.Location = new Point(421, 0);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(221, 50);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Dock = DockStyle.Fill;
            lblNgaySinh.Location = new Point(650, 0);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(160, 50);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Dock = DockStyle.Fill;
            lblGioiTinh.Location = new Point(818, 0);
            lblGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(81, 50);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Dock = DockStyle.Fill;
            lblSDT.Location = new Point(907, 0);
            lblSDT.Margin = new Padding(4, 0, 4, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(166, 50);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "Số điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(1081, 0);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(297, 50);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Dock = DockStyle.Fill;
            lblDiaChi.Location = new Point(1386, 0);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(266, 50);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbXoa
            // 
            ptbXoa.Image = Properties.Resources.Xoa1;
            ptbXoa.Location = new Point(1714, 10);
            ptbXoa.Margin = new Padding(10, 10, 4, 4);
            ptbXoa.Name = "ptbXoa";
            ptbXoa.Size = new Size(30, 30);
            ptbXoa.SizeMode = PictureBoxSizeMode.Zoom;
            ptbXoa.TabIndex = 1;
            ptbXoa.TabStop = false;
            // 
            // ptbSua
            // 
            ptbSua.Image = Properties.Resources.edit1;
            ptbSua.Location = new Point(1666, 10);
            ptbSua.Margin = new Padding(10, 10, 4, 4);
            ptbSua.Name = "ptbSua";
            ptbSua.Size = new Size(30, 30);
            ptbSua.SizeMode = PictureBoxSizeMode.Zoom;
            ptbSua.TabIndex = 1;
            ptbSua.TabStop = false;
            // 
            // NhanVienUC
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlNhanVien);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "NhanVienUC";
            Size = new Size(1750, 50);
            pnlNhanVien.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNhanVien;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblID;
        private Label lblTaiKhoan;
        private Label lblChucVu;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblDiaChi;
        private PictureBox ptbSua;
        private PictureBox ptbXoa;
    }
}
