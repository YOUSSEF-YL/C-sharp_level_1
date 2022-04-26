using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_07Manipulation_des_listes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count-1)
            {
                int j = listBox1.SelectedIndex;
                listBox1.Items.Insert(listBox1.SelectedIndex +2 , listBox1.SelectedItem);
                listBox1.Items.RemoveAt(j);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
            {
                int j = listBox2.SelectedIndex;
                listBox2.Items.Insert(listBox2.SelectedIndex + 2, listBox2.SelectedItem);
                listBox2.Items.RemoveAt(j);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > 0)
            {
                int i = listBox1.SelectedIndex;
                listBox1.Items.Insert(listBox1.SelectedIndex - 1, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(i + 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > 0)
            {
                int i = listBox2.SelectedIndex;
                listBox2.Items.Insert(listBox2.SelectedIndex - 1, listBox2.SelectedItem);
                listBox2.Items.RemoveAt(i + 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<object> ls = new List<object>();
            foreach (object o in listBox1.Items)
                ls.Add(o);
                listBox1.Items.Clear();
                ls.Sort();
                foreach (object ob in ls)
                    listBox1.Items.Add(ob);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<object> ls = new List<object>();
            foreach (object o in listBox1.Items)
                ls.Add(o);
                listBox1.Items.Clear();
                ls.Sort();
                ls.Reverse();
                foreach (object ob in ls)
                    listBox1.Items.Add(ob);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<object> ls = new List<object>();
            foreach (object o in listBox2.Items)
                ls.Add(o);
                listBox2.Items.Clear();
                ls.Sort();
                ls.Reverse();
                foreach (object ob in ls)
                    listBox2.Items.Add(ob);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<object> ls = new List<object>();
            foreach (object o in listBox2.Items)
                ls.Add(o);
                listBox2.Items.Clear();
                ls.Sort();
                foreach (object ob in ls)
                    listBox2.Items.Add(ob);
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
