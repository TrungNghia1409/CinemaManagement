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
            lbGheDaChon = new Label();
            lbGiaGhe = new Label();
            panel3 = new Panel();
            ptrbManHinh = new PictureBox();
            flpGhe = new FlowLayoutPanel();
            panel2 = new Panel();
            lbDinhDang = new Label();
            lbNgayChieu = new Label();
            lbGioChieu = new Label();
            lbTenPhim = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            btnXacNhan = new Button();
            button2 = new Button();
            btnChonHinhThucThanhToan = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrbManHinh).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbGheDaChon);
            panel1.Controls.Add(lbGiaGhe);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 698);
            panel1.TabIndex = 0;
            // 
            // lbGheDaChon
            // 
            lbGheDaChon.AutoSize = true;
            lbGheDaChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbGheDaChon.Location = new Point(41, 626);
            lbGheDaChon.MaximumSize = new Size(300, 0);
            lbGheDaChon.Name = "lbGheDaChon";
            lbGheDaChon.Size = new Size(100, 20);
            lbGheDaChon.TabIndex = 1;
            lbGheDaChon.Text = "Ghế Đã Chọn";
            // 
            // lbGiaGhe
            // 
            lbGiaGhe.AutoSize = true;
            lbGiaGhe.Location = new Point(41, 668);
            lbGiaGhe.Name = "lbGiaGhe";
            lbGiaGhe.Size = new Size(61, 20);
            lbGiaGhe.TabIndex = 1;
            lbGiaGhe.Text = "Giá Ghế";
            // 
            // panel3
            // 
            panel3.Controls.Add(ptrbManHinh);
            panel3.Controls.Add(flpGhe);
            panel3.Location = new Point(3, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 526);
            panel3.TabIndex = 0;
            // 
            // ptrbManHinh
            // 
            ptrbManHinh.Location = new Point(71, 3);
            ptrbManHinh.Name = "ptrbManHinh";
            ptrbManHinh.Size = new Size(780, 107);
            ptrbManHinh.TabIndex = 1;
            ptrbManHinh.TabStop = false;
            // 
            // flpGhe
            // 
            flpGhe.Location = new Point(3, 116);
            flpGhe.Name = "flpGhe";
            flpGhe.Size = new Size(901, 407);
            flpGhe.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbDinhDang);
            panel2.Controls.Add(lbNgayChieu);
            panel2.Controls.Add(lbGioChieu);
            panel2.Controls.Add(lbTenPhim);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 88);
            panel2.TabIndex = 0;
            // 
            // lbDinhDang
            // 
            lbDinhDang.AutoSize = true;
            lbDinhDang.Location = new Point(24, 52);
            lbDinhDang.Name = "lbDinhDang";
            lbDinhDang.Size = new Size(80, 20);
            lbDinhDang.TabIndex = 1;
            lbDinhDang.Text = "Định Dạng";
            // 
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.Location = new Point(654, 14);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(85, 20);
            lbNgayChieu.TabIndex = 1;
            lbNgayChieu.Text = "Ngày Chiếu";
            // 
            // lbGioChieu
            // 
            lbGioChieu.AutoSize = true;
            lbGioChieu.Location = new Point(654, 52);
            lbGioChieu.Name = "lbGioChieu";
            lbGioChieu.Size = new Size(73, 20);
            lbGioChieu.TabIndex = 1;
            lbGioChieu.Text = "Giờ Chiếu";
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTenPhim.Location = new Point(24, 5);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(113, 31);
            lbTenPhim.TabIndex = 1;
            lbTenPhim.Text = "Tên Phim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Goldenrod;
            label8.Location = new Point(747, 668);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 0;
            label8.Text = "[ ] Đang chọn (vàng)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(541, 668);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 0;
            label7.Text = "[ ] Trống (xanh lá)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(363, 668);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "[ ] Đặt rồi (đỏ)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(363, 626);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Ghi Chú";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(420, 706);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(161, 29);
            btnXacNhan.TabIndex = 1;
            btnXacNhan.Text = "CK Thành Công";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // button2
            // 
            button2.Location = new Point(757, 706);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnChonHinhThucThanhToan
            // 
            btnChonHinhThucThanhToan.Location = new Point(587, 706);
            btnChonHinhThucThanhToan.Name = "btnChonHinhThucThanhToan";
            btnChonHinhThucThanhToan.Size = new Size(161, 29);
            btnChonHinhThucThanhToan.TabIndex = 2;
            btnChonHinhThucThanhToan.Text = "Xác Nhận";
            btnChonHinhThucThanhToan.UseVisualStyleBackColor = true;
            btnChonHinhThucThanhToan.Click += btnChonHinhThucThanhToan_Click;
            // 
            // FrmChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 747);
            Controls.Add(btnChonHinhThucThanhToan);
            Controls.Add(button2);
            Controls.Add(btnXacNhan);
            Controls.Add(panel1);
            Name = "FrmChonGhe";
            Text = "FrmChonGhe";
            Activated += FrmChonGhe_Activated;
            Load += FrmChonGhe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptrbManHinh).EndInit();
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
        private Button btnXacNhan;
        private Button button2;
        private Label lbGheDaChon;
        private Label lbGiaGhe;
        private Button btnChonHinhThucThanhToan;
        private PictureBox ptrbManHinh;
    }
}