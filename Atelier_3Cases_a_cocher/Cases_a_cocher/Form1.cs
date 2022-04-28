using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cases_a_cocher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RAZ_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    cb.Checked = false;
                } 
            }

           
            listBox1.Items.Clear();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if(cb.Checked)
                    {
                        listBox1.Items.Add(cb.Text);
                    }
                    
                        
                    // c.Checked = false;
                }
            }
        }
    }
}
