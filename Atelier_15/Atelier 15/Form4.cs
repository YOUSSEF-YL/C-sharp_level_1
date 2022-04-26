using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_15
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int mintotal = 0;
            int sectotal = 0;
            int mintotaltype = 0;
            int sectotaltype = 0;


            foreach (Emission emi in Form1.lsEm)
            {
                
                
                    string[] duree = emi.Duree.Split(':');
                    int min = int.Parse(duree[0]);
                    int sec = int.Parse(duree[1]);
                    mintotal += min;
                    sectotal += sec;

            }
            mintotaltype += sectotaltype / 60;
            sectotaltype += sectotaltype % 60;

            textBox1.Text = mintotal + "min" + sectotal + "sec";

            foreach (Emission emi in Form1.lsEm)
            {
                if(emi.TypeEmission == comboBox1.SelectedItem.ToString())
                {
                    string[] duree = emi.Duree.Split(':');
                    int min = int.Parse(duree[0]);
                    int sec = int.Parse(duree[1]);
                    mintotaltype += min;
                    sectotaltype += sec;
                }
            }

            mintotaltype += sectotaltype / 60;
            sectotaltype += sectotaltype % 60;

            textBox2.Text = mintotaltype + "min" + sectotaltype + "sec";
            double secondtotal = mintotal * 60 + sectotal;

            double secondtotaltpe = mintotaltype * 60 + sectotaltype;
            textBox3.Text = (secondtotaltpe / secondtotal * 100).ToString(".00") + "%";
        }
    }
}
