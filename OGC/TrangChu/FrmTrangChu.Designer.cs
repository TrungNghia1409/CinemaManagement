namespace OGC.TrangChu
{
    partial class FrmTrangChu
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
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            flpPhimMoi = new FlowLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            flpSuatChieu = new FlowLayoutPanel();
            label3 = new Label();
            flpPhimHot = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            flpSuatChieu.SuspendLayout();
            flpPhimHot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flpSuatChieu);
            panel1.Controls.Add(flpPhimMoi);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 523);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(flpPhimHot);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 124);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 118);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Xin Chào";
            // 
            // flpPhimMoi
            // 
            flpPhimMoi.Location = new Point(3, 153);
            flpPhimMoi.Name = "flpPhimMoi";
            flpPhimMoi.Size = new Size(373, 367);
            flpPhimMoi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 130);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Phim Mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 0;
            label4.Text = "Suất Chiếu Hôm Nay";
            // 
            // flpSuatChieu
            // 
            flpSuatChieu.Controls.Add(label4);
            flpSuatChieu.Location = new Point(382, 153);
            flpSuatChieu.Name = "flpSuatChieu";
            flpSuatChieu.Size = new Size(484, 132);
            flpSuatChieu.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 20);
            label3.TabIndex = 0;
            label3.Text = "Phim Danh Thu Cao Nhất Tháng";
            // 
            // flpPhimHot
            // 
            flpPhimHot.Controls.Add(label3);
            flpPhimHot.Location = new Point(376, 3);
            flpPhimHot.Name = "flpPhimHot";
            flpPhimHot.Size = new Size(484, 118);
            flpPhimHot.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(478, 198);
            dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 299);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "Kho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 16);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 1;
            label6.Text = "Tên người logic";
            // 
            // FrmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 530);
            Controls.Add(panel1);
            Name = "FrmTrangChu";
            Text = "FrmTrangChu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flpSuatChieu.ResumeLayout(false);
            flpSuatChieu.PerformLayout();
            flpPhimHot.ResumeLayout(false);
            flpPhimHot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel flpPhimMoi;
        private Label label2;
        private FlowLayoutPanel flpSuatChieu;
        private Label label4;
        private FlowLayoutPanel flpPhimHot;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
    }
}