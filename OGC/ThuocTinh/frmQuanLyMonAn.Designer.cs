namespace OGC.QuanLyDichVu
{
    partial class frmQuanLyMonAn
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
            panel5 = new Panel();
            tbGiaMonAn = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            cbLoaiMonAn = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            tbTenMonAn = new TextBox();
            label1 = new Label();
            dtgvMonAn = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            btnXoaMonAn = new Button();
            btnSuaMonAn = new Button();
            btnThemMonAn = new Button();
            btnTaiAnhMonAn = new Button();
            label13 = new Label();
            panel16 = new Panel();
            tbMoTaMonAn = new TextBox();
            label12 = new Label();
            btnXoaAnh = new Button();
            AnhDoAn = new PictureBox();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMonAn).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhDoAn).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(tbGiaMonAn);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 95);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 42);
            panel5.TabIndex = 0;
            // 
            // tbGiaMonAn
            // 
            tbGiaMonAn.Location = new Point(88, 9);
            tbGiaMonAn.Margin = new Padding(3, 2, 3, 2);
            tbGiaMonAn.Name = "tbGiaMonAn";
            tbGiaMonAn.Size = new Size(203, 23);
            tbGiaMonAn.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 0;
            label3.Text = "Giá";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbLoaiMonAn);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(3, 49);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 42);
            panel7.TabIndex = 0;
            // 
            // cbLoaiMonAn
            // 
            cbLoaiMonAn.FormattingEnabled = true;
            cbLoaiMonAn.Location = new Point(88, 11);
            cbLoaiMonAn.Margin = new Padding(3, 2, 3, 2);
            cbLoaiMonAn.Name = "cbLoaiMonAn";
            cbLoaiMonAn.Size = new Size(203, 23);
            cbLoaiMonAn.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 14);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "Loại";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbTenMonAn);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 42);
            panel3.TabIndex = 0;
            // 
            // tbTenMonAn
            // 
            tbTenMonAn.Location = new Point(88, 9);
            tbTenMonAn.Margin = new Padding(3, 2, 3, 2);
            tbTenMonAn.Name = "tbTenMonAn";
            tbTenMonAn.Size = new Size(203, 23);
            tbTenMonAn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Món Ăn";
            // 
            // dtgvMonAn
            // 
            dtgvMonAn.BorderStyle = BorderStyle.Fixed3D;
            dtgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMonAn.Location = new Point(4, 3);
            dtgvMonAn.Margin = new Padding(3, 2, 3, 2);
            dtgvMonAn.Name = "dtgvMonAn";
            dtgvMonAn.RowHeadersWidth = 51;
            dtgvMonAn.Size = new Size(431, 329);
            dtgvMonAn.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dtgvMonAn);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 340);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoaMonAn);
            panel1.Controls.Add(btnSuaMonAn);
            panel1.Controls.Add(btnThemMonAn);
            panel1.Controls.Add(btnTaiAnhMonAn);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(btnXoaAnh);
            panel1.Controls.Add(AnhDoAn);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(440, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 329);
            panel1.TabIndex = 1;
            // 
            // btnXoaMonAn
            // 
            btnXoaMonAn.Location = new Point(192, 283);
            btnXoaMonAn.Margin = new Padding(3, 2, 3, 2);
            btnXoaMonAn.Name = "btnXoaMonAn";
            btnXoaMonAn.Size = new Size(74, 22);
            btnXoaMonAn.TabIndex = 2;
            btnXoaMonAn.Text = "Xóa";
            btnXoaMonAn.UseVisualStyleBackColor = true;
            btnXoaMonAn.Click += btnXoaMonAn_Click;
            // 
            // btnSuaMonAn
            // 
            btnSuaMonAn.Location = new Point(112, 283);
            btnSuaMonAn.Margin = new Padding(3, 2, 3, 2);
            btnSuaMonAn.Name = "btnSuaMonAn";
            btnSuaMonAn.Size = new Size(74, 22);
            btnSuaMonAn.TabIndex = 2;
            btnSuaMonAn.Text = "Sửa";
            btnSuaMonAn.UseVisualStyleBackColor = true;
            btnSuaMonAn.Click += btnSuaMonAn_Click;
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Location = new Point(32, 283);
            btnThemMonAn.Margin = new Padding(3, 2, 3, 2);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(74, 22);
            btnThemMonAn.TabIndex = 2;
            btnThemMonAn.Text = "Thêm";
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // btnTaiAnhMonAn
            // 
            btnTaiAnhMonAn.Location = new Point(303, 274);
            btnTaiAnhMonAn.Margin = new Padding(3, 2, 3, 2);
            btnTaiAnhMonAn.Name = "btnTaiAnhMonAn";
            btnTaiAnhMonAn.Size = new Size(74, 22);
            btnTaiAnhMonAn.TabIndex = 1;
            btnTaiAnhMonAn.Text = "Tải Ảnh";
            btnTaiAnhMonAn.UseVisualStyleBackColor = true;
            btnTaiAnhMonAn.Click += btnTaiAnhMonAn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(303, 2);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 0;
            label13.Text = "Ảnh Món Ăn";
            // 
            // panel16
            // 
            panel16.Controls.Add(tbMoTaMonAn);
            panel16.Controls.Add(label12);
            panel16.Location = new Point(3, 142);
            panel16.Name = "panel16";
            panel16.Size = new Size(295, 127);
            panel16.TabIndex = 0;
            // 
            // tbMoTaMonAn
            // 
            tbMoTaMonAn.Location = new Point(9, 20);
            tbMoTaMonAn.Margin = new Padding(3, 2, 3, 2);
            tbMoTaMonAn.Multiline = true;
            tbMoTaMonAn.Name = "tbMoTaMonAn";
            tbMoTaMonAn.Size = new Size(282, 106);
            tbMoTaMonAn.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 2);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 0;
            label12.Text = "Mô Tả";
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Location = new Point(387, 274);
            btnXoaAnh.Margin = new Padding(3, 2, 3, 2);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(74, 22);
            btnXoaAnh.TabIndex = 1;
            btnXoaAnh.Text = "Xóa Ảnh";
            btnXoaAnh.UseVisualStyleBackColor = true;
            // 
            // AnhDoAn
            // 
            AnhDoAn.Location = new Point(303, 20);
            AnhDoAn.Margin = new Padding(3, 2, 3, 2);
            AnhDoAn.Name = "AnhDoAn";
            AnhDoAn.Size = new Size(158, 250);
            AnhDoAn.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhDoAn.TabIndex = 0;
            AnhDoAn.TabStop = false;
            // 
            // frmQuanLyMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 347);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuanLyMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyMonAn";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMonAn).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnhDoAn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private TextBox tbGiaMonAn;
        private Label label3;
        private Panel panel7;
        private ComboBox cbLoaiMonAn;
        private Label label5;
        private Panel panel3;
        private TextBox tbTenMonAn;
        private Label label1;
        private DataGridView dtgvMonAn;
        private Panel panel2;
        private Panel panel1;
        private Button btnTaiAnhMonAn;
        private Label label13;
        private Panel panel16;
        private TextBox tbMoTaMonAn;
        private Label label12;
        private Button btnXoaAnh;
        private PictureBox AnhDoAn;
        private Button btnThemMonAn;
        private Button btnXoaMonAn;
        private Button btnSuaMonAn;
    }
}