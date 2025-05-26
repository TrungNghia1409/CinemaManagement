namespace OGC.LichChieu
{
    partial class LichChieuUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLichChieuUC = new Panel();
            tlpLichChieuUC = new TableLayoutPanel();
            lblTenPhim = new Label();
            lblTenPhong = new Label();
            lblNgayGio = new Label();
            lblGiaVe = new Label();
            lblDiaDiem = new Label();
            lblTrangThai = new Label();
            tlpTieuDeUC = new TableLayoutPanel();
            panel2 = new Panel();
            pnlLichChieuUC.SuspendLayout();
            tlpLichChieuUC.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLichChieuUC
            // 
            pnlLichChieuUC.Controls.Add(tlpLichChieuUC);
            pnlLichChieuUC.Controls.Add(tlpTieuDeUC);
            pnlLichChieuUC.Controls.Add(panel2);
            pnlLichChieuUC.Location = new Point(0, 0);
            pnlLichChieuUC.Name = "pnlLichChieuUC";
            pnlLichChieuUC.Size = new Size(1072, 35);
            pnlLichChieuUC.TabIndex = 0;
            pnlLichChieuUC.Paint += pnlLichChieuUC_Paint;
            // 
            // tlpLichChieuUC
            // 
            tlpLichChieuUC.BackColor = SystemColors.ControlLight;
            tlpLichChieuUC.ColumnCount = 6;
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.13994F));
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8600578F));
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tlpLichChieuUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpLichChieuUC.Controls.Add(lblTenPhim, 0, 0);
            tlpLichChieuUC.Controls.Add(lblTenPhong, 1, 0);
            tlpLichChieuUC.Controls.Add(lblNgayGio, 2, 0);
            tlpLichChieuUC.Controls.Add(lblGiaVe, 3, 0);
            tlpLichChieuUC.Controls.Add(lblDiaDiem, 4, 0);
            tlpLichChieuUC.Controls.Add(lblTrangThai, 5, 0);
            tlpLichChieuUC.Dock = DockStyle.Fill;
            tlpLichChieuUC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpLichChieuUC.Location = new Point(0, 0);
            tlpLichChieuUC.Name = "tlpLichChieuUC";
            tlpLichChieuUC.RowCount = 1;
            tlpLichChieuUC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLichChieuUC.Size = new Size(1072, 35);
            tlpLichChieuUC.TabIndex = 2;
            tlpLichChieuUC.Click += tlpLichChieuUC_Click;
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Dock = DockStyle.Fill;
            lblTenPhim.Location = new Point(3, 0);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(204, 35);
            lblTenPhim.TabIndex = 0;
            lblTenPhim.Text = "Tên phim";
            lblTenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Dock = DockStyle.Fill;
            lblTenPhong.Location = new Point(213, 0);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(111, 35);
            lblTenPhong.TabIndex = 0;
            lblTenPhong.Text = "Phòng chiếu";
            lblTenPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayGio
            // 
            lblNgayGio.AutoSize = true;
            lblNgayGio.Dock = DockStyle.Fill;
            lblNgayGio.Location = new Point(330, 0);
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(207, 35);
            lblNgayGio.TabIndex = 0;
            lblNgayGio.Text = "Ngày giờ chiếu";
            lblNgayGio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGiaVe
            // 
            lblGiaVe.AutoSize = true;
            lblGiaVe.Dock = DockStyle.Fill;
            lblGiaVe.Location = new Point(543, 0);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(116, 35);
            lblGiaVe.TabIndex = 0;
            lblGiaVe.Text = "Giá vé";
            lblGiaVe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaDiem
            // 
            lblDiaDiem.AutoSize = true;
            lblDiaDiem.Dock = DockStyle.Fill;
            lblDiaDiem.Location = new Point(665, 0);
            lblDiaDiem.Name = "lblDiaDiem";
            lblDiaDiem.Size = new Size(253, 35);
            lblDiaDiem.TabIndex = 0;
            lblDiaDiem.Text = "Địa điểm";
            lblDiaDiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Location = new Point(924, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(145, 35);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTieuDeUC
            // 
            tlpTieuDeUC.ColumnCount = 6;
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.13994F));
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8600578F));
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tlpTieuDeUC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpTieuDeUC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpTieuDeUC.Location = new Point(24, 48);
            tlpTieuDeUC.Name = "tlpTieuDeUC";
            tlpTieuDeUC.RowCount = 1;
            tlpTieuDeUC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTieuDeUC.Size = new Size(1072, 48);
            tlpTieuDeUC.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(96, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // LichChieuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLichChieuUC);
            Name = "LichChieuUC";
            Size = new Size(1072, 35);
            pnlLichChieuUC.ResumeLayout(false);
            tlpLichChieuUC.ResumeLayout(false);
            tlpLichChieuUC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLichChieuUC;
        private Panel panel2;
        private TableLayoutPanel tlpLichChieuUC;
        private TableLayoutPanel tlpTieuDeUC;
        private Label lblTenPhim;
        private Label lblTenPhong;
        private Label lblNgayGio;
        private Label lblGiaVe;
        private Label lblDiaDiem;
        public Label lblTrangThai;
    }
}
