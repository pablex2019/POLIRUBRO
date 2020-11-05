using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public partial class frmIniciarSesion : Form
    {
        private UsuarioControler usuario;

        public frmIniciarSesion()
        {
            InitializeComponent();
            usuario = new UsuarioControler("Usuario");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario.ValidarExistencia(txtUsuario.Text, txtClave.Text,this);
        }
    }
}
