﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.NHANVIEN
{
    public partial class TieuDeNhanVienUC : UserControl
    {
        public TieuDeNhanVienUC()
        {
            InitializeComponent();
        }

        private void pnlTieuDe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTieuDe, 15);
        }
    }
}
