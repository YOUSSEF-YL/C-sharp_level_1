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
    public partial class Form1 : Form
    {
        public static List<Employe> lsep = new List<Employe>();

        public Form1()
        {
            InitializeComponent();
        }

         double Salairenet;
         public double Prime = 500.00;

        private void button1_Click(object sender, EventArgs e)
        {
           
            double taux = 0;
            double deduire = 0;
            
            string Nom = textBox1.Text;
            DateTime DateNaissance = dateTimePicker1.Value;

            double Salaire = double.Parse(textBox2.Text);

            if (Salaire >= 2.501 && Salaire <= 4166.66)
            {
                taux = 10 / 100;
                deduire = 250;
            }
                
            if (Salaire >= 4166.67 && Salaire <= 5.000)
            {
                taux = 20 / 100; 
                deduire = 666.66;
            }
              
            if (Salaire >= 5.001 && Salaire <= 6666.66)
            {
                taux = 30 / 100;
                deduire = 1166.66;
            }
               
            if (Salaire >= 6666.67 && Salaire <= 15.000)
            {
                taux = 34 / 100;
                deduire = 1433.33;
            }
               
            if (Salaire > 15.000)
            {
                taux = 38 / 100;
                deduire = 2033.33;
            }
               
            if (Salaire < 2.500)
            {
                taux = 0 / 100;
                deduire = 0;
            }
              
            double ir = (Salaire * taux)- deduire;


            Salairenet = Employe.SalaireNet(Salaire, ir, Prime);
            string SituationFamiale = comboBox1.Text;
            string Sexe = "";
            if (radioButton1.Checked)
                Sexe = radioButton1.Text;
            if (radioButton2.Checked)
                Sexe = radioButton2.Text;

            bool EstCommercial = checkBox1.Checked;
            Employe Emp = new Employe(DateNaissance, Nom, Salairenet, Sexe, SituationFamiale,EstCommercial);

            lsep.Add(Emp);

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
               
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
             Prime = 500.00;
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           textBox3.Text = Salairenet.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             Prime = 1000.00;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
             frm2.textBox1.Visible = true;
             frm2.label1.Visible = true;
        }
    }
}
