using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox3.Enabled = false;
            }
            else
                groupBox3.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);

                }
                StringBuilder sb = new StringBuilder();
                foreach (string s in checkedListBox1.Items)
                    listBox3.Items.Add(s);
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                    listBox3.Items.Clear();
                }
            }
                


            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Add(checkedListBox1.SelectedItem);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a;
            int.TryParse(textBox2.Text, out a);


            if (a > 59)
                errorProvider1.SetError(textBox2, "entrer une valeur entre 0 et 59");

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false)
            {
                errorProvider1.SetError(textBox2, "entrer une valeur numérique ");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string res;
          

            StringBuilder sb = new StringBuilder();
            foreach (string s in listBox3.Items)
                sb.Append(s+",");

            res = textBox1.Text + ":" + comboBox1.SelectedItem.ToString() + "h" + textBox2.Text + sb;
           
            listBox1.Items.Add(res);
        }
    }
}
