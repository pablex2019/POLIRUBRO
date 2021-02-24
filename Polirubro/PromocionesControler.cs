using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polirubro
{
    public class PromocionesControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<PromocionModelo> ListaPromociones { get; set; }
        private string DatosPromociones;
        private MetodosGenericos MetodosGenericos { get; set; }

        public PromocionesControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
            this.MetodosGenericos = new MetodosGenericos();
        }
        private void Leer()
        {
            this.DatosPromociones = this.AccesoADatos.Leer();
            this.ListaPromociones = this.DatosPromociones?.Length > 0 ? JsonConvert.DeserializeObject<List<PromocionModelo>>(this.DatosPromociones) : new List<PromocionModelo>();
        }
        private void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosPromociones = JsonConvert.SerializeObject(this.ListaPromociones);
            this.AccesoADatos.Guardar(this.DatosPromociones);
        }
    }
}
