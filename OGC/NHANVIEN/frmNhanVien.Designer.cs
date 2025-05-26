namespace OGC.NHANVIEN
{
    partial class frmNhanVien
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
            pnlTren = new Panel();
            cbChucVu = new ComboBox();
            lblUserLogin = new Label();
            btnReset = new Button();
            lblBackHome = new Label();
            txbTimKiem = new TextBox();
            pnlDuoi = new Panel();
            flpTieuDeNhanVien = new FlowLayoutPanel();
            flpNhanVien = new FlowLayoutPanel();
            pnlTren.SuspendLayout();
            pnlDuoi.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTren
            // 
            pnlTren.Controls.Add(cbChucVu);
            pnlTren.Controls.Add(lblUserLogin);
            pnlTren.Controls.Add(btnReset);
            pnlTren.Controls.Add(lblBackHome);
            pnlTren.Controls.Add(txbTimKiem);
            pnlTren.Dock = DockStyle.Top;
            pnlTren.Location = new Point(0, 0);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(1784, 80);
            pnlTren.TabIndex = 0;
            // 
            // cbChucVu
            // 
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(600, 32);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(136, 23);
            cbChucVu.TabIndex = 4;
            cbChucVu.SelectedIndexChanged += cbChucVu_SelectedIndexChanged;
            // 
            // lblUserLogin
            // 
            lblUserLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserLogin.Location = new Point(1576, 24);
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(204, 40);
            lblUserLogin.TabIndex = 3;
            lblUserLogin.Text = "lbl";
            lblUserLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(480, 24);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 40);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblBackHome
            // 
            lblBackHome.AutoSize = true;
            lblBackHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBackHome.Location = new Point(40, 32);
            lblBackHome.Name = "lblBackHome";
            lblBackHome.Size = new Size(70, 21);
            lblBackHome.TabIndex = 1;
            lblBackHome.Text = "⟲ Home";
            lblBackHome.Click += lblBackHome_Click;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTimKiem.Location = new Point(128, 24);
            txbTimKiem.Multiline = true;
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(336, 40);
            txbTimKiem.TabIndex = 0;
            txbTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // pnlDuoi
            // 
            pnlDuoi.Controls.Add(flpTieuDeNhanVien);
            pnlDuoi.Controls.Add(flpNhanVien);
            pnlDuoi.Dock = DockStyle.Bottom;
            pnlDuoi.Location = new Point(0, 81);
            pnlDuoi.Name = "pnlDuoi";
            pnlDuoi.Size = new Size(1784, 680);
            pnlDuoi.TabIndex = 1;
            // 
            // flpTieuDeNhanVien
            // 
            flpTieuDeNhanVien.Location = new Point(8, 8);
            flpTieuDeNhanVien.Name = "flpTieuDeNhanVien";
            flpTieuDeNhanVien.Size = new Size(1768, 48);
            flpTieuDeNhanVien.TabIndex = 1;
            // 
            // flpNhanVien
            // 
            flpNhanVien.Location = new Point(8, 64);
            flpNhanVien.Name = "flpNhanVien";
            flpNhanVien.Size = new Size(1768, 608);
            flpNhanVien.TabIndex = 0;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 761);
            Controls.Add(pnlDuoi);
            Controls.Add(pnlTren);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            pnlTren.ResumeLayout(false);
            pnlTren.PerformLayout();
            pnlDuoi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTren;
        private Panel pnlDuoi;
        private FlowLayoutPanel flpNhanVien;
        private FlowLayoutPanel flpTieuDeNhanVien;
        private Label lblBackHome;
        private TextBox txbTimKiem;
        private Button btnReset;
        private Label lblUserLogin;
        private ComboBox cbChucVu;
    }
}