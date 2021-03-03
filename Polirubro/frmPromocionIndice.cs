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
    public partial class frmPromocionIndice : Form
    {
        private string id;
        private PromocionesControler Promociones;

        public frmPromocionIndice()
        {
            InitializeComponent();
            Promociones = new PromocionesControler("Promocion");
        }
        private void frmPromocionIndice_Load(object sender, EventArgs e)
        {
            dgvPromocion.DataSource = Promociones.ListadoInicial();
        }
        private void dgvPromocion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvPromocion.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPromocionesAgregar PromocionesAgregar = new frmPromocionesAgregar();
            PromocionesAgregar.Grilla = dgvPromocion;
            PromocionesAgregar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPromocionEditar editar = new frmPromocionEditar();
            editar.Id = Convert.ToInt32(id);
            editar.Grilla = dgvPromocion;
            editar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            //Esblecer el tipo de hoja
            Document doc = new Document(PageSize.A4);
            //Asignamos el contenido del datagridview a una tabla
            PdfPTable pdfTable = new PdfPTable(dgvPromocion.ColumnCount);
            pdfTable.TotalWidth = 100f;
            float[] anchos = new float[] { 10f, 40f, 50f};
            pdfTable.SetWidths(anchos);
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //Recorremos el datagridview para agregar el nombre de las columnas
            foreach (DataGridViewColumn column in dgvPromocion.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 178);
                pdfTable.AddCell(cell);
            }
            //Recorremos el datagridview para agregar el contenido de las filas
            foreach (DataGridViewRow row in dgvPromocion.Rows)
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
            using (FileStream stream = new FileStream(ruta + "Promociones.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
                doc.Add(new Paragraph("Listado de Promociones"));
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(pdfTable);
                doc.Close();
                stream.Close();
            }
        }
    }
}
