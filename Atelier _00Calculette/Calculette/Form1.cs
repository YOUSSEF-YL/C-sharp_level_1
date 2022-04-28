using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

       
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (Add.Checked)
                {
                    textBox3.Text = (double.Parse(textBox1.Text) +
                        double.Parse(textBox2.Text)).ToString();
                }
                else if (soustrac.Checked)
                {
                    textBox3.Text = (double.Parse(textBox1.Text) -
                        double.Parse(textBox2.Text)).ToString();

                }
                else if (Multip.Checked)
                {
                    textBox3.Text = (double.Parse(textBox1.Text) *
                        double.Parse(textBox2.Text)).ToString();

                }
                else if (Divis.Checked)
                {
                    textBox3.Text = (double.Parse(textBox1.Text) /
                       double.Parse(textBox2.Text)).ToString();
                }
                else if (Racine.Checked)
                {
                    double a;
                    a = Math.Pow(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                        textBox3.Text = a.ToString();
                }
            }
            else
            {
               if( textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("erreur");
                }
            }
    }

    

        private void soustrac_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void Multip_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "X";
        }

        private void Divis_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void Racine_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "^";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
