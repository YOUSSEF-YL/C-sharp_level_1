using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Atelier_15
{
    public partial class Form1 : Form
    {

        public static List<Emission> lsEm = new List<Emission>();


        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Emission>));

            StreamReader strr = new StreamReader("D:\\Atelier_15.xml");

            lsEm = (List<Emission>)serialiser.Deserialize(strr);
            strr.Close();

            

        }


        private void ajoutProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Ajout d'un programme")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {
                
                Form2 frm2 = new Form2();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void consultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Consultation par date")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {

                Form3 frm3 = new Form3();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool overt = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Statistiques")
                {
                    overt = true;
                    frm.Focus();
                    break;
                }
            }
            if (overt == false)
            {

                Form4 frm4 = new Form4();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Emission>));

            StreamWriter strw = new StreamWriter("D:\\Atelier_15.xml");

            serialiser.Serialize(strw, lsEm);

            strw.Close();


            Application.Exit();
        }

        
    }
}
