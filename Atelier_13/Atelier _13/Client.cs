using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier__13
{
    public class Client
    {
        public int Nreglement { get; set; }

        public string Nom { get; set; }

        public string Typeclien { get; set; }

        public int Nbrposte { get; set; }

        public string Typeserv { get; set; }

        public int NbrHeure { get; set; }

        public DateTime Date { get; set; }

        public int Montant { get; set; }


        public Client(int Nreglement, string Nom, string Typeclien,
            int Nbrposte, string Typeserv, int NbrHeure, DateTime Date, int Montant)
        {
            this.Nreglement = Nreglement;
            this.Nom = Nom;
            this.Typeclien = Typeclien;
            this.Nbrposte = Nbrposte;
            this.Typeserv = Typeserv;
            this.NbrHeure = NbrHeure;
            this.Date = Date;
            this.Montant = Montant;

        }

        public static int Calcule(int a, int b, int c)
        {


            c = a * c + b * c;

            return c;
        }

    }
}
