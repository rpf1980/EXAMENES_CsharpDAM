using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Btn EXPLORAR
        private void idBtnExplorar_Click(object sender, EventArgs e)
        {

        }

        //Métodos aparte
        public bool ValidaRuta(string ruta)
        {
            bool rutaValida = false;

            if(ruta.Contains(":"))
            {
                string[] copia = ruta.Split(':');

                char[] parseChar = copia[0].ToCharArray();
                
                if(Char.IsUpper(parseChar[0]))
                {
                    rutaValida = true;
                }
                
            }

            return rutaValida;
        }
    }
}
