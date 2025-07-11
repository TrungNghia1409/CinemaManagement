namespace OGC.Log_NhanVien
{
    partial class frmLog_NhanVien
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
            pnlThoiGian = new Panel();
            ckbTatCa = new CheckBox();
            btnKiemTra = new Button();
            label2 = new Label();
            lblNgay = new Label();
            label1 = new Label();
            lblNam = new Label();
            cbThang = new ComboBox();
            cbNgay = new ComboBox();
            cbNam = new ComboBox();
            pnlTieuDe_Log_NhanVien = new Panel();
            pnlLog_NhanVien = new Panel();
            pnlThoiGian.SuspendLayout();
            SuspendLayout();
            // 
            // pnlThoiGian
            // 
            pnlThoiGian.Controls.Add(ckbTatCa);
            pnlThoiGian.Controls.Add(btnKiemTra);
            pnlThoiGian.Controls.Add(label2);
            pnlThoiGian.Controls.Add(lblNgay);
            pnlThoiGian.Controls.Add(label1);
            pnlThoiGian.Controls.Add(lblNam);
            pnlThoiGian.Controls.Add(cbThang);
            pnlThoiGian.Controls.Add(cbNgay);
            pnlThoiGian.Controls.Add(cbNam);
            pnlThoiGian.Location = new Point(0, 0);
            pnlThoiGian.Name = "pnlThoiGian";
            pnlThoiGian.Size = new Size(888, 48);
            pnlThoiGian.TabIndex = 0;
            // 
            // ckbTatCa
            // 
            ckbTatCa.AutoSize = true;
            ckbTatCa.Location = new Point(810, 17);
            ckbTatCa.Name = "ckbTatCa";
            ckbTatCa.Size = new Size(57, 19);
            ckbTatCa.TabIndex = 4;
            ckbTatCa.Text = "Tất cả";
            ckbTatCa.UseVisualStyleBackColor = true;
            ckbTatCa.CheckedChanged += ckbTatCa_CheckedChanged;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(719, 13);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(75, 23);
            btnKiemTra.TabIndex = 3;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(304, 32);
            label2.TabIndex = 2;
            label2.Text = "NHẬT KÝ HOẠT ĐỘNG";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(352, 14);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(48, 20);
            lblNgay.TabIndex = 1;
            lblNgay.Text = "Ngày:";
            lblNgay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(472, 14);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Tháng:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNam
            // 
            lblNam.Location = new Point(600, 14);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(36, 20);
            lblNam.TabIndex = 1;
            lblNam.Text = "Năm:";
            lblNam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(520, 13);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(72, 23);
            cbThang.TabIndex = 0;
            cbThang.SelectedIndexChanged += cbThang_SelectedIndexChanged;
            // 
            // cbNgay
            // 
            cbNgay.FormattingEnabled = true;
            cbNgay.Location = new Point(400, 13);
            cbNgay.Name = "cbNgay";
            cbNgay.Size = new Size(72, 23);
            cbNgay.TabIndex = 0;
            cbNgay.SelectedIndexChanged += cbNgay_SelectedIndexChanged;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(638, 13);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(72, 23);
            cbNam.TabIndex = 0;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // pnlTieuDe_Log_NhanVien
            // 
            pnlTieuDe_Log_NhanVien.Location = new Point(0, 48);
            pnlTieuDe_Log_NhanVien.Name = "pnlTieuDe_Log_NhanVien";
            pnlTieuDe_Log_NhanVien.Size = new Size(888, 70);
            pnlTieuDe_Log_NhanVien.TabIndex = 1;
            // 
            // pnlLog_NhanVien
            // 
            pnlLog_NhanVien.AutoScroll = true;
            pnlLog_NhanVien.Location = new Point(0, 120);
            pnlLog_NhanVien.Name = "pnlLog_NhanVien";
            pnlLog_NhanVien.Size = new Size(888, 340);
            pnlLog_NhanVien.TabIndex = 0;
            // 
            // frmLog_NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(pnlLog_NhanVien);
            Controls.Add(pnlTieuDe_Log_NhanVien);
            Controls.Add(pnlThoiGian);
            Name = "frmLog_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLog_NhanVien";
            Load += frmLog_NhanVien_Load;
            pnlThoiGian.ResumeLayout(false);
            pnlThoiGian.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlThoiGian;
        private Panel pnlTieuDe_Log_NhanVien;
        private Panel pnlLog_NhanVien;
        private Label lblNam;
        private ComboBox cbThang;
        private ComboBox cbNgay;
        private ComboBox cbNam;
        private Label label1;
        private Label lblNgay;
        private Label label2;
        private Button btnKiemTra;
        private CheckBox ckbTatCa;
    }
}