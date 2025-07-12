namespace OGC.QuanLyDichVu
{
    partial class frmPhuongThucThanhToan
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
            lblPTTT = new Label();
            btnTienMat = new Button();
            btnChuyenKhoan = new Button();
            SuspendLayout();
            // 
            // lblPTTT
            // 
            lblPTTT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPTTT.Location = new Point(32, 8);
            lblPTTT.Name = "lblPTTT";
            lblPTTT.Size = new Size(216, 80);
            lblPTTT.TabIndex = 0;
            lblPTTT.Text = "Hãy chọn 1 phương thức thanh toán";
            lblPTTT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTienMat
            // 
            btnTienMat.Location = new Point(8, 104);
            btnTienMat.Name = "btnTienMat";
            btnTienMat.Size = new Size(120, 48);
            btnTienMat.TabIndex = 1;
            btnTienMat.Text = "Tiền mặt";
            btnTienMat.UseVisualStyleBackColor = true;
            btnTienMat.Click += btnTienMat_Click;
            // 
            // btnChuyenKhoan
            // 
            btnChuyenKhoan.Location = new Point(144, 104);
            btnChuyenKhoan.Name = "btnChuyenKhoan";
            btnChuyenKhoan.Size = new Size(120, 48);
            btnChuyenKhoan.TabIndex = 1;
            btnChuyenKhoan.Text = "Chuyển khoản";
            btnChuyenKhoan.UseVisualStyleBackColor = true;
            btnChuyenKhoan.Click += btnChuyenKhoan_Click;
            // 
            // frmPhuongThucThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 161);
            Controls.Add(btnChuyenKhoan);
            Controls.Add(btnTienMat);
            Controls.Add(lblPTTT);
            Name = "frmPhuongThucThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPhuongThucThanhToan";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPTTT;
        private Button btnTienMat;
        private Button btnChuyenKhoan;
    }
}