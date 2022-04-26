using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier06Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string msg = "";

            msg = comboBox1.Text + "/ " + comboBox2.Text + "/ " + comboBox3.Text;
           
            DialogResult dr1 = MessageBox.Show("votre date   :" + msg,
                "Date de naissance", MessageBoxButtons.OK);
                if(dr1 == DialogResult.OK)
            {
                int age = DateTime.Now.Year - int.Parse(comboBox3.SelectedItem.ToString());
                DialogResult dr2 = MessageBox.Show("Votre Age est :" + age, "Age",
                   MessageBoxButtons.OK);

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr3 = MessageBox.Show("voulez vou vrament quitter" ,"Fermeture"
                       ,MessageBoxButtons.OK , MessageBoxIcon.Question);
            if (dr3 == DialogResult.OK)
                Application.Exit();
        }
    }
}
