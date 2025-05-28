namespace OGC.QuanLyDichVu
{
    partial class frmQuanLyDichVu
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
            pnlPhai = new Panel();
            btnResetGioHang = new Button();
            btnThanhToan = new Button();
            txbTongTien = new TextBox();
            lblTongTien = new Label();
            flpCart = new FlowLayoutPanel();
            pnlTrai = new Panel();
            pnlTop = new Panel();
            cbLoaiMonAn = new ComboBox();
            txbTimKiem = new TextBox();
            btnThemSanPham = new Button();
            btnReset = new Button();
            flpDichVu = new FlowLayoutPanel();
            pnlPhai.SuspendLayout();
            pnlTrai.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPhai
            // 
            pnlPhai.Controls.Add(btnResetGioHang);
            pnlPhai.Controls.Add(btnThanhToan);
            pnlPhai.Controls.Add(txbTongTien);
            pnlPhai.Controls.Add(lblTongTien);
            pnlPhai.Controls.Add(flpCart);
            pnlPhai.Dock = DockStyle.Right;
            pnlPhai.Location = new Point(879, 0);
            pnlPhai.Margin = new Padding(3, 4, 3, 4);
            pnlPhai.Name = "pnlPhai";
            pnlPhai.Size = new Size(347, 596);
            pnlPhai.TabIndex = 1;
            // 
            // btnResetGioHang
            // 
            btnResetGioHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResetGioHang.Location = new Point(18, 523);
            btnResetGioHang.Margin = new Padding(3, 4, 3, 4);
            btnResetGioHang.Name = "btnResetGioHang";
            btnResetGioHang.Size = new Size(131, 53);
            btnResetGioHang.TabIndex = 3;
            btnResetGioHang.Text = "Reset Cart";
            btnResetGioHang.UseVisualStyleBackColor = true;
            btnResetGioHang.Click += btnResetGioHang_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThanhToan.Location = new Point(201, 523);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(131, 53);
            btnThanhToan.TabIndex = 3;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txbTongTien
            // 
            txbTongTien.Font = new Font("Segoe UI", 12F);
            txbTongTien.Location = new Point(128, 448);
            txbTongTien.Margin = new Padding(3, 4, 3, 4);
            txbTongTien.Multiline = true;
            txbTongTien.Name = "txbTongTien";
            txbTongTien.Size = new Size(205, 52);
            txbTongTien.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(18, 461);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(103, 28);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền";
            // 
            // flpCart
            // 
            flpCart.AutoScroll = true;
            flpCart.Location = new Point(9, 11);
            flpCart.Margin = new Padding(3, 4, 3, 4);
            flpCart.Name = "flpCart";
            flpCart.Size = new Size(329, 416);
            flpCart.TabIndex = 0;
            // 
            // pnlTrai
            // 
            pnlTrai.Controls.Add(pnlTop);
            pnlTrai.Controls.Add(flpDichVu);
            pnlTrai.Dock = DockStyle.Left;
            pnlTrai.Location = new Point(0, 0);
            pnlTrai.Margin = new Padding(3, 4, 3, 4);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(878, 596);
            pnlTrai.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(cbLoaiMonAn);
            pnlTop.Controls.Add(txbTimKiem);
            pnlTop.Controls.Add(btnThemSanPham);
            pnlTop.Controls.Add(btnReset);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(878, 85);
            pnlTop.TabIndex = 1;
            // 
            // cbLoaiMonAn
            // 
            cbLoaiMonAn.FlatStyle = FlatStyle.Flat;
            cbLoaiMonAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLoaiMonAn.FormattingEnabled = true;
            cbLoaiMonAn.ItemHeight = 28;
            cbLoaiMonAn.Location = new Point(494, 29);
            cbLoaiMonAn.Margin = new Padding(3, 4, 3, 4);
            cbLoaiMonAn.Name = "cbLoaiMonAn";
            cbLoaiMonAn.Size = new Size(137, 36);
            cbLoaiMonAn.TabIndex = 2;
            cbLoaiMonAn.SelectedIndexChanged += cbLoaiMonAn_SelectedIndexChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.BorderStyle = BorderStyle.None;
            txbTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTimKiem.Location = new Point(9, 21);
            txbTimKiem.Margin = new Padding(3, 4, 3, 4);
            txbTimKiem.Multiline = true;
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(347, 53);
            txbTimKiem.TabIndex = 1;
            txbTimKiem.TextAlign = HorizontalAlignment.Center;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemSanPham.Image = Properties.Resources.add___Copy1;
            btnThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemSanPham.Location = new Point(768, 21);
            btnThemSanPham.Margin = new Padding(3, 4, 3, 4);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(95, 53);
            btnThemSanPham.TabIndex = 0;
            btnThemSanPham.Text = "Thêm ";
            btnThemSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnThemSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(366, 21);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 53);
            btnReset.TabIndex = 0;
            btnReset.Text = "⟲ Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // flpDichVu
            // 
            flpDichVu.AutoScroll = true;
            flpDichVu.FlowDirection = FlowDirection.TopDown;
            flpDichVu.Location = new Point(0, 85);
            flpDichVu.Margin = new Padding(3, 4, 3, 4);
            flpDichVu.Name = "flpDichVu";
            flpDichVu.Size = new Size(880, 513);
            flpDichVu.TabIndex = 0;
            flpDichVu.WrapContents = false;
            // 
            // frmQuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 596);
            Controls.Add(pnlPhai);
            Controls.Add(pnlTrai);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuanLyDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyDichVu";
            pnlPhai.ResumeLayout(false);
            pnlPhai.PerformLayout();
            pnlTrai.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPhai;
        private Panel pnlTrai;
        private FlowLayoutPanel flpDichVu;
        private Panel pnlTop;
        private ComboBox cbLoaiMonAn;
        private TextBox txbTimKiem;
        private Button btnThemSanPham;
        private Button btnReset;
        private TextBox txbTongTien;
        private Label lblTongTien;
        private Button btnResetGioHang;
        private Button btnThanhToan;
        public FlowLayoutPanel flpCart;
    }
}