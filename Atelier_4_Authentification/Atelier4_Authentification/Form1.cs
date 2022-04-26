using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier4_Authentification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tdi" && textBox2.Text == "tdi")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
                label4.Text = "Le nom d'utilisateur ou le mot de " +
                    "pas sot incorrects";
        }
    }
}
