using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Atelier_15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int exist = 0;
            int Numemis = int.Parse(textBox1.Text);
            foreach (Emission emi in Form1.lsEm)
            {
               if(emi.NumEmission == Numemis)
                {
                    exist = 1;
                    MessageBox.Show("ce numero exist deja");
                    break;
                }

            }
            if (exist == 0)
            {
               

                string Nom = textBox2.Text;

                DateTime DateEmission = DateTime.Parse(maskedTextBox3.Text);

                string Heur = maskedTextBox1.Text;
                string Duree = maskedTextBox2.Text;

                string TypeEmission = comboBox1.SelectedItem.ToString();

                Emission emision = new Emission(Numemis, Nom, DateEmission, Heur, Duree, TypeEmission);

                Form1.lsEm.Add(emision);
            }

            foreach (Control c in Controls)
            {
                if(c is TextBox)
                     c.Text = "";

                if (c is MaskedTextBox)
                    c.Text = "";

                if (c is ComboBox)
                    c.Text = "";
            }

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
