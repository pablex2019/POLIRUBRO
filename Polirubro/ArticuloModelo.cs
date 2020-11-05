using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polirubro
{
    public class ArticuloModelo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set; }
        public double Ganancia { get; set; }
        public int Cantidad { get; set; }
    }
}
