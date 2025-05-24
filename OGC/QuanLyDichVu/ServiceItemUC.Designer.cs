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
            lblGia_Tittle = new Label();
            lblTen_Tittle = new Label();
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
            pnlContainer.Controls.Add(lblGia_Tittle);
            pnlContainer.Controls.Add(lblTen_Tittle);
            pnlContainer.Controls.Add(ptbAnh);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(5);
            pnlContainer.Size = new Size(201, 300);
            pnlContainer.TabIndex = 0;
            // 
            // ptbGioHang
            // 
            ptbGioHang.Location = new Point(88, 248);
            ptbGioHang.Name = "ptbGioHang";
            ptbGioHang.Size = new Size(56, 32);
            ptbGioHang.TabIndex = 3;
            ptbGioHang.TabStop = false;
            // 
            // lblGia
            // 
            lblGia.Font = new Font("Segoe UI", 12F);
            lblGia.Location = new Point(56, 208);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(136, 25);
            lblGia.TabIndex = 2;
            lblGia.Text = "label1";
            lblGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 12F);
            lblTen.Location = new Point(56, 176);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(136, 25);
            lblTen.TabIndex = 2;
            lblTen.Text = "label1";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGia_Tittle
            // 
            lblGia_Tittle.AutoSize = true;
            lblGia_Tittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGia_Tittle.Location = new Point(8, 208);
            lblGia_Tittle.Name = "lblGia_Tittle";
            lblGia_Tittle.Size = new Size(35, 21);
            lblGia_Tittle.TabIndex = 1;
            lblGia_Tittle.Text = "Giá";
            // 
            // lblTen_Tittle
            // 
            lblTen_Tittle.AutoSize = true;
            lblTen_Tittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTen_Tittle.Location = new Point(8, 176);
            lblTen_Tittle.Name = "lblTen_Tittle";
            lblTen_Tittle.Size = new Size(37, 21);
            lblTen_Tittle.TabIndex = 1;
            lblTen_Tittle.Text = "Tên";
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(48, 8);
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
            Size = new Size(201, 300);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblGia;
        private Label lblTen;
        private Label lblGia_Tittle;
        private Label lblTen_Tittle;
        private PictureBox ptbAnh;
        private PictureBox ptbGioHang;
    }
}
