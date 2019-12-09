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
        Complejo objeto1 = new Complejo();
        Complejo objeto2 = new Complejo();

        public Form1()
        {
            InitializeComponent();
        }

        //Btn MOSTRAR COMPLEJO 1
        private void button1_Click(object sender, EventArgs e)
        {
            objeto1.ParteReal = int.Parse(idTxtReal1.Text);
            objeto1.ParteImaginaria = int.Parse(idTxtImag1.Text);

            idTxtComplejo1.Text = objeto1.Mostrar();
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

        //Btn MOSTRAR COMPLEJO 2
        private void button2_Click(object sender, EventArgs e)
        {
            objeto2.ParteReal = int.Parse(idTxtReal2.Text);
            objeto2.ParteImaginaria = int.Parse(idTxtImag2.Text);

            idTxtComplejo2.Text = objeto2.Mostrar();
        }

        //Btn SUMA
        private void button3_Click(object sender, EventArgs e)
        {
            objeto1.ParteReal = int.Parse(idTxtReal1.Text);
            objeto1.ParteImaginaria = int.Parse(idTxtImag1.Text);
            objeto2.ParteReal = int.Parse(idTxtReal2.Text);
            objeto2.ParteImaginaria = int.Parse(idTxtImag2.Text);

            Complejo resultado = new Complejo();

            idTxtSuma.Text = resultado.Sumar(objeto1, objeto2).Mostrar();
        }

        //Btn PRODUCTO
        private void button4_Click(object sender, EventArgs e)
        {
            objeto1.ParteReal = int.Parse(idTxtReal1.Text);
            objeto1.ParteImaginaria = int.Parse(idTxtImag1.Text);
            objeto2.ParteReal = int.Parse(idTxtReal2.Text);
            objeto2.ParteImaginaria = int.Parse(idTxtImag2.Text);

            Complejo resultado = new Complejo();

            idTxtProducto.Text = resultado.Multiplicar(objeto1, objeto2).Mostrar();
        }
    }
}
