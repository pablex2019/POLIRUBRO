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
        public DataGridView Grilla;
        private ArticuloControler articulo;
        private PromocionesControler promocion;
        private MetodosGenericos MetodosGenericos;

        public frmPromocionesAgregar()
        {
            InitializeComponent();
            articulo = new ArticuloControler("Articulo");
            promocion = new PromocionesControler("Promocion");
            MetodosGenericos = new MetodosGenericos();
        }
        private void frmPromocionesAgregar_Load(object sender, EventArgs e)
        {
            cboArticulos.DataSource = articulo.ListadoInicial().Select(x=>x.Descripcion).ToList();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            promocion.ABM(1,this,null,0,Grilla);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Cancelar(this);
        }
    }
}
