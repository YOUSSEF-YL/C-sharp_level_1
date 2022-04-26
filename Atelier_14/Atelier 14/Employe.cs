using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_14
{
   public class Employe
    {
        //public int Matricule { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Nom { get; set; }

        public double Salaire { get; set; }

        public string Sexe { get; set; }

        public string SituationFamiale { get; set; }

        public bool EstCommercial { get; set; }

        public Employe( DateTime DateNaissance, string Nom,
            double Salaire, string Sexe, string SituationFamiale, bool EstCommercial)
        {
            //this.Matricule = Matricule;
            this.DateNaissance = DateNaissance;
            this.Nom = Nom;
            this.Sexe = Sexe;
            this.SituationFamiale = SituationFamiale;
            this.Salaire = Salaire;
            this.EstCommercial = EstCommercial;
            

        }


       static public double SalaireNet(double a,double b, double c)
        {
            double net;

            net = a + b + c;
            return net;
        }
    }
}
