namespace OGC.QuanLyDichVu
{
    partial class frmQuanLyDichVu
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
            pnlPhai = new Panel();
            pnlTrai = new Panel();
            flpDichVu = new FlowLayoutPanel();
            pnlTrai.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPhai
            // 
            pnlPhai.Location = new Point(800, 0);
            pnlPhai.Name = "pnlPhai";
            pnlPhai.Size = new Size(272, 448);
            pnlPhai.TabIndex = 1;
            // 
            // pnlTrai
            // 
            pnlTrai.Controls.Add(flpDichVu);
            pnlTrai.Location = new Point(0, 0);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(800, 450);
            pnlTrai.TabIndex = 0;
            // 
            // flpDichVu
            // 
            flpDichVu.AutoScroll = true;
            flpDichVu.Dock = DockStyle.Left;
            flpDichVu.FlowDirection = FlowDirection.TopDown;
            flpDichVu.Location = new Point(0, 0);
            flpDichVu.Name = "flpDichVu";
            flpDichVu.Size = new Size(800, 450);
            flpDichVu.TabIndex = 0;
            flpDichVu.WrapContents = false;
            // 
            // frmQuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 447);
            Controls.Add(pnlPhai);
            Controls.Add(pnlTrai);
            Name = "frmQuanLyDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyDichVu";
            pnlTrai.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPhai;
        private Panel pnlTrai;
        private FlowLayoutPanel flpDichVu;
    }
}