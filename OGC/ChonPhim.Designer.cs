namespace OGC
{
    partial class ChonPhim
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
            fplHienThiPhim = new FlowLayoutPanel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btnTimPhim = new Button();
            btnDatVe = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            fplHienThiPhim.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimPhim);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 80);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(fplHienThiPhim);
            panel2.Location = new Point(3, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 513);
            panel2.TabIndex = 1;
            // 
            // fplHienThiPhim
            // 
            fplHienThiPhim.Controls.Add(btnDatVe);
            fplHienThiPhim.Location = new Point(2, 5);
            fplHienThiPhim.Name = "fplHienThiPhim";
            fplHienThiPhim.Size = new Size(1098, 505);
            fplHienThiPhim.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Đặt Vé Nhanh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(378, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(535, 18);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(750, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên Phim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(825, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 4;
            // 
            // btnTimPhim
            // 
            btnTimPhim.Location = new Point(1045, 18);
            btnTimPhim.Name = "btnTimPhim";
            btnTimPhim.Size = new Size(49, 28);
            btnTimPhim.TabIndex = 5;
            btnTimPhim.Text = "🔎";
            btnTimPhim.UseVisualStyleBackColor = true;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(3, 3);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = true;
            // 
            // ChonPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 608);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ChonPhim";
            Text = "ChonPhim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            fplHienThiPhim.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel fplHienThiPhim;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnTimPhim;
        private TextBox textBox1;
        private Label label2;
        private Button btnDatVe;
    }
}