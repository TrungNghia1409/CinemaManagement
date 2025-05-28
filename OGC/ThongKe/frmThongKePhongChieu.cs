using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGC.ThongKe
{
    public partial class frmThongKePhongChieu : Form
    {
        public frmThongKePhongChieu()
        {
            InitializeComponent();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
