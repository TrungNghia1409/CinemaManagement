namespace OGC.Phim
{
    partial class FrmXacNhanThanhToanVePhim
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
            btnXoaTienKhachDua = new Button();
            lblTrangThai = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            lbNgayThanhToan = new Label();
            lbTongTien = new Label();
            lbGheDaChon = new Label();
            tbTenNhanVien = new TextBox();
            tbTienThoi = new TextBox();
            tbTienKhachDua = new TextBox();
            tbKhuyenMai = new TextBox();
            txbSDT = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            tbMaKhuyenMai = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoaTienKhachDua);
            panel1.Controls.Add(lblTrangThai);
            panel1.Controls.Add(btnXacNhan);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(lbNgayThanhToan);
            panel1.Controls.Add(lbTongTien);
            panel1.Controls.Add(lbGheDaChon);
            panel1.Controls.Add(tbTenNhanVien);
            panel1.Controls.Add(tbTienThoi);
            panel1.Controls.Add(tbTienKhachDua);
            panel1.Controls.Add(tbKhuyenMai);
            panel1.Controls.Add(txbSDT);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbMaKhuyenMai);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 506);
            panel1.TabIndex = 0;
            // 
            // btnXoaTienKhachDua
            // 
            btnXoaTienKhachDua.Location = new Point(528, 300);
            btnXoaTienKhachDua.Name = "btnXoaTienKhachDua";
            btnXoaTienKhachDua.Size = new Size(94, 29);
            btnXoaTienKhachDua.TabIndex = 7;
            btnXoaTienKhachDua.Text = "Reset";
            btnXoaTienKhachDua.UseVisualStyleBackColor = true;
            btnXoaTienKhachDua.Click += btnXoaTienKhachDua_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(528, 101);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(428, 459);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(275, 459);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbNgayThanhToan
            // 
            lbNgayThanhToan.AutoSize = true;
            lbNgayThanhToan.Location = new Point(245, 220);
            lbNgayThanhToan.Name = "lbNgayThanhToan";
            lbNgayThanhToan.Size = new Size(124, 20);
            lbNgayThanhToan.TabIndex = 3;
            lbNgayThanhToan.Text = "Ngày Thanh Toán";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(241, 180);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(75, 20);
            lbTongTien.TabIndex = 3;
            lbTongTien.Text = "Tổng Tiền";
            // 
            // lbGheDaChon
            // 
            lbGheDaChon.AutoSize = true;
            lbGheDaChon.Location = new Point(245, 139);
            lbGheDaChon.Name = "lbGheDaChon";
            lbGheDaChon.Size = new Size(96, 20);
            lbGheDaChon.TabIndex = 3;
            lbGheDaChon.Text = "Ghế Đã Chọn";
            // 
            // tbTenNhanVien
            // 
            tbTenNhanVien.Location = new Point(241, 380);
            tbTenNhanVien.Name = "tbTenNhanVien";
            tbTenNhanVien.ReadOnly = true;
            tbTenNhanVien.Size = new Size(281, 27);
            tbTenNhanVien.TabIndex = 2;
            // 
            // tbTienThoi
            // 
            tbTienThoi.Location = new Point(241, 340);
            tbTienThoi.Name = "tbTienThoi";
            tbTienThoi.ReadOnly = true;
            tbTienThoi.Size = new Size(281, 27);
            tbTienThoi.TabIndex = 2;
            tbTienThoi.Leave += textBox1_Leave;
            // 
            // tbTienKhachDua
            // 
            tbTienKhachDua.Location = new Point(241, 300);
            tbTienKhachDua.Name = "tbTienKhachDua";
            tbTienKhachDua.Size = new Size(281, 27);
            tbTienKhachDua.TabIndex = 2;
            tbTienKhachDua.TextChanged += tbTienKhachDua_TextChanged;
            tbTienKhachDua.Leave += textBox1_Leave;
            // 
            // tbKhuyenMai
            // 
            tbKhuyenMai.Location = new Point(241, 257);
            tbKhuyenMai.Name = "tbKhuyenMai";
            tbKhuyenMai.Size = new Size(281, 27);
            tbKhuyenMai.TabIndex = 1;
            tbKhuyenMai.Leave += textBox1_Leave;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(241, 98);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(281, 27);
            txbSDT.TabIndex = 0;
            txbSDT.Leave += textBox1_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 140);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 1;
            label6.Text = "Số Ghế Đã Chọn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 340);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 1;
            label8.Text = "Tiền Thối";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 300);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 1;
            label7.Text = "Tiền Khách Đưa";
            // 
            // tbMaKhuyenMai
            // 
            tbMaKhuyenMai.AutoSize = true;
            tbMaKhuyenMai.Location = new Point(23, 260);
            tbMaKhuyenMai.Name = "tbMaKhuyenMai";
            tbMaKhuyenMai.Size = new Size(111, 20);
            tbMaKhuyenMai.TabIndex = 1;
            tbMaKhuyenMai.Text = "Mã Khuyến Mãi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 100);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 1;
            label5.Text = "Số Điện Thoại Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 180);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 220);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày Thanh Toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 380);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhân Viên Lập Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 18);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "XÁC NHẬN THANH TOÁN";
            // 
            // FrmXacNhanThanhToanVePhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 512);
            Controls.Add(panel1);
            Name = "FrmXacNhanThanhToanVePhim";
            Text = "FrmXacNhanThanhToanVePhim";
            Load += FrmXacNhanThanhToanVePhim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label lbNgayThanhToan;
        private Label lbTongTien;
        private Label lbGheDaChon;
        private TextBox tbTenNhanVien;
        private TextBox txbSDT;
        private Button btnXacNhan;
        private Button btnHuy;
        private Label lblTrangThai;
        private TextBox tbKhuyenMai;
        private Label tbMaKhuyenMai;
        private TextBox tbTienKhachDua;
        private Label label7;
        private TextBox tbTienThoi;
        private Label label8;
        private Button btnXoaTienKhachDua;
    }
}