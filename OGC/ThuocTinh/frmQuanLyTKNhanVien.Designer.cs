namespace OGC.ThuocTinh
{
    partial class frmQuanLyTKNhanVien
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
            lblQuanlyTKNhanVien = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlMKNhanVien = new Panel();
            txbMKNhanVien = new TextBox();
            pnlTKNhanVien = new Panel();
            txbTKNhanVien = new TextBox();
            panel3 = new Panel();
            pnlSuaTKNhanVien = new Panel();
            btnSuaTKNhanVien = new Button();
            pnlXoaTKNhanVien = new Panel();
            btnXoaTKNhanVien = new Button();
            pnlThemTKNhanVien = new Panel();
            btnThemTKNhanVien = new Button();
            grbChucVu = new GroupBox();
            dgvTKNhanVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlMKNhanVien.SuspendLayout();
            pnlTKNhanVien.SuspendLayout();
            panel3.SuspendLayout();
            pnlSuaTKNhanVien.SuspendLayout();
            pnlXoaTKNhanVien.SuspendLayout();
            pnlThemTKNhanVien.SuspendLayout();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlyTKNhanVien);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 2;
            // 
            // lblQuanlyTKNhanVien
            // 
            lblQuanlyTKNhanVien.AutoSize = true;
            lblQuanlyTKNhanVien.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlyTKNhanVien.ForeColor = Color.White;
            lblQuanlyTKNhanVien.Location = new Point(128, 16);
            lblQuanlyTKNhanVien.Name = "lblQuanlyTKNhanVien";
            lblQuanlyTKNhanVien.Size = new Size(241, 37);
            lblQuanlyTKNhanVien.TabIndex = 0;
            lblQuanlyTKNhanVien.Text = "Quản lý tài khoản";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pnlMKNhanVien);
            panel2.Controls.Add(pnlTKNhanVien);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 100);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 64);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản";
            // 
            // pnlMKNhanVien
            // 
            pnlMKNhanVien.Controls.Add(txbMKNhanVien);
            pnlMKNhanVien.Location = new Point(152, 56);
            pnlMKNhanVien.Name = "pnlMKNhanVien";
            pnlMKNhanVien.Size = new Size(288, 40);
            pnlMKNhanVien.TabIndex = 2;
            pnlMKNhanVien.Paint += pnlMKNhanVien_Paint;
            // 
            // txbMKNhanVien
            // 
            txbMKNhanVien.BorderStyle = BorderStyle.None;
            txbMKNhanVien.Dock = DockStyle.Fill;
            txbMKNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMKNhanVien.Location = new Point(0, 0);
            txbMKNhanVien.Multiline = true;
            txbMKNhanVien.Name = "txbMKNhanVien";
            txbMKNhanVien.PasswordChar = '*';
            txbMKNhanVien.Size = new Size(288, 40);
            txbMKNhanVien.TabIndex = 2;
            // 
            // pnlTKNhanVien
            // 
            pnlTKNhanVien.Controls.Add(txbTKNhanVien);
            pnlTKNhanVien.Location = new Point(152, 8);
            pnlTKNhanVien.Name = "pnlTKNhanVien";
            pnlTKNhanVien.Size = new Size(288, 40);
            pnlTKNhanVien.TabIndex = 2;
            pnlTKNhanVien.Paint += pnlTKNhanVien_Paint;
            // 
            // txbTKNhanVien
            // 
            txbTKNhanVien.BorderStyle = BorderStyle.None;
            txbTKNhanVien.Dock = DockStyle.Fill;
            txbTKNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTKNhanVien.Location = new Point(0, 0);
            txbTKNhanVien.Multiline = true;
            txbTKNhanVien.Name = "txbTKNhanVien";
            txbTKNhanVien.Size = new Size(288, 40);
            txbTKNhanVien.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSuaTKNhanVien);
            panel3.Controls.Add(pnlXoaTKNhanVien);
            panel3.Controls.Add(pnlThemTKNhanVien);
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 4;
            // 
            // pnlSuaTKNhanVien
            // 
            pnlSuaTKNhanVien.Controls.Add(btnSuaTKNhanVien);
            pnlSuaTKNhanVien.Location = new Point(328, 16);
            pnlSuaTKNhanVien.Name = "pnlSuaTKNhanVien";
            pnlSuaTKNhanVien.Size = new Size(96, 32);
            pnlSuaTKNhanVien.TabIndex = 0;
            pnlSuaTKNhanVien.Paint += pnlSuaTKNhanVien_Paint;
            // 
            // btnSuaTKNhanVien
            // 
            btnSuaTKNhanVien.BackColor = SystemColors.ActiveCaption;
            btnSuaTKNhanVien.Dock = DockStyle.Fill;
            btnSuaTKNhanVien.FlatAppearance.BorderSize = 0;
            btnSuaTKNhanVien.FlatStyle = FlatStyle.Flat;
            btnSuaTKNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaTKNhanVien.ForeColor = Color.White;
            btnSuaTKNhanVien.Location = new Point(0, 0);
            btnSuaTKNhanVien.Name = "btnSuaTKNhanVien";
            btnSuaTKNhanVien.Size = new Size(96, 32);
            btnSuaTKNhanVien.TabIndex = 5;
            btnSuaTKNhanVien.Text = "Sửa";
            btnSuaTKNhanVien.UseVisualStyleBackColor = false;
            btnSuaTKNhanVien.Click += btnSuaTKNhanVien_Click;
            // 
            // pnlXoaTKNhanVien
            // 
            pnlXoaTKNhanVien.Controls.Add(btnXoaTKNhanVien);
            pnlXoaTKNhanVien.Location = new Point(192, 16);
            pnlXoaTKNhanVien.Name = "pnlXoaTKNhanVien";
            pnlXoaTKNhanVien.Size = new Size(96, 32);
            pnlXoaTKNhanVien.TabIndex = 0;
            pnlXoaTKNhanVien.Paint += pnlXoaTKNhanVien_Paint;
            // 
            // btnXoaTKNhanVien
            // 
            btnXoaTKNhanVien.BackColor = Color.IndianRed;
            btnXoaTKNhanVien.Dock = DockStyle.Fill;
            btnXoaTKNhanVien.FlatAppearance.BorderSize = 0;
            btnXoaTKNhanVien.FlatStyle = FlatStyle.Flat;
            btnXoaTKNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaTKNhanVien.ForeColor = Color.White;
            btnXoaTKNhanVien.Location = new Point(0, 0);
            btnXoaTKNhanVien.Name = "btnXoaTKNhanVien";
            btnXoaTKNhanVien.Size = new Size(96, 32);
            btnXoaTKNhanVien.TabIndex = 4;
            btnXoaTKNhanVien.Text = "Xóa";
            btnXoaTKNhanVien.UseVisualStyleBackColor = false;
            btnXoaTKNhanVien.Click += btnXoaTKNhanVien_Click;
            // 
            // pnlThemTKNhanVien
            // 
            pnlThemTKNhanVien.Controls.Add(btnThemTKNhanVien);
            pnlThemTKNhanVien.Location = new Point(56, 16);
            pnlThemTKNhanVien.Name = "pnlThemTKNhanVien";
            pnlThemTKNhanVien.Size = new Size(96, 32);
            pnlThemTKNhanVien.TabIndex = 0;
            pnlThemTKNhanVien.Paint += pnlThemTKNhanVien_Paint;
            // 
            // btnThemTKNhanVien
            // 
            btnThemTKNhanVien.BackColor = Color.MediumAquamarine;
            btnThemTKNhanVien.Dock = DockStyle.Fill;
            btnThemTKNhanVien.FlatAppearance.BorderSize = 0;
            btnThemTKNhanVien.FlatStyle = FlatStyle.Flat;
            btnThemTKNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemTKNhanVien.ForeColor = Color.White;
            btnThemTKNhanVien.Location = new Point(0, 0);
            btnThemTKNhanVien.Name = "btnThemTKNhanVien";
            btnThemTKNhanVien.Size = new Size(96, 32);
            btnThemTKNhanVien.TabIndex = 3;
            btnThemTKNhanVien.Text = "Thêm";
            btnThemTKNhanVien.UseVisualStyleBackColor = false;
            btnThemTKNhanVien.Click += btnThemTKNhanVien_Click;
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dgvTKNhanVien);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 184);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 308);
            grbChucVu.TabIndex = 5;
            grbChucVu.TabStop = false;
            // 
            // dgvTKNhanVien
            // 
            dgvTKNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKNhanVien.Location = new Point(8, 32);
            dgvTKNhanVien.Name = "dgvTKNhanVien";
            dgvTKNhanVien.Size = new Size(472, 288);
            dgvTKNhanVien.TabIndex = 0;
            // 
            // frmQuanLyTKNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(grbChucVu);
            Name = "frmQuanLyTKNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyTKNhanVien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlMKNhanVien.ResumeLayout(false);
            pnlMKNhanVien.PerformLayout();
            pnlTKNhanVien.ResumeLayout(false);
            pnlTKNhanVien.PerformLayout();
            panel3.ResumeLayout(false);
            pnlSuaTKNhanVien.ResumeLayout(false);
            pnlXoaTKNhanVien.ResumeLayout(false);
            pnlThemTKNhanVien.ResumeLayout(false);
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTKNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuanlyTKNhanVien;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel pnlMKNhanVien;
        private TextBox txbMKNhanVien;
        private Panel pnlTKNhanVien;
        private TextBox txbTKNhanVien;
        private Panel panel3;
        private Panel pnlSuaTKNhanVien;
        private Button btnSuaTKNhanVien;
        private Panel pnlXoaTKNhanVien;
        private Button btnXoaTKNhanVien;
        private Panel pnlThemTKNhanVien;
        private Button btnThemTKNhanVien;
        private GroupBox grbChucVu;
        private DataGridView dgvTKNhanVien;
    }
}