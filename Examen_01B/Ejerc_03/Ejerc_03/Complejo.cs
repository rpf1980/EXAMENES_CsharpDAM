using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_03
{
    class Complejo
    {
        //Atributos
        private int parteReal;
        private int parteImaginaria;

        //Constructores
        public Complejo() { }

        public Complejo(int parteReal, int parteImaginaria)
        {
            this.ParteReal = parteReal;
            this.ParteImaginaria = parteImaginaria;
        }

        //Propiedades de los atributos ( Getters && Setters )
        public int ParteReal { get => parteReal; set => parteReal = value; }
        public int ParteImaginaria { get => parteImaginaria; set => parteImaginaria = value; }

        //Métodos
        public string Mostrar()
        {
            return $"{ParteReal}+{ParteImaginaria}j";
        }

        public Complejo Sumar(Complejo objeto1, Complejo objeto2)
        {
            int res1, res2;

            res1 = objeto1.ParteReal + objeto2.ParteReal;
            res2 = objeto1.ParteImaginaria + objeto2.ParteImaginaria;

            Complejo resultado = new Complejo(res1, res2);

            return resultado;
        }

        public Complejo Multiplicar(Complejo objeto1, Complejo objeto2)
        {
            int real1, real2, imag1, imag2;
            int a, b, c, d;
            int resReal, resImag;

            real1 = objeto1.ParteReal;
            imag1 = objeto1.ParteImaginaria;
            real2 = objeto2.ParteReal;
            imag2 = objeto2.ParteImaginaria;

            a = real1 * real2;
            b = real1 * imag2;
            c = imag1 * real2;
            d = imag1 * imag2;

            resReal = a + (-d);
            resImag = b + c;

            Complejo objetoResultado = new Complejo(resReal, resImag);

            return objetoResultado;
        }
    }
}
