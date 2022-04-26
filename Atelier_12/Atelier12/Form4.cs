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
    public partial class Form4_consulta : Form
    {
        public Form4_consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int numiscrip = int.Parse(textBox1.Text);
            for (int i = 0; i < Form1.lsstag.Count; i++)
            {
                if (Form1.lsstag.ElementAt(i).NumInscript == numiscrip)
                {
                    textBox2.Text = Form1.lsstag.ElementAt(i).Nom;
                    textBox3.Text = Form1.lsstag.ElementAt(i).Prenom;
                    textBox4.Text = Form1.lsstag.ElementAt(i).Sex;
                    textBox5.Text = Form1.lsstag.ElementAt(i).DateNaissance
                        .ToShortDateString();
                    textBox6.Text = Form1.lsstag.ElementAt(i).Module.ToString();
                    textBox7.Text = Form1.lsstag.ElementAt(i).Note.ToString();
                    a = 1;
                    break;
                }
                
                 if (a == 0)
                {
                    MessageBox.Show("Ce numero n'existe pas", "Suppression",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }
    }
}
