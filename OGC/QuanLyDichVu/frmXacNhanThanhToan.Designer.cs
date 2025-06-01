namespace OGC.QuanLyDichVu
{
    partial class frmXacNhanThanhToan
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
            lblIDKhachHang = new Label();
            lblIDNhanVien = new Label();
            lblTongTien = new Label();
            lblNgayMua = new Label();
            lblMaKhuyenMai = new Label();
            lblSDT = new Label();
            txbSDT = new TextBox();
            txbIDKhachHang = new TextBox();
            txbIDNhanVien = new TextBox();
            txbTongTien = new TextBox();
            txbNgayMua = new TextBox();
            txbMaKhuyenMai = new TextBox();
            btnXacNhan = new Button();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // lblIDKhachHang
            // 
            lblIDKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDKhachHang.Location = new Point(16, 64);
            lblIDKhachHang.Name = "lblIDKhachHang";
            lblIDKhachHang.Size = new Size(136, 23);
            lblIDKhachHang.TabIndex = 0;
            lblIDKhachHang.Text = "Mã khách hàng";
            // 
            // lblIDNhanVien
            // 
            lblIDNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDNhanVien.Location = new Point(16, 104);
            lblIDNhanVien.Name = "lblIDNhanVien";
            lblIDNhanVien.Size = new Size(136, 23);
            lblIDNhanVien.TabIndex = 0;
            lblIDNhanVien.Text = "Mã nhân viên";
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(16, 144);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(136, 23);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền";
            // 
            // lblNgayMua
            // 
            lblNgayMua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayMua.Location = new Point(16, 184);
            lblNgayMua.Name = "lblNgayMua";
            lblNgayMua.Size = new Size(136, 23);
            lblNgayMua.TabIndex = 0;
            lblNgayMua.Text = "Ngày mua";
            // 
            // lblMaKhuyenMai
            // 
            lblMaKhuyenMai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaKhuyenMai.Location = new Point(16, 224);
            lblMaKhuyenMai.Name = "lblMaKhuyenMai";
            lblMaKhuyenMai.Size = new Size(136, 23);
            lblMaKhuyenMai.TabIndex = 0;
            lblMaKhuyenMai.Text = "Mã khuyến mãi";
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(16, 24);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(136, 23);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "SDT khách hàng";
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(168, 24);
            txbSDT.Multiline = true;
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(232, 23);
            txbSDT.TabIndex = 1;
            txbSDT.Leave += txbSDT_Leave;
            // 
            // txbIDKhachHang
            // 
            txbIDKhachHang.Location = new Point(168, 64);
            txbIDKhachHang.Multiline = true;
            txbIDKhachHang.Name = "txbIDKhachHang";
            txbIDKhachHang.ReadOnly = true;
            txbIDKhachHang.Size = new Size(232, 23);
            txbIDKhachHang.TabIndex = 1;
            // 
            // txbIDNhanVien
            // 
            txbIDNhanVien.Location = new Point(168, 104);
            txbIDNhanVien.Multiline = true;
            txbIDNhanVien.Name = "txbIDNhanVien";
            txbIDNhanVien.ReadOnly = true;
            txbIDNhanVien.Size = new Size(232, 23);
            txbIDNhanVien.TabIndex = 1;
            // 
            // txbTongTien
            // 
            txbTongTien.Location = new Point(168, 144);
            txbTongTien.Multiline = true;
            txbTongTien.Name = "txbTongTien";
            txbTongTien.ReadOnly = true;
            txbTongTien.Size = new Size(232, 23);
            txbTongTien.TabIndex = 1;
            // 
            // txbNgayMua
            // 
            txbNgayMua.Location = new Point(168, 184);
            txbNgayMua.Multiline = true;
            txbNgayMua.Name = "txbNgayMua";
            txbNgayMua.Size = new Size(232, 23);
            txbNgayMua.TabIndex = 1;
            // 
            // txbMaKhuyenMai
            // 
            txbMaKhuyenMai.Location = new Point(168, 224);
            txbMaKhuyenMai.Multiline = true;
            txbMaKhuyenMai.Name = "txbMaKhuyenMai";
            txbMaKhuyenMai.Size = new Size(232, 23);
            txbMaKhuyenMai.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(224, 256);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(115, 23);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(408, 28);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 15);
            lblTrangThai.TabIndex = 3;
            // 
            // frmXacNhanThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 291);
            Controls.Add(lblTrangThai);
            Controls.Add(btnXacNhan);
            Controls.Add(txbMaKhuyenMai);
            Controls.Add(txbNgayMua);
            Controls.Add(txbTongTien);
            Controls.Add(txbIDNhanVien);
            Controls.Add(txbIDKhachHang);
            Controls.Add(txbSDT);
            Controls.Add(lblMaKhuyenMai);
            Controls.Add(lblNgayMua);
            Controls.Add(lblTongTien);
            Controls.Add(lblIDNhanVien);
            Controls.Add(lblSDT);
            Controls.Add(lblIDKhachHang);
            Name = "frmXacNhanThanhToan";
            Text = "frmXacNhanThanhToan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDKhachHang;
        private Label lblIDNhanVien;
        private Label lblTongTien;
        private Label lblNgayMua;
        private Label lblMaKhuyenMai;
        private Label lblSDT;
        private TextBox txbSDT;
        private TextBox txbIDKhachHang;
        private TextBox txbIDNhanVien;
        private TextBox txbTongTien;
        private TextBox txbNgayMua;
        private TextBox txbMaKhuyenMai;
        private Button btnXacNhan;
        private Label lblTrangThai;
    }
}