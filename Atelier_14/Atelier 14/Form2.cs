using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

           
            foreach (Employe Emp in Form1.lsep)
            {
                string Nom = Emp.Nom;
                string DateNaissance = Emp.DateNaissance.ToShortDateString();
                string Sexe = Emp.Sexe;
                string SituationFamiale = Emp.SituationFamiale;
                string Salaire = Emp.Salaire.ToString();
                bool EstCommercial = Emp.EstCommercial;
                dataGridView1.Rows.Add(Nom, DateNaissance, Sexe, SituationFamiale, Salaire, EstCommercial);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Employe emp in Form1.lsep)
            {
                if (emp.Nom == textBox1.Text)
                {
                    dataGridView1.Rows.Add(emp.Nom, emp.DateNaissance.ToShortDateString(),
                        emp.Sexe, emp.SituationFamiale , emp.Salaire , emp.EstCommercial);
                }
            }
        }
    }
}
