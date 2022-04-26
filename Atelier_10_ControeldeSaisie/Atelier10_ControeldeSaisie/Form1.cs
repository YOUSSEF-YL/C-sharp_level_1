using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier10_ControeldeSaisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex nom = new Regex("^[a-zA-Z]+$");
            bool res = nom.IsMatch(textBox2.Text);
            if(!res)
            {
                errorProvider1.SetError(textBox2, "only letters");
                toolStripStatusLabel1.Text = "Error de saise";
            }
            else
            {
                errorProvider1.Clear();
                toolStripStatusLabel1.Text = "";
            }
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex Prenom = new Regex("^[a-zA-Z]+$");
            bool res = Prenom.IsMatch(textBox3.Text);
            if (!res)
            {
                errorProvider1.SetError(textBox3, "only letters");
                toolStripStatusLabel1.Text = "Error de saise";
            }
            else
            {
                errorProvider1.Clear();
                toolStripStatusLabel1.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Regex Codepostal = new Regex("^[0-9]{5}$");
            bool res = Codepostal.IsMatch(textBox5.Text);
            if (!res)
            {
                errorProvider1.SetError(textBox5, "only numbers");
                toolStripStatusLabel1.Text = "Error de saise";
            }
            else
            {
                errorProvider1.Clear();
                toolStripStatusLabel1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(errorProvider1.GetError(textBox2)=="" &&
                errorProvider2.GetError(textBox3)==""&&
                errorProvider3.GetError(textBox5)==""&&
                toolStripStatusLabel1.Text =="")
            {
                Form2 frm2 = new Form2();
                frm2.textBox1.Text = textBox2.Text;
                frm2.textBox2.Text = textBox3.Text;
                frm2.textBox3.Text = textBox4.Text;
                frm2.textBox4.Text = textBox5.Text;
                frm2.Show();
            }
            Visible = false;
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
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Focus();
        }
    }
}
