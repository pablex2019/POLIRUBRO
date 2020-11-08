<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Utilities.IO;
using System;
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
using System.IO;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public partial class frmArticuloIndice : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private string descripcion;
=======
        private int Id;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
        private int Id;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
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
<<<<<<< HEAD
<<<<<<< HEAD
                descripcion = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
=======
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            if(!string.IsNullOrEmpty(descripcion))
            {
                frmArticuloEditar Editar = new frmArticuloEditar();
                Editar.descripcion = descripcion;
                Editar.Show();
            }
        }
=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            if(Id!=0)
            {
                frmArticuloEditar Editar = new frmArticuloEditar();
                Editar.Id = Id;
                Editar.Grilla = dataGridView1;
                Editar.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                articulo.ABM(3, null, null, Id, dataGridView1);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            //Esblecer el tipo de hoja
            Document doc = new Document(PageSize.A4);
            //Asignamos el contenido del datagridview a una tabla
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.TotalWidth = 250f;
            float[] anchos = new float[] { 10f, 70f, 45f, 45f, 35f, 35f };
            pdfTable.SetWidths(anchos);
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //Recorremos el datagridview para agregar el nombre de las columnas
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 178);
                pdfTable.AddCell(cell);
            }
            //Recorremos el datagridview para agregar el contenido de las filas
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            //Exportar el PDF
            string ruta = @"C:\Users\pablo\Desktop\Documentos\Proyectos\POLIRUBRO\Reportes\";
            if(!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (FileStream stream = new FileStream(ruta + "Articulos.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
                doc.Add(new Paragraph("Listado de Articulos"));
                doc.Add(new Paragraph(Chunk.NEWLINE));
                doc.Add(pdfTable);
                doc.Close();
                stream.Close();
            }
        }
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
    }
}
