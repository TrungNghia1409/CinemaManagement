namespace OGC.Phim
{
    partial class FrmPhuongThucThanhToanVe
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
            btnChuyenKhoan = new Button();
            btnTienMat = new Button();
            lblPTTT = new Label();
            SuspendLayout();
            // 
            // btnChuyenKhoan
            // 
            btnChuyenKhoan.Location = new Point(166, 139);
            btnChuyenKhoan.Margin = new Padding(3, 4, 3, 4);
            btnChuyenKhoan.Name = "btnChuyenKhoan";
            btnChuyenKhoan.Size = new Size(137, 64);
            btnChuyenKhoan.TabIndex = 4;
            btnChuyenKhoan.Text = "Chuyển khoản";
            btnChuyenKhoan.UseVisualStyleBackColor = true;
            btnChuyenKhoan.Click += btnChuyenKhoan_Click;
            // 
            // btnTienMat
            // 
            btnTienMat.Location = new Point(10, 139);
            btnTienMat.Margin = new Padding(3, 4, 3, 4);
            btnTienMat.Name = "btnTienMat";
            btnTienMat.Size = new Size(137, 64);
            btnTienMat.TabIndex = 3;
            btnTienMat.Text = "Tiền mặt";
            btnTienMat.UseVisualStyleBackColor = true;
            btnTienMat.Click += btnTienMat_Click;
            // 
            // lblPTTT
            // 
            lblPTTT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPTTT.Location = new Point(38, 11);
            lblPTTT.Name = "lblPTTT";
            lblPTTT.Size = new Size(247, 107);
            lblPTTT.TabIndex = 2;
            lblPTTT.Text = "Hãy chọn 1 phương thức thanh toán";
            lblPTTT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPhuongThucThanhToanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 215);
            Controls.Add(btnChuyenKhoan);
            Controls.Add(btnTienMat);
            Controls.Add(lblPTTT);
            Name = "FrmPhuongThucThanhToanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPhuongThucThanhToanVe";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChuyenKhoan;
        private Button btnTienMat;
        private Label lblPTTT;
    }
}