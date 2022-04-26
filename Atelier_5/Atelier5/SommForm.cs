using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier5
{
    public partial class SommForm : Form
    {
        public SommForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SommForm_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (Control c  in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.Show();
            this.Hide();
        }

       

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
                textBox3.Text = (double.Parse(textBox1.Text) +
                     double.Parse(textBox2.Text)).ToString();
            else
                textBox3.Text = "";
        }
    }
}
