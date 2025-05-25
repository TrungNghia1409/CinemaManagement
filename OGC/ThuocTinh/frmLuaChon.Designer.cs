namespace OGC.ThuocTinh
{
    partial class frmLuaChon
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
            label1 = new Label();
            btnNhanVien = new Button();
            btnTKNhanVien = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(256, 72);
            label1.TabIndex = 0;
            label1.Text = "Bạn muốn quản lý mục nào?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Font = new Font("Segoe UI", 12F);
            btnNhanVien.Location = new Point(8, 104);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(160, 50);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnTKNhanVien
            // 
            btnTKNhanVien.Font = new Font("Segoe UI", 12F);
            btnTKNhanVien.Location = new Point(200, 104);
            btnTKNhanVien.Name = "btnTKNhanVien";
            btnTKNhanVien.Size = new Size(160, 50);
            btnTKNhanVien.TabIndex = 1;
            btnTKNhanVien.Text = "Tài khoản Nhân viên";
            btnTKNhanVien.UseVisualStyleBackColor = true;
            btnTKNhanVien.Click += btnTKNhanVien_Click;
            // 
            // frmLuaChon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 166);
            Controls.Add(btnTKNhanVien);
            Controls.Add(btnNhanVien);
            Controls.Add(label1);
            Name = "frmLuaChon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLuaChon";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNhanVien;
        private Button btnTKNhanVien;
    }
}