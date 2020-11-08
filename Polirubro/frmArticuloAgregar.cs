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
    public partial class frmArticuloAgregar : Form
    {
        public DataGridView Grilla;
        private ArticuloControler Articulo;
        private MetodosGenericos MetodosGenericos;

        public frmArticuloAgregar()
        {
            InitializeComponent();
            Articulo = new ArticuloControler("Articulo");
            MetodosGenericos = new MetodosGenericos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Articulo.ABM(1,this,null, Grilla);
=======
            Articulo.ABM(1,this,null,0, Grilla);
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Cancelar(this);
        }
    }
}
