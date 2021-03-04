using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public class ArticuloControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<ArticuloModelo> ListaArticulos { get; set; }
        private string DatosArticulos;
        private MetodosGenericos MetodosGenericos { get; set; }

        public ArticuloControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
            this.MetodosGenericos = new MetodosGenericos();
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
<<<<<<< HEAD
<<<<<<< HEAD
        public ArticuloModelo ObtenerArticulo(string Descripcion)
        {
            Leer();
            return this.ListaArticulos.Where(x => x.Descripcion == Descripcion).FirstOrDefault();
=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        public ArticuloModelo ObtenerArticulo(int id)
        {
            Leer();
            return this.ListaArticulos.Where(x => x.Id == id).FirstOrDefault();
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        }
        public bool Existe(frmArticuloAgregar ArticuloAgregar)
        {
            return this.ListaArticulos.Any(x => x.Descripcion == ArticuloAgregar.txtDescripcion.Text);
        }
        public int ObtenerUltimoID()
        {
            return ListaArticulos.Max(x => x.Id) + 1;
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public void ABM(int Operacion,frmArticuloAgregar ArticuloAgregar,frmArticuloEditar ArticuloEditar,string descripcion,DataGridView Grilla)
        {
            Leer();
            switch(Operacion)
            {
                case 1://Alta
                    if(ListaArticulos.Count>0)
                    {
                        if(Existe(ArticuloAgregar)!=true)
                        {
                            ArticuloModelo Articulo = new ArticuloModelo();
=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        public void ABM(int Operacion,frmArticuloAgregar ArticuloAgregar,frmArticuloEditar ArticuloEditar,int Id,DataGridView Grilla)
        {
            Leer();
            switch (Operacion)
            {
                case 1://Alta
                    ArticuloModelo Articulo = new ArticuloModelo();
                    if (ListaArticulos.Count>0)
                    {
                        if(Existe(ArticuloAgregar)!=true)
                        {
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
                            Articulo.Id = ObtenerUltimoID();
                            Articulo.Descripcion = ArticuloAgregar.txtDescripcion.Text;
                            Articulo.PrecioCosto = Convert.ToDouble(ArticuloAgregar.txtPrecioCosto.Text);
                            Articulo.PrecioVenta = Convert.ToDouble(ArticuloAgregar.txtPrecioVenta.Text);
                            Articulo.Cantidad = Convert.ToInt32(ArticuloAgregar.txtCantidad.Text);
                            Articulo.Ganancia = Convert.ToDouble(ArticuloAgregar.txtGanancia.Text);
                            this.ListaArticulos.Add(Articulo);
                            Guardar();
                            MetodosGenericos.LimpiarCampos(ArticuloAgregar);
                            Grilla.DataSource = ListadoInicial();
                        }
                    }
                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                        ArticuloModelo Articulo = new ArticuloModelo();
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
                        Articulo.Id = 1;
                        Articulo.Descripcion = ArticuloAgregar.txtDescripcion.Text;
                        Articulo.PrecioCosto = Convert.ToDouble(ArticuloAgregar.txtPrecioCosto.Text);
                        Articulo.PrecioVenta = Convert.ToDouble(ArticuloAgregar.txtPrecioVenta.Text);
                        Articulo.Cantidad = Convert.ToInt32(ArticuloAgregar.txtCantidad.Text);
                        Articulo.Ganancia = Convert.ToDouble(ArticuloAgregar.txtGanancia.Text);
                        this.ListaArticulos.Add(Articulo);
                        Guardar();
                        MessageBox.Show("Articulo Agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MetodosGenericos.LimpiarCampos(ArticuloAgregar);
                        Grilla.DataSource = ListadoInicial();
                    }
                    break;
                case 2://Edicion
<<<<<<< HEAD
<<<<<<< HEAD
                        var Articulo = ObtenerArticulo(descripcion);
                        Articulo.Descripcion = ArticuloEditar.txtDescripcion.Text;
                        Articulo.PrecioCosto = Convert.ToDouble(ArticuloEditar.txtPrecioCosto.Text);
                        Articulo.PrecioVenta = Convert.ToDouble(ArticuloEditar.txtPrecioVenta.Text);
                        Articulo.Cantidad = Convert.ToInt32(ArticuloEditar.txtCantidad.Text);
                        Articulo.Ganancia = Convert.ToDouble(ArticuloEditar.txtGanancia.Text);
                        Guardar();
                        MessageBox.Show("Articulo Editado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3://Baja

=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
                        var _Articulo = ObtenerArticulo(Id);
                        _Articulo.Descripcion = ArticuloEditar.txtDescripcion.Text;
                        _Articulo.PrecioCosto = Convert.ToDouble(ArticuloEditar.txtPrecioCosto.Text);
                        _Articulo.PrecioVenta = Convert.ToDouble(ArticuloEditar.txtPrecioVenta.Text);
                        _Articulo.Cantidad = Convert.ToInt32(ArticuloEditar.txtCantidad.Text);
                        _Articulo.Ganancia = Convert.ToDouble(ArticuloEditar.txtGanancia.Text);
                        Guardar();
                        MessageBox.Show("Articulo Editado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Grilla.DataSource = ListadoInicial();
                    break;
                case 3://Baja
                        var _Arti = ObtenerArticulo(Id);
                        this.ListaArticulos.Remove(_Arti);
                        Guardar();
                        MessageBox.Show("Articulo Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Grilla.DataSource = ListadoInicial();
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
                    break;
            }
        }
    }
}
