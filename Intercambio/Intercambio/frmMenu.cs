using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intercambio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal frm = new frmSucursal();
            frm.Show();
        }
    }
}
