namespace OGC.ThuocTinh
{
    partial class frmDinhDangPhim
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
            lblQuanlydinhdangphim = new Label();
            panel2 = new Panel();
            pnlDinhDangPhim = new Panel();
            txbDinhDangPhim = new TextBox();
            lblTendinhdangphim = new Label();
            panel3 = new Panel();
            pnlSuaDinhDangPhim = new Panel();
            btnSuaDinhDangPhim = new Button();
            pnlXoaDinhDangPhim = new Panel();
            btnXoaDinhDangPhim = new Button();
            pnlThemDinhDangPhim = new Panel();
            btnThemDinhDangPhim = new Button();
            grbChucVu = new GroupBox();
            dgvDinhDangPhim = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlDinhDangPhim.SuspendLayout();
            panel3.SuspendLayout();
            pnlSuaDinhDangPhim.SuspendLayout();
            pnlXoaDinhDangPhim.SuspendLayout();
            pnlThemDinhDangPhim.SuspendLayout();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDinhDangPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlydinhdangphim);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 2;
            // 
            // lblQuanlydinhdangphim
            // 
            lblQuanlydinhdangphim.AutoSize = true;
            lblQuanlydinhdangphim.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlydinhdangphim.ForeColor = Color.White;
            lblQuanlydinhdangphim.Location = new Point(80, 16);
            lblQuanlydinhdangphim.Name = "lblQuanlydinhdangphim";
            lblQuanlydinhdangphim.Size = new Size(323, 37);
            lblQuanlydinhdangphim.TabIndex = 0;
            lblQuanlydinhdangphim.Text = "Quản lý định dạng phim";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlDinhDangPhim);
            panel2.Controls.Add(lblTendinhdangphim);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 80);
            panel2.TabIndex = 3;
            // 
            // pnlDinhDangPhim
            // 
            pnlDinhDangPhim.Controls.Add(txbDinhDangPhim);
            pnlDinhDangPhim.Location = new Point(104, 32);
            pnlDinhDangPhim.Name = "pnlDinhDangPhim";
            pnlDinhDangPhim.Size = new Size(272, 40);
            pnlDinhDangPhim.TabIndex = 2;
            pnlDinhDangPhim.Paint += pnlDinhDangPhim_Paint;
            // 
            // txbDinhDangPhim
            // 
            txbDinhDangPhim.BorderStyle = BorderStyle.None;
            txbDinhDangPhim.Dock = DockStyle.Fill;
            txbDinhDangPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDinhDangPhim.Location = new Point(0, 0);
            txbDinhDangPhim.Multiline = true;
            txbDinhDangPhim.Name = "txbDinhDangPhim";
            txbDinhDangPhim.Size = new Size(272, 40);
            txbDinhDangPhim.TabIndex = 1;
            // 
            // lblTendinhdangphim
            // 
            lblTendinhdangphim.AutoSize = true;
            lblTendinhdangphim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTendinhdangphim.Location = new Point(112, 8);
            lblTendinhdangphim.Name = "lblTendinhdangphim";
            lblTendinhdangphim.Size = new Size(107, 21);
            lblTendinhdangphim.TabIndex = 0;
            lblTendinhdangphim.Text = "Tên định dạng";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSuaDinhDangPhim);
            panel3.Controls.Add(pnlXoaDinhDangPhim);
            panel3.Controls.Add(pnlThemDinhDangPhim);
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 4;
            // 
            // pnlSuaDinhDangPhim
            // 
            pnlSuaDinhDangPhim.Controls.Add(btnSuaDinhDangPhim);
            pnlSuaDinhDangPhim.Location = new Point(328, 16);
            pnlSuaDinhDangPhim.Name = "pnlSuaDinhDangPhim";
            pnlSuaDinhDangPhim.Size = new Size(96, 32);
            pnlSuaDinhDangPhim.TabIndex = 0;
            pnlSuaDinhDangPhim.Paint += pnlSuaDinhDangPhim_Paint;
            // 
            // btnSuaDinhDangPhim
            // 
            btnSuaDinhDangPhim.BackColor = SystemColors.ActiveCaption;
            btnSuaDinhDangPhim.Dock = DockStyle.Fill;
            btnSuaDinhDangPhim.FlatAppearance.BorderSize = 0;
            btnSuaDinhDangPhim.FlatStyle = FlatStyle.Flat;
            btnSuaDinhDangPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaDinhDangPhim.ForeColor = Color.White;
            btnSuaDinhDangPhim.Location = new Point(0, 0);
            btnSuaDinhDangPhim.Name = "btnSuaDinhDangPhim";
            btnSuaDinhDangPhim.Size = new Size(96, 32);
            btnSuaDinhDangPhim.TabIndex = 0;
            btnSuaDinhDangPhim.Text = "Sửa";
            btnSuaDinhDangPhim.UseVisualStyleBackColor = false;
            btnSuaDinhDangPhim.Click += btnSuaDinhDangPhim_Click;
            // 
            // pnlXoaDinhDangPhim
            // 
            pnlXoaDinhDangPhim.Controls.Add(btnXoaDinhDangPhim);
            pnlXoaDinhDangPhim.Location = new Point(192, 16);
            pnlXoaDinhDangPhim.Name = "pnlXoaDinhDangPhim";
            pnlXoaDinhDangPhim.Size = new Size(96, 32);
            pnlXoaDinhDangPhim.TabIndex = 0;
            pnlXoaDinhDangPhim.Paint += pnlXoaDinhDangPhim_Paint;
            // 
            // btnXoaDinhDangPhim
            // 
            btnXoaDinhDangPhim.BackColor = Color.IndianRed;
            btnXoaDinhDangPhim.Dock = DockStyle.Fill;
            btnXoaDinhDangPhim.FlatAppearance.BorderSize = 0;
            btnXoaDinhDangPhim.FlatStyle = FlatStyle.Flat;
            btnXoaDinhDangPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaDinhDangPhim.ForeColor = Color.White;
            btnXoaDinhDangPhim.Location = new Point(0, 0);
            btnXoaDinhDangPhim.Name = "btnXoaDinhDangPhim";
            btnXoaDinhDangPhim.Size = new Size(96, 32);
            btnXoaDinhDangPhim.TabIndex = 0;
            btnXoaDinhDangPhim.Text = "Xóa";
            btnXoaDinhDangPhim.UseVisualStyleBackColor = false;
            btnXoaDinhDangPhim.Click += btnXoaDinhDangPhim_Click;
            // 
            // pnlThemDinhDangPhim
            // 
            pnlThemDinhDangPhim.Controls.Add(btnThemDinhDangPhim);
            pnlThemDinhDangPhim.Location = new Point(56, 16);
            pnlThemDinhDangPhim.Name = "pnlThemDinhDangPhim";
            pnlThemDinhDangPhim.Size = new Size(96, 32);
            pnlThemDinhDangPhim.TabIndex = 0;
            pnlThemDinhDangPhim.Paint += pnlThemDinhDangPhim_Paint;
            // 
            // btnThemDinhDangPhim
            // 
            btnThemDinhDangPhim.BackColor = Color.MediumAquamarine;
            btnThemDinhDangPhim.Dock = DockStyle.Fill;
            btnThemDinhDangPhim.FlatAppearance.BorderSize = 0;
            btnThemDinhDangPhim.FlatStyle = FlatStyle.Flat;
            btnThemDinhDangPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemDinhDangPhim.ForeColor = Color.White;
            btnThemDinhDangPhim.Location = new Point(0, 0);
            btnThemDinhDangPhim.Name = "btnThemDinhDangPhim";
            btnThemDinhDangPhim.Size = new Size(96, 32);
            btnThemDinhDangPhim.TabIndex = 0;
            btnThemDinhDangPhim.Text = "Thêm";
            btnThemDinhDangPhim.UseVisualStyleBackColor = false;
            btnThemDinhDangPhim.Click += btnThemDinhDangPhim_Click;
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dgvDinhDangPhim);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 164);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 328);
            grbChucVu.TabIndex = 5;
            grbChucVu.TabStop = false;
            // 
            // dgvDinhDangPhim
            // 
            dgvDinhDangPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDinhDangPhim.Location = new Point(8, 32);
            dgvDinhDangPhim.Name = "dgvDinhDangPhim";
            dgvDinhDangPhim.Size = new Size(472, 288);
            dgvDinhDangPhim.TabIndex = 0;
            // 
            // frmDinhDangPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(grbChucVu);
            Name = "frmDinhDangPhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDinhDangPhim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDinhDangPhim.ResumeLayout(false);
            pnlDinhDangPhim.PerformLayout();
            panel3.ResumeLayout(false);
            pnlSuaDinhDangPhim.ResumeLayout(false);
            pnlXoaDinhDangPhim.ResumeLayout(false);
            pnlThemDinhDangPhim.ResumeLayout(false);
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDinhDangPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuanlydinhdangphim;
        private Panel panel2;
        private Panel pnlDinhDangPhim;
        private TextBox txbDinhDangPhim;
        private Label lblTendinhdangphim;
        private Panel panel3;
        private Panel pnlSuaDinhDangPhim;
        private Button btnSuaDinhDangPhim;
        private Panel pnlXoaDinhDangPhim;
        private Button btnXoaDinhDangPhim;
        private Panel pnlThemDinhDangPhim;
        private Button btnThemDinhDangPhim;
        private GroupBox grbChucVu;
        private DataGridView dgvDinhDangPhim;
    }
}