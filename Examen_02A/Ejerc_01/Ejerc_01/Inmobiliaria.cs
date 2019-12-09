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
    class Inmobiliaria
    {
        public List<Piso> ListaPisos { get; set; }

        //Métodos
        public void AddPiso(Piso piso)
        {
            ListaPisos.Add(piso);
        }
    }
}
