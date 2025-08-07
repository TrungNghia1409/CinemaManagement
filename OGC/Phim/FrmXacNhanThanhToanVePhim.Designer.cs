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
            lblTrangThai = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            lbNgayThanhToan = new Label();
            lbTongTien = new Label();
            lbGheDaChon = new Label();
            tbMaNhanVien = new TextBox();
            txbSDT = new TextBox();
            label6 = new Label();
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
            panel1.Controls.Add(lblTrangThai);
            panel1.Controls.Add(btnXacNhan);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(lbNgayThanhToan);
            panel1.Controls.Add(lbTongTien);
            panel1.Controls.Add(lbGheDaChon);
            panel1.Controls.Add(tbMaNhanVien);
            panel1.Controls.Add(txbSDT);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 328);
            panel1.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(528, 66);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(428, 274);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(275, 274);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbNgayThanhToan
            // 
            lbNgayThanhToan.AutoSize = true;
            lbNgayThanhToan.Location = new Point(245, 185);
            lbNgayThanhToan.Name = "lbNgayThanhToan";
            lbNgayThanhToan.Size = new Size(124, 20);
            lbNgayThanhToan.TabIndex = 3;
            lbNgayThanhToan.Text = "Ngày Thanh Toán";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(241, 145);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(75, 20);
            lbTongTien.TabIndex = 3;
            lbTongTien.Text = "Tổng Tiền";
            // 
            // lbGheDaChon
            // 
            lbGheDaChon.AutoSize = true;
            lbGheDaChon.Location = new Point(245, 104);
            lbGheDaChon.Name = "lbGheDaChon";
            lbGheDaChon.Size = new Size(96, 20);
            lbGheDaChon.TabIndex = 3;
            lbGheDaChon.Text = "Ghế Đã Chọn";
            // 
            // tbMaNhanVien
            // 
            tbMaNhanVien.Location = new Point(241, 218);
            tbMaNhanVien.Name = "tbMaNhanVien";
            tbMaNhanVien.ReadOnly = true;
            tbMaNhanVien.Size = new Size(281, 27);
            tbMaNhanVien.TabIndex = 2;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(241, 63);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(281, 27);
            txbSDT.TabIndex = 2;
            txbSDT.Leave += textBox1_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 105);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 1;
            label6.Text = "Số Ghế Đã Chọn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 65);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 1;
            label5.Text = "Số Điện Thoại Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 185);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày Thanh Toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 225);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 18);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "XÁC NHẬN THANH TOÁN";
            // 
            // FrmXacNhanThanhToanVePhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 339);
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
        private TextBox tbMaNhanVien;
        private TextBox txbSDT;
        private Button btnXacNhan;
        private Button btnHuy;
        private Label lblTrangThai;
    }
}