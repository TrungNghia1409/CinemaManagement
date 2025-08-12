namespace OGC
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logo = new PictureBox();
            panel2 = new Panel();
            pnlUser = new Panel();
            lblDangXuat = new Label();
            lblUser = new Label();
            label1 = new Label();
            pnlQuanLyPhim = new Panel();
            btnQuanLyPhim = new Button();
            pnlDichVu = new Panel();
            btnDichVu = new Button();
            pnlQuanLyChung = new Panel();
            btnQuanLyChung = new Button();
            pnlThongKe = new Panel();
            btnThongKe = new Button();
            pnlDatVe = new Panel();
            btnDatVe = new Button();
            pnlTrangChu = new Panel();
            btnTrangChu = new Button();
            panel_Body = new Panel();
            flơThanhDieuHuong = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlQuanLyPhim.SuspendLayout();
            pnlDichVu.SuspendLayout();
            pnlQuanLyChung.SuspendLayout();
            pnlThongKe.SuspendLayout();
            pnlDatVe.SuspendLayout();
            pnlTrangChu.SuspendLayout();
            flơThanhDieuHuong.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BorderStyle = BorderStyle.FixedSingle;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(-1, 1);
            Logo.Name = "Logo";
            Logo.Size = new Size(96, 95);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(80, 80, 80);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Logo);
            panel2.Controls.Add(pnlUser);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1473, 107);
            panel2.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(lblDangXuat);
            pnlUser.Controls.Add(lblUser);
            pnlUser.Location = new Point(1051, 11);
            pnlUser.Margin = new Padding(3, 4, 3, 4);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(311, 63);
            pnlUser.TabIndex = 2;
            // 
            // lblDangXuat
            // 
            lblDangXuat.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDangXuat.ForeColor = SystemColors.ButtonHighlight;
            lblDangXuat.Location = new Point(196, 17);
            lblDangXuat.Name = "lblDangXuat";
            lblDangXuat.Size = new Size(106, 32);
            lblDangXuat.TabIndex = 1;
            lblDangXuat.Text = "Đăng xuất";
            lblDangXuat.TextAlign = ContentAlignment.MiddleCenter;
            lblDangXuat.Click += lblDangXuat_Click;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblUser.ForeColor = SystemColors.ButtonHighlight;
            lblUser.Location = new Point(-51, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(254, 64);
            lblUser.TabIndex = 1;
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(120, 28);
            label1.Name = "label1";
            label1.Size = new Size(92, 38);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // pnlQuanLyPhim
            // 
            pnlQuanLyPhim.Controls.Add(btnQuanLyPhim);
            pnlQuanLyPhim.Location = new Point(3, 508);
            pnlQuanLyPhim.Name = "pnlQuanLyPhim";
            pnlQuanLyPhim.Size = new Size(210, 95);
            pnlQuanLyPhim.TabIndex = 0;
            // 
            // btnQuanLyPhim
            // 
            btnQuanLyPhim.Dock = DockStyle.Fill;
            btnQuanLyPhim.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhim.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyPhim.Location = new Point(0, 0);
            btnQuanLyPhim.Name = "btnQuanLyPhim";
            btnQuanLyPhim.Size = new Size(210, 95);
            btnQuanLyPhim.TabIndex = 0;
            btnQuanLyPhim.Text = "Quản Lý Phim";
            btnQuanLyPhim.UseVisualStyleBackColor = true;
            btnQuanLyPhim.Click += btnQuanLyPhim_Click;
            // 
            // pnlDichVu
            // 
            pnlDichVu.Controls.Add(btnDichVu);
            pnlDichVu.Location = new Point(3, 306);
            pnlDichVu.Name = "pnlDichVu";
            pnlDichVu.Size = new Size(210, 95);
            pnlDichVu.TabIndex = 0;
            // 
            // btnDichVu
            // 
            btnDichVu.Dock = DockStyle.Fill;
            btnDichVu.FlatStyle = FlatStyle.Flat;
            btnDichVu.ForeColor = SystemColors.ButtonHighlight;
            btnDichVu.Location = new Point(0, 0);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(210, 95);
            btnDichVu.TabIndex = 0;
            btnDichVu.Text = "Dịch Vụ";
            btnDichVu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDichVu.UseVisualStyleBackColor = true;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // pnlQuanLyChung
            // 
            pnlQuanLyChung.Controls.Add(btnQuanLyChung);
            pnlQuanLyChung.Location = new Point(3, 104);
            pnlQuanLyChung.Name = "pnlQuanLyChung";
            pnlQuanLyChung.Size = new Size(210, 95);
            pnlQuanLyChung.TabIndex = 0;
            // 
            // btnQuanLyChung
            // 
            btnQuanLyChung.Dock = DockStyle.Fill;
            btnQuanLyChung.FlatStyle = FlatStyle.Flat;
            btnQuanLyChung.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyChung.Location = new Point(0, 0);
            btnQuanLyChung.Name = "btnQuanLyChung";
            btnQuanLyChung.Size = new Size(210, 95);
            btnQuanLyChung.TabIndex = 0;
            btnQuanLyChung.Text = "Quản Lý Chung";
            btnQuanLyChung.UseVisualStyleBackColor = true;
            btnQuanLyChung.Click += btnQuanLyChung_Click;
            // 
            // pnlThongKe
            // 
            pnlThongKe.Controls.Add(btnThongKe);
            pnlThongKe.Location = new Point(3, 407);
            pnlThongKe.Name = "pnlThongKe";
            pnlThongKe.Size = new Size(210, 95);
            pnlThongKe.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Fill;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.ForeColor = SystemColors.ButtonHighlight;
            btnThongKe.Location = new Point(0, 0);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(210, 95);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // pnlDatVe
            // 
            pnlDatVe.Controls.Add(btnDatVe);
            pnlDatVe.Location = new Point(3, 205);
            pnlDatVe.Name = "pnlDatVe";
            pnlDatVe.Size = new Size(210, 95);
            pnlDatVe.TabIndex = 0;
            // 
            // btnDatVe
            // 
            btnDatVe.Dock = DockStyle.Fill;
            btnDatVe.FlatStyle = FlatStyle.Flat;
            btnDatVe.ForeColor = SystemColors.ButtonHighlight;
            btnDatVe.Location = new Point(0, 0);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(210, 95);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // pnlTrangChu
            // 
            pnlTrangChu.Controls.Add(btnTrangChu);
            pnlTrangChu.Location = new Point(3, 3);
            pnlTrangChu.Name = "pnlTrangChu";
            pnlTrangChu.Size = new Size(210, 95);
            pnlTrangChu.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.FromArgb(80, 80, 80);
            btnTrangChu.Dock = DockStyle.Fill;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(210, 95);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.Control;
            panel_Body.Location = new Point(221, 104);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1258, 645);
            panel_Body.TabIndex = 1;
            // 
            // flơThanhDieuHuong
            // 
            flơThanhDieuHuong.BackColor = Color.FromArgb(80, 80, 80);
            flơThanhDieuHuong.Controls.Add(pnlTrangChu);
            flơThanhDieuHuong.Controls.Add(pnlQuanLyChung);
            flơThanhDieuHuong.Controls.Add(pnlDatVe);
            flơThanhDieuHuong.Controls.Add(pnlDichVu);
            flơThanhDieuHuong.Controls.Add(pnlThongKe);
            flơThanhDieuHuong.Controls.Add(pnlQuanLyPhim);
            flơThanhDieuHuong.Location = new Point(6, 101);
            flơThanhDieuHuong.Margin = new Padding(3, 4, 3, 4);
            flơThanhDieuHuong.Name = "flơThanhDieuHuong";
            flơThanhDieuHuong.Size = new Size(217, 648);
            flơThanhDieuHuong.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(flơThanhDieuHuong);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng bạn đến với OGC";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlQuanLyPhim.ResumeLayout(false);
            pnlDichVu.ResumeLayout(false);
            pnlQuanLyChung.ResumeLayout(false);
            pnlThongKe.ResumeLayout(false);
            pnlDatVe.ResumeLayout(false);
            pnlTrangChu.ResumeLayout(false);
            flơThanhDieuHuong.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel pnlQuanLyPhim;
        private Panel pnlDichVu;
        private Panel pnlQuanLyChung;
        private Panel pnlThongKe;
        private Panel pnlDatVe;
        private Panel pnlTrangChu;
        private Button btnDichVu;
        private Button btnQuanLyChung;
        private Button btnThongKe;
        private Button btnDatVe;
        private Button btnTrangChu;
        private Button btnQuanLyPhim;
        protected PictureBox Logo;
        private Panel panel_Body;
        private Panel pnlUser;
        private Label lblUser;
        private FlowLayoutPanel flơThanhDieuHuong;
        private Label lblDangXuat;
    }
}
