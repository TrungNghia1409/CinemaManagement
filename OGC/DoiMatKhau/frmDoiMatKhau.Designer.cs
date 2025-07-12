namespace OGC.DoiMatKhau
{
    partial class frmDoiMatKhau
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
            btnXacNhan = new Button();
            chbHien_XacNhanMKMoi = new CheckBox();
            chbHien_MKMoi = new CheckBox();
            txbXacNhanMatKhauMoi = new TextBox();
            txbMatKhauMoi = new TextBox();
            lblXacNhanMatKhau = new Label();
            lblMatKhauMoi = new Label();
            lblSoSanh = new Label();
            SuspendLayout();
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(280, 112);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 23);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // chbHien_XacNhanMKMoi
            // 
            chbHien_XacNhanMKMoi.AutoSize = true;
            chbHien_XacNhanMKMoi.Location = new Point(480, 84);
            chbHien_XacNhanMKMoi.Name = "chbHien_XacNhanMKMoi";
            chbHien_XacNhanMKMoi.Size = new Size(104, 19);
            chbHien_XacNhanMKMoi.TabIndex = 8;
            chbHien_XacNhanMKMoi.Text = "Hiện mật khẩu";
            chbHien_XacNhanMKMoi.UseVisualStyleBackColor = true;
            chbHien_XacNhanMKMoi.CheckedChanged += chbHien_XacNhanMKMoi_CheckedChanged;
            // 
            // chbHien_MKMoi
            // 
            chbHien_MKMoi.AutoSize = true;
            chbHien_MKMoi.Location = new Point(480, 44);
            chbHien_MKMoi.Name = "chbHien_MKMoi";
            chbHien_MKMoi.Size = new Size(104, 19);
            chbHien_MKMoi.TabIndex = 9;
            chbHien_MKMoi.Text = "Hiện mật khẩu";
            chbHien_MKMoi.UseVisualStyleBackColor = true;
            chbHien_MKMoi.CheckedChanged += chbHien_MKMoi_CheckedChanged;
            // 
            // txbXacNhanMatKhauMoi
            // 
            txbXacNhanMatKhauMoi.Location = new Point(200, 80);
            txbXacNhanMatKhauMoi.Name = "txbXacNhanMatKhauMoi";
            txbXacNhanMatKhauMoi.Size = new Size(272, 23);
            txbXacNhanMatKhauMoi.TabIndex = 6;
            txbXacNhanMatKhauMoi.TextChanged += txbXacNhanMatKhauMoi_TextChanged;
            // 
            // txbMatKhauMoi
            // 
            txbMatKhauMoi.Location = new Point(200, 40);
            txbMatKhauMoi.Name = "txbMatKhauMoi";
            txbMatKhauMoi.Size = new Size(272, 23);
            txbMatKhauMoi.TabIndex = 7;
            txbMatKhauMoi.TextChanged += txbMatKhauMoi_TextChanged;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(16, 80);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(168, 23);
            lblXacNhanMatKhau.TabIndex = 4;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            lblXacNhanMatKhau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhauMoi.Location = new Point(16, 40);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(168, 23);
            lblMatKhauMoi.TabIndex = 5;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            lblMatKhauMoi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSoSanh
            // 
            lblSoSanh.Location = new Point(200, 8);
            lblSoSanh.Name = "lblSoSanh";
            lblSoSanh.Size = new Size(272, 20);
            lblSoSanh.TabIndex = 11;
            lblSoSanh.Text = "label1";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 154);
            Controls.Add(lblSoSanh);
            Controls.Add(btnXacNhan);
            Controls.Add(chbHien_XacNhanMKMoi);
            Controls.Add(chbHien_MKMoi);
            Controls.Add(txbXacNhanMatKhauMoi);
            Controls.Add(txbMatKhauMoi);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(lblMatKhauMoi);
            Name = "frmDoiMatKhau";
            Text = "frmDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXacNhan;
        private CheckBox chbHien_XacNhanMKMoi;
        private CheckBox chbHien_MKMoi;
        private TextBox txbXacNhanMatKhauMoi;
        private TextBox txbMatKhauMoi;
        private Label lblXacNhanMatKhau;
        private Label lblMatKhauMoi;
        private Label lblSoSanh;
    }
}