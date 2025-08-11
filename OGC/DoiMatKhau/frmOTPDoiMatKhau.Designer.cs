namespace OGC.DoiMatKhau
{
    partial class frmOTPDoiMatKhau
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
            lblGuiLaiMaOTP = new Label();
            txbOTP6 = new TextBox();
            txbOTP5 = new TextBox();
            txbOTP4 = new TextBox();
            txbOTP3 = new TextBox();
            txbOTP2 = new TextBox();
            txbOTP1 = new TextBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblGuiLaiMaOTP
            // 
            lblGuiLaiMaOTP.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGuiLaiMaOTP.ForeColor = Color.DodgerBlue;
            lblGuiLaiMaOTP.Location = new Point(8, 72);
            lblGuiLaiMaOTP.Name = "lblGuiLaiMaOTP";
            lblGuiLaiMaOTP.Size = new Size(64, 16);
            lblGuiLaiMaOTP.TabIndex = 15;
            lblGuiLaiMaOTP.Text = "Gửi lại mã";
            lblGuiLaiMaOTP.Click += lblGuiLaiMaOTP_Click;
            // 
            // txbOTP6
            // 
            txbOTP6.Location = new Point(288, 40);
            txbOTP6.Name = "txbOTP6";
            txbOTP6.Size = new Size(48, 23);
            txbOTP6.TabIndex = 14;
            txbOTP6.TextChanged += txbOTP6_TextChanged;
            // 
            // txbOTP5
            // 
            txbOTP5.Location = new Point(232, 40);
            txbOTP5.Name = "txbOTP5";
            txbOTP5.Size = new Size(48, 23);
            txbOTP5.TabIndex = 13;
            txbOTP5.TextChanged += txbOTP5_TextChanged;
            // 
            // txbOTP4
            // 
            txbOTP4.Location = new Point(176, 40);
            txbOTP4.Name = "txbOTP4";
            txbOTP4.Size = new Size(48, 23);
            txbOTP4.TabIndex = 12;
            txbOTP4.TextChanged += txbOTP4_TextChanged;
            // 
            // txbOTP3
            // 
            txbOTP3.Location = new Point(120, 40);
            txbOTP3.Name = "txbOTP3";
            txbOTP3.Size = new Size(48, 23);
            txbOTP3.TabIndex = 11;
            txbOTP3.TextChanged += txbOTP3_TextChanged;
            // 
            // txbOTP2
            // 
            txbOTP2.Location = new Point(64, 40);
            txbOTP2.Name = "txbOTP2";
            txbOTP2.Size = new Size(48, 23);
            txbOTP2.TabIndex = 10;
            txbOTP2.TextChanged += txbOTP2_TextChanged;
            // 
            // txbOTP1
            // 
            txbOTP1.Location = new Point(8, 40);
            txbOTP1.Name = "txbOTP1";
            txbOTP1.Size = new Size(48, 23);
            txbOTP1.TabIndex = 9;
            txbOTP1.TextChanged += txbOTP1_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(8, 8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(328, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Xin chaof";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmOTPDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 96);
            Controls.Add(lblGuiLaiMaOTP);
            Controls.Add(txbOTP6);
            Controls.Add(txbOTP5);
            Controls.Add(txbOTP4);
            Controls.Add(txbOTP3);
            Controls.Add(txbOTP2);
            Controls.Add(txbOTP1);
            Controls.Add(lblEmail);
            Name = "frmOTPDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOTPDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGuiLaiMaOTP;
        private TextBox txbOTP6;
        private TextBox txbOTP5;
        private TextBox txbOTP4;
        private TextBox txbOTP3;
        private TextBox txbOTP2;
        private TextBox txbOTP1;
        private Label lblEmail;
    }
}