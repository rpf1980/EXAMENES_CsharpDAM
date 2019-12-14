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
    public partial class FormAddPiso : Form
    {
        int strId = 0;
        string strDireccion = "";
        float strSuperficie = 0;
        string strOrientacion = "";
        double strPrecio = 0;

        FileStream fichero = null;
        string nombreFichero = "data.xml";
        Piso piso = null;
        Inmobiliaria inmobiliaria = new Inmobiliaria();

        public FormAddPiso()
        {
            InitializeComponent();
        }

        //Btn SALIR
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn LIMPIAR
        private void button1_Click(object sender, EventArgs e)
        {           
            idTxtID.Text = "";
            idTxtDireccion.Text = "";
            idTxtSuperf.Text = "";
            idTxtPrecio.Text = "";
            idComboBox.Text = "";
        }

        private void idTxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        
        private void idTxtSuperf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }
       
        private void idTxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        //Btn AÑADIR 
        private void button2_Click(object sender, EventArgs e)
        {
            //Capturamos los strings de los campos del registro
            strId = int.Parse(idTxtID.Text);
            strDireccion = idTxtDireccion.Text;
            strSuperficie = float.Parse(idTxtSuperf.Text);
            strOrientacion = idComboBox.Text;
            strPrecio = double.Parse(idTxtPrecio.Text);
                      
            try
            {
                //Asignamos los valores al objeto piso
                piso = new Piso();
                piso.Id = strId;
                piso.Direccion = strDireccion;
                piso.Superficie = strSuperficie;
                piso.Orientacion = strOrientacion;
                piso.Precio = strPrecio;

                //Comprobamos la existencia del fichero
                if(!File.Exists(nombreFichero))
                {
                    //Como no existe el fichero:

                    //Creamos el fichero
                    fichero = new FileStream(nombreFichero, FileMode.Create);
                    inmobiliaria.AddPiso(piso); //Añadimos el piso a la lista de pisos

                    //Creamos el formateador XML
                    XmlSerializer format = new XmlSerializer(inmobiliaria.GetType());
                    format.Serialize(fichero, inmobiliaria); //Serializamos el registro de datos
                    fichero.Close();
                }
                else
                {
                    //Pero... si el fichero ya existe:

                    //1. Abrimos y deserializamos todo el xml
                    fichero = new FileStream(nombreFichero, FileMode.Open);
                    XmlSerializer format = new XmlSerializer(inmobiliaria.GetType());
                    inmobiliaria = (Inmobiliaria)format.Deserialize(fichero);
                    fichero.Close();

                    //2. Abrimos y serializamos el nuevo objeto de lista de pisos generado ( objeto que tiene un nuevo registro de piso )
                    fichero = new FileStream(nombreFichero, FileMode.Create);
                    inmobiliaria.AddPiso(piso);
                    XmlSerializer format2 = new XmlSerializer(inmobiliaria.GetType());
                    format2.Serialize(fichero, inmobiliaria);
                    fichero.Close();
                }
                MessageBox.Show("¡ Registro Ok !");
            }
            catch(Exception ex)
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
