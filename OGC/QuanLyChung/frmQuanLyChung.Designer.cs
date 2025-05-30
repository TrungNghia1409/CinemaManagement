namespace OGC.QuanLyChung
{
    partial class frmQuanLyChung
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
            pnlLichChieu = new Panel();
            btnLichChieu = new Button();
            pnlThuocTinh = new Panel();
            btnThuocTinh = new Button();
            button1 = new Button();
            pnlPhongChieu = new Panel();
            btnPhongChieu = new Button();
            pnlPhim = new Panel();
            btnPhim = new Button();
            btnDoAn = new Button();
            pnlLichChieu.SuspendLayout();
            pnlThuocTinh.SuspendLayout();
            pnlPhongChieu.SuspendLayout();
            pnlPhim.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLichChieu
            // 
            pnlLichChieu.Controls.Add(btnLichChieu);
            pnlLichChieu.Location = new Point(72, 232);
            pnlLichChieu.Name = "pnlLichChieu";
            pnlLichChieu.Size = new Size(408, 152);
            pnlLichChieu.TabIndex = 7;
            pnlLichChieu.Paint += pnlLichChieu_Paint;
            // 
            // btnLichChieu
            // 
            btnLichChieu.Dock = DockStyle.Fill;
            btnLichChieu.FlatAppearance.BorderSize = 0;
            btnLichChieu.FlatStyle = FlatStyle.Flat;
            btnLichChieu.Font = new Font("Segoe UI", 14.25F);
            btnLichChieu.ForeColor = Color.Gray;
            btnLichChieu.Image = Properties.Resources.lichchieu;
            btnLichChieu.ImageAlign = ContentAlignment.TopCenter;
            btnLichChieu.Location = new Point(0, 0);
            btnLichChieu.Name = "btnLichChieu";
            btnLichChieu.Padding = new Padding(0, 30, 0, 0);
            btnLichChieu.Size = new Size(408, 152);
            btnLichChieu.TabIndex = 0;
            btnLichChieu.Text = "LỊCH CHIẾU";
            btnLichChieu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLichChieu.UseVisualStyleBackColor = true;
            btnLichChieu.Click += btnLichChieu_Click;
            // 
            // pnlThuocTinh
            // 
            pnlThuocTinh.Controls.Add(btnThuocTinh);
            pnlThuocTinh.Controls.Add(button1);
            pnlThuocTinh.Location = new Point(592, 232);
            pnlThuocTinh.Name = "pnlThuocTinh";
            pnlThuocTinh.Size = new Size(408, 152);
            pnlThuocTinh.TabIndex = 10;
            pnlThuocTinh.Paint += pnlThuocTinh_Paint;
            // 
            // btnThuocTinh
            // 
            btnThuocTinh.Dock = DockStyle.Fill;
            btnThuocTinh.FlatAppearance.BorderSize = 0;
            btnThuocTinh.FlatStyle = FlatStyle.Flat;
            btnThuocTinh.Font = new Font("Segoe UI", 14.25F);
            btnThuocTinh.ForeColor = Color.Gray;
            btnThuocTinh.Image = Properties.Resources.thuoctinh1;
            btnThuocTinh.ImageAlign = ContentAlignment.TopCenter;
            btnThuocTinh.Location = new Point(0, 0);
            btnThuocTinh.Name = "btnThuocTinh";
            btnThuocTinh.Padding = new Padding(0, 15, 0, 0);
            btnThuocTinh.Size = new Size(408, 152);
            btnThuocTinh.TabIndex = 0;
            btnThuocTinh.Text = "THUỘC TÍNH";
            btnThuocTinh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThuocTinh.UseVisualStyleBackColor = true;
            btnThuocTinh.Click += btnThuocTinh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(-296, -128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "CHỨC VỤ";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlPhongChieu
            // 
            pnlPhongChieu.Controls.Add(btnPhongChieu);
            pnlPhongChieu.Location = new Point(592, 63);
            pnlPhongChieu.Name = "pnlPhongChieu";
            pnlPhongChieu.Size = new Size(408, 152);
            pnlPhongChieu.TabIndex = 11;
            pnlPhongChieu.Paint += pnlPhongChieu_Paint;
            // 
            // btnPhongChieu
            // 
            btnPhongChieu.Dock = DockStyle.Fill;
            btnPhongChieu.FlatAppearance.BorderSize = 0;
            btnPhongChieu.FlatStyle = FlatStyle.Flat;
            btnPhongChieu.Font = new Font("Segoe UI", 14.25F);
            btnPhongChieu.ForeColor = Color.Gray;
            btnPhongChieu.Image = Properties.Resources.phongchieu;
            btnPhongChieu.ImageAlign = ContentAlignment.TopCenter;
            btnPhongChieu.Location = new Point(0, 0);
            btnPhongChieu.Name = "btnPhongChieu";
            btnPhongChieu.Padding = new Padding(0, 30, 0, 0);
            btnPhongChieu.Size = new Size(408, 152);
            btnPhongChieu.TabIndex = 0;
            btnPhongChieu.Text = "PHÒNG CHIẾU";
            btnPhongChieu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhongChieu.UseVisualStyleBackColor = true;
            btnPhongChieu.Click += btnPhongChieu_Click;
            // 
            // pnlPhim
            // 
            pnlPhim.Controls.Add(btnPhim);
            pnlPhim.Location = new Point(72, 64);
            pnlPhim.Name = "pnlPhim";
            pnlPhim.Size = new Size(408, 152);
            pnlPhim.TabIndex = 12;
            pnlPhim.Paint += pnlPhim_Paint;
            // 
            // btnPhim
            // 
            btnPhim.Dock = DockStyle.Fill;
            btnPhim.FlatAppearance.BorderSize = 0;
            btnPhim.FlatStyle = FlatStyle.Flat;
            btnPhim.Font = new Font("Segoe UI", 14.25F);
            btnPhim.ForeColor = Color.Gray;
            btnPhim.Image = Properties.Resources.film1;
            btnPhim.ImageAlign = ContentAlignment.TopCenter;
            btnPhim.Location = new Point(0, 0);
            btnPhim.Name = "btnPhim";
            btnPhim.Padding = new Padding(0, 30, 0, 0);
            btnPhim.Size = new Size(408, 152);
            btnPhim.TabIndex = 0;
            btnPhim.Text = "PHIM";
            btnPhim.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhim.UseVisualStyleBackColor = true;
            btnPhim.Click += btnPhim_Click;
            // 
            // btnDoAn
            // 
            btnDoAn.Location = new Point(1006, 130);
            btnDoAn.Name = "btnDoAn";
            btnDoAn.Size = new Size(94, 29);
            btnDoAn.TabIndex = 13;
            btnDoAn.Text = "Đồ Ăn";
            btnDoAn.UseVisualStyleBackColor = true;
            btnDoAn.Click += btnDoAn_Click;
            // 
            // frmQuanLyChung
            // 
            ClientSize = new Size(1343, 447);
            Controls.Add(btnDoAn);
            Controls.Add(pnlLichChieu);
            Controls.Add(pnlThuocTinh);
            Controls.Add(pnlPhongChieu);
            Controls.Add(pnlPhim);
            Name = "frmQuanLyChung";
            StartPosition = FormStartPosition.CenterScreen;
            pnlLichChieu.ResumeLayout(false);
            pnlThuocTinh.ResumeLayout(false);
            pnlPhongChieu.ResumeLayout(false);
            pnlPhim.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLichChieu;
        private Button btnLichChieu;
        private Panel pnlDinhDangPhim;
        private Button btnDinhDangPhim;
        private Panel pnlLoaiMonAn;
        private Button btnLoaiMonAn;
        private Panel pnlThuocTinh;
        private Button button1;
        private Button btnThuocTinh;
        private Panel pnlPhongChieu;
        private Button btnPhongChieu;
        private Panel pnlPhim;
        private Button btnPhim;
        private Button btnDoAn;
    }
}