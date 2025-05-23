namespace OGC.ThuocTinh
{
    partial class frmQuanLyLoaiMonAn
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
            grbChucVu = new GroupBox();
            dgvLoaiMonAn = new DataGridView();
            panel3 = new Panel();
            pnlSua = new Panel();
            btnSua_LoaiMonAn = new Button();
            pnlXoa = new Panel();
            btnXoa_LoaiMonAn = new Button();
            pnlThem = new Panel();
            btnThem_loaimonan = new Button();
            panel2 = new Panel();
            pnlTenLoaiMonAn = new Panel();
            txbTenLoaiMonAn = new TextBox();
            lblTenloaimonan = new Label();
            panel1 = new Panel();
            lblQuanlyloaimonan = new Label();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiMonAn).BeginInit();
            panel3.SuspendLayout();
            pnlSua.SuspendLayout();
            pnlXoa.SuspendLayout();
            pnlThem.SuspendLayout();
            panel2.SuspendLayout();
            pnlTenLoaiMonAn.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dgvLoaiMonAn);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 164);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 328);
            grbChucVu.TabIndex = 5;
            grbChucVu.TabStop = false;
            // 
            // dgvLoaiMonAn
            // 
            dgvLoaiMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiMonAn.Location = new Point(8, 32);
            dgvLoaiMonAn.Name = "dgvLoaiMonAn";
            dgvLoaiMonAn.Size = new Size(472, 288);
            dgvLoaiMonAn.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSua);
            panel3.Controls.Add(pnlXoa);
            panel3.Controls.Add(pnlThem);
            panel3.Location = new Point(0, 492);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 2;
            // 
            // pnlSua
            // 
            pnlSua.Controls.Add(btnSua_LoaiMonAn);
            pnlSua.Location = new Point(328, 16);
            pnlSua.Name = "pnlSua";
            pnlSua.Size = new Size(96, 32);
            pnlSua.TabIndex = 0;
            pnlSua.Paint += pnlSua_Paint;
            // 
            // btnSua_LoaiMonAn
            // 
            btnSua_LoaiMonAn.BackColor = SystemColors.ActiveCaption;
            btnSua_LoaiMonAn.Dock = DockStyle.Fill;
            btnSua_LoaiMonAn.FlatAppearance.BorderSize = 0;
            btnSua_LoaiMonAn.FlatStyle = FlatStyle.Flat;
            btnSua_LoaiMonAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua_LoaiMonAn.ForeColor = Color.White;
            btnSua_LoaiMonAn.Location = new Point(0, 0);
            btnSua_LoaiMonAn.Name = "btnSua_LoaiMonAn";
            btnSua_LoaiMonAn.Size = new Size(96, 32);
            btnSua_LoaiMonAn.TabIndex = 0;
            btnSua_LoaiMonAn.Text = "Sửa";
            btnSua_LoaiMonAn.UseVisualStyleBackColor = false;
            btnSua_LoaiMonAn.Click += btnSua_LoaiMonAn_Click;
            // 
            // pnlXoa
            // 
            pnlXoa.Controls.Add(btnXoa_LoaiMonAn);
            pnlXoa.Location = new Point(192, 16);
            pnlXoa.Name = "pnlXoa";
            pnlXoa.Size = new Size(96, 32);
            pnlXoa.TabIndex = 0;
            pnlXoa.Paint += pnlXoa_Paint;
            // 
            // btnXoa_LoaiMonAn
            // 
            btnXoa_LoaiMonAn.BackColor = Color.IndianRed;
            btnXoa_LoaiMonAn.Dock = DockStyle.Fill;
            btnXoa_LoaiMonAn.FlatAppearance.BorderSize = 0;
            btnXoa_LoaiMonAn.FlatStyle = FlatStyle.Flat;
            btnXoa_LoaiMonAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa_LoaiMonAn.ForeColor = Color.White;
            btnXoa_LoaiMonAn.Location = new Point(0, 0);
            btnXoa_LoaiMonAn.Name = "btnXoa_LoaiMonAn";
            btnXoa_LoaiMonAn.Size = new Size(96, 32);
            btnXoa_LoaiMonAn.TabIndex = 0;
            btnXoa_LoaiMonAn.Text = "Xóa";
            btnXoa_LoaiMonAn.UseVisualStyleBackColor = false;
            btnXoa_LoaiMonAn.Click += btnXoa_LoaiMonAn_Click;
            // 
            // pnlThem
            // 
            pnlThem.Controls.Add(btnThem_loaimonan);
            pnlThem.Location = new Point(56, 16);
            pnlThem.Name = "pnlThem";
            pnlThem.Size = new Size(96, 32);
            pnlThem.TabIndex = 0;
            pnlThem.Paint += pnlThem_Paint;
            // 
            // btnThem_loaimonan
            // 
            btnThem_loaimonan.BackColor = Color.MediumAquamarine;
            btnThem_loaimonan.Dock = DockStyle.Fill;
            btnThem_loaimonan.FlatAppearance.BorderSize = 0;
            btnThem_loaimonan.FlatStyle = FlatStyle.Flat;
            btnThem_loaimonan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem_loaimonan.ForeColor = Color.White;
            btnThem_loaimonan.Location = new Point(0, 0);
            btnThem_loaimonan.Name = "btnThem_loaimonan";
            btnThem_loaimonan.Size = new Size(96, 32);
            btnThem_loaimonan.TabIndex = 0;
            btnThem_loaimonan.Text = "Thêm";
            btnThem_loaimonan.UseVisualStyleBackColor = false;
            btnThem_loaimonan.Click += btnThem_loaimonan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTenLoaiMonAn);
            panel2.Controls.Add(lblTenloaimonan);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 80);
            panel2.TabIndex = 3;
            // 
            // pnlTenLoaiMonAn
            // 
            pnlTenLoaiMonAn.Controls.Add(txbTenLoaiMonAn);
            pnlTenLoaiMonAn.Location = new Point(104, 32);
            pnlTenLoaiMonAn.Name = "pnlTenLoaiMonAn";
            pnlTenLoaiMonAn.Size = new Size(272, 40);
            pnlTenLoaiMonAn.TabIndex = 2;
            pnlTenLoaiMonAn.Paint += pnlTenLoaiMonAn_Paint;
            // 
            // txbTenLoaiMonAn
            // 
            txbTenLoaiMonAn.BorderStyle = BorderStyle.None;
            txbTenLoaiMonAn.Dock = DockStyle.Fill;
            txbTenLoaiMonAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenLoaiMonAn.Location = new Point(0, 0);
            txbTenLoaiMonAn.Multiline = true;
            txbTenLoaiMonAn.Name = "txbTenLoaiMonAn";
            txbTenLoaiMonAn.Size = new Size(272, 40);
            txbTenLoaiMonAn.TabIndex = 1;
            // 
            // lblTenloaimonan
            // 
            lblTenloaimonan.AutoSize = true;
            lblTenloaimonan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenloaimonan.Location = new Point(112, 8);
            lblTenloaimonan.Name = "lblTenloaimonan";
            lblTenloaimonan.Size = new Size(62, 21);
            lblTenloaimonan.TabIndex = 0;
            lblTenloaimonan.Text = "Tên loại";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlyloaimonan);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 4;
            // 
            // lblQuanlyloaimonan
            // 
            lblQuanlyloaimonan.AutoSize = true;
            lblQuanlyloaimonan.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlyloaimonan.ForeColor = Color.White;
            lblQuanlyloaimonan.Location = new Point(96, 16);
            lblQuanlyloaimonan.Name = "lblQuanlyloaimonan";
            lblQuanlyloaimonan.Size = new Size(272, 37);
            lblQuanlyloaimonan.TabIndex = 0;
            lblQuanlyloaimonan.Text = "Quản lý loại món ăn";
            // 
            // frmQuanLyLoaiMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(grbChucVu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmQuanLyLoaiMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyLoaiMonAn";
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiMonAn).EndInit();
            panel3.ResumeLayout(false);
            pnlSua.ResumeLayout(false);
            pnlXoa.ResumeLayout(false);
            pnlThem.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTenLoaiMonAn.ResumeLayout(false);
            pnlTenLoaiMonAn.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbChucVu;
        private DataGridView dgvLoaiMonAn;
        private Panel panel3;
        private Panel pnlSua;
        private Button btnSua_LoaiMonAn;
        private Panel pnlXoa;
        private Button btnXoa_LoaiMonAn;
        private Panel pnlThem;
        private Button btnThem_loaimonan;
        private Panel panel2;
        private Panel pnlTenLoaiMonAn;
        private TextBox txbTenLoaiMonAn;
        private Label lblTenloaimonan;
        private Panel panel1;
        private Label lblQuanlyloaimonan;
    }
}