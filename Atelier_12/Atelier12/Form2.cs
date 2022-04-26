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
    public partial class Form2_Ajout_S : Form
    {
        public Form2_Ajout_S()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int numInscript = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string prenom = textBox3.Text;

            string sex = "";
            if (radioButton1.Checked)
                sex = radioButton1.Text;
            if (radioButton2.Checked)
                sex = radioButton2.Text;

            DateTime dateNaissance = dateTimePicker1.Value;
            int module = int.Parse(comboBox1.Text);
            double note = double.Parse(textBox5.Text);

            Stagiare stag = new Stagiare(numInscript ,nom, prenom, sex, dateNaissance, module,note);

            Form1.lsstag.Add(stag);

            foreach (Control c in Controls)
            {
                if(c is TextBox)
                    c.Text = null;
            }
            textBox1.Focus();
        }
    }
}

