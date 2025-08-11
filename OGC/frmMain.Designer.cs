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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 95);
            panel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BorderStyle = BorderStyle.FixedSingle;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(5, 0);
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
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pnlUser);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(110, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1369, 95);
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
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            label1.Location = new Point(17, 28);
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
            btnDichVu.Location = new Point(0, 0);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(210, 95);
            btnDichVu.TabIndex = 0;
            btnDichVu.Text = "Dịch Vụ";
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
            btnTrangChu.Dock = DockStyle.Fill;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(210, 95);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.Location = new Point(226, 101);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1253, 648);
            panel_Body.TabIndex = 1;
            // 
            // flơThanhDieuHuong
            // 
            flơThanhDieuHuong.BackColor = SystemColors.Control;
            flơThanhDieuHuong.Controls.Add(pnlTrangChu);
            flơThanhDieuHuong.Controls.Add(pnlQuanLyChung);
            flơThanhDieuHuong.Controls.Add(pnlDatVe);
            flơThanhDieuHuong.Controls.Add(pnlDichVu);
            flơThanhDieuHuong.Controls.Add(pnlThongKe);
            flơThanhDieuHuong.Controls.Add(pnlQuanLyPhim);
            flơThanhDieuHuong.Location = new Point(6, 101);
            flơThanhDieuHuong.Margin = new Padding(3, 4, 3, 4);
            flơThanhDieuHuong.Name = "flơThanhDieuHuong";
            flơThanhDieuHuong.Size = new Size(214, 648);
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
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng bạn đến với OGC";
            FormClosed += frmMain_FormClosed;
            panel1.ResumeLayout(false);
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

        private Panel panel1;
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
