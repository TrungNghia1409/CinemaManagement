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
            btnKiemTra.Location = new Point(475, 647);
            btnKiemTra.Margin = new Padding(3, 4, 3, 4);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(101, 32);
            btnKiemTra.TabIndex = 14;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(27, 380);
            btnKetThuc.Margin = new Padding(3, 4, 3, 4);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(101, 64);
            btnKetThuc.TabIndex = 12;
            btnKetThuc.Text = "Dừng";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(27, 273);
            btnBatDau.Margin = new Padding(3, 4, 3, 4);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(101, 64);
            btnBatDau.TabIndex = 13;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(256, 113);
            cbCamera.Margin = new Padding(3, 4, 3, 4);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(511, 28);
            cbCamera.TabIndex = 11;
         
            // 
            // txbID
            // 
            txbID.Location = new Point(256, 604);
            txbID.Margin = new Padding(3, 4, 3, 4);
            txbID.Name = "txbID";
            txbID.Size = new Size(511, 27);
            txbID.TabIndex = 10;
           
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(155, 167);
            ptbCamera.Margin = new Padding(3, 4, 3, 4);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(613, 395);
            ptbCamera.TabIndex = 9;
            ptbCamera.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(110, 593);
            label2.Name = "label2";
            label2.Size = new Size(137, 53);
            label2.TabIndex = 6;
            label2.Text = "Mã đọc được";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 103);
            label3.Name = "label3";
            label3.Size = new Size(238, 43);
            label3.TabIndex = 7;
            label3.Text = "Lựa chọn camera đầu vào";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 17);
            label1.Name = "label1";
            label1.Size = new Size(421, 53);
            label1.TabIndex = 8;
            label1.Text = "Kiểm tra hóa đơn vé";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KiemTraHoaDonVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 696);
            Controls.Add(btnKiemTra);
            Controls.Add(btnKetThuc);
            Controls.Add(btnBatDau);
            Controls.Add(cbCamera);
            Controls.Add(txbID);
            Controls.Add(ptbCamera);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "KiemTraHoaDonVe";
            Text = "KiemTraHoaDonVe";
            FormClosing += KiemTraHoaDonVe_FormClosing;
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