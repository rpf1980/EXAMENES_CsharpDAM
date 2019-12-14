using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc_02
{
    class Validar
    {
        public static void ValidaRutaFichero(KeyPressEventArgs v)
        {
            if(Char.IsLetter(v.KeyChar) && Char.IsUpper(v.KeyChar))
            {
                v.Handled = false;
            }

        }
    }
}
