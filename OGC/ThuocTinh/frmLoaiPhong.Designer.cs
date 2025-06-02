namespace OGC.ThuocTinh
{
    partial class frmLoaiPhong
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
            lblQuanlyLoaiPhong = new Label();
            panel2 = new Panel();
            pnlTenLoaiPhong = new Panel();
            txbTenLoaiPhong = new TextBox();
            lblTenloaiphong = new Label();
            panel3 = new Panel();
            pnlSuaLoaiPhong = new Panel();
            btnSuaLoaiPhong = new Button();
            pnlXoaLoaiPhong = new Panel();
            btnXoaLoaiPhong = new Button();
            pnlThemLoaiPhong = new Panel();
            btnThemLoaiPhong = new Button();
            grbChucVu = new GroupBox();
            dgvLoaiPhong = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTenLoaiPhong.SuspendLayout();
            panel3.SuspendLayout();
            pnlSuaLoaiPhong.SuspendLayout();
            pnlXoaLoaiPhong.SuspendLayout();
            pnlThemLoaiPhong.SuspendLayout();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlyLoaiPhong);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 2;
            // 
            // lblQuanlyLoaiPhong
            // 
            lblQuanlyLoaiPhong.AutoSize = true;
            lblQuanlyLoaiPhong.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlyLoaiPhong.ForeColor = Color.White;
            lblQuanlyLoaiPhong.Location = new Point(128, 16);
            lblQuanlyLoaiPhong.Name = "lblQuanlyLoaiPhong";
            lblQuanlyLoaiPhong.Size = new Size(259, 37);
            lblQuanlyLoaiPhong.TabIndex = 0;
            lblQuanlyLoaiPhong.Text = "Quản lý loại phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTenLoaiPhong);
            panel2.Controls.Add(lblTenloaiphong);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 80);
            panel2.TabIndex = 3;
            // 
            // pnlTenLoaiPhong
            // 
            pnlTenLoaiPhong.Controls.Add(txbTenLoaiPhong);
            pnlTenLoaiPhong.Location = new Point(104, 32);
            pnlTenLoaiPhong.Name = "pnlTenLoaiPhong";
            pnlTenLoaiPhong.Size = new Size(272, 40);
            pnlTenLoaiPhong.TabIndex = 2;
            pnlTenLoaiPhong.Paint += pnlTenLoaiPhong_Paint;
            // 
            // txbTenLoaiPhong
            // 
            txbTenLoaiPhong.BorderStyle = BorderStyle.None;
            txbTenLoaiPhong.Dock = DockStyle.Fill;
            txbTenLoaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenLoaiPhong.Location = new Point(0, 0);
            txbTenLoaiPhong.Multiline = true;
            txbTenLoaiPhong.Name = "txbTenLoaiPhong";
            txbTenLoaiPhong.Size = new Size(272, 40);
            txbTenLoaiPhong.TabIndex = 1;
            // 
            // lblTenloaiphong
            // 
            lblTenloaiphong.AutoSize = true;
            lblTenloaiphong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenloaiphong.Location = new Point(112, 8);
            lblTenloaiphong.Name = "lblTenloaiphong";
            lblTenloaiphong.Size = new Size(111, 21);
            lblTenloaiphong.TabIndex = 0;
            lblTenloaiphong.Text = "Tên loại phòng";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSuaLoaiPhong);
            panel3.Controls.Add(pnlXoaLoaiPhong);
            panel3.Controls.Add(pnlThemLoaiPhong);
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 4;
            // 
            // pnlSuaLoaiPhong
            // 
            pnlSuaLoaiPhong.Controls.Add(btnSuaLoaiPhong);
            pnlSuaLoaiPhong.Location = new Point(328, 16);
            pnlSuaLoaiPhong.Name = "pnlSuaLoaiPhong";
            pnlSuaLoaiPhong.Size = new Size(96, 32);
            pnlSuaLoaiPhong.TabIndex = 0;
            pnlSuaLoaiPhong.Paint += pnlSuaLoaiPhong_Paint;
            // 
            // btnSuaLoaiPhong
            // 
            btnSuaLoaiPhong.BackColor = SystemColors.ActiveCaption;
            btnSuaLoaiPhong.Dock = DockStyle.Fill;
            btnSuaLoaiPhong.FlatAppearance.BorderSize = 0;
            btnSuaLoaiPhong.FlatStyle = FlatStyle.Flat;
            btnSuaLoaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaLoaiPhong.ForeColor = Color.White;
            btnSuaLoaiPhong.Location = new Point(0, 0);
            btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            btnSuaLoaiPhong.Size = new Size(96, 32);
            btnSuaLoaiPhong.TabIndex = 4;
            btnSuaLoaiPhong.Text = "Sửa";
            btnSuaLoaiPhong.UseVisualStyleBackColor = false;
            btnSuaLoaiPhong.Click += btnSuaLoaiPhong_Click;
            // 
            // pnlXoaLoaiPhong
            // 
            pnlXoaLoaiPhong.Controls.Add(btnXoaLoaiPhong);
            pnlXoaLoaiPhong.Location = new Point(192, 16);
            pnlXoaLoaiPhong.Name = "pnlXoaLoaiPhong";
            pnlXoaLoaiPhong.Size = new Size(96, 32);
            pnlXoaLoaiPhong.TabIndex = 0;
            pnlXoaLoaiPhong.Paint += pnlXoaLoaiPhong_Paint;
            // 
            // btnXoaLoaiPhong
            // 
            btnXoaLoaiPhong.BackColor = Color.IndianRed;
            btnXoaLoaiPhong.Dock = DockStyle.Fill;
            btnXoaLoaiPhong.FlatAppearance.BorderSize = 0;
            btnXoaLoaiPhong.FlatStyle = FlatStyle.Flat;
            btnXoaLoaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaLoaiPhong.ForeColor = Color.White;
            btnXoaLoaiPhong.Location = new Point(0, 0);
            btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            btnXoaLoaiPhong.Size = new Size(96, 32);
            btnXoaLoaiPhong.TabIndex = 3;
            btnXoaLoaiPhong.Text = "Xóa";
            btnXoaLoaiPhong.UseVisualStyleBackColor = false;
            btnXoaLoaiPhong.Click += btnXoaLoaiPhong_Click;
            // 
            // pnlThemLoaiPhong
            // 
            pnlThemLoaiPhong.Controls.Add(btnThemLoaiPhong);
            pnlThemLoaiPhong.Location = new Point(56, 16);
            pnlThemLoaiPhong.Name = "pnlThemLoaiPhong";
            pnlThemLoaiPhong.Size = new Size(96, 32);
            pnlThemLoaiPhong.TabIndex = 0;
            pnlThemLoaiPhong.Paint += pnlThemLoaiPhong_Paint;
            // 
            // btnThemLoaiPhong
            // 
            btnThemLoaiPhong.BackColor = Color.MediumAquamarine;
            btnThemLoaiPhong.Dock = DockStyle.Fill;
            btnThemLoaiPhong.FlatAppearance.BorderSize = 0;
            btnThemLoaiPhong.FlatStyle = FlatStyle.Flat;
            btnThemLoaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemLoaiPhong.ForeColor = Color.White;
            btnThemLoaiPhong.Location = new Point(0, 0);
            btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            btnThemLoaiPhong.Size = new Size(96, 32);
            btnThemLoaiPhong.TabIndex = 2;
            btnThemLoaiPhong.Text = "Thêm";
            btnThemLoaiPhong.UseVisualStyleBackColor = false;
            btnThemLoaiPhong.Click += btnThemLoaiPhong_Click;
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dgvLoaiPhong);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 164);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 328);
            grbChucVu.TabIndex = 5;
            grbChucVu.TabStop = false;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(8, 32);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.Size = new Size(472, 288);
            dgvLoaiPhong.TabIndex = 0;
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(grbChucVu);
            Name = "frmLoaiPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoaiPhong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTenLoaiPhong.ResumeLayout(false);
            pnlTenLoaiPhong.PerformLayout();
            panel3.ResumeLayout(false);
            pnlSuaLoaiPhong.ResumeLayout(false);
            pnlXoaLoaiPhong.ResumeLayout(false);
            pnlThemLoaiPhong.ResumeLayout(false);
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuanlyLoaiPhong;
        private Panel panel2;
        private Panel pnlTenLoaiPhong;
        private TextBox txbTenLoaiPhong;
        private Label lblTenloaiphong;
        private Panel panel3;
        private Panel pnlSuaLoaiPhong;
        private Button btnSuaLoaiPhong;
        private Panel pnlXoaLoaiPhong;
        private Button btnXoaLoaiPhong;
        private Panel pnlThemLoaiPhong;
        private Button btnThemLoaiPhong;
        private GroupBox grbChucVu;
        private DataGridView dgvLoaiPhong;
    }
}