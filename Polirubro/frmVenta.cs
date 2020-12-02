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
    public partial class frmVenta : Form
    {
        private ArticuloControler Articulo;
        private VentaControler Venta;

        private string dato;

        public frmVenta()
        {
            InitializeComponent();
            Articulo = new ArticuloControler("Articulo");
            Venta = new VentaControler("Venta");
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string anio = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString();
            string minuto = DateTime.Now.Minute.ToString();
            string segundo = DateTime.Now.Second.ToString();
            dato = mes + "/" + dia + "/" + anio + " " + hora + ":" + minuto + ":" + segundo;
            txtFecha.Text = dato;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (Articulo.ObtenerArticulo(Convert.ToInt32(txtCodigo.Text)) != null)
                {
                    txtDescripcion.Text = Articulo.ObtenerArticulo(Convert.ToInt32(txtCodigo.Text)).Descripcion;
                    txtPrecioVenta.Text = Articulo.ObtenerArticulo(Convert.ToInt32(txtCodigo.Text)).PrecioVenta.ToString();
                    txtPrecioCosto.Text = Articulo.ObtenerArticulo(Convert.ToInt32(txtCodigo.Text)).PrecioCosto.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double venta = 0.0;
            double costo = 0.0;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtCodigo.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtDescripcion.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtCantidad.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtPrecioCosto.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtPrecioVenta.Text;

            dataGridView1.Rows[n].Cells[5].Value = Convert.ToDouble(Convert.ToDouble(txtPrecioCosto.Text) * Convert.ToDouble(txtCantidad.Text));
            dataGridView1.Rows[n].Cells[6].Value = Convert.ToDouble(Convert.ToDouble(txtPrecioVenta.Text) * Convert.ToDouble(txtCantidad.Text));

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string id = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                string descripcion = dataGridView1.Rows[i].Cells[1].Value.ToString();
                double precioCosto = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                double precioVenta = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                int cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                double subtotalCosto = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                double subtotalVenta = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                venta += subtotalVenta;
                costo += subtotalCosto;
            }
            txtVenta.Text = venta.ToString();
            txtCosto.Text = costo.ToString();
            txtGanancia.Text = Convert.ToString(venta - costo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            double subtotal = 0.0;
            double costo = 0.0;
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                costo += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                subtotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            txtVenta.Text = subtotal.ToString();
            txtCosto.Text = costo.ToString();
            txtGanancia.Text = Convert.ToString(subtotal - costo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            VentaModelo venta = new VentaModelo();
            venta.Fecha = txtFecha.Text;
            venta.Importe = Convert.ToDouble(txtVenta.Text);
            venta.Costo = Convert.ToDouble(txtCosto.Text);
            venta.Ganancia = Convert.ToDouble(txtGanancia.Text);
            Venta.ABM(venta);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            new frmHistorial().Show();
        }
    } 
}
