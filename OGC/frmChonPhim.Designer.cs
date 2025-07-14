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
            chbTatCaNgay = new CheckBox();
            btnTimPhim = new Button();
            txbTimKiem = new TextBox();
            label2 = new Label();
            cbtheloaiphim = new ComboBox();
            cbdinhdang = new ComboBox();
            dtpChonNgayChieu = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            fplHienThiPhim = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chbTatCaNgay);
            panel1.Controls.Add(btnTimPhim);
            panel1.Controls.Add(txbTimKiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbtheloaiphim);
            panel1.Controls.Add(cbdinhdang);
            panel1.Controls.Add(dtpChonNgayChieu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 101);
            panel1.TabIndex = 0;
            // 
            // chbTatCaNgay
            // 
            chbTatCaNgay.AutoSize = true;
            chbTatCaNgay.Location = new Point(281, 43);
            chbTatCaNgay.Name = "chbTatCaNgay";
            chbTatCaNgay.Size = new Size(71, 24);
            chbTatCaNgay.TabIndex = 6;
            chbTatCaNgay.Text = "Tất cả";
            chbTatCaNgay.UseVisualStyleBackColor = true;
            chbTatCaNgay.CheckedChanged += chbTatCaNgay_CheckedChanged;
            // 
            // btnTimPhim
            // 
            btnTimPhim.Location = new Point(1045, 41);
            btnTimPhim.Name = "btnTimPhim";
            btnTimPhim.Size = new Size(49, 28);
            btnTimPhim.TabIndex = 5;
            btnTimPhim.Text = "🔎";
            btnTimPhim.UseVisualStyleBackColor = true;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(825, 42);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(214, 27);
            txbTimKiem.TabIndex = 4;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(825, 3);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên Phim";
            // 
            // cbtheloaiphim
            // 
            cbtheloaiphim.FormattingEnabled = true;
            cbtheloaiphim.Location = new Point(583, 41);
            cbtheloaiphim.Name = "cbtheloaiphim";
            cbtheloaiphim.Size = new Size(151, 28);
            cbtheloaiphim.TabIndex = 2;
            cbtheloaiphim.SelectedIndexChanged += cbtheloaiphim_SelectedIndexChanged_1;
            // 
            // cbdinhdang
            // 
            cbdinhdang.FormattingEnabled = true;
            cbdinhdang.Location = new Point(426, 41);
            cbdinhdang.Name = "cbdinhdang";
            cbdinhdang.Size = new Size(151, 28);
            cbdinhdang.TabIndex = 2;
            cbdinhdang.SelectedIndexChanged += cbdinhdang_SelectedIndexChanged_1;
            // 
            // dtpChonNgayChieu
            // 
            dtpChonNgayChieu.Location = new Point(25, 41);
            dtpChonNgayChieu.Name = "dtpChonNgayChieu";
            dtpChonNgayChieu.Size = new Size(250, 27);
            dtpChonNgayChieu.TabIndex = 1;
            dtpChonNgayChieu.ValueChanged += dtpChonNgayChieu_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 3);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 0;
            label5.Text = "Thể Loại Phim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 3);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 0;
            label4.Text = "Định Dạng Phim ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 3);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày Công Chiếu";
            // 
            // panel2
            // 
            panel2.Controls.Add(fplHienThiPhim);
            panel2.Location = new Point(3, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 514);
            panel2.TabIndex = 1;
            // 
            // fplHienThiPhim
            // 
            fplHienThiPhim.AutoScroll = true;
            fplHienThiPhim.Location = new Point(2, 3);
            fplHienThiPhim.Name = "fplHienThiPhim";
            fplHienThiPhim.Size = new Size(1098, 526);
            fplHienThiPhim.TabIndex = 0;
            // 
            // frmChonPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 627);
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
        private Button btnTimPhim;
        private TextBox txbTimKiem;
        private Label label2;
        private CheckBox chbTatCaNgay;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}