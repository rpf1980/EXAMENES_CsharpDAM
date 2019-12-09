using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_03
{
    class Fraccion
    {
        //Atributos
        private int numerador = 0;
        private int denominador = 0;

        public int Numerador { get => numerador; set => numerador = value; }
        public int Denominador { get => denominador; set => denominador = value; }

        //Constructores
        public Fraccion() { }

        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }



        //Métodos
        public string Mostrar()
        {
            return $"{Numerador}/{Denominador}";
        }

        public Fraccion Sumar(Fraccion f)
        {
            int den = Mcm(this.denominador, f.denominador);
            int num = (this.numerador * (den / this.denominador) + (f.numerador * (den / f.denominador)));
            Fraccion fr = new Fraccion(num, den);

            return fr;
        }

        public Fraccion Multiplicar(Fraccion f)
        {
            int num, den;

            num = this.numerador * f.numerador;
            den = this.denominador * f.denominador;

            Fraccion fr = new Fraccion(num, den);
            return fr;
        }

        //Métodos aparte
        public int Mcm(int a, int b)
        {
            int multiplo;

            //Seleccionamos el mayor de los dos
            if (a > b)
            {
                multiplo = a;
            }
            else
            {
                multiplo = b;
            }

            //Ahora vamos comprobando si ese número es el mcm
            //o son los sucesivos superiores a él
            while (multiplo % a != 0 || multiplo % b != 0)
            {
                multiplo++;
            }

            //Para salir del bucle debe cumplirse;
            //- multiplo es un número múltiplo de a y b simultáneamente

            return multiplo;
        }

    }
}
