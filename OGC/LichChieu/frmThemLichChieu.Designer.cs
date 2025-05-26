namespace OGC.LichChieu
{
    partial class frmThemLichChieu
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
            ptbAnhPhong = new PictureBox();
            txbDiaDiem = new TextBox();
            txbGiaVe = new TextBox();
            dtpNgayGio = new DateTimePicker();
            cbTenPhong = new ComboBox();
            cbTenPhim = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnDongYThemLC = new Button();
            txbID = new TextBox();
            lblDiaDiem = new Label();
            lblGiaVe = new Label();
            ptbAnh = new PictureBox();
            lblNgayGio = new Label();
            label2 = new Label();
            lblTenPhim = new Label();
            lblIDPhong = new Label();
            lblIDPhim = new Label();
            lblID = new Label();
            pmlPhai = new Panel();
            pnlTrai = new Panel();
            txbIDPhong = new TextBox();
            txbIDPhim = new TextBox();
            btnDongLC = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            pmlPhai.SuspendLayout();
            pnlTrai.SuspendLayout();
            SuspendLayout();
            // 
            // ptbAnhPhong
            // 
            ptbAnhPhong.Location = new Point(64, 240);
            ptbAnhPhong.Name = "ptbAnhPhong";
            ptbAnhPhong.Size = new Size(104, 136);
            ptbAnhPhong.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnhPhong.TabIndex = 0;
            ptbAnhPhong.TabStop = false;
            // 
            // txbDiaDiem
            // 
            txbDiaDiem.Location = new Point(128, 312);
            txbDiaDiem.Name = "txbDiaDiem";
            txbDiaDiem.Size = new Size(200, 23);
            txbDiaDiem.TabIndex = 11;
            // 
            // txbGiaVe
            // 
            txbGiaVe.Location = new Point(128, 272);
            txbGiaVe.Name = "txbGiaVe";
            txbGiaVe.Size = new Size(200, 23);
            txbGiaVe.TabIndex = 10;
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(128, 232);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(200, 23);
            dtpNgayGio.TabIndex = 9;
            // 
            // cbTenPhong
            // 
            cbTenPhong.FormattingEnabled = true;
            cbTenPhong.Location = new Point(128, 192);
            cbTenPhong.Name = "cbTenPhong";
            cbTenPhong.Size = new Size(200, 23);
            cbTenPhong.TabIndex = 8;
            cbTenPhong.SelectedIndexChanged += cbTenphong_SelectedIndexChanged;
            // 
            // cbTenPhim
            // 
            cbTenPhim.FormattingEnabled = true;
            cbTenPhim.Location = new Point(128, 152);
            cbTenPhim.Name = "cbTenPhim";
            cbTenPhim.Size = new Size(200, 23);
            cbTenPhim.TabIndex = 8;
            cbTenPhim.SelectedIndexChanged += cbTenPhim_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 216);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1;
            label3.Text = "Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Phim";
            // 
            // btnDongYThemLC
            // 
            btnDongYThemLC.Font = new Font("Segoe UI", 12F);
            btnDongYThemLC.Location = new Point(24, 368);
            btnDongYThemLC.Name = "btnDongYThemLC";
            btnDongYThemLC.Size = new Size(128, 32);
            btnDongYThemLC.TabIndex = 5;
            btnDongYThemLC.Text = "Đồng ý";
            btnDongYThemLC.UseVisualStyleBackColor = true;
            btnDongYThemLC.Click += btnDongYThemLC_Click;
            // 
            // txbID
            // 
            txbID.Location = new Point(128, 24);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(200, 23);
            txbID.TabIndex = 7;
            // 
            // lblDiaDiem
            // 
            lblDiaDiem.AutoSize = true;
            lblDiaDiem.Font = new Font("Segoe UI", 12F);
            lblDiaDiem.Location = new Point(45, 312);
            lblDiaDiem.Name = "lblDiaDiem";
            lblDiaDiem.Size = new Size(72, 21);
            lblDiaDiem.TabIndex = 2;
            lblDiaDiem.Text = "Địa điểm";
            // 
            // lblGiaVe
            // 
            lblGiaVe.AutoSize = true;
            lblGiaVe.Font = new Font("Segoe UI", 12F);
            lblGiaVe.Location = new Point(64, 272);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(53, 21);
            lblGiaVe.TabIndex = 2;
            lblGiaVe.Text = "Giá vé";
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(64, 40);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(104, 136);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 0;
            ptbAnh.TabStop = false;
            // 
            // lblNgayGio
            // 
            lblNgayGio.AutoSize = true;
            lblNgayGio.Font = new Font("Segoe UI", 12F);
            lblNgayGio.Location = new Point(43, 232);
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(74, 21);
            lblNgayGio.TabIndex = 2;
            lblNgayGio.Text = "Ngày giờ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 192);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên phòng";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Segoe UI", 12F);
            lblTenPhim.Location = new Point(44, 152);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(73, 21);
            lblTenPhim.TabIndex = 2;
            lblTenPhim.Text = "Tên phim";
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Font = new Font("Segoe UI", 12F);
            lblIDPhong.Location = new Point(36, 104);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(81, 21);
            lblIDPhong.TabIndex = 2;
            lblIDPhong.Text = "Mã phòng";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Font = new Font("Segoe UI", 12F);
            lblIDPhim.Location = new Point(45, 64);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(72, 21);
            lblIDPhim.TabIndex = 3;
            lblIDPhim.Text = "Mã phim";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(16, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 21);
            lblID.TabIndex = 4;
            lblID.Text = "Mã lịch chiếu";
            // 
            // pmlPhai
            // 
            pmlPhai.Controls.Add(ptbAnhPhong);
            pmlPhai.Controls.Add(ptbAnh);
            pmlPhai.Controls.Add(label3);
            pmlPhai.Controls.Add(label1);
            pmlPhai.Location = new Point(343, 0);
            pmlPhai.Name = "pmlPhai";
            pmlPhai.Size = new Size(192, 408);
            pmlPhai.TabIndex = 4;
            // 
            // pnlTrai
            // 
            pnlTrai.Controls.Add(txbDiaDiem);
            pnlTrai.Controls.Add(txbGiaVe);
            pnlTrai.Controls.Add(dtpNgayGio);
            pnlTrai.Controls.Add(cbTenPhong);
            pnlTrai.Controls.Add(cbTenPhim);
            pnlTrai.Controls.Add(txbIDPhong);
            pnlTrai.Controls.Add(txbIDPhim);
            pnlTrai.Controls.Add(txbID);
            pnlTrai.Controls.Add(lblDiaDiem);
            pnlTrai.Controls.Add(lblGiaVe);
            pnlTrai.Controls.Add(lblNgayGio);
            pnlTrai.Controls.Add(label2);
            pnlTrai.Controls.Add(lblTenPhim);
            pnlTrai.Controls.Add(lblIDPhong);
            pnlTrai.Controls.Add(lblIDPhim);
            pnlTrai.Controls.Add(lblID);
            pnlTrai.Location = new Point(-1, 0);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(344, 352);
            pnlTrai.TabIndex = 3;
            // 
            // txbIDPhong
            // 
            txbIDPhong.Location = new Point(128, 104);
            txbIDPhong.Name = "txbIDPhong";
            txbIDPhong.ReadOnly = true;
            txbIDPhong.Size = new Size(200, 23);
            txbIDPhong.TabIndex = 7;
            // 
            // txbIDPhim
            // 
            txbIDPhim.Location = new Point(128, 64);
            txbIDPhim.Name = "txbIDPhim";
            txbIDPhim.ReadOnly = true;
            txbIDPhim.Size = new Size(200, 23);
            txbIDPhim.TabIndex = 7;
            // 
            // btnDongLC
            // 
            btnDongLC.Font = new Font("Segoe UI", 12F);
            btnDongLC.Location = new Point(192, 368);
            btnDongLC.Name = "btnDongLC";
            btnDongLC.Size = new Size(128, 32);
            btnDongLC.TabIndex = 5;
            btnDongLC.Text = "Đóng";
            btnDongLC.UseVisualStyleBackColor = true;
            // 
            // frmThemLichChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 408);
            Controls.Add(btnDongLC);
            Controls.Add(btnDongYThemLC);
            Controls.Add(pmlPhai);
            Controls.Add(pnlTrai);
            Name = "frmThemLichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemLichChieu";
            ((System.ComponentModel.ISupportInitialize)ptbAnhPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            pmlPhai.ResumeLayout(false);
            pmlPhai.PerformLayout();
            pnlTrai.ResumeLayout(false);
            pnlTrai.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbAnhPhong;
        private TextBox txbDiaDiem;
        private TextBox txbGiaVe;
        private DateTimePicker dtpNgayGio;
        private ComboBox cbTenPhong;
        private ComboBox cbTenPhim;
        private Label label3;
        private Label label1;
        private Button btnDongYThemLC;
        private TextBox txbID;
        private Label lblDiaDiem;
        private Label lblGiaVe;
        private PictureBox ptbAnh;
        private Label lblNgayGio;
        private Label label2;
        private Label lblTenPhim;
        private Label lblIDPhong;
        private Label lblIDPhim;
        private Label lblID;
        private Panel pmlPhai;
        private Panel pnlTrai;
        private Button btnDongLC;
        private TextBox txbIDPhong;
        private TextBox txbIDPhim;
    }
}