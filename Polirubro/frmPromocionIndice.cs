﻿using System;
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
    public partial class frmPromocionIndice : Form
    {
        private string id;

        public frmPromocionIndice()
        {
            InitializeComponent();
        }
        private void dgvPromocion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvPromocion.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmPromocionesAgregar().Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
