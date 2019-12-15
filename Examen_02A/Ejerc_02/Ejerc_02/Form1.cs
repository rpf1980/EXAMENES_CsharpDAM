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
            FileInfo oFInfo;
            DirectoryInfo oDInfo;
            string[] arrayArchivos;
            string rutaDir = idTxtRuta.Text;

            try
            {
                //Validamos la estructura del string escrito como nombre-ruta del fichero
                if (ValidaRuta(rutaDir))
                {
                    oFInfo = new FileInfo(rutaDir);

                    //Guardamos los fichero existentes dentro de un array
                    arrayArchivos = Directory.GetFiles(rutaDir);

                    //Guardamos el NOMBRE del directorio
                    string nombreDir = Path.GetDirectoryName(rutaDir);

                    //Guardamos RUTA completa del directorio
                    string fullPath = Path.GetFullPath(rutaDir);

                    //Guardamos fecha ÚLTIMO ACCESO del directorio 
                    DateTime lastAcces = Directory.GetLastAccessTime(rutaDir);                    

                    if (Directory.Exists(nombreDir))
                    {
                        //Mostramos en la listBox los nombres de los ficheros encontrados en el directorio
                        foreach (string item in arrayArchivos)
                        {
                            listBox.Items.Add(item);
                        }

                        //Mostramos nombre completo
                        idTxtNombre.Text = fullPath;

                        //Mostramos fecha del último acceso del fichero
                        idTxtFecha.Text = lastAcces.ToString();

                        //Mostramos tamaño del Directorio
                        idTxtTama.Text = oFInfo.Length.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"El fichero no existe");
                    }
                }
                else
                {
                    MessageBox.Show("La ruta ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }                                                  
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
