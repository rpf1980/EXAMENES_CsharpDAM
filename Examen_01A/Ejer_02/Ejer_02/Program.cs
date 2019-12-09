using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe numerador 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe denominador 2: ");
            int den1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Escribe numerador 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Escribe denominador 2: ");
            int den2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Fraccion f = new Fraccion(num1, den1);

            Fraccion fraccion = new Fraccion(num2, den2);

            Fraccion res = f.Sumar(fraccion);

            Fraccion res2 = f.Multiplicar(fraccion);

            Console.WriteLine($"SUMA = {res.Mostrar()}");
            Console.WriteLine($"MULTIPLICACIÓN = {res2.Mostrar()}");

            Console.ReadKey();

        }
    }
}
