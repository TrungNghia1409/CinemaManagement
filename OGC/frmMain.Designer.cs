namespace OGC
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Logo = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel9 = new Panel();
            button6 = new Button();
            panel7 = new Panel();
            button4 = new Button();
            panel5 = new Panel();
            btnThuocTinh = new Button();
            panel8 = new Panel();
            button5 = new Button();
            panel6 = new Panel();
            btnDatVe = new Button();
            panel4 = new Panel();
            btnTrangChu = new Button();
            panel_Body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 95);
            panel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BorderStyle = BorderStyle.FixedSingle;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(4, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(96, 95);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(110, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1369, 95);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(1, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 647);
            panel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(button6);
            panel9.Location = new Point(3, 508);
            panel9.Name = "panel9";
            panel9.Size = new Size(224, 95);
            panel9.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(0, 3);
            button6.Name = "button6";
            button6.Size = new Size(221, 89);
            button6.TabIndex = 0;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(button4);
            panel7.Location = new Point(3, 306);
            panel7.Name = "panel7";
            panel7.Size = new Size(224, 95);
            panel7.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(0, 3);
            button4.Name = "button4";
            button4.Size = new Size(221, 89);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnThuocTinh);
            panel5.Location = new Point(3, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 95);
            panel5.TabIndex = 0;
            // 
            // btnThuocTinh
            // 
            btnThuocTinh.Location = new Point(0, 3);
            btnThuocTinh.Name = "btnThuocTinh";
            btnThuocTinh.Size = new Size(221, 89);
            btnThuocTinh.TabIndex = 0;
            btnThuocTinh.Text = "Thuộc Tính";
            btnThuocTinh.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(button5);
            panel8.Location = new Point(3, 407);
            panel8.Name = "panel8";
            panel8.Size = new Size(224, 95);
            panel8.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(0, 3);
            button5.Name = "button5";
            button5.Size = new Size(221, 89);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDatVe);
            panel6.Location = new Point(3, 205);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 95);
            panel6.TabIndex = 0;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(0, 3);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(221, 89);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTrangChu);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 95);
            panel4.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(0, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(221, 89);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.BorderStyle = BorderStyle.FixedSingle;
            panel_Body.Location = new Point(235, 102);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1244, 647);
            panel_Body.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(panel_Body);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            Text = "Chào mừng bạn đến với OGC";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel9;
        private Panel panel7;
        private Panel panel5;
        private Panel panel8;
        private Panel panel6;
        private Panel panel4;
        private Button button4;
        private Button btnThuocTinh;
        private Button button5;
        private Button btnDatVe;
        private Button btnTrangChu;
        private Button button6;
        protected PictureBox Logo;
        private Panel panel_Body;
    }
}
