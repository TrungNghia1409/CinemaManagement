namespace OGC.Phim
{
    partial class frmQuanLyPhim
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
            panel2 = new Panel();
            panel1 = new Panel();
            AnhPhim = new PictureBox();
            btnXoaPhim = new Button();
            btnSuaPhim = new Button();
            btnThemPhim = new Button();
            panel15 = new Panel();
            btnTaiAnh = new Button();
            btnXoaAnh = new Button();
            panel13 = new Panel();
            tbMoTa = new TextBox();
            label11 = new Label();
            panel12 = new Panel();
            dtpKhoiChieu = new DateTimePicker();
            label10 = new Label();
            panel10 = new Panel();
            cbTrangThai = new ComboBox();
            label8 = new Label();
            panel6 = new Panel();
            tbDienVien = new TextBox();
            label4 = new Label();
            panel9 = new Panel();
            cbTheLoaiPhim = new ComboBox();
            label7 = new Label();
            panel4 = new Panel();
            tbThoiLuong = new TextBox();
            label2 = new Label();
            panel8 = new Panel();
            cbLoaiphong = new ComboBox();
            label6 = new Label();
            panel5 = new Panel();
            tbDaoDien = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            cbDoTuoi = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            tbTenPhim = new TextBox();
            label1 = new Label();
            dtgvPhim = new DataGridView();
            panel11 = new Panel();
            textBox9 = new TextBox();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhPhim).BeginInit();
            panel15.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).BeginInit();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dtgvPhim);
            panel2.Controls.Add(panel11);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1176, 670);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(AnhPhim);
            panel1.Controls.Add(btnXoaPhim);
            panel1.Controls.Add(btnSuaPhim);
            panel1.Controls.Add(btnThemPhim);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(551, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 664);
            panel1.TabIndex = 1;
            // 
            // AnhPhim
            // 
            AnhPhim.Location = new Point(325, 3);
            AnhPhim.Name = "AnhPhim";
            AnhPhim.Size = new Size(297, 264);
            AnhPhim.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhPhim.TabIndex = 0;
            AnhPhim.TabStop = false;
            // 
            // btnXoaPhim
            // 
            btnXoaPhim.Location = new Point(228, 583);
            btnXoaPhim.Name = "btnXoaPhim";
            btnXoaPhim.Size = new Size(94, 29);
            btnXoaPhim.TabIndex = 1;
            btnXoaPhim.Text = "Xóa Phim";
            btnXoaPhim.UseVisualStyleBackColor = true;
            btnXoaPhim.Click += btnXoaPhim_Click;
            // 
            // btnSuaPhim
            // 
            btnSuaPhim.Location = new Point(113, 583);
            btnSuaPhim.Name = "btnSuaPhim";
            btnSuaPhim.Size = new Size(94, 29);
            btnSuaPhim.TabIndex = 1;
            btnSuaPhim.Text = "Sửa Phim";
            btnSuaPhim.UseVisualStyleBackColor = true;
            // 
            // btnThemPhim
            // 
            btnThemPhim.Location = new Point(3, 583);
            btnThemPhim.Name = "btnThemPhim";
            btnThemPhim.Size = new Size(94, 29);
            btnThemPhim.TabIndex = 1;
            btnThemPhim.Text = "Thêm Phim";
            btnThemPhim.UseVisualStyleBackColor = true;
            btnThemPhim.Click += btnThemPhim_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnTaiAnh);
            panel15.Controls.Add(btnXoaAnh);
            panel15.Location = new Point(325, 270);
            panel15.Name = "panel15";
            panel15.Size = new Size(294, 35);
            panel15.TabIndex = 0;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(178, 3);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 1;
            btnTaiAnh.Text = "Tải Ảnh";
            btnTaiAnh.UseVisualStyleBackColor = true;
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Location = new Point(7, 3);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(94, 29);
            btnXoaAnh.TabIndex = 1;
            btnXoaAnh.Text = "Xóa Ảnh";
            btnXoaAnh.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(tbMoTa);
            panel13.Controls.Add(label11);
            panel13.Location = new Point(325, 311);
            panel13.Name = "panel13";
            panel13.Size = new Size(297, 266);
            panel13.TabIndex = 0;
            // 
            // tbMoTa
            // 
            tbMoTa.Location = new Point(7, 25);
            tbMoTa.Multiline = true;
            tbMoTa.Name = "tbMoTa";
            tbMoTa.Size = new Size(282, 236);
            tbMoTa.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 2);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 0;
            label11.Text = "Mô Tả";
            // 
            // panel12
            // 
            panel12.Controls.Add(dtpKhoiChieu);
            panel12.Controls.Add(label10);
            panel12.Location = new Point(3, 499);
            panel12.Name = "panel12";
            panel12.Size = new Size(319, 78);
            panel12.TabIndex = 0;
            // 
            // dtpKhoiChieu
            // 
            dtpKhoiChieu.Location = new Point(7, 40);
            dtpKhoiChieu.Name = "dtpKhoiChieu";
            dtpKhoiChieu.Size = new Size(270, 27);
            dtpKhoiChieu.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 15);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 0;
            label10.Text = "Ngày Khởi Chiếu";
            // 
            // panel10
            // 
            panel10.Controls.Add(cbTrangThai);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(3, 437);
            panel10.Name = "panel10";
            panel10.Size = new Size(319, 56);
            panel10.TabIndex = 0;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(85, 12);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(228, 28);
            cbTrangThai.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 15);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 0;
            label8.Text = "Trạng Thái";
            // 
            // panel6
            // 
            panel6.Controls.Add(tbDienVien);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 189);
            panel6.Name = "panel6";
            panel6.Size = new Size(319, 56);
            panel6.TabIndex = 0;
            // 
            // tbDienVien
            // 
            tbDienVien.Location = new Point(85, 12);
            tbDienVien.Name = "tbDienVien";
            tbDienVien.Size = new Size(231, 27);
            tbDienVien.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 15);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Diễn Viên";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbTheLoaiPhim);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(3, 313);
            panel9.Name = "panel9";
            panel9.Size = new Size(319, 56);
            panel9.TabIndex = 0;
            // 
            // cbTheLoaiPhim
            // 
            cbTheLoaiPhim.FormattingEnabled = true;
            cbTheLoaiPhim.Location = new Point(85, 12);
            cbTheLoaiPhim.Name = "cbTheLoaiPhim";
            cbTheLoaiPhim.Size = new Size(228, 28);
            cbTheLoaiPhim.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 15);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 0;
            label7.Text = "Thể Loại";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbThoiLuong);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 56);
            panel4.TabIndex = 0;
            // 
            // tbThoiLuong
            // 
            tbThoiLuong.Location = new Point(85, 12);
            tbThoiLuong.Name = "tbThoiLuong";
            tbThoiLuong.Size = new Size(231, 27);
            tbThoiLuong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Thời Lượng";
            // 
            // panel8
            // 
            panel8.Controls.Add(cbLoaiphong);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(3, 375);
            panel8.Name = "panel8";
            panel8.Size = new Size(319, 56);
            panel8.TabIndex = 0;
            // 
            // cbLoaiphong
            // 
            cbLoaiphong.FormattingEnabled = true;
            cbLoaiphong.Location = new Point(85, 12);
            cbLoaiphong.Name = "cbLoaiphong";
            cbLoaiphong.Size = new Size(228, 28);
            cbLoaiphong.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 15);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 0;
            label6.Text = "Loại Phòng";
            // 
            // panel5
            // 
            panel5.Controls.Add(tbDaoDien);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(319, 56);
            panel5.TabIndex = 0;
            // 
            // tbDaoDien
            // 
            tbDaoDien.Location = new Point(85, 12);
            tbDaoDien.Name = "tbDaoDien";
            tbDaoDien.Size = new Size(231, 27);
            tbDaoDien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "Đạo Diễn";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbDoTuoi);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(3, 251);
            panel7.Name = "panel7";
            panel7.Size = new Size(319, 56);
            panel7.TabIndex = 0;
            // 
            // cbDoTuoi
            // 
            cbDoTuoi.FormattingEnabled = true;
            cbDoTuoi.Location = new Point(85, 15);
            cbDoTuoi.Name = "cbDoTuoi";
            cbDoTuoi.Size = new Size(228, 28);
            cbDoTuoi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Độ Tuổi";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbTenPhim);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 56);
            panel3.TabIndex = 0;
            // 
            // tbTenPhim
            // 
            tbTenPhim.Location = new Point(85, 12);
            tbTenPhim.Name = "tbTenPhim";
            tbTenPhim.Size = new Size(231, 27);
            tbTenPhim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Phim";
            // 
            // dtgvPhim
            // 
            dtgvPhim.BorderStyle = BorderStyle.Fixed3D;
            dtgvPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPhim.Location = new Point(3, 3);
            dtgvPhim.Name = "dtgvPhim";
            dtgvPhim.RowHeadersWidth = 51;
            dtgvPhim.Size = new Size(542, 664);
            dtgvPhim.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(textBox9);
            panel11.Controls.Add(label9);
            panel11.Location = new Point(551, 502);
            panel11.Name = "panel11";
            panel11.Size = new Size(319, 56);
            panel11.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(85, 12);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(231, 27);
            textBox9.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 15);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 0;
            label9.Text = "Trạng Thái";
            // 
            // frmQuanLyPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 675);
            Controls.Add(panel2);
            Name = "frmQuanLyPhim";
            Text = "QuanLyPhim";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnhPhim).EndInit();
            panel15.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dtgvPhim;
        private Panel panel1;
        private Panel panel15;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private TextBox tbThoiLuong;
        private Label label2;
        private TextBox tbTenPhim;
        private Panel panel6;
        private TextBox tbDienVien;
        private Label label4;
        private Panel panel5;
        private TextBox tbDaoDien;
        private Label label3;
        private Panel panel10;
        private Label label8;
        private Panel panel8;
        private Label label6;
        private Panel panel7;
        private Label label5;
        private Panel panel13;
        private TextBox tbMoTa;
        private Label label11;
        private Panel panel12;
        private Label label10;
        private Panel panel11;
        private TextBox textBox9;
        private Label label9;
        private ComboBox cbLoaiphong;
        private ComboBox cbDoTuoi;
        private ComboBox cbTrangThai;
        private PictureBox AnhPhim;
        private Panel panel9;
        private Label label7;
        private ComboBox cbTheLoaiPhim;
        private Button btnXoaPhim;
        private Button btnSuaPhim;
        private Button btnThemPhim;
        private Button btnXoaAnh;
        private Button btnTaiAnh;
        private DateTimePicker dtpKhoiChieu;
    }
}