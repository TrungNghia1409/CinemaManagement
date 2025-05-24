namespace OGC.ThuocTinh
{
    partial class frmTheLoaiPhim
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
            lblQuanlyloaiphim = new Label();
            panel2 = new Panel();
            pnlTenLoaiPhim = new Panel();
            txbTenLoaiPhim = new TextBox();
            lblTenloaiphim = new Label();
            panel3 = new Panel();
            pnlSuaLoaiPhim = new Panel();
            btnSuaLoaiPhim = new Button();
            pnlXoaLoaiPhim = new Panel();
            btnXoaLoaiPhim = new Button();
            pnlThemLoaiPhim = new Panel();
            btnThemLoaiPhim = new Button();
            grbChucVu = new GroupBox();
            dgvLoaiPhim = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTenLoaiPhim.SuspendLayout();
            panel3.SuspendLayout();
            pnlSuaLoaiPhim.SuspendLayout();
            pnlXoaLoaiPhim.SuspendLayout();
            pnlThemLoaiPhim.SuspendLayout();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlyloaiphim);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 2;
            // 
            // lblQuanlyloaiphim
            // 
            lblQuanlyloaiphim.AutoSize = true;
            lblQuanlyloaiphim.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlyloaiphim.ForeColor = Color.White;
            lblQuanlyloaiphim.Location = new Point(128, 16);
            lblQuanlyloaiphim.Name = "lblQuanlyloaiphim";
            lblQuanlyloaiphim.Size = new Size(242, 37);
            lblQuanlyloaiphim.TabIndex = 0;
            lblQuanlyloaiphim.Text = "Quản lý loại phim";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTenLoaiPhim);
            panel2.Controls.Add(lblTenloaiphim);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 80);
            panel2.TabIndex = 3;
            // 
            // pnlTenLoaiPhim
            // 
            pnlTenLoaiPhim.Controls.Add(txbTenLoaiPhim);
            pnlTenLoaiPhim.Location = new Point(104, 32);
            pnlTenLoaiPhim.Name = "pnlTenLoaiPhim";
            pnlTenLoaiPhim.Size = new Size(272, 40);
            pnlTenLoaiPhim.TabIndex = 2;
            pnlTenLoaiPhim.Paint += pnlTenLoaiPhim_Paint;
            // 
            // txbTenLoaiPhim
            // 
            txbTenLoaiPhim.BorderStyle = BorderStyle.None;
            txbTenLoaiPhim.Dock = DockStyle.Fill;
            txbTenLoaiPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenLoaiPhim.Location = new Point(0, 0);
            txbTenLoaiPhim.Multiline = true;
            txbTenLoaiPhim.Name = "txbTenLoaiPhim";
            txbTenLoaiPhim.Size = new Size(272, 40);
            txbTenLoaiPhim.TabIndex = 1;
            // 
            // lblTenloaiphim
            // 
            lblTenloaiphim.AutoSize = true;
            lblTenloaiphim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenloaiphim.Location = new Point(112, 8);
            lblTenloaiphim.Name = "lblTenloaiphim";
            lblTenloaiphim.Size = new Size(102, 21);
            lblTenloaiphim.TabIndex = 0;
            lblTenloaiphim.Text = "Tên loại phim";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSuaLoaiPhim);
            panel3.Controls.Add(pnlXoaLoaiPhim);
            panel3.Controls.Add(pnlThemLoaiPhim);
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 4;
            // 
            // pnlSuaLoaiPhim
            // 
            pnlSuaLoaiPhim.Controls.Add(btnSuaLoaiPhim);
            pnlSuaLoaiPhim.Location = new Point(328, 16);
            pnlSuaLoaiPhim.Name = "pnlSuaLoaiPhim";
            pnlSuaLoaiPhim.Size = new Size(96, 32);
            pnlSuaLoaiPhim.TabIndex = 0;
            pnlSuaLoaiPhim.Paint += pnlSuaLoaiPhim_Paint;
            // 
            // btnSuaLoaiPhim
            // 
            btnSuaLoaiPhim.BackColor = SystemColors.ActiveCaption;
            btnSuaLoaiPhim.Dock = DockStyle.Fill;
            btnSuaLoaiPhim.FlatAppearance.BorderSize = 0;
            btnSuaLoaiPhim.FlatStyle = FlatStyle.Flat;
            btnSuaLoaiPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaLoaiPhim.ForeColor = Color.White;
            btnSuaLoaiPhim.Location = new Point(0, 0);
            btnSuaLoaiPhim.Name = "btnSuaLoaiPhim";
            btnSuaLoaiPhim.Size = new Size(96, 32);
            btnSuaLoaiPhim.TabIndex = 0;
            btnSuaLoaiPhim.Text = "Sửa";
            btnSuaLoaiPhim.UseVisualStyleBackColor = false;
            btnSuaLoaiPhim.Click += btnSuaLoaiPhim_Click;
            // 
            // pnlXoaLoaiPhim
            // 
            pnlXoaLoaiPhim.Controls.Add(btnXoaLoaiPhim);
            pnlXoaLoaiPhim.Location = new Point(192, 16);
            pnlXoaLoaiPhim.Name = "pnlXoaLoaiPhim";
            pnlXoaLoaiPhim.Size = new Size(96, 32);
            pnlXoaLoaiPhim.TabIndex = 0;
            pnlXoaLoaiPhim.Paint += pnlXoaLoaiPhim_Paint;
            // 
            // btnXoaLoaiPhim
            // 
            btnXoaLoaiPhim.BackColor = Color.IndianRed;
            btnXoaLoaiPhim.Dock = DockStyle.Fill;
            btnXoaLoaiPhim.FlatAppearance.BorderSize = 0;
            btnXoaLoaiPhim.FlatStyle = FlatStyle.Flat;
            btnXoaLoaiPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaLoaiPhim.ForeColor = Color.White;
            btnXoaLoaiPhim.Location = new Point(0, 0);
            btnXoaLoaiPhim.Name = "btnXoaLoaiPhim";
            btnXoaLoaiPhim.Size = new Size(96, 32);
            btnXoaLoaiPhim.TabIndex = 0;
            btnXoaLoaiPhim.Text = "Xóa";
            btnXoaLoaiPhim.UseVisualStyleBackColor = false;
            btnXoaLoaiPhim.Click += btnXoaLoaiPhim_Click;
            // 
            // pnlThemLoaiPhim
            // 
            pnlThemLoaiPhim.Controls.Add(btnThemLoaiPhim);
            pnlThemLoaiPhim.Location = new Point(56, 16);
            pnlThemLoaiPhim.Name = "pnlThemLoaiPhim";
            pnlThemLoaiPhim.Size = new Size(96, 32);
            pnlThemLoaiPhim.TabIndex = 0;
            pnlThemLoaiPhim.Paint += pnlThemLoaiPhim_Paint;
            // 
            // btnThemLoaiPhim
            // 
            btnThemLoaiPhim.BackColor = Color.MediumAquamarine;
            btnThemLoaiPhim.Dock = DockStyle.Fill;
            btnThemLoaiPhim.FlatAppearance.BorderSize = 0;
            btnThemLoaiPhim.FlatStyle = FlatStyle.Flat;
            btnThemLoaiPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemLoaiPhim.ForeColor = Color.White;
            btnThemLoaiPhim.Location = new Point(0, 0);
            btnThemLoaiPhim.Name = "btnThemLoaiPhim";
            btnThemLoaiPhim.Size = new Size(96, 32);
            btnThemLoaiPhim.TabIndex = 0;
            btnThemLoaiPhim.Text = "Thêm";
            btnThemLoaiPhim.UseVisualStyleBackColor = false;
            btnThemLoaiPhim.Click += btnThemLoaiPhim_Click;
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dgvLoaiPhim);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 164);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 328);
            grbChucVu.TabIndex = 5;
            grbChucVu.TabStop = false;
            // 
            // dgvLoaiPhim
            // 
            dgvLoaiPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhim.Location = new Point(8, 32);
            dgvLoaiPhim.Name = "dgvLoaiPhim";
            dgvLoaiPhim.Size = new Size(472, 288);
            dgvLoaiPhim.TabIndex = 0;
            // 
            // frmTheLoaiPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(grbChucVu);
            Name = "frmTheLoaiPhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTheLoaiPhim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTenLoaiPhim.ResumeLayout(false);
            pnlTenLoaiPhim.PerformLayout();
            panel3.ResumeLayout(false);
            pnlSuaLoaiPhim.ResumeLayout(false);
            pnlXoaLoaiPhim.ResumeLayout(false);
            pnlThemLoaiPhim.ResumeLayout(false);
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuanlyloaiphim;
        private Panel panel2;
        private Panel pnlTenLoaiPhim;
        private TextBox txbTenLoaiPhim;
        private Label lblTenloaiphim;
        private Panel panel3;
        private Panel pnlSuaLoaiPhim;
        private Button btnSuaLoaiPhim;
        private Panel pnlXoaLoaiPhim;
        private Button btnXoaLoaiPhim;
        private Panel pnlThemLoaiPhim;
        private Button btnThemLoaiPhim;
        private GroupBox grbChucVu;
        private DataGridView dgvLoaiPhim;
    }
}