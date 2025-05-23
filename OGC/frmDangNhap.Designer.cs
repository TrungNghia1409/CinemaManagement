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
            panel2 = new Panel();
            panel3 = new Panel();
            pnlTaiKhoan = new Panel();
            pnlMatKhau = new Panel();
            btnDangNhap = new Button();
            ptbDangNhap = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblMember = new Label();
            txbTaiKhoan = new TextBox();
            txbMatKhau = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTaiKhoan.SuspendLayout();
            pnlMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDangNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMember);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 64);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ptbDangNhap);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 200);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(240, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 200);
            panel3.TabIndex = 0;
            // 
            // pnlTaiKhoan
            // 
            pnlTaiKhoan.Controls.Add(txbTaiKhoan);
            pnlTaiKhoan.Location = new Point(296, 88);
            pnlTaiKhoan.Name = "pnlTaiKhoan";
            pnlTaiKhoan.Size = new Size(272, 40);
            pnlTaiKhoan.TabIndex = 1;
            // 
            // pnlMatKhau
            // 
            pnlMatKhau.Controls.Add(txbMatKhau);
            pnlMatKhau.Location = new Point(296, 160);
            pnlMatKhau.Name = "pnlMatKhau";
            pnlMatKhau.Size = new Size(272, 40);
            pnlMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(392, 224);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Login";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // ptbDangNhap
            // 
            ptbDangNhap.Location = new Point(32, 8);
            ptbDangNhap.Name = "ptbDangNhap";
            ptbDangNhap.Size = new Size(176, 136);
            ptbDangNhap.TabIndex = 1;
            ptbDangNhap.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(248, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(248, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMember.Location = new Point(352, 24);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(166, 30);
            lblMember.TabIndex = 0;
            lblMember.Text = "Members Login";
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.BorderStyle = BorderStyle.None;
            txbTaiKhoan.Location = new Point(160, 8);
            txbTaiKhoan.Multiline = true;
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(100, 23);
            txbTaiKhoan.TabIndex = 0;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(160, 8);
            txbMatKhau.Multiline = true;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(100, 23);
            txbMatKhau.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangNhap);
            Controls.Add(panel2);
            Controls.Add(pnlMatKhau);
            Controls.Add(pnlTaiKhoan);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlTaiKhoan.ResumeLayout(false);
            pnlTaiKhoan.PerformLayout();
            pnlMatKhau.ResumeLayout(false);
            pnlMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDangNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox ptbDangNhap;
        private Panel pnlTaiKhoan;
        private Panel pnlMatKhau;
        private Button btnDangNhap;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblMember;
        private TextBox txbTaiKhoan;
        private TextBox txbMatKhau;
    }
}