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
    public partial class frmHistorial : Form
    {
        private VentaControler Venta;
        private double costo,ganancia,venta;
        public frmHistorial()
        {
            InitializeComponent();
            Venta = new VentaControler("Venta");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double gananciaTotal = Convert.ToDouble(txtGananciaTotal.Text);
            double porcentaje = Convert.ToDouble(textBox1.Text);
            double montoAdrian = gananciaTotal * porcentaje / 100;
            double montoPabloWalter = montoAdrian / 2;
            textBox2.Text = Convert.ToString(montoAdrian);
            textBox3.Text = Convert.ToString(montoPabloWalter);
            textBox4.Text = Convert.ToString(montoPabloWalter);
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Venta.ListadoInicial();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                venta += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                costo += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                ganancia += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            txtVentaTotal.Text = venta.ToString();
            txtCostoTotal.Text = costo.ToString();
            txtGananciaTotal.Text = ganancia.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dtpFechaDesde.Value.ToString("dd/M/yyyy");
            string fechaHasta = dtpFechaDesde.Value.ToString("dd/M/yyyy");
        }
    }
}
