using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_03
{
    public partial class Form1 : Form
    {
        Fraccion fraccion1 = new Fraccion();
        Fraccion fraccion2 = new Fraccion();                

        public Form1()
        {
            InitializeComponent();
        }

        //Btn MOSTRAR FRACCIÓN 1
        private void button1_Click(object sender, EventArgs e)
        {
            int strNumerador1 = Convert.ToInt32(idTxtNum1.Text);
            int strDenominador1 = Convert.ToInt32(idTxtDen1.Text);

            fraccion1.Numerador = strNumerador1;
            fraccion1.Denominador = strDenominador1;

            idTxtFracc1.Text = fraccion1.Mostrar();
        }

        //Btn MOSTRAR FRACCIÓN 2
        private void button2_Click(object sender, EventArgs e)
        {
            int strNumerador2 = Convert.ToInt32(idTxtNum2.Text);
            int strDenominador2 = Convert.ToInt32(idTxtDen2.Text);

            fraccion2.Numerador = strNumerador2;
            fraccion2.Denominador = strDenominador2;

            idTxtFracc2.Text = fraccion2.Mostrar();
        }

        //Btn SUMAR 
        private void button3_Click(object sender, EventArgs e)
        {
            //Fracción 1
            int strNumerador1 = Convert.ToInt32(idTxtNum1.Text);
            int strDenominador1 = Convert.ToInt32(idTxtDen1.Text);

            fraccion1.Numerador = strNumerador1;
            fraccion1.Denominador = strDenominador1;

            //Fracción 2
            int strNumerador2 = Convert.ToInt32(idTxtNum2.Text);
            int strDenominador2 = Convert.ToInt32(idTxtDen2.Text);

            fraccion2.Numerador = strNumerador2;
            fraccion2.Denominador = strDenominador2;

            idTxtSuma.Text = fraccion1.Sumar(fraccion2).Mostrar();
        }

        //Btn PRODUCTO
        private void button4_Click(object sender, EventArgs e)
        {
            //Fracción 1
            int strNumerador1 = Convert.ToInt32(idTxtNum1.Text);
            int strDenominador1 = Convert.ToInt32(idTxtDen1.Text);

            fraccion1.Numerador = strNumerador1;
            fraccion1.Denominador = strDenominador1;

            //Fracción 2
            int strNumerador2 = Convert.ToInt32(idTxtNum2.Text);
            int strDenominador2 = Convert.ToInt32(idTxtDen2.Text);

            idTxtProducto.Text = fraccion1.Multiplicar(fraccion2).Mostrar();
        }
    }
}
