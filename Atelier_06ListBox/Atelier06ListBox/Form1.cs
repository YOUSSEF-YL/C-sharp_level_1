using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier06ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items.Count.ToString();
            textBox2.Text = listBox1.SelectedIndex.ToString();
            textBox3.Text = listBox1.SelectedItem.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                        c.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            
           
            

        }
    }
}
