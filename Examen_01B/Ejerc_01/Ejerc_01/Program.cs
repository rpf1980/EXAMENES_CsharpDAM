using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_01
{
    class Program
    {
        static string QuitaAcentos(string palabra)
        {
            string copia = palabra.Trim().ToLower();
            string con = "áéíóúü";
            string sin = "aeiouu";
            int numeroIteraciones = con.Length;

            for (int i = 0; i < numeroIteraciones; i++)
            {
                copia = copia.Replace(con[i], sin[i]);
            }

            return copia;
        }

        static bool CuatroVocales(string palabra)
        {
            bool strOk = false;
            string copia = QuitaAcentos(palabra);
            string vocales = "aeiou";
            string strVocalesSinRepetir = "";

            for (int i = 0; i < copia.Length; i++)
            {
                for (int j = 0; j < vocales.Length; j++)
                {
                    if (!strVocalesSinRepetir.Contains(copia[i]) && copia[i] == vocales[j])
                    {
                        strVocalesSinRepetir += copia[i];
                    }
                }
                
            }            

            if(strVocalesSinRepetir.Length > 3)
            {
                strOk = true;
            }

            return strOk;
        }

        static int ValidaArrayPalabras(string[] array)
        {
            int nPalabrasOk = 0;
            string palabra = "";

            for (int i = 0; i < array.Length; i++)
            {
                palabra = array[i];

                if(CuatroVocales(palabra))
                {
                    nPalabrasOk++;
                }
            }

            return nPalabrasOk;
        }

        static void Main(string[] args)
        {
            //Leemos la frase por consola
            Console.WriteLine("Escribe una frase:");
            string frase = Console.ReadLine();

            //Número de palabras de la frase
            string[] array = frase.Split(' ');
            Console.WriteLine($"La frase contiene {array.Length} palabra/s");

            //Número de palabras con al menos 4 vocales diferentes
            Console.WriteLine($"La frase contiene {ValidaArrayPalabras(array)} palabras con 4 o más vocales diferentes");

            Console.ReadKey();
        }
    }
}
