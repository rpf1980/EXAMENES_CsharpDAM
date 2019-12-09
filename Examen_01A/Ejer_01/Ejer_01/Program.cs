using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejer_01
{
    class Program
    {
        //Método que quita acentos de las vocales
        static string QuitaAcentos(string cadena)
        {
            string copia = cadena;           
            string con = "áéíóúäü";
            string sin = "aeiouau";
            int numeroElementos = con.Length;

            for (int i = 0; i < numeroElementos; i++)
            {
                copia = copia.Replace(con[i], sin[i]);
            }

            return copia;
        }

        //Método que comprueba si hay 4 o más vocales diferentes en una palabra
        static bool CuatroVocalesOmas(string palabra)
        {
            bool palabraOk = false;
            string vocales = "aeiou";
            string strSinRepetir = "";
            string copia = palabra.Trim().ToLower();

            for (int i = 0; i < copia.Length; i++)
            {
                for (int j = 0; j < vocales.Length; j++)
                {
                    if(!strSinRepetir.Contains(copia[i]) && copia[i] == vocales[j])
                    {
                        strSinRepetir = strSinRepetir + copia[i];
                    }
                }
            }

            if(strSinRepetir.Length > 3)
            {
                palabraOk = true;
            }

            return palabraOk;
        }

        static int ValidaArray(string[] array)
        {
            int res = 0;
            string palabra = "";

            for (int i = 0; i < array.Length; i++)
            {
                palabra = array[i];

                if(CuatroVocalesOmas(palabra))
                {
                    res++;
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            //Pedimos la frase al usuario
            Console.WriteLine("Escribe una frase:");
            string frase = Console.ReadLine();

            //Palabras que tiene la frase
            string[] array = frase.Split(' ');
            Console.WriteLine($"La frase contiene {array.Length} palabras");

            //Número de palabras con 4 o más vocales diferentes
            int nPalabrasOk = ValidaArray(array);
            Console.WriteLine($"La frase contiene {nPalabrasOk} palabra/s que cumplen la regla");

            Console.ReadKey();
        }
    }
}
