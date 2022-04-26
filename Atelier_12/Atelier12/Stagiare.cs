using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier12
{
  public  class Stagiare
    {
        public int NumInscript { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Sex { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Module { get; set; }

        public double Note { get; set; }

       

        public Stagiare(int numInscript, string nom, string prenom, string sex, DateTime dateNaissance, int module, double note)
        {
            NumInscript = numInscript;
            Nom = nom;
            Prenom = prenom;
            Sex = sex;
            DateNaissance = dateNaissance;
            Module = module;
            Note = note;
        }
    }
}
