using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace Ejerc_01
{
    public partial class FormBuscarPiso : Form
    {
        FileStream fichero = null;
        string nombreFichero = "data.xml";
        Piso piso = null;
        Inmobiliaria inmobiliaria = new Inmobiliaria();
        Inmobiliaria objetosPisosMostrar = new Inmobiliaria();
        public FormBuscarPiso()
        {
            InitializeComponent();
        }

        //Btn BUSCAR
        private void button1_Click(object sender, EventArgs e)
        {
            //Guardamos string del Valor para el criterio
            string valorCriterio = idTxtCriterio.Text;
            
            //Leemos el xml
            try
            {
                fichero = new FileStream(nombreFichero, FileMode.Open);
                XmlSerializer format = new XmlSerializer(inmobiliaria.GetType());
                inmobiliaria = (Inmobiliaria)format.Deserialize(fichero);
                fichero.Close();

                for (int i = 0; i < inmobiliaria.ListaPisos1.Count; i++)
                {
                    //Si el check superficie está clicado y el valor superficie del objeto piso es igual al string del valor criterio insertado en el campo textbox
                    if (checkSuperficie.Checked && inmobiliaria.ListaPisos1[i].Superficie == float.Parse(valorCriterio))
                    {
                        richTextBox.Text += inmobiliaria.ListaPisos1[i].Mostrar() + "\n";
                    }
                    else
                    {
                        if(checkOrientacion.Checked && inmobiliaria.ListaPisos1[i].Orientacion.Equals(valorCriterio))
                        {
                            richTextBox.Text += inmobiliaria.ListaPisos1[i].Mostrar() + "\n";
                        }
                        else
                        {
                            if(checkPrecio.Checked && inmobiliaria.ListaPisos1[i].Precio == double.Parse(valorCriterio))
                            {
                                richTextBox.Text += inmobiliaria.ListaPisos1[i].Mostrar() + "\n";                                
                            }
                            
                        }
                    }
                }             
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            
        }
    }
}
