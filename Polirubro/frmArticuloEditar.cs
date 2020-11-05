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
    public partial class frmArticuloEditar : Form
    {
        public DataGridView Grilla;
        public string descripcion;
        private MetodosGenericos MetodosGenericos;
        private ArticuloControler Articulo;

        public frmArticuloEditar()
        {
            InitializeComponent();
            Articulo = new ArticuloControler("Articulo");
            MetodosGenericos = new MetodosGenericos();
        }

        private void frmArticuloEditar_Load(object sender, EventArgs e)
        {
            var _Articulo = Articulo.ObtenerArticulo(descripcion);
            txtDescripcion.Text = _Articulo.Descripcion;
            txtPrecioCosto.Text = _Articulo.Descripcion;
            txtPrecioVenta.Text = _Articulo.Descripcion;
            txtCantidad.Text = _Articulo.Descripcion;
            txtGanancia.Text = _Articulo.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo.ABM(2,null,this,descripcion, Grilla);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Cancelar(this);
        }
    }
}
