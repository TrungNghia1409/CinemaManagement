namespace OGC.Phim
{
    partial class FrmChonGhe
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
            panel3 = new Panel();
            flpGhe = new FlowLayoutPanel();
            panel2 = new Panel();
            lbDinhDang = new Label();
            lbNgayChieu = new Label();
            lbGioChieu = new Label();
            lbTenPhim = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 600);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(flpGhe);
            panel3.Location = new Point(3, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 370);
            panel3.TabIndex = 0;
            // 
            // flpGhe
            // 
            flpGhe.Location = new Point(3, 3);
            flpGhe.Name = "flpGhe";
            flpGhe.Size = new Size(901, 358);
            flpGhe.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbDinhDang);
            panel2.Controls.Add(lbNgayChieu);
            panel2.Controls.Add(lbGioChieu);
            panel2.Controls.Add(lbTenPhim);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 125);
            panel2.TabIndex = 0;
            // 
            // lbDinhDang
            // 
            lbDinhDang.AutoSize = true;
            lbDinhDang.Location = new Point(387, 86);
            lbDinhDang.Name = "lbDinhDang";
            lbDinhDang.Size = new Size(80, 20);
            lbDinhDang.TabIndex = 1;
            lbDinhDang.Text = "Định Dạng";
            // 
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.Location = new Point(387, 48);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(85, 20);
            lbNgayChieu.TabIndex = 1;
            lbNgayChieu.Text = "Ngày Chiếu";
            // 
            // lbGioChieu
            // 
            lbGioChieu.AutoSize = true;
            lbGioChieu.Location = new Point(8, 86);
            lbGioChieu.Name = "lbGioChieu";
            lbGioChieu.Size = new Size(73, 20);
            lbGioChieu.TabIndex = 1;
            lbGioChieu.Text = "Giờ Chiếu";
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.Location = new Point(8, 48);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(69, 20);
            lbTenPhim.TabIndex = 1;
            lbTenPhim.Text = "Tên Phim";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 4);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 0;
            label9.Text = "Chọn Ghế";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 540);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 0;
            label8.Text = "[ ] Đang chọn (vàng)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 540);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 0;
            label7.Text = "[ ] Trống (xanh lá)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(171, 540);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "[ ] Đặt rồi (đỏ)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 507);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Ghi Chú";
            // 
            // button1
            // 
            button1.Location = new Point(706, 617);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(820, 617);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 658);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "FrmChonGhe";
            Text = "FrmChonGhe";
            Load += FrmChonGhe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lbTenPhim;
        private Label label1;
        private Label lbDinhDang;
        private Label lbNgayChieu;
        private Label lbGioChieu;
        private FlowLayoutPanel flpGhe;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label9;
    }
}