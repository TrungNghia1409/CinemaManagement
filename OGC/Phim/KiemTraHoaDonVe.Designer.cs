namespace OGC.Phim
{
    partial class KiemTraHoaDonVe
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
            btnKiemTra = new Button();
            btnKetThuc = new Button();
            btnBatDau = new Button();
            cbCamera = new ComboBox();
            txbID = new TextBox();
            ptbCamera = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbCamera).BeginInit();
            SuspendLayout();
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(416, 485);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(88, 24);
            btnKiemTra.TabIndex = 14;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(24, 285);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(88, 48);
            btnKetThuc.TabIndex = 12;
            btnKetThuc.Text = "Dừng";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(24, 205);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(88, 48);
            btnBatDau.TabIndex = 13;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(224, 85);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(448, 23);
            cbCamera.TabIndex = 11;
            // 
            // txbID
            // 
            txbID.Location = new Point(224, 453);
            txbID.Name = "txbID";
            txbID.Size = new Size(448, 23);
            txbID.TabIndex = 10;
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(136, 125);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(536, 296);
            ptbCamera.TabIndex = 9;
            ptbCamera.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(96, 445);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 6;
            label2.Text = "Mã đọc được";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 77);
            label3.Name = "label3";
            label3.Size = new Size(208, 32);
            label3.TabIndex = 7;
            label3.Text = "Lựa chọn camera đầu vào";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 13);
            label1.Name = "label1";
            label1.Size = new Size(368, 40);
            label1.TabIndex = 8;
            label1.Text = "Kiểm tra hóa đơn vé";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KiemTraHoaDonVe
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "KiemTraHoaDonVe";
            Text = "KiemTraHoaDonVe";
            FormClosing += KiemTraHoaDonVe_FormClosing;
            Load += KiemTraHoaDonVe_Load;
            ((System.ComponentModel.ISupportInitialize)ptbCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKiemTra;
        private Button btnKetThuc;
        private Button btnBatDau;
        private ComboBox cbCamera;
        private TextBox txbID;
        private PictureBox ptbCamera;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}