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
    public partial class Form3_Supprim : Form
    {
        public Form3_Supprim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int numiscrip = int.Parse(textBox1.Text);
            for (int i = 0; i < Form1.lsstag.Count; i++)
            {
                if(Form1.lsstag.ElementAt(i).NumInscript == numiscrip)
                {
                    Form1.lsstag.RemoveAt(i);
                    a = 1;
                    break;
                }
            }
            if (a == 1)
            {
                MessageBox.Show("Le stagiaire a ete supprime","Suppression",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
             if (a == 0)
            {
                MessageBox.Show("Ce numero n'existe pas", "Suppression",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
