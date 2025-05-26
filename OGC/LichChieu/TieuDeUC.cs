using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.LichChieu
{
    public partial class TieuDeUC : UserControl
    {
        public TieuDeUC()
        {
            InitializeComponent();
        }

        private void pnlTieuDeUC_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            UIHelper.RoundPanelCorners(pnlTieuDeUC, 15);
        }
    }
}
