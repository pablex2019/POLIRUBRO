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
        private string descripcion;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticuloAgregar Agregar = new frmArticuloAgregar();
            Agregar.Grilla = dataGridView1;
            Agregar.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                descripcion = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(descripcion))
            {
                frmArticuloEditar Editar = new frmArticuloEditar();
                Editar.descripcion = descripcion;
                Editar.Show();
            }
        }
    }
}
