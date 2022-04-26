using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier12
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach (Stagiare stg in Form1.lsstag)
            {
                string Numiscrip = stg.NumInscript.ToString();
                string Nom = stg.Nom;
                string Prnom = stg.Prenom;
                string sexe = stg.Sex;
                string DateNaiss = stg.DateNaissance.ToShortDateString();
                string Module = stg.Module.ToString();
                string Note = stg.Note.ToString();
                string info = Numiscrip + " " + Nom + " " + Prnom + " " + sexe
                   + "  " + DateNaiss +"\n" + Module +" "+Note;

                listBox1.Items.Add(info);
            }
        }
    }
}
