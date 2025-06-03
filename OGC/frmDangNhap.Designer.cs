namespace OGC
{
    partial class frmDangNhap
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
            lblMember = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ptbDangNhap = new PictureBox();
            panel3 = new Panel();
            pnlDangNhap_Phai = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDangNhap = new Button();
            pnlMatKhau = new Panel();
            txbMatKhau = new TextBox();
            pnlTaiKhoan = new Panel();
            txbTaiKhoan = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDangNhap).BeginInit();
            pnlDangNhap_Phai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMatKhau.SuspendLayout();
            pnlTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMember);
            panel1.Location = new Point(248, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 64);
            panel1.TabIndex = 0;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMember.Location = new Point(104, 16);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(166, 30);
            lblMember.TabIndex = 4;
            lblMember.Text = "Members Login";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ptbDangNhap);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 264);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 224);
            label1.Name = "label1";
            label1.Size = new Size(239, 15);
            label1.TabIndex = 5;
            label1.Text = "⦿ 2025 OGC Cinema | Designe by Double2N";
            // 
            // ptbDangNhap
            // 
            ptbDangNhap.Image = Properties.Resources.staff_training;
            ptbDangNhap.Location = new Point(16, 8);
            ptbDangNhap.Name = "ptbDangNhap";
            ptbDangNhap.Size = new Size(216, 200);
            ptbDangNhap.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbDangNhap.TabIndex = 1;
            ptbDangNhap.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(312, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 200);
            panel3.TabIndex = 0;
            // 
            // pnlDangNhap_Phai
            // 
            pnlDangNhap_Phai.Controls.Add(pictureBox2);
            pnlDangNhap_Phai.Controls.Add(pictureBox1);
            pnlDangNhap_Phai.Controls.Add(btnDangNhap);
            pnlDangNhap_Phai.Controls.Add(pnlMatKhau);
            pnlDangNhap_Phai.Controls.Add(pnlTaiKhoan);
            pnlDangNhap_Phai.Location = new Point(248, 64);
            pnlDangNhap_Phai.Name = "pnlDangNhap_Phai";
            pnlDangNhap_Phai.Size = new Size(336, 200);
            pnlDangNhap_Phai.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(4, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.username;
            pictureBox1.Location = new Point(4, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(144, 144);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(92, 35);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Login";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            btnDangNhap.Paint += btnDangNhap_Paint;
            // 
            // pnlMatKhau
            // 
            pnlMatKhau.Controls.Add(txbMatKhau);
            pnlMatKhau.Location = new Point(52, 93);
            pnlMatKhau.Name = "pnlMatKhau";
            pnlMatKhau.Size = new Size(272, 40);
            pnlMatKhau.TabIndex = 4;
            pnlMatKhau.Paint += pnlMatKhau_Paint;
            // 
            // txbMatKhau
            // 
            txbMatKhau.BorderStyle = BorderStyle.None;
            txbMatKhau.Dock = DockStyle.Fill;
            txbMatKhau.Font = new Font("Segoe UI", 14.25F);
            txbMatKhau.Location = new Point(0, 0);
            txbMatKhau.Multiline = true;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(272, 40);
            txbMatKhau.TabIndex = 2;
            txbMatKhau.Enter += txbMatKhau_Enter;
            txbMatKhau.Leave += txbMatKhau_Leave;
            // 
            // pnlTaiKhoan
            // 
            pnlTaiKhoan.Controls.Add(txbTaiKhoan);
            pnlTaiKhoan.Location = new Point(52, 21);
            pnlTaiKhoan.Name = "pnlTaiKhoan";
            pnlTaiKhoan.Size = new Size(272, 40);
            pnlTaiKhoan.TabIndex = 5;
            pnlTaiKhoan.Paint += pnlTaiKhoan_Paint;
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.BackColor = Color.White;
            txbTaiKhoan.BorderStyle = BorderStyle.None;
            txbTaiKhoan.Dock = DockStyle.Fill;
            txbTaiKhoan.Font = new Font("Segoe UI", 14.25F);
            txbTaiKhoan.Location = new Point(0, 0);
            txbTaiKhoan.Multiline = true;
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(272, 40);
            txbTaiKhoan.TabIndex = 1;
            txbTaiKhoan.Enter += txbTaiKhoan_Enter;
            txbTaiKhoan.Leave += txbTaiKhoan_Leave;
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(pnlDangNhap_Phai);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDangNhap).EndInit();
            pnlDangNhap_Phai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMatKhau.ResumeLayout(false);
            pnlMatKhau.PerformLayout();
            pnlTaiKhoan.ResumeLayout(false);
            pnlTaiKhoan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox ptbDangNhap;
        private Label lblMember;
        private Label label1;
        private Panel pnlDangNhap_Phai;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnDangNhap;
        private Panel pnlMatKhau;
        private TextBox txbMatKhau;
        private Panel pnlTaiKhoan;
        private TextBox txbTaiKhoan;
    }
}