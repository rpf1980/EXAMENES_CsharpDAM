﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo comp1 = new Complejo(4, 5);
            Complejo comp2 = new Complejo(2, 7);
            Complejo res = new Complejo();

            Console.WriteLine($"SUMA = {res.Sumar(comp1, comp2).Mostrar()}");
            Console.WriteLine($"PRODUCTO = {res.Multiplicar(comp1, comp2).Mostrar()}");
          
            Console.ReadKey();
        }
    }
}
