using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Ejerc_01
{
    public partial class AddPisoForm : Form
    {   
        int strId = 0;
        string strDireccion = "";
        float strSuperficie = 0;
        string strOrientacion = "";
        double strPrecio = 0;

        Inmobiliaria inmobiliaria = new Inmobiliaria();

        public AddPisoForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fichero = null;
            Piso piso = null;

            strId = int.Parse(idTxtId.Text);
            strDireccion = idTxtDireccion.Text;
            strSuperficie = float.Parse(idTxtSuperficie.Text);
            strOrientacion = idTxtOrientacion.Text;
            strPrecio = double.Parse(idTxtPrecio.Text);

            try
            {
                piso = new Piso();

                piso.Id = strId;
                piso.Direccion = strDireccion;
                piso.Superficie = strSuperficie;
                piso.Orientacion = strOrientacion;
                piso.Precio = strPrecio;

                if(File.Exists("data.xml"))
                {
                    //COMO YA EXISTE:                                       
                    //4. Machacamos el fichero con la nueva info

                    //1. Abrimos el fichero
                    fichero = new FileStream("data.xml", FileMode.Open);
                    
                    //Creamos formateador XML para la Deserialización del mismo
                    XmlSerializer format = new XmlSerializer(inmobiliaria.GetType());

                    //2. Volcamos todos los objetos piso en una lista de pisos
                    inmobiliaria = (Inmobiliaria)format.Deserialize(fichero);

                    //Cerramos el fichero
                    fichero.Close();

                    //3. Abrimos de nuevo el fichero
                    fichero = new FileStream("data.xml", FileMode.Open);
                    inmobiliaria.AddPiso(piso);
                    XmlSerializer format2 = new XmlSerializer(inmobiliaria.GetType());
                    format2.Serialize(fichero, inmobiliaria);

                    fichero.Close();
                }
                else
                {
                    //COMO NO EXISTE:

                    //1. Creamos el fichero
                    fichero = new FileStream("data.xml", FileMode.Create);
                    inmobiliaria.AddPiso(piso);

                    //Creamos formateador XML
                    XmlSerializer format = new XmlSerializer(inmobiliaria.GetType());
                    format.Serialize(fichero, inmobiliaria);
                    fichero.Close();
                }

                MessageBox.Show("¡ Registro Ok !");

            }
            catch(IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if(fichero != null)
                {
                    fichero.Close();
                }
            }

        }
    }
}
