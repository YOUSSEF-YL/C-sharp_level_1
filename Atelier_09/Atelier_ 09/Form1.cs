using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier__09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var Item in checkedListBox1.CheckedItems)
                listBox1.Items.Add(Item);

            foreach (var Item in checkedListBox2.CheckedItems)
                listBox1.Items.Add(Item);

                     foreach (var Item in checkedListBox3.CheckedItems)
                listBox1.Items.Add(Item);

            foreach (var Item in checkedListBox4.CheckedItems)
                listBox1.Items.Add(Item);

            Width = 728;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            while (checkedListBox1.CheckedIndices.Count > 0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
            ////
            while (checkedListBox2.CheckedIndices.Count > 0)
            {
                checkedListBox2.SetItemChecked(checkedListBox2.CheckedIndices[0], false);
            }
            /////
            while (checkedListBox3.CheckedIndices.Count > 0)
            {
                checkedListBox3.SetItemChecked(checkedListBox3.CheckedIndices[0], false);
            }
            ////
            while (checkedListBox4.CheckedIndices.Count > 0)
            {
                checkedListBox4.SetItemChecked(checkedListBox4.CheckedIndices[0], false);
            }
            listBox1.Items.Clear();
            Width = 475;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 475;
        }
    }
}
