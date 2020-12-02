using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public class VentaControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<VentaModelo> ListaVentas { get; set; }
        private string DatosVentas;
        private MetodosGenericos MetodosGenericos { get; set; }

        public VentaControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
            this.MetodosGenericos = new MetodosGenericos();
        }
        private void Leer()
        {
            this.DatosVentas = this.AccesoADatos.Leer();
            this.ListaVentas = this.DatosVentas?.Length > 0 ? JsonConvert.DeserializeObject<List<VentaModelo>>(this.DatosVentas) : new List<VentaModelo>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosVentas = JsonConvert.SerializeObject(this.ListaVentas);
            this.AccesoADatos.Guardar(this.DatosVentas);
        }
        public List<VentaModelo> ListadoInicial()
        {
            Leer();
            return this.ListaVentas.ToList();
        }
        public int ObtenerUltimoID()
        {
            return ListaVentas.Max(x => x.Id) + 1;
        }
        public List<VentaModelo>ListadoFiltrado(string fechaDesde, string fechaHasta)
        {
            return ListaVentas.Where(x => x.Fecha.Contains(fechaDesde) && x.Fecha.Contains(fechaHasta)).ToList();
        }
        public void ABM(VentaModelo venta)
        {
            Leer();
            if(this.ListaVentas.Count()==0)
            {
                venta.Id = 1;
                this.ListaVentas.Add(venta);
                Guardar();
            }
            else
            {
                venta.Id = ObtenerUltimoID();
                this.ListaVentas.Add(venta);
                Guardar();
            }
            MessageBox.Show("Venta agregada","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
