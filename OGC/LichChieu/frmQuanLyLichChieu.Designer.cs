﻿namespace OGC.LichChieu
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
            pnlMid = new Panel();
            flpLichChieu = new FlowLayoutPanel();
            pnlTieuDe = new Panel();
            pnlTop = new Panel();
            btnThemLC = new Button();
            pnlDate = new Panel();
            chbBoLoc = new CheckBox();
            label1 = new Label();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            btnReset = new Button();
            cbTenPhong = new ComboBox();
            txbTimKiem = new TextBox();
            panel1.SuspendLayout();
            pnlMid.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlDate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlMid);
            panel1.Controls.Add(pnlTop);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 416);
            panel1.TabIndex = 0;
            // 
            // pnlMid
            // 
            pnlMid.Controls.Add(flpLichChieu);
            pnlMid.Controls.Add(pnlTieuDe);
            pnlMid.Location = new Point(0, 60);
            pnlMid.Name = "pnlMid";
            pnlMid.Size = new Size(1096, 348);
            pnlMid.TabIndex = 1;
            // 
            // flpLichChieu
            // 
            flpLichChieu.AutoScroll = true;
            flpLichChieu.Location = new Point(0, 48);
            flpLichChieu.Name = "flpLichChieu";
            flpLichChieu.Size = new Size(1096, 300);
            flpLichChieu.TabIndex = 1;
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1096, 48);
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
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1096, 60);
            pnlTop.TabIndex = 0;
            // 
            // btnThemLC
            // 
            btnThemLC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemLC.Location = new Point(992, 12);
            btnThemLC.Name = "btnThemLC";
            btnThemLC.Size = new Size(80, 32);
            btnThemLC.TabIndex = 4;
            btnThemLC.Text = "✚ Thêm";
            btnThemLC.UseVisualStyleBackColor = true;
            btnThemLC.Click += btnThemLC_Click;
            // 
            // pnlDate
            // 
            pnlDate.Controls.Add(chbBoLoc);
            pnlDate.Controls.Add(label1);
            pnlDate.Controls.Add(dtpKetThuc);
            pnlDate.Controls.Add(dtpBatDau);
            pnlDate.Location = new Point(440, 8);
            pnlDate.Name = "pnlDate";
            pnlDate.Size = new Size(544, 40);
            pnlDate.TabIndex = 3;
            // 
            // chbBoLoc
            // 
            chbBoLoc.AutoSize = true;
            chbBoLoc.Location = new Point(464, 12);
            chbBoLoc.Name = "chbBoLoc";
            chbBoLoc.Size = new Size(57, 19);
            chbBoLoc.TabIndex = 5;
            chbBoLoc.Text = "Tất cả";
            chbBoLoc.UseVisualStyleBackColor = true;
            chbBoLoc.CheckedChanged += chbBoLoc_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 11);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 0;
            label1.Text = "To";
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpKetThuc.Location = new Point(256, 8);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(200, 23);
            dtpKetThuc.TabIndex = 0;
            dtpKetThuc.ValueChanged += dtpKetThuc_ValueChanged;
            // 
            // dtpBatDau
            // 
            dtpBatDau.CustomFormat = "dd/MM/yyyy";
            dtpBatDau.Location = new Point(8, 9);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(200, 23);
            dtpBatDau.TabIndex = 0;
            dtpBatDau.ValueChanged += dtpBatDau_ValueChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(224, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cbTenPhong
            // 
            cbTenPhong.FormattingEnabled = true;
            cbTenPhong.Location = new Point(328, 16);
            cbTenPhong.Name = "cbTenPhong";
            cbTenPhong.Size = new Size(96, 23);
            cbTenPhong.TabIndex = 1;
            cbTenPhong.SelectedIndexChanged += cbTenPhong_SelectedIndexChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(8, 16);
            txbTimKiem.Multiline = true;
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(208, 23);
            txbTimKiem.TabIndex = 0;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // frmQuanLyLichChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 416);
            Controls.Add(panel1);
            Name = "frmQuanLyLichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyLichChieu";
            panel1.ResumeLayout(false);
            pnlMid.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlMid;
        private Panel pnlTop;
        private Panel pnlDate;
        private Button btnReset;
        private ComboBox cbTenPhong;
        private TextBox txbTimKiem;
        private Label label1;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Panel pnlTieuDe;
        private Button btnThemLC;
        private CheckBox chbBoLoc;
        private FlowLayoutPanel flpLichChieu;
    }
}