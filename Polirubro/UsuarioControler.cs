using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Polirubro
{
    public class UsuarioControler
    {
        private string Archivo { get; set; }
        private AccesoADatos AccesoADatos { get; set; }
        private List<UsuarioModelo>ListaUsuarios { get; set; }
        private string DatosUsuarios;

        public UsuarioControler(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.AccesoADatos = new AccesoADatos(this.Archivo);
        }
        private void Leer()
        {
            this.DatosUsuarios = this.AccesoADatos.Leer();
            this.ListaUsuarios = this.DatosUsuarios?.Length > 0 ? JsonConvert.DeserializeObject<List<UsuarioModelo>>(this.DatosUsuarios) : new List<UsuarioModelo>();
        }
        private void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosUsuarios = JsonConvert.SerializeObject(this.ListaUsuarios);
            this.AccesoADatos.Guardar(this.DatosUsuarios);
        }
        public void ValidarExistencia(string NombreUsuario,string Clave,frmIniciarSesion inicio)
        {
            if(!string.IsNullOrEmpty(NombreUsuario) && !string.IsNullOrEmpty(Clave))
            {
                Leer();
                UsuarioModelo usuario = new UsuarioModelo();
                if (ListaUsuarios.Count > 0)
                {
                    if(ListaUsuarios.Any(x => x.NombreUsuario == NombreUsuario && x.Clave == Clave)==true)
                    {
                        MessageBox.Show("Bienvenido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio.Hide();
                        inicio.ShowInTaskbar = false;
                        new frmPanel().Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña Invalida/o", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    usuario.Id = 1;
                    usuario.NombreUsuario = "proda";
                    usuario.Clave = "test";
                    this.ListaUsuarios.Add(usuario);
                    Guardar();
                    MessageBox.Show("Se agrego un nuevo usuario, debido a que no existia ninguno", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin completar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
