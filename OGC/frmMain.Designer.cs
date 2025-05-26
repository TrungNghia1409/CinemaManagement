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
            lblUser = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel9 = new Panel();
            btnQuanLyPhim = new Button();
            panel7 = new Panel();
            btnDichVu = new Button();
            panel5 = new Panel();
            btnThuocTinh = new Button();
            panel8 = new Panel();
            btnLichChieu = new Button();
            panel6 = new Panel();
            btnDatVe = new Button();
            panel4 = new Panel();
            btnTrangChu = new Button();
            panel_Body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            pnlUser.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
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
            pnlUser.Controls.Add(lblUser);
            pnlUser.Location = new Point(1134, 11);
            pnlUser.Margin = new Padding(3, 4, 3, 4);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(229, 64);
            pnlUser.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(229, 64);
            lblUser.TabIndex = 1;
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(1, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 647);
            panel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnQuanLyPhim);
            panel9.Location = new Point(3, 508);
            panel9.Name = "panel9";
            panel9.Size = new Size(224, 95);
            panel9.TabIndex = 0;
            // 
            // btnQuanLyPhim
            // 
            btnQuanLyPhim.Location = new Point(0, 3);
            btnQuanLyPhim.Name = "btnQuanLyPhim";
            btnQuanLyPhim.Size = new Size(221, 89);
            btnQuanLyPhim.TabIndex = 0;
            btnQuanLyPhim.Text = "Quản Lý Phim";
            btnQuanLyPhim.UseVisualStyleBackColor = true;
            btnQuanLyPhim.Click += btnQuanLyPhim_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnDichVu);
            panel7.Location = new Point(3, 307);
            panel7.Name = "panel7";
            panel7.Size = new Size(224, 95);
            panel7.TabIndex = 0;
            // 
            // btnDichVu
            // 
            btnDichVu.Location = new Point(0, 3);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(221, 89);
            btnDichVu.TabIndex = 0;
            btnDichVu.Text = "Dịch Vụ";
            btnDichVu.UseVisualStyleBackColor = true;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnThuocTinh);
            panel5.Location = new Point(3, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 95);
            panel5.TabIndex = 0;
            // 
            // btnThuocTinh
            // 
            btnThuocTinh.Location = new Point(0, 3);
            btnThuocTinh.Name = "btnThuocTinh";
            btnThuocTinh.Size = new Size(221, 89);
            btnThuocTinh.TabIndex = 0;
            btnThuocTinh.Text = "Thuộc Tính";
            btnThuocTinh.UseVisualStyleBackColor = true;
            btnThuocTinh.Click += btnThuocTinh_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLichChieu);
            panel8.Location = new Point(3, 407);
            panel8.Name = "panel8";
            panel8.Size = new Size(224, 95);
            panel8.TabIndex = 0;
            // 
            // btnLichChieu
            // 
            btnLichChieu.Location = new Point(0, 3);
            btnLichChieu.Name = "btnLichChieu";
            btnLichChieu.Size = new Size(221, 89);
            btnLichChieu.TabIndex = 0;
            btnLichChieu.Text = "Lịch Chiếu";
            btnLichChieu.UseVisualStyleBackColor = true;
            btnLichChieu.Click += btnNhanVien_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDatVe);
            panel6.Location = new Point(3, 205);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 95);
            panel6.TabIndex = 0;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(0, 3);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(221, 89);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTrangChu);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 95);
            panel4.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(0, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(221, 89);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.Location = new Point(235, 101);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1245, 648);
            panel_Body.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(panel_Body);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng bạn đến với OGC";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel9;
        private Panel panel7;
        private Panel panel5;
        private Panel panel8;
        private Panel panel6;
        private Panel panel4;
        private Button btnDichVu;
        private Button btnThuocTinh;
        private Button btnLichChieu;
        private Button btnDatVe;
        private Button btnTrangChu;
        private Button btnQuanLyPhim;
        protected PictureBox Logo;
        private Panel panel_Body;
        private Panel pnlUser;
        private Label lblUser;
    }
}
