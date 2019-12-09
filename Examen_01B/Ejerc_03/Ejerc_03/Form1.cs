using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Btn MOSTRAR COMPLEJO 1
        private void button1_Click(object sender, EventArgs e)
        {          
            
        }

        
        private void idTxtReal1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Validamos el campo REAL 1 con la clase Validar
        private void idTxtReal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        //Validamos el campo IMAGINARIA 1 con la clase Validar
        private void idTxtImag1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        //Validamos el campo REAL 2 con la clase Validar
        private void idTxtReal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        //Validamos el campo IMAGINARIA 2 con la clase Validar
        private void idTxtImag2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e); 
        }
    }
}
