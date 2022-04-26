using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier07_ListAvancee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                if (listBox1.Items.Contains(textBox1.Text))
                {
                   // listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                 listBox1.Items.Add(textBox1.Text);
                
            }
            else
                button1.Enabled = false;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.Items.Count.ToString();
            textBox4.Text = listBox1.SelectedIndex.ToString();
            textBox5.Text = listBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indix;
            int.TryParse(textBox2.Text, out indix);
            if (indix < listBox1.Items.Count)
                listBox1.SetSelected(indix, true); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }
    }
}
