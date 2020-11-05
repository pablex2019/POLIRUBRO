using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polirubro
{
    public class MetodosGenericos
    {
        //Cancelar
        public void Cancelar(Control _Control)
        {
            DialogResult resultado = MessageBox.Show("¿ Esta seguro de cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch(resultado)
            {
                case DialogResult.Yes:
                    _Control.Hide();
                    break;
            }
        }
        //Limpiar Campos de los Formularios
        public void LimpiarCampos(Control control)
        {
            foreach(var i in control.Controls)
            {
                if(i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
            }
        }
    }
}
