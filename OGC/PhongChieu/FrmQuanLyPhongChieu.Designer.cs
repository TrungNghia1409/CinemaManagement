namespace OGC.PhongChieu
{
    partial class FrmQuanLyPhongChieu
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
            dtgPhongChieu = new DataGridView();
            panel2 = new Panel();
            picAnhPhong = new PictureBox();
            btnTaiAnh = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cbLoaiPhong = new ComboBox();
            cbTrangThai = new ComboBox();
            tbMaLoaiPhong = new TextBox();
            tbSucChua = new TextBox();
            tbTenPhong = new TextBox();
            tbID = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPhongChieu).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgPhongChieu);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 376);
            panel1.TabIndex = 0;
            // 
            // dtgPhongChieu
            // 
            dtgPhongChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPhongChieu.Location = new Point(3, 3);
            dtgPhongChieu.Name = "dtgPhongChieu";
            dtgPhongChieu.RowHeadersWidth = 51;
            dtgPhongChieu.Size = new Size(510, 360);
            dtgPhongChieu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(picAnhPhong);
            panel2.Controls.Add(btnTaiAnh);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(cbLoaiPhong);
            panel2.Controls.Add(cbTrangThai);
            panel2.Controls.Add(tbMaLoaiPhong);
            panel2.Controls.Add(tbSucChua);
            panel2.Controls.Add(tbTenPhong);
            panel2.Controls.Add(tbID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(525, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 376);
            panel2.TabIndex = 0;
            // 
            // picAnhPhong
            // 
            picAnhPhong.Location = new Point(381, 10);
            picAnhPhong.Name = "picAnhPhong";
            picAnhPhong.Size = new Size(246, 213);
            picAnhPhong.TabIndex = 4;
            picAnhPhong.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(461, 238);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 3;
            btnTaiAnh.Text = "Tải Ảnh";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(284, 334);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(163, 334);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 334);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(132, 203);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(151, 28);
            cbLoaiPhong.TabIndex = 2;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(132, 163);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(151, 28);
            cbTrangThai.TabIndex = 2;
            // 
            // tbMaLoaiPhong
            // 
            tbMaLoaiPhong.Location = new Point(132, 251);
            tbMaLoaiPhong.Name = "tbMaLoaiPhong";
            tbMaLoaiPhong.Size = new Size(151, 27);
            tbMaLoaiPhong.TabIndex = 1;
            // 
            // tbSucChua
            // 
            tbSucChua.Location = new Point(132, 118);
            tbSucChua.Name = "tbSucChua";
            tbSucChua.Size = new Size(151, 27);
            tbSucChua.TabIndex = 1;
            // 
            // tbTenPhong
            // 
            tbTenPhong.Location = new Point(132, 77);
            tbTenPhong.Name = "tbTenPhong";
            tbTenPhong.Size = new Size(151, 27);
            tbTenPhong.TabIndex = 1;
            // 
            // tbID
            // 
            tbID.Location = new Point(132, 29);
            tbID.Name = "tbID";
            tbID.Size = new Size(151, 27);
            tbID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 118);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Sức Chứa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 258);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã Loại Phòng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 203);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 0;
            label6.Text = "Loại Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 163);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Trạng Thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Phòng";
            // 
            // FrmQuanLyPhongChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 386);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmQuanLyPhongChieu";
            Text = "FrmQuanLyPhongChieu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgPhongChieu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox tbMaLoaiPhong;
        private TextBox tbSucChua;
        private TextBox tbTenPhong;
        private TextBox tbID;
        private ComboBox cbTrangThai;
        private Button btnTaiAnh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dtgPhongChieu;
        private PictureBox picAnhPhong;
        private ComboBox cbLoaiPhong;
        private Label label6;
    }
}