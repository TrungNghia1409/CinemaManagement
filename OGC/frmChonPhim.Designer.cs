namespace OGC
{
    partial class frmChonPhim
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
            panel1 = new Panel();
            btnTimPhim = new Button();
            txbTimKiem = new TextBox();
            label2 = new Label();
            cbtheloaiphim = new ComboBox();
            cbdinhdang = new ComboBox();
            dtpChonNgayChieu = new DateTimePicker();
            label1 = new Label();
            panel2 = new Panel();
            fplHienThiPhim = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimPhim);
            panel1.Controls.Add(txbTimKiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbtheloaiphim);
            panel1.Controls.Add(cbdinhdang);
            panel1.Controls.Add(dtpChonNgayChieu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 80);
            panel1.TabIndex = 0;
            // 
            // btnTimPhim
            // 
            btnTimPhim.Location = new Point(1045, 18);
            btnTimPhim.Name = "btnTimPhim";
            btnTimPhim.Size = new Size(49, 28);
            btnTimPhim.TabIndex = 5;
            btnTimPhim.Text = "🔎";
            btnTimPhim.UseVisualStyleBackColor = true;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(825, 19);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(214, 27);
            txbTimKiem.TabIndex = 4;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(750, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên Phim";
            // 
            // cbtheloaiphim
            // 
            cbtheloaiphim.FormattingEnabled = true;
            cbtheloaiphim.Location = new Point(535, 18);
            cbtheloaiphim.Name = "cbtheloaiphim";
            cbtheloaiphim.Size = new Size(151, 28);
            cbtheloaiphim.TabIndex = 2;
            cbtheloaiphim.SelectedIndexChanged += cbtheloaiphim_SelectedIndexChanged_1;
            // 
            // cbdinhdang
            // 
            cbdinhdang.FormattingEnabled = true;
            cbdinhdang.Location = new Point(378, 18);
            cbdinhdang.Name = "cbdinhdang";
            cbdinhdang.Size = new Size(151, 28);
            cbdinhdang.TabIndex = 2;
            cbdinhdang.SelectedIndexChanged += cbdinhdang_SelectedIndexChanged_1;
            // 
            // dtpChonNgayChieu
            // 
            dtpChonNgayChieu.Location = new Point(122, 18);
            dtpChonNgayChieu.Name = "dtpChonNgayChieu";
            dtpChonNgayChieu.Size = new Size(250, 27);
            dtpChonNgayChieu.TabIndex = 1;
            dtpChonNgayChieu.ValueChanged += dtpChonNgayChieu_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Đặt Vé Nhanh";
            // 
            // panel2
            // 
            panel2.Controls.Add(fplHienThiPhim);
            panel2.Location = new Point(3, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 513);
            panel2.TabIndex = 1;
            // 
            // fplHienThiPhim
            // 
            fplHienThiPhim.Location = new Point(2, 5);
            fplHienThiPhim.Name = "fplHienThiPhim";
            fplHienThiPhim.Size = new Size(1098, 505);
            fplHienThiPhim.TabIndex = 0;
            // 
            // frmChonPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 608);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmChonPhim";
            Text = "ChonPhim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel fplHienThiPhim;
        private ComboBox cbtheloaiphim;
        private ComboBox cbdinhdang;
        private DateTimePicker dtpChonNgayChieu;
        private Label label1;
        private Button btnTimPhim;
        private TextBox txbTimKiem;
        private Label label2;
    }
}