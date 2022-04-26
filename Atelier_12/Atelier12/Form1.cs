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
    public partial class Form1 : Form
    {
        public static List<Stagiare> lsstag = new List<Stagiare>();

        public Form1()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Form3")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                Form3_Supprim frm3 = new Form3_Supprim();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Form4")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                Form4_consulta frm4 = new Form4_consulta();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void listeDesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Form5")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                Form5 frm5 = new Form5();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void listeDesStagiairsParModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Form6")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                Form6 frm6 = new Form6();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void listeTousLesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Form7")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                Form7 frm7 = new Form7();
                frm7.MdiParent = this;
                frm7.Show();
            }

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if(frm.Text == "Form2")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if(overt == false)
            {
                Form2_Ajout_S frm2 = new Form2_Ajout_S();
                frm2.MdiParent = this;
                frm2.Show();
            }

        }

        
    }
}
