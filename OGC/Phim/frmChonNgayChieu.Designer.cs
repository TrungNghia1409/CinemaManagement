namespace OGC.Phim
{
    partial class frmChonNgayChieu
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
            panel2 = new Panel();
            ptbAnhPhim = new PictureBox();
            panel4 = new Panel();
            flpNgayChieu = new FlowLayoutPanel();
            label4 = new Label();
            btnThoat = new Button();
            panel5 = new Panel();
            lb1 = new Label();
            label2 = new Label();
            lbTheLoai = new Label();
            lbDinhDang = new Label();
            lbTenPhim = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhim).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(3, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 160);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(ptbAnhPhim);
            panel2.Location = new Point(3, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 412);
            panel2.TabIndex = 4;
            // 
            // ptbAnhPhim
            // 
            ptbAnhPhim.Location = new Point(9, 3);
            ptbAnhPhim.Name = "ptbAnhPhim";
            ptbAnhPhim.Size = new Size(257, 400);
            ptbAnhPhim.TabIndex = 0;
            ptbAnhPhim.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(flpNgayChieu);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(272, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(602, 412);
            panel4.TabIndex = 5;
            // 
            // flpNgayChieu
            // 
            flpNgayChieu.Location = new Point(3, 26);
            flpNgayChieu.Name = "flpNgayChieu";
            flpNgayChieu.Size = new Size(596, 380);
            flpNgayChieu.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Chọn Ngày Chiếu";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(780, 599);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbTenPhim);
            panel5.Controls.Add(lbDinhDang);
            panel5.Controls.Add(lbTheLoai);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lb1);
            panel5.Location = new Point(9, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(862, 154);
            panel5.TabIndex = 0;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(3, 49);
            lb1.Name = "lb1";
            lb1.Size = new Size(72, 20);
            lb1.TabIndex = 4;
            lb1.Text = "Thể Loại: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 121);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 5;
            label2.Text = "Định Dạng Phim: ";
            // 
            // lbTheLoai
            // 
            lbTheLoai.AutoSize = true;
            lbTheLoai.Location = new Point(101, 49);
            lbTheLoai.Name = "lbTheLoai";
            lbTheLoai.Size = new Size(94, 20);
            lbTheLoai.TabIndex = 6;
            lbTheLoai.Text = "labelTheLoai";
            // 
            // lbDinhDang
            // 
            lbDinhDang.AutoSize = true;
            lbDinhDang.Location = new Point(133, 121);
            lbDinhDang.Name = "lbDinhDang";
            lbDinhDang.Size = new Size(109, 20);
            lbDinhDang.TabIndex = 6;
            lbDinhDang.Text = "labelDinhDang";
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.Location = new Point(6, 9);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(69, 20);
            lbTenPhim.TabIndex = 0;
            lbTenPhim.Text = "Tên Phim";
            // 
            // frmChonNgayChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 639);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(btnThoat);
            Name = "frmChonNgayChieu";
            Text = "frmChonNgayChieu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhim).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox ptbAnhPhim;
        private Panel panel4;
        private FlowLayoutPanel flpNgayChieu;
        private Label label4;
        private Button btnThoat;
        private Panel panel5;
        private Label lbTenPhim;
        private Label lbDinhDang;
        private Label lbTheLoai;
        private Label label2;
        private Label lb1;
    }
}