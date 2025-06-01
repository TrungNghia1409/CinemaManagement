namespace OGC.QuanLyDichVu
{
    partial class frmChiTietHoaDonMonAn
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
            dgvChiTiet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(8, 8);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(568, 240);
            dgvChiTiet.TabIndex = 0;
            // 
            // frmChiTietHoaDonMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(dgvChiTiet);
            Name = "frmChiTietHoaDonMonAn";
            Text = "frmChiTietHoaDonMonAn";
            Load += frmChiTietHoaDonMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChiTiet;
    }
}