using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void mnuArticulo_Click(object sender, EventArgs e)
        {
            new frmArticuloIndice().Show();
        }

        private void mnuVenta_Click(object sender, EventArgs e)
        {
            new frmVenta().Show();
        }

        private void mnuPromocion_Click(object sender, EventArgs e)
        {
            new frmPromocionIndice().Show();
        }
    }
}
