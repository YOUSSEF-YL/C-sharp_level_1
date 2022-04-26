using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier10_Croisiere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            if (textBox1.Text != "")
                button2.Enabled = true;
            else
                button2.Enabled = false;
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
                errorProvider1.SetError(dateTimePicker1, "La date de depart doit" +
                    " inferieur a la date d'arrivee");
            else
            {
                errorProvider1.Dispose();
                TimeSpan ts = dateTimePicker2.Value - dateTimePicker1.Value;
                int jours = (int)ts.TotalDays;
                label4.Text = jours.ToString() + "jours(s)";

            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
                errorProvider2.SetError(dateTimePicker2, "La date de depart doit" +
                    " superieur a la date d'arrivee");
            else
            {
                errorProvider1.Dispose();
                TimeSpan ts = dateTimePicker2.Value - dateTimePicker1.Value;
                int jours = (int)ts.TotalDays;
               label4.Text = jours.ToString() + "jours(s)";

            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > numericUpDown3.Value)
                MessageBox.Show("Le nombre de places doit etre superieur au nombre des inscrits",
                    "Regle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                label7.Text = "Libres:" + (numericUpDown2.Value - numericUpDown3.Value).ToString();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > numericUpDown2.Value)
                MessageBox.Show("Le nombre de places doit etre superieur au nombre des inscrits",
                    "Regle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                label7.Text = "Libres:" + (numericUpDown2.Value - numericUpDown3.Value).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string recap;
            string dep = "Depart  :" + dateTimePicker1.Value.ToShortTimeString().ToString();
            string Arr = "Arrivee  :" + dateTimePicker2.Value.ToShortTimeString().ToString();
            string dur = "Duree :" + label6.Text;
            string plac = "places  :" + numericUpDown2.Value.ToString();
            string insc = "inscrits  :" + numericUpDown3.Value.ToString();
            recap = (dep + "\n" + Arr + "\n" + dur + "\n" + plac + "\n" + insc);
            MessageBox.Show(recap, textBox1.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
