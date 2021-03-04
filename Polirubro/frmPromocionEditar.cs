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
    public partial class frmPromocionEditar : Form
    {
        public int Id;
        public DataGridView Grilla;
        private MetodosGenericos MetodosGenericos;
        private PromocionesControler Promocion;
        private ArticuloControler Articulo;

        public frmPromocionEditar()
        {
            InitializeComponent();
            Promocion = new PromocionesControler("Promocion");
            MetodosGenericos = new MetodosGenericos();
            Articulo = new ArticuloControler("Articulo");
        }

        private void frmPromocionEditar_Load(object sender, EventArgs e)
        {
            var _Promocion = Promocion.ObtenerPromocion(Id);
            cboArticulos.DataSource = Articulo.ListadoInicial().Select(x=>x.Descripcion).ToList();
            cboArticulos.SelectedIndex = _Promocion.Id;
            rtbDescripcion.Text = _Promocion.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Promocion.ABM(2, null, this, Id, Grilla);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Cancelar(this);
        }
    }
}
