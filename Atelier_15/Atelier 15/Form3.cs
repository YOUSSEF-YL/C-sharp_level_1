using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Atelier_15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Emission emi in Form1.lsEm)
            {
               dataGridView1.Rows.Add(emi.NumEmission, emi.Nom, emi.Heur, emi.DateEmission);
                
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Emission emi in Form1.lsEm)
            {
                if(emi.DateEmission.Date == dateTimePicker1.Value.Date)
                {
                    dataGridView1.Rows.Add(emi.NumEmission, emi.Nom, emi.Heur, emi.Duree);
                }
            }
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
        }
    }
}
