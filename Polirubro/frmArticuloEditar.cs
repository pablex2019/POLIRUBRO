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
<<<<<<< HEAD
        public string descripcion;
=======
        public int Id;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
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
<<<<<<< HEAD
            var _Articulo = Articulo.ObtenerArticulo(descripcion);
            txtDescripcion.Text = _Articulo.Descripcion;
            txtPrecioCosto.Text = _Articulo.Descripcion;
            txtPrecioVenta.Text = _Articulo.Descripcion;
            txtCantidad.Text = _Articulo.Descripcion;
            txtGanancia.Text = _Articulo.Descripcion;
=======
            var _Articulo = Articulo.ObtenerArticulo(Id);
            txtDescripcion.Text = _Articulo.Descripcion;
            txtPrecioCosto.Text = _Articulo.PrecioCosto.ToString();
            txtPrecioVenta.Text = _Articulo.PrecioVenta.ToString();
            txtCantidad.Text = _Articulo.Cantidad.ToString();
            txtGanancia.Text = _Articulo.Ganancia.ToString();
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Articulo.ABM(2,null,this,descripcion, Grilla);
=======
            Articulo.ABM(2,null,this,Id, Grilla);
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Cancelar(this);
        }
    }
}
