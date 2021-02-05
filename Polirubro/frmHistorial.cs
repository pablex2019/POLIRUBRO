using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            double montoPabloWalter = ((gananciaTotal-montoAdrian)/2);
            textBox2.Text = Convert.ToString(montoAdrian);
            textBox3.Text = Convert.ToString(montoPabloWalter);
            textBox4.Text = Convert.ToString(montoPabloWalter);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            //Esblecer el tipo de hoja
            Document doc = new Document(PageSize.A4);
            //Asignamos el contenido del datagridview a una tabla
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.TotalWidth = 215f;
            float[] anchos = new float[] { 10f, 70f, 45f, 45f, 35f};
            pdfTable.SetWidths(anchos);
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //Recorremos el datagridview para agregar el nombre de las columnas
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 178);
                pdfTable.AddCell(cell);
            }
            //Recorremos el datagridview para agregar el contenido de las filas
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            //Exportar el PDF
            string ruta = @"C:\Users\practiaglobal\Desktop\Emprendimiento\POLIRUBRO\Reportes\";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (FileStream stream = new FileStream(ruta + "Ventas.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
                doc.Add(new Paragraph("Ventas "+ dtpFechaDesde.Text.ToString()+" al "+dtpFechaHasta.Text.ToString()));
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(pdfTable);
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(new Paragraph("Venta Total: "+txtVentaTotal.Text));
                doc.Add(new Paragraph("Costo Total: " + txtCostoTotal.Text));
                doc.Add(new Paragraph("Ganancia Total: " + txtGananciaTotal.Text));
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(new Paragraph("Ganancias"));
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(new Paragraph("Adrian: "+textBox2.Text));
                doc.Add(new Paragraph("Walter: "+textBox3.Text));
                doc.Add(new Paragraph("Pablo: "+textBox4.Text));
                doc.Close();
                stream.Close();
            }
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
