using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int type = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            if (type == 1)
            {
                listBox2.Items.Add(textBox1.Text);
            }
            if (type == 2)
            {
                 MessageBox.Show("saisi  le montant ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                
                sum1 += Convert.ToInt32(listBox1.Items[i]);

               
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                
                sum2 += Convert.ToInt32(listBox2.Items[i]);
               
            }

            label4.Text = sum1.ToString();
            label5.Text = sum2.ToString();
            int res;

            res= sum1 + sum2;
            label6.Text = res.ToString();
            
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);

            }
            if (type == 1)
            {
               
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
            }
            else
                MessageBox.Show("aucune écriture  dans la liste ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
               DialogResult dr1= MessageBox.Show("saisi  un réel  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                
            }
            

        }
    }
}
