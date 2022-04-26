using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                LblmsgError.Text = "Zones obligatoires" ;
            }

            if ( textBox2.Text == "" )
            {
                LblmsgError.Text = "VOuse devez saiser la Qte";
            }
            else
            {
                double  qte, TTVA, TTC, PU;
                  double.TryParse(textBox2.Text,out qte);
                  double.TryParse(textBox1.Text,out PU);
                 double.TryParse(textBox3.Text,out TTVA);

              double  Ht = qte * PU;
                TTC = (Ht * TTVA) / 100 + Ht;
               textBox4.Text = Ht.ToString();
                textBox5.Text = TTC.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsPunctuation(e.KeyChar) == false)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsPunctuation(e.KeyChar) == false)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsPunctuation(e.KeyChar) == false)
                e.Handled = true;
        }

        
    }
}



