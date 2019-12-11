using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejerc_01
{
    [Serializable()]
    [XmlRoot("Inmobiliaria")]
    public class Inmobiliaria
    {
        private List<Piso> ListaPisos = new List<Piso>();

        public Inmobiliaria() 
        {
            this.ListaPisos = new List<Piso>();
        }

        public List<Piso> ListaPisos1 { get => ListaPisos; set => ListaPisos = value; }     
    }
}
