namespace OGC.QuanLyDichVu
{
    partial class frmThemMonAn
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
            panel1 = new Panel();
            btnTaiAnhMonAn = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            panel16 = new Panel();
            tbMoTaMonAn = new TextBox();
            label12 = new Label();
            AnhDoAn = new PictureBox();
            panel5 = new Panel();
            tbGiaMonAn = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            cbLoaiMonAn = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            tbTenMonAn = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhDoAn).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTaiAnhMonAn);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(AnhDoAn);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 412);
            panel1.TabIndex = 2;
            // 
            // btnTaiAnhMonAn
            // 
            btnTaiAnhMonAn.Location = new Point(82, 365);
            btnTaiAnhMonAn.Name = "btnTaiAnhMonAn";
            btnTaiAnhMonAn.Size = new Size(94, 29);
            btnTaiAnhMonAn.TabIndex = 3;
            btnTaiAnhMonAn.Text = "Tải Ảnh";
            btnTaiAnhMonAn.UseVisualStyleBackColor = true;
            btnTaiAnhMonAn.Click += btnTaiAnhMonAn_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(500, 365);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(400, 365);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Xác Nhận";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(tbMoTaMonAn);
            panel16.Controls.Add(label12);
            panel16.Location = new Point(257, 193);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(337, 169);
            panel16.TabIndex = 0;
            // 
            // tbMoTaMonAn
            // 
            tbMoTaMonAn.Location = new Point(10, 26);
            tbMoTaMonAn.Multiline = true;
            tbMoTaMonAn.Name = "tbMoTaMonAn";
            tbMoTaMonAn.Size = new Size(322, 140);
            tbMoTaMonAn.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 3);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 0;
            label12.Text = "Mô Tả";
            // 
            // AnhDoAn
            // 
            AnhDoAn.Location = new Point(3, 6);
            AnhDoAn.Name = "AnhDoAn";
            AnhDoAn.Size = new Size(248, 353);
            AnhDoAn.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhDoAn.TabIndex = 0;
            AnhDoAn.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbGiaMonAn);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(257, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 56);
            panel5.TabIndex = 0;
            // 
            // tbGiaMonAn
            // 
            tbGiaMonAn.Location = new Point(101, 12);
            tbGiaMonAn.Name = "tbGiaMonAn";
            tbGiaMonAn.Size = new Size(231, 27);
            tbGiaMonAn.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 0;
            label3.Text = "Giá";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbLoaiMonAn);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(257, 68);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 56);
            panel7.TabIndex = 0;
            // 
            // cbLoaiMonAn
            // 
            cbLoaiMonAn.FormattingEnabled = true;
            cbLoaiMonAn.Location = new Point(101, 15);
            cbLoaiMonAn.Name = "cbLoaiMonAn";
            cbLoaiMonAn.Size = new Size(231, 28);
            cbLoaiMonAn.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 0;
            label5.Text = "Loại";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbTenMonAn);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(257, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 56);
            panel3.TabIndex = 0;
            // 
            // tbTenMonAn
            // 
            tbTenMonAn.Location = new Point(101, 12);
            tbTenMonAn.Name = "tbTenMonAn";
            tbTenMonAn.Size = new Size(231, 27);
            tbTenMonAn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Món Ăn";
            // 
            // frmThemMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 423);
            Controls.Add(panel1);
            Name = "frmThemMonAn";
            Text = "frmThemDoAn";
            panel1.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnhDoAn).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel16;
        private TextBox tbMoTaMonAn;
        private Label label12;
        private PictureBox AnhDoAn;
        private Panel panel5;
        private TextBox tbGiaMonAn;
        private Label label3;
        private Panel panel7;
        private ComboBox cbLoaiMonAn;
        private Label label5;
        private Panel panel3;
        private TextBox tbTenMonAn;
        private Label label1;
        private Button btnHuy;
        private Button btnThem;
        private Button btnTaiAnhMonAn;
    }
}