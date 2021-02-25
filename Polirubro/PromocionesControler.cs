using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool Existe(frmPromocionesAgregar PromocionAgregar)
        {
            return this.ListaPromociones.Any(x => x.Descripcion == PromocionAgregar.cboArticulos.Text);
        }
        public int ObtenerUltimoID()
        {
            return ListaPromociones.Max(x => x.Id) + 1;
        }
        public PromocionModelo ObtenerPromocion(int id)
        {
            Leer();
            return this.ListaPromociones.Where(x => x.Id == id).FirstOrDefault();
        }
        public List<PromocionModelo> ListadoInicial()
        {
            Leer();
            return this.ListaPromociones.ToList();
        }
        public void ABM(int Operacion, frmPromocionesAgregar PromocionesAgregar, frmArticuloEditar ArticuloEditar, int Id, DataGridView Grilla)
        {
            Leer();
            switch (Operacion)
            {
                case 1://Alta
                    PromocionModelo Promocion = new PromocionModelo();
                    if (ListaPromociones.Count > 0)
                    {
                        if (Existe(PromocionesAgregar) != true)
                        {
                            Promocion.Id = ObtenerUltimoID();
                            Promocion.Articulo = PromocionesAgregar.cboArticulos.Text;
                            Promocion.Descripcion = PromocionesAgregar.rtbDescripcion.Text;
                            this.ListaPromociones.Add(Promocion);
                            Guardar();
                            MetodosGenericos.LimpiarCampos(PromocionesAgregar);
                            Grilla.DataSource = ListadoInicial();
                        }
                    }
                    else
                    {
                        Promocion.Id = 1;
                        Promocion.Articulo = PromocionesAgregar.cboArticulos.Text;
                        Promocion.Descripcion = PromocionesAgregar.rtbDescripcion.Text;
                        this.ListaPromociones.Add(Promocion);
                        Guardar();
                        MetodosGenericos.LimpiarCampos(PromocionesAgregar);
                        Grilla.DataSource = ListadoInicial();
                    }
                    MessageBox.Show("Promocion Agregada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2://Edicion
                    var _Promocion = ObtenerPromocion(Id);
                    
                    Guardar();
                    MessageBox.Show("Promocion Editada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Grilla.DataSource = ListadoInicial();
                    break;
                case 3://Baja
                    var _Arti = ObtenerPromocion(Id);
                    this.ListaPromociones.Remove(_Arti);
                    Guardar();
                    MessageBox.Show("Promocion Eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Grilla.DataSource = ListadoInicial();
                    break;
            }
        }
    }
}
