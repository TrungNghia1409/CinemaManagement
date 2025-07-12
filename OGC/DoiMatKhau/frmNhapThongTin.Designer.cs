namespace OGC.DoiMatKhau
{
    partial class frmNhapThongTin
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
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            txbHoTen = new TextBox();
            txbSDT = new TextBox();
            txbEmail = new TextBox();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoTen.Location = new Point(8, 16);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSDT.Location = new Point(8, 56);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 23);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "SĐT";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(8, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(120, 16);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(272, 23);
            txbHoTen.TabIndex = 1;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(120, 56);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(272, 23);
            txbSDT.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(120, 96);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(272, 23);
            txbEmail.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(200, 128);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 23);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // frmNhapThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 167);
            Controls.Add(btnXacNhan);
            Controls.Add(txbEmail);
            Controls.Add(txbSDT);
            Controls.Add(txbHoTen);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Name = "frmNhapThongTin";
            Text = "frmNhapThongTin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private TextBox txbHoTen;
        private TextBox txbSDT;
        private TextBox txbEmail;
        private Button btnXacNhan;
    }
}