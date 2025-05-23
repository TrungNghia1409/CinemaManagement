namespace OGC.frmThuocTinh
{
    partial class frmThemChucVu
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
            lblQuanlychucvu = new Label();
            panel2 = new Panel();
            txbTenChucVu = new TextBox();
            lblTenchucvu = new Label();
            panel3 = new Panel();
            pnlSua = new Panel();
            btnSua = new Button();
            pnlXoa = new Panel();
            btnXoa = new Button();
            pnlThem = new Panel();
            btnThem = new Button();
            grbChucVu = new GroupBox();
            dataGridView1 = new DataGridView();
            pnlTenChucVu = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlSua.SuspendLayout();
            pnlXoa.SuspendLayout();
            pnlThem.SuspendLayout();
            grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTenChucVu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblQuanlychucvu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 80);
            panel1.TabIndex = 0;
            // 
            // lblQuanlychucvu
            // 
            lblQuanlychucvu.AutoSize = true;
            lblQuanlychucvu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanlychucvu.ForeColor = Color.White;
            lblQuanlychucvu.Location = new Point(128, 16);
            lblQuanlychucvu.Name = "lblQuanlychucvu";
            lblQuanlychucvu.Size = new Size(219, 37);
            lblQuanlychucvu.TabIndex = 0;
            lblQuanlychucvu.Text = "Quản lý chức vụ";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTenChucVu);
            panel2.Controls.Add(lblTenchucvu);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 80);
            panel2.TabIndex = 0;
            // 
            // txbTenChucVu
            // 
            txbTenChucVu.BorderStyle = BorderStyle.FixedSingle;
            txbTenChucVu.Location = new Point(104, 0);
            txbTenChucVu.Multiline = true;
            txbTenChucVu.Name = "txbTenChucVu";
            txbTenChucVu.Size = new Size(136, 32);
            txbTenChucVu.TabIndex = 1;
            // 
            // lblTenchucvu
            // 
            lblTenchucvu.AutoSize = true;
            lblTenchucvu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenchucvu.Location = new Point(112, 8);
            lblTenchucvu.Name = "lblTenchucvu";
            lblTenchucvu.Size = new Size(90, 21);
            lblTenchucvu.TabIndex = 0;
            lblTenchucvu.Text = "Tên chức vụ";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlSua);
            panel3.Controls.Add(pnlXoa);
            panel3.Controls.Add(pnlThem);
            panel3.Location = new Point(0, 488);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 64);
            panel3.TabIndex = 0;
            // 
            // pnlSua
            // 
            pnlSua.Controls.Add(btnSua);
            pnlSua.Location = new Point(328, 16);
            pnlSua.Name = "pnlSua";
            pnlSua.Size = new Size(96, 32);
            pnlSua.TabIndex = 0;
            pnlSua.Paint += pnlSua_Paint;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // pnlXoa
            // 
            pnlXoa.Controls.Add(btnXoa);
            pnlXoa.Location = new Point(192, 16);
            pnlXoa.Name = "pnlXoa";
            pnlXoa.Size = new Size(96, 32);
            pnlXoa.TabIndex = 0;
            pnlXoa.Paint += pnlXoa_Paint;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(16, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // pnlThem
            // 
            pnlThem.Controls.Add(btnThem);
            pnlThem.Location = new Point(56, 16);
            pnlThem.Name = "pnlThem";
            pnlThem.Size = new Size(96, 32);
            pnlThem.TabIndex = 0;
            pnlThem.Paint += pnlThem_Paint;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(8, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // grbChucVu
            // 
            grbChucVu.Controls.Add(dataGridView1);
            grbChucVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChucVu.Location = new Point(0, 160);
            grbChucVu.Name = "grbChucVu";
            grbChucVu.Size = new Size(480, 328);
            grbChucVu.TabIndex = 1;
            grbChucVu.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(472, 288);
            dataGridView1.TabIndex = 0;
            // 
            // pnlTenChucVu
            // 
            pnlTenChucVu.Controls.Add(txbTenChucVu);
            pnlTenChucVu.Location = new Point(104, 32);
            pnlTenChucVu.Name = "pnlTenChucVu";
            pnlTenChucVu.Size = new Size(272, 40);
            pnlTenChucVu.TabIndex = 2;
            pnlTenChucVu.Paint += pnlTenChucVu_Paint;
            // 
            // frmThemChucVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(grbChucVu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmThemChucVu";
            Text = "frmThemChucVu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            pnlSua.ResumeLayout(false);
            pnlXoa.ResumeLayout(false);
            pnlThem.ResumeLayout(false);
            grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTenChucVu.ResumeLayout(false);
            pnlTenChucVu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox grbChucVu;
        private Label lblQuanlychucvu;
        private Label lblTenchucvu;
        private TextBox txbTenChucVu;
        private DataGridView dataGridView1;
        private Panel pnlSua;
        private Panel pnlXoa;
        private Panel pnlThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel pnlTenChucVu;
    }
}