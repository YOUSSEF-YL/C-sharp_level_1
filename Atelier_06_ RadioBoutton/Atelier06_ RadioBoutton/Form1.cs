using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier06__RadioBoutton
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        string chois1 = "";
        string chois2 = "";
        int Valeur1, Valeur2;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chois1 = "button N1";
            Valeur1 = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chois1 = "button N2"; 
            Valeur1 = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chois1 = "button N3"; 
            Valeur1 = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            chois2 = "button N1";
            Valeur2 = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            chois2 = "button N2"; 
            Valeur2 = 6;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            chois2 = "button N3";
            Valeur2 = 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Valeur1.ToString();
            label4.Text = Valeur2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = chois1;
            label2.Text = chois2;
            
        }
    }
}
