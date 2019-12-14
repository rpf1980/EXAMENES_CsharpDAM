using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

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

        //Métodos
        public void AddPiso(Piso piso)
        {
            this.ListaPisos.Add(piso);
        }

        public Piso BuscaPiso(string criterio)
        {
            Piso piso = null;

            for (int i = 0; i < this.ListaPisos.Count; i++)
            {
                if (this.ListaPisos[i].Superficie == float.Parse(criterio) || this.ListaPisos[i].Orientacion == criterio || this.ListaPisos[i].Precio == double.Parse(criterio))
                {
                    piso = this.ListaPisos[i];
                }
            }

            return piso;
        }
    }
}
