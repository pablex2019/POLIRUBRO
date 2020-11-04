using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polirubro
{
    public class ArticuloControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<ArticuloModelo> ListaArticulos { get; set; }
        private string DatosArticulos;

        public ArticuloControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
        }
        private void Leer()
        {
            this.DatosArticulos = this.AccesoADatos.Leer();
            this.ListaArticulos = this.DatosArticulos?.Length > 0 ? JsonConvert.DeserializeObject<List<ArticuloModelo>>(this.DatosArticulos) : new List<ArticuloModelo>();
        }
        private void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosArticulos = JsonConvert.SerializeObject(this.ListaArticulos);
            this.AccesoADatos.Guardar(this.DatosArticulos);
        }
        public List<ArticuloModelo> ListadoInicial()
        {
            Leer();
            return this.ListaArticulos.ToList();
        }
        public void ABM()
        {

        }
    }
}
