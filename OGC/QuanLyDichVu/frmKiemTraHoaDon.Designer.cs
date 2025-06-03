namespace OGC.QuanLyDichVu
{
    partial class frmKiemTraHoaDon
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ptbCamera = new PictureBox();
            txbID = new TextBox();
            cbCamera = new ComboBox();
            btnBatDau = new Button();
            btnKetThuc = new Button();
            btnKiemTra = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbCamera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 16);
            label1.Name = "label1";
            label1.Size = new Size(368, 40);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra hóa đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(96, 448);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 0;
            label2.Text = "Mã đọc được";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 80);
            label3.Name = "label3";
            label3.Size = new Size(208, 32);
            label3.TabIndex = 0;
            label3.Text = "Lựa chọn camera đầu vào";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(136, 128);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(536, 296);
            ptbCamera.TabIndex = 1;
            ptbCamera.TabStop = false;
            // 
            // txbID
            // 
            txbID.Location = new Point(224, 456);
            txbID.Name = "txbID";
            txbID.Size = new Size(448, 23);
            txbID.TabIndex = 2;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(224, 88);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(448, 23);
            cbCamera.TabIndex = 3;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(24, 208);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(88, 48);
            btnBatDau.TabIndex = 4;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(24, 288);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(88, 48);
            btnKetThuc.TabIndex = 4;
            btnKetThuc.Text = "Dừng";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(416, 488);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(88, 24);
            btnKiemTra.TabIndex = 5;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // frmKiemTraHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 522);
            Controls.Add(btnKiemTra);
            Controls.Add(btnKetThuc);
            Controls.Add(btnBatDau);
            Controls.Add(cbCamera);
            Controls.Add(txbID);
            Controls.Add(ptbCamera);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmKiemTraHoaDon";
            Text = "frmKiemTraHoaDon";
            FormClosing += frmKiemTraHoaDon_FormClosing;
            Load += frmKiemTraHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)ptbCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox ptbCamera;
        private TextBox txbID;
        private ComboBox cbCamera;
        private Button btnBatDau;
        private Button btnKetThuc;
        private Button btnKiemTra;
    }
}