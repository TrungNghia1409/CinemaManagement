namespace OGC.LichChieu
{
    partial class frmQuanLyLichChieu
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
            pnlBottom = new Panel();
            pnlMid = new Panel();
            pnlLichChieu = new Panel();
            flpLichChieu = new FlowLayoutPanel();
            pnlTieuDe = new Panel();
            pnlTop = new Panel();
            btnThemLC = new Button();
            pnlDate = new Panel();
            label1 = new Label();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            btnReset = new Button();
            cbTenPhong = new ComboBox();
            txbTimKiem = new TextBox();
            panel1.SuspendLayout();
            pnlMid.SuspendLayout();
            pnlLichChieu.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlDate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlBottom);
            panel1.Controls.Add(pnlMid);
            panel1.Controls.Add(pnlTop);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 597);
            panel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.Location = new Point(0, 533);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1225, 69);
            pnlBottom.TabIndex = 2;
            // 
            // pnlMid
            // 
            pnlMid.Controls.Add(pnlLichChieu);
            pnlMid.Controls.Add(pnlTieuDe);
            pnlMid.Dock = DockStyle.Top;
            pnlMid.Location = new Point(0, 80);
            pnlMid.Margin = new Padding(3, 4, 3, 4);
            pnlMid.Name = "pnlMid";
            pnlMid.Size = new Size(1225, 437);
            pnlMid.TabIndex = 1;
            // 
            // pnlLichChieu
            // 
            pnlLichChieu.Controls.Add(flpLichChieu);
            pnlLichChieu.Dock = DockStyle.Top;
            pnlLichChieu.Location = new Point(0, 64);
            pnlLichChieu.Margin = new Padding(3, 4, 3, 4);
            pnlLichChieu.Name = "pnlLichChieu";
            pnlLichChieu.Size = new Size(1225, 395);
            pnlLichChieu.TabIndex = 1;
            // 
            // flpLichChieu
            // 
            flpLichChieu.Dock = DockStyle.Top;
            flpLichChieu.Location = new Point(0, 0);
            flpLichChieu.Margin = new Padding(3, 4, 3, 4);
            flpLichChieu.Name = "flpLichChieu";
            flpLichChieu.Size = new Size(1225, 384);
            flpLichChieu.TabIndex = 1;
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Margin = new Padding(3, 4, 3, 4);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1225, 64);
            pnlTieuDe.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnThemLC);
            pnlTop.Controls.Add(pnlDate);
            pnlTop.Controls.Add(btnReset);
            pnlTop.Controls.Add(cbTenPhong);
            pnlTop.Controls.Add(txbTimKiem);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1225, 80);
            pnlTop.TabIndex = 0;
            // 
            // btnThemLC
            // 
            btnThemLC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemLC.Location = new Point(1170, 16);
            btnThemLC.Margin = new Padding(3, 4, 3, 4);
            btnThemLC.Name = "btnThemLC";
            btnThemLC.Size = new Size(40, 47);
            btnThemLC.TabIndex = 4;
            btnThemLC.Text = "✚";
            btnThemLC.UseVisualStyleBackColor = true;
            btnThemLC.Click += btnThemLC_Click;
            // 
            // pnlDate
            // 
            pnlDate.Controls.Add(label1);
            pnlDate.Controls.Add(dtpKetThuc);
            pnlDate.Controls.Add(dtpBatDau);
            pnlDate.Location = new Point(576, 11);
            pnlDate.Margin = new Padding(3, 4, 3, 4);
            pnlDate.Name = "pnlDate";
            pnlDate.Size = new Size(558, 53);
            pnlDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 28);
            label1.TabIndex = 0;
            label1.Text = "To";
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Location = new Point(329, 12);
            dtpKetThuc.Margin = new Padding(3, 4, 3, 4);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(228, 27);
            dtpKetThuc.TabIndex = 0;
            dtpKetThuc.ValueChanged += dtpKetThuc_ValueChanged;
            // 
            // dtpBatDau
            // 
            dtpBatDau.Location = new Point(9, 12);
            dtpBatDau.Margin = new Padding(3, 4, 3, 4);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(228, 27);
            dtpBatDau.TabIndex = 0;
            dtpBatDau.ValueChanged += dtpBatDau_ValueChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(320, 21);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cbTenPhong
            // 
            cbTenPhong.FormattingEnabled = true;
            cbTenPhong.Location = new Point(421, 21);
            cbTenPhong.Margin = new Padding(3, 4, 3, 4);
            cbTenPhong.Name = "cbTenPhong";
            cbTenPhong.Size = new Size(138, 28);
            cbTenPhong.TabIndex = 1;
            cbTenPhong.SelectedIndexChanged += cbTenPhong_SelectedIndexChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(9, 21);
            txbTimKiem.Margin = new Padding(3, 4, 3, 4);
            txbTimKiem.Multiline = true;
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(292, 29);
            txbTimKiem.TabIndex = 0;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // frmQuanLyLichChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 596);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuanLyLichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyLichChieu";
            panel1.ResumeLayout(false);
            pnlMid.ResumeLayout(false);
            pnlLichChieu.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlBottom;
        private Panel pnlMid;
        private Panel pnlTop;
        private Panel pnlDate;
        private Button btnReset;
        private ComboBox cbTenPhong;
        private TextBox txbTimKiem;
        private Label label1;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Panel pnlLichChieu;
        private Panel pnlTieuDe;
        private FlowLayoutPanel flpLichChieu;
        private Button btnThemLC;
    }
}