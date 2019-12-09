using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_01
{
    class Piso
    {
        //Atributos
        private int id;
        private string direccion;
        private float superficie;
        private string orientacion;
        private double precio;

        //Constructores
        public Piso() { }

        public Piso(int id, string direccion, float superficie, string orientacion, double precio)
        {
            this.Id = id;
            this.Direccion = direccion;
            this.Superficie = superficie;
            this.Orientacion = orientacion;
            this.Precio = precio;
        }

        //Getters && Setters
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Superficie { get => superficie; set => superficie = value; }
        public string Orientacion { get => orientacion; set => orientacion = value; }
        public double Precio { get => precio; set => precio = value; }

        //Método toString
        public string Mostrar()
        {
            return $"DIRECCIÓN:    {this.Direccion}\n" +
                   $"SUPERFICIE:   {this.Superficie}\n" +
                   $"ORIENTACIÓN:  {this.Orientacion}\n" +
                   $"PRECIO:       {this.Precio}";
        }
    }
}
