using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polirubro
{
    public class UsuarioControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<UsuarioModelo>ListaArticulos { get; set; }
        private string DatosArchivos;

        public UsuarioControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
        }
        private void Leer()
        {
            this.DatosArchivos = this.AccesoADatos.Leer();
            this.ListaArticulos = this.DatosArchivos?.Length > 0 ? JsonConvert.DeserializeObject<List<UsuarioModelo>>(this.DatosArchivos) : new List<UsuarioModelo>();
        }
        public List<UsuarioModelo> ListadoInicial()
        {
            Leer();
            return this.ListaArticulos;
        }
    }
}
