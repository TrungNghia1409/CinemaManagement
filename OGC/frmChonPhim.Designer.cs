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
            btnKiemTra = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKiemTra);
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
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 76);
            panel1.TabIndex = 0;
            // 
            // chbTatCaNgay
            // 
            chbTatCaNgay.AutoSize = true;
            chbTatCaNgay.Location = new Point(246, 32);
            chbTatCaNgay.Margin = new Padding(3, 2, 3, 2);
            chbTatCaNgay.Name = "chbTatCaNgay";
            chbTatCaNgay.Size = new Size(57, 19);
            chbTatCaNgay.TabIndex = 6;
            chbTatCaNgay.Text = "Tất cả";
            chbTatCaNgay.UseVisualStyleBackColor = true;
            chbTatCaNgay.CheckedChanged += chbTatCaNgay_CheckedChanged;
            // 
            // btnTimPhim
            // 
            btnTimPhim.Location = new Point(808, 31);
            btnTimPhim.Margin = new Padding(3, 2, 3, 2);
            btnTimPhim.Name = "btnTimPhim";
            btnTimPhim.Size = new Size(43, 21);
            btnTimPhim.TabIndex = 5;
            btnTimPhim.Text = "🔎";
            btnTimPhim.UseVisualStyleBackColor = true;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(616, 31);
            txbTimKiem.Margin = new Padding(3, 2, 3, 2);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(188, 23);
            txbTimKiem.TabIndex = 4;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 2);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên Phim";
            // 
            // cbtheloaiphim
            // 
            cbtheloaiphim.FormattingEnabled = true;
            cbtheloaiphim.Location = new Point(457, 31);
            cbtheloaiphim.Margin = new Padding(3, 2, 3, 2);
            cbtheloaiphim.Name = "cbtheloaiphim";
            cbtheloaiphim.Size = new Size(133, 23);
            cbtheloaiphim.TabIndex = 2;
            cbtheloaiphim.SelectedIndexChanged += cbtheloaiphim_SelectedIndexChanged_1;
            // 
            // cbdinhdang
            // 
            cbdinhdang.FormattingEnabled = true;
            cbdinhdang.Location = new Point(320, 31);
            cbdinhdang.Margin = new Padding(3, 2, 3, 2);
            cbdinhdang.Name = "cbdinhdang";
            cbdinhdang.Size = new Size(133, 23);
            cbdinhdang.TabIndex = 2;
            cbdinhdang.SelectedIndexChanged += cbdinhdang_SelectedIndexChanged_1;
            // 
            // dtpChonNgayChieu
            // 
            dtpChonNgayChieu.Location = new Point(22, 31);
            dtpChonNgayChieu.Margin = new Padding(3, 2, 3, 2);
            dtpChonNgayChieu.Name = "dtpChonNgayChieu";
            dtpChonNgayChieu.Size = new Size(219, 23);
            dtpChonNgayChieu.TabIndex = 1;
            dtpChonNgayChieu.ValueChanged += dtpChonNgayChieu_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 2);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 0;
            label5.Text = "Thể Loại Phim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 2);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Định Dạng Phim ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 2);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 0;
            label3.Text = "Ngày Công Chiếu";
            // 
            // panel2
            // 
            panel2.Controls.Add(fplHienThiPhim);
            panel2.Location = new Point(3, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 386);
            panel2.TabIndex = 1;
            // 
            // fplHienThiPhim
            // 
            fplHienThiPhim.AutoScroll = true;
            fplHienThiPhim.Location = new Point(2, 2);
            fplHienThiPhim.Margin = new Padding(3, 2, 3, 2);
            fplHienThiPhim.Name = "fplHienThiPhim";
            fplHienThiPhim.Size = new Size(961, 394);
            fplHienThiPhim.TabIndex = 0;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(864, 32);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(93, 23);
            btnKiemTra.TabIndex = 0;
            btnKiemTra.Text = "Kiểm tra ";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // frmChonPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 470);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnKiemTra;
    }
}