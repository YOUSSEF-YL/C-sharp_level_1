using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Atelier_15
{
   public class Emission
    {
        public int NumEmission { get; set; }

        public string Nom { get; set; }

        public DateTime DateEmission { get; set; }

        public string Heur { get; set; }

       
        public string Duree { get; set; }

        public string TypeEmission { get; set; }

        public Emission(int NumEmission, string Nom, DateTime DateEmission, string Heur, string Duree, string TypeEmission)
        {
            this.NumEmission = NumEmission;
            this.Nom = Nom;
            this.DateEmission = DateEmission;
            this.Heur = Heur;
            this.Duree  = Duree;
            this.TypeEmission = TypeEmission;

        }

       
       
        public Emission()
        {

        }

    }
}
    