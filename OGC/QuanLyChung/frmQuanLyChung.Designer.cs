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
            pnlDichVu = new Panel();
            pnlKho = new Panel();
            btnKho = new Button();
            pnlLichChieu.SuspendLayout();
            pnlThuocTinh.SuspendLayout();
            pnlPhongChieu.SuspendLayout();
            pnlPhim.SuspendLayout();
            pnlDichVu.SuspendLayout();
            pnlKho.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLichChieu
            // 
            pnlLichChieu.Controls.Add(btnLichChieu);
            pnlLichChieu.Location = new Point(72, 232);
            pnlLichChieu.Name = "pnlLichChieu";
            pnlLichChieu.Size = new Size(264, 152);
            pnlLichChieu.TabIndex = 7;
            pnlLichChieu.Paint += pnlLichChieu_Paint;
            // 
            // btnLichChieu
            // 
            btnLichChieu.BackColor = SystemColors.ControlLight;
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
            btnLichChieu.Size = new Size(264, 152);
            btnLichChieu.TabIndex = 0;
            btnLichChieu.Text = "LỊCH CHIẾU";
            btnLichChieu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLichChieu.UseVisualStyleBackColor = false;
            btnLichChieu.Click += btnLichChieu_Click;
            // 
            // pnlThuocTinh
            // 
            pnlThuocTinh.Controls.Add(btnThuocTinh);
            pnlThuocTinh.Controls.Add(button1);
            pnlThuocTinh.Location = new Point(408, 233);
            pnlThuocTinh.Name = "pnlThuocTinh";
            pnlThuocTinh.Size = new Size(264, 152);
            pnlThuocTinh.TabIndex = 10;
            pnlThuocTinh.Paint += pnlThuocTinh_Paint;
            // 
            // btnThuocTinh
            // 
            btnThuocTinh.BackColor = SystemColors.ControlLight;
            btnThuocTinh.Dock = DockStyle.Fill;
            btnThuocTinh.FlatAppearance.BorderSize = 0;
            btnThuocTinh.FlatStyle = FlatStyle.Flat;
            btnThuocTinh.Font = new Font("Segoe UI", 14.25F);
            btnThuocTinh.ForeColor = Color.Gray;
            btnThuocTinh.Image = Properties.Resources.thuoctinh1;
            btnThuocTinh.ImageAlign = ContentAlignment.TopCenter;
            btnThuocTinh.Location = new Point(0, 0);
            btnThuocTinh.Name = "btnThuocTinh";
            btnThuocTinh.Padding = new Padding(0, 10, 0, 0);
            btnThuocTinh.Size = new Size(264, 152);
            btnThuocTinh.TabIndex = 0;
            btnThuocTinh.Text = "THUỘC TÍNH";
            btnThuocTinh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThuocTinh.UseVisualStyleBackColor = false;
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
            pnlPhongChieu.Location = new Point(408, 64);
            pnlPhongChieu.Name = "pnlPhongChieu";
            pnlPhongChieu.Size = new Size(264, 152);
            pnlPhongChieu.TabIndex = 11;
            pnlPhongChieu.Paint += pnlPhongChieu_Paint;
            // 
            // btnPhongChieu
            // 
            btnPhongChieu.BackColor = SystemColors.ControlLight;
            btnPhongChieu.Dock = DockStyle.Fill;
            btnPhongChieu.FlatAppearance.BorderSize = 0;
            btnPhongChieu.FlatStyle = FlatStyle.Flat;
            btnPhongChieu.Font = new Font("Segoe UI", 14.25F);
            btnPhongChieu.ForeColor = SystemColors.GrayText;
            btnPhongChieu.Image = Properties.Resources.phongchieu;
            btnPhongChieu.ImageAlign = ContentAlignment.TopCenter;
            btnPhongChieu.Location = new Point(0, 0);
            btnPhongChieu.Name = "btnPhongChieu";
            btnPhongChieu.Padding = new Padding(0, 30, 0, 0);
            btnPhongChieu.Size = new Size(264, 152);
            btnPhongChieu.TabIndex = 0;
            btnPhongChieu.Text = "PHÒNG CHIẾU";
            btnPhongChieu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhongChieu.UseVisualStyleBackColor = false;
            btnPhongChieu.Click += btnPhongChieu_Click;
            // 
            // pnlPhim
            // 
            pnlPhim.Controls.Add(btnPhim);
            pnlPhim.Location = new Point(72, 64);
            pnlPhim.Name = "pnlPhim";
            pnlPhim.Size = new Size(264, 152);
            pnlPhim.TabIndex = 12;
            pnlPhim.Paint += pnlPhim_Paint;
            // 
            // btnPhim
            // 
            btnPhim.BackColor = SystemColors.ControlLight;
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
            btnPhim.Size = new Size(264, 152);
            btnPhim.TabIndex = 0;
            btnPhim.Text = "PHIM";
            btnPhim.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhim.UseVisualStyleBackColor = false;
            btnPhim.Click += btnPhim_Click;
            // 
            // btnDoAn
            // 
            btnDoAn.BackColor = SystemColors.ControlLight;
            btnDoAn.Dock = DockStyle.Fill;
            btnDoAn.FlatAppearance.BorderSize = 0;
            btnDoAn.FlatStyle = FlatStyle.Flat;
            btnDoAn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoAn.ForeColor = SystemColors.GrayText;
            btnDoAn.Image = Properties.Resources.catering;
            btnDoAn.ImageAlign = ContentAlignment.TopCenter;
            btnDoAn.Location = new Point(0, 0);
            btnDoAn.Name = "btnDoAn";
            btnDoAn.Padding = new Padding(0, 30, 0, 0);
            btnDoAn.Size = new Size(264, 152);
            btnDoAn.TabIndex = 13;
            btnDoAn.Text = "DỊCH VỤ";
            btnDoAn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoAn.UseVisualStyleBackColor = false;
            btnDoAn.Click += btnDoAn_Click;
            // 
            // pnlDichVu
            // 
            pnlDichVu.Controls.Add(btnDoAn);
            pnlDichVu.Location = new Point(744, 64);
            pnlDichVu.Name = "pnlDichVu";
            pnlDichVu.Size = new Size(264, 152);
            pnlDichVu.TabIndex = 14;
            pnlDichVu.Paint += pnlDichVu_Paint;
            // 
            // pnlKho
            // 
            pnlKho.Controls.Add(btnKho);
            pnlKho.Location = new Point(744, 232);
            pnlKho.Name = "pnlKho";
            pnlKho.Size = new Size(264, 152);
            pnlKho.TabIndex = 14;
            pnlKho.Paint += pnlKho_Paint;
            // 
            // btnKho
            // 
            btnKho.BackColor = SystemColors.ControlLight;
            btnKho.Dock = DockStyle.Fill;
            btnKho.FlatAppearance.BorderSize = 0;
            btnKho.FlatStyle = FlatStyle.Flat;
            btnKho.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKho.ForeColor = SystemColors.GrayText;
            btnKho.Image = Properties.Resources.work;
            btnKho.ImageAlign = ContentAlignment.TopCenter;
            btnKho.Location = new Point(0, 0);
            btnKho.Name = "btnKho";
            btnKho.Padding = new Padding(0, 30, 0, 0);
            btnKho.Size = new Size(264, 152);
            btnKho.TabIndex = 13;
            btnKho.Text = "KHO";
            btnKho.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKho.UseVisualStyleBackColor = false;
            btnKho.Click += btnKho_Click;
            // 
            // frmQuanLyChung
            // 
            ClientSize = new Size(1072, 447);
            Controls.Add(pnlKho);
            Controls.Add(pnlDichVu);
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
            pnlDichVu.ResumeLayout(false);
            pnlKho.ResumeLayout(false);
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
        private Panel pnlDichVu;
        private Panel pnlKho;
        private Button btnKho;
    }
}