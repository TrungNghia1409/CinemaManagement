namespace OGC.QuanLyDichVu
{
    partial class ServiceItemUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            ptbGioHang = new PictureBox();
            lblGia = new Label();
            lblTen = new Label();
            ptbAnh = new PictureBox();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.WhiteSmoke;
            pnlContainer.Controls.Add(ptbGioHang);
            pnlContainer.Controls.Add(lblGia);
            pnlContainer.Controls.Add(lblTen);
            pnlContainer.Controls.Add(ptbAnh);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(5);
            pnlContainer.Size = new Size(184, 288);
            pnlContainer.TabIndex = 0;
            // 
            // ptbGioHang
            // 
            ptbGioHang.Image = Properties.Resources.giohang;
            ptbGioHang.Location = new Point(56, 248);
            ptbGioHang.Name = "ptbGioHang";
            ptbGioHang.Size = new Size(72, 32);
            ptbGioHang.SizeMode = PictureBoxSizeMode.Zoom;
            ptbGioHang.TabIndex = 3;
            ptbGioHang.TabStop = false;
            ptbGioHang.Click += ptbGioHang_Click;
            // 
            // lblGia
            // 
            lblGia.Font = new Font("Segoe UI", 12F);
            lblGia.Location = new Point(24, 216);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(136, 25);
            lblGia.TabIndex = 2;
            lblGia.Text = "label1";
            lblGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 12F);
            lblTen.Location = new Point(24, 184);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(136, 25);
            lblTen.TabIndex = 2;
            lblTen.Text = "label1";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(24, 16);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(139, 160);
            ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAnh.TabIndex = 0;
            ptbAnh.TabStop = false;
            // 
            // ServiceItemUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "ServiceItemUC";
            Size = new Size(184, 291);
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblGia;
        private Label lblTen;
        private PictureBox ptbAnh;
        private PictureBox ptbGioHang;
    }
}
