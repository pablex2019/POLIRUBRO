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
    public partial class frmPromocionesAgregar : Form
    {
        private ArticuloControler articulo;

        public frmPromocionesAgregar()
        {
            InitializeComponent();
            articulo = new ArticuloControler("Articulo");
        }
        private void frmPromocionesAgregar_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = articulo.ListadoInicial().Select(x=>x.Descripcion).ToList();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
