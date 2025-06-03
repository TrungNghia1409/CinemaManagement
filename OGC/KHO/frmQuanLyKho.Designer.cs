namespace OGC.KHO
{
    partial class frmQuanLyKho
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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            lblTrangThai = new Label();
            btnReset = new Button();
            panel16 = new Panel();
            cbThangCapNhat = new ComboBox();
            cbNamCapNhat = new ComboBox();
            cbNgayCapNhat = new ComboBox();
            lblNgayCapNhat = new Label();
            panel6 = new Panel();
            txbSoLuongThem = new TextBox();
            lblSoLuongThem = new Label();
            panel4 = new Panel();
            txbSoLuong = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txbTenMonAn = new TextBox();
            lblTenMonAn = new Label();
            panel7 = new Panel();
            txbIDMonAn = new TextBox();
            lblIDMonAn = new Label();
            panel3 = new Panel();
            txbIDKho = new TextBox();
            lblIDKho = new Label();
            panel2 = new Panel();
            dgvKho = new DataGridView();
            panel1.SuspendLayout();
            panel16.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(176, 288);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 22);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(8, 320);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 22);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(8, 288);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 22);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTrangThai);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(440, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 357);
            panel1.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(304, 96);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(160, 40);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "label1";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(176, 320);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 22);
            btnReset.TabIndex = 2;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(cbThangCapNhat);
            panel16.Controls.Add(cbNamCapNhat);
            panel16.Controls.Add(cbNgayCapNhat);
            panel16.Controls.Add(lblNgayCapNhat);
            panel16.Location = new Point(3, 233);
            panel16.Name = "panel16";
            panel16.Size = new Size(295, 42);
            panel16.TabIndex = 0;
            // 
            // cbThangCapNhat
            // 
            cbThangCapNhat.FormattingEnabled = true;
            cbThangCapNhat.Location = new Point(168, 8);
            cbThangCapNhat.Name = "cbThangCapNhat";
            cbThangCapNhat.Size = new Size(56, 23);
            cbThangCapNhat.TabIndex = 1;
            cbThangCapNhat.SelectedIndexChanged += cbThangCapNhat_SelectedIndexChanged;
            // 
            // cbNamCapNhat
            // 
            cbNamCapNhat.FormattingEnabled = true;
            cbNamCapNhat.Location = new Point(232, 8);
            cbNamCapNhat.Name = "cbNamCapNhat";
            cbNamCapNhat.Size = new Size(56, 23);
            cbNamCapNhat.TabIndex = 1;
            cbNamCapNhat.SelectedIndexChanged += cbNamCapNhat_SelectedIndexChanged;
            // 
            // cbNgayCapNhat
            // 
            cbNgayCapNhat.FormattingEnabled = true;
            cbNgayCapNhat.Location = new Point(104, 8);
            cbNgayCapNhat.Name = "cbNgayCapNhat";
            cbNgayCapNhat.Size = new Size(56, 23);
            cbNgayCapNhat.TabIndex = 1;
            // 
            // lblNgayCapNhat
            // 
            lblNgayCapNhat.AutoSize = true;
            lblNgayCapNhat.Location = new Point(8, 9);
            lblNgayCapNhat.Name = "lblNgayCapNhat";
            lblNgayCapNhat.Size = new Size(84, 15);
            lblNgayCapNhat.TabIndex = 0;
            lblNgayCapNhat.Text = "Ngày cập nhật";
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSoLuongThem);
            panel6.Controls.Add(lblSoLuongThem);
            panel6.Location = new Point(3, 186);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 42);
            panel6.TabIndex = 0;
            // 
            // txbSoLuongThem
            // 
            txbSoLuongThem.Location = new Point(96, 10);
            txbSoLuongThem.Margin = new Padding(3, 2, 3, 2);
            txbSoLuongThem.Name = "txbSoLuongThem";
            txbSoLuongThem.Size = new Size(195, 23);
            txbSoLuongThem.TabIndex = 1;
            // 
            // lblSoLuongThem
            // 
            lblSoLuongThem.AutoSize = true;
            lblSoLuongThem.Location = new Point(6, 13);
            lblSoLuongThem.Name = "lblSoLuongThem";
            lblSoLuongThem.Size = new Size(85, 15);
            lblSoLuongThem.TabIndex = 0;
            lblSoLuongThem.Text = "Số lượng thêm";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbSoLuong);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 140);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(295, 42);
            panel4.TabIndex = 0;
            // 
            // txbSoLuong
            // 
            txbSoLuong.Location = new Point(96, 10);
            txbSoLuong.Margin = new Padding(3, 2, 3, 2);
            txbSoLuong.Name = "txbSoLuong";
            txbSoLuong.Size = new Size(195, 23);
            txbSoLuong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Số lượng";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbTenMonAn);
            panel5.Controls.Add(lblTenMonAn);
            panel5.Location = new Point(3, 95);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 42);
            panel5.TabIndex = 0;
            // 
            // txbTenMonAn
            // 
            txbTenMonAn.Location = new Point(96, 10);
            txbTenMonAn.Margin = new Padding(3, 2, 3, 2);
            txbTenMonAn.Name = "txbTenMonAn";
            txbTenMonAn.Size = new Size(195, 23);
            txbTenMonAn.TabIndex = 1;
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.Location = new Point(6, 13);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(69, 15);
            lblTenMonAn.TabIndex = 0;
            lblTenMonAn.Text = "Tên món ăn";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbIDMonAn);
            panel7.Controls.Add(lblIDMonAn);
            panel7.Location = new Point(3, 49);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 42);
            panel7.TabIndex = 0;
            // 
            // txbIDMonAn
            // 
            txbIDMonAn.Location = new Point(96, 9);
            txbIDMonAn.Margin = new Padding(3, 2, 3, 2);
            txbIDMonAn.Name = "txbIDMonAn";
            txbIDMonAn.ReadOnly = true;
            txbIDMonAn.Size = new Size(195, 23);
            txbIDMonAn.TabIndex = 1;
            // 
            // lblIDMonAn
            // 
            lblIDMonAn.AutoSize = true;
            lblIDMonAn.Location = new Point(6, 13);
            lblIDMonAn.Name = "lblIDMonAn";
            lblIDMonAn.Size = new Size(68, 15);
            lblIDMonAn.TabIndex = 0;
            lblIDMonAn.Text = "Mã món ăn";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbIDKho);
            panel3.Controls.Add(lblIDKho);
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 42);
            panel3.TabIndex = 0;
            // 
            // txbIDKho
            // 
            txbIDKho.Location = new Point(96, 9);
            txbIDKho.Margin = new Padding(3, 2, 3, 2);
            txbIDKho.Name = "txbIDKho";
            txbIDKho.ReadOnly = true;
            txbIDKho.Size = new Size(195, 23);
            txbIDKho.TabIndex = 1;
            // 
            // lblIDKho
            // 
            lblIDKho.AutoSize = true;
            lblIDKho.Location = new Point(9, 13);
            lblIDKho.Name = "lblIDKho";
            lblIDKho.Size = new Size(47, 15);
            lblIDKho.TabIndex = 0;
            lblIDKho.Text = "Mã kho";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvKho);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 376);
            panel2.TabIndex = 2;
            // 
            // dgvKho
            // 
            dgvKho.BorderStyle = BorderStyle.Fixed3D;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Location = new Point(4, 3);
            dgvKho.Margin = new Padding(3, 2, 3, 2);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersWidth = 51;
            dgvKho.Size = new Size(431, 357);
            dgvKho.TabIndex = 0;
            dgvKho.CellClick += dgvKho_CellClick;
            // 
            // frmQuanLyKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 387);
            Controls.Add(panel2);
            Name = "frmQuanLyKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyKho";
            panel1.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel1;
        private Panel panel16;
        private Panel panel5;
        private ComboBox cbLoaiMonAn;
        private Label lblTenMonAn;
        private Panel panel7;
        private TextBox tbGiaMonAn;
        private Label lblIDMonAn;
        private Panel panel3;
        private TextBox txbIDKho;
        private Label lblIDKho;
        private Panel panel2;
        private DataGridView dgvKho;
        private TextBox txbTenMonAn;
        private ComboBox cbThangCapNhat;
        private ComboBox cbNamCapNhat;
        private ComboBox cbNgayCapNhat;
        private Label lblNgayCapNhat;
        private TextBox txbIDMonAn;
        private Label lblTrangThai;
        private Panel panel4;
        private TextBox txbSoLuong;
        private Label label1;
        private Button btnReset;
        private Panel panel6;
        private TextBox txbSoLuongThem;
        private Label lblSoLuongThem;
    }
}