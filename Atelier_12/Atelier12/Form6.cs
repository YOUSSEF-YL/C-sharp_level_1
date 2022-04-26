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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int module = int.Parse(comboBox1.SelectedItem.ToString());
            foreach (Stagiare stg in Form1.lsstag)
            {
                if(module == stg.Module)
                {
                    string Numiscrip = stg.NumInscript.ToString();
                    string Nom = stg.Nom;
                    string Prnom = stg.Prenom;
                    string sexe = stg.Sex;
                    string DateNaiss = stg.DateNaissance.ToShortDateString();
                    string Module = stg.Module.ToString();
                    string Note = stg.Note.ToString();
                    string info = Numiscrip + " " + Nom + " " + Prnom + " " + sexe
                   + "  " + DateNaiss + "\n" + Module + " " + Note;
                    listBox1.Items.Add(info);
                }
            }
        }
    }
}
