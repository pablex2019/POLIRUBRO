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
    public partial class frmArticuloIndice : Form
    {
        private ArticuloControler articulo;

        public frmArticuloIndice()
        {
            InitializeComponent();
            articulo = new ArticuloControler("Articulo");
        }

        private void frmArticuloIndice_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = articulo.ListadoInicial();
        }
    }
}
