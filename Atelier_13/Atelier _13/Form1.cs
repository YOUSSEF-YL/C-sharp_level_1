using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier__13
{
    public partial class Form1 : Form
    {

       public static List<Client> lscl = new List<Client>();
        
        public Form1()
        {
            InitializeComponent();
        }

        public int NbrHeure;
        public  int Nreglement;
       public int index = lscl.Count;
      

        int a=0;
        int b=0;
        int m=0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Etudiant")
            {
                a = 15;
            }
            if (comboBox1.Text == "Fonctionnaire")
            {
                a = 20;
            }
            if (comboBox1.Text == "Abonné ")
            {
                a = 6;
            }
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Navigation")
            {
                b = 0;
            }
            if (comboBox2.Text == "Visioconférence")
            {
                b = 20;
            }
            if (comboBox2.Text == "Navigation Assistance")
            {
                b = 10;
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


             Nreglement = int.Parse(textBox1.Text);

            string Nom = textBox2.Text;

            string Typeclien = comboBox1.Text;

            int Nbrposte = int.Parse(textBox3.Text);

            string Typeserv = comboBox2.Text;

             NbrHeure = int.Parse(textBox4.Text);

            DateTime Date = DateTime.Parse(textBox5.Text);
            
            int Montant = m;
            m = Client.Calcule(a, b, NbrHeure);
            textBox6.Text = m.ToString();
     
            Client cli = new Client(Nreglement, Nom,
                Typeclien, Nbrposte, Typeserv, Nbrposte, Date, Montant);

            
            lscl.Add(cli);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            foreach (Client c in lscl)
            {
                if (c.Nreglement == Nreglement)
                {
                    lscl.Remove(c);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int Nreglement = int.Parse(textBox1.Text);
            string Nom = textBox2.Text;
            string Typeclien = comboBox1.Text;
            int Nbrposte = int.Parse(textBox3.Text);
            string Typeserv = comboBox2.Text;
            int NbrHeure = int.Parse(textBox4.Text);
            DateTime Date = DateTime.Parse(textBox5.Text);
            int Montant = int.Parse(textBox6.Text);

            Client cli = new Client(Nreglement, Nom,
             Typeclien, Nbrposte, Typeserv, Nbrposte, Date, Montant);

            int ind;

            for (int i = 0; i < lscl.Count; i++)
            {
                if (textBox1.Text == lscl.ElementAt(i).Nreglement.ToString())
                {
                    ind = i + 1;
                    break;
                }

                lscl[1-i ] = cli;
            }



            textBox6.Text = cli.Montant.ToString();
            textBox5.Text = cli.Date.ToString();
            textBox4.Text = cli.NbrHeure.ToString();
            textBox2.Text = cli.Nom;
            textBox1.Text = cli.Nreglement.ToString();
            comboBox1.Text = cli.Typeclien;
            comboBox2.Text = cli.Typeserv;
            textBox3.Text = cli.Nbrposte.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            int Nreglement = int.Parse(textBox1.Text);
            string Nom = textBox2.Text;
            string Typeclien = comboBox1.Text;
            int Nbrposte = int.Parse(textBox3.Text);
            string Typeserv = comboBox2.Text;
            int NbrHeure = int.Parse(textBox4.Text);
            DateTime Date = DateTime.Parse(textBox5.Text);
            int Montant = int.Parse(textBox6.Text);

            Client cli = new Client(Nreglement, Nom,
             Typeclien, Nbrposte, Typeserv, Nbrposte, Date, Montant);

            int ind;

            for (int i = 0; i < lscl.Count; i++)
            {
                if (textBox1.Text == lscl.ElementAt(i).Nreglement.ToString())
                {
                    ind = i + 1;
                    break;
                }
              
                lscl[1+i] = cli;
            }


            
            textBox6.Text = cli.Montant.ToString();
            textBox5.Text = cli.Date.ToString();
            textBox4.Text = cli.NbrHeure.ToString();
            textBox2.Text = cli.Nom;
            textBox1.Text = cli.Nreglement.ToString();
            comboBox1.Text = cli.Typeclien;
            comboBox2.Text = cli.Typeserv;
            textBox3.Text = cli.Nbrposte.ToString();
            

           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var itemCount = lscl.Count;

            if (lscl.Count > 0)
            {
                var item = lscl[lscl.Count - 1];
            }

            
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr1 = MessageBox.Show("voulez vou vrament quitter",
                "quitter ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (dr1 == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Client c in lscl)
            {
              
                if (c.Nreglement == Nreglement)
                {
                    textBox6.Text = c.Montant.ToString();
                    textBox5.Text = c.Date.ToString();
                    textBox4.Text = c.NbrHeure.ToString();
                    textBox2.Text = c.Nom;
                    textBox1.Text = c.Nreglement.ToString();
                    comboBox1.Text = c.Typeclien;
                    comboBox2.Text = c.Typeserv;
                    textBox3.Text = c.Nbrposte.ToString();
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            foreach (Client c in lscl)
            {
                if (c.Nreglement == Nreglement)
                {
                    lscl.Remove(c);


                   // Nreglement = int.Parse(textBox1.Text);
                   c.Nom = textBox2.Text;
                    //string Nom = textBox2.Text;

                   // string Typeclien = comboBox1.Text;

                    c.Typeclien = comboBox1.Text;

                    //int Nbrposte = int.Parse(textBox3.Text);

                    c.Nbrposte = int.Parse(textBox3.Text);


                   // string Typeserv = comboBox2.Text;

                    c.Typeserv = comboBox2.Text;

                   // NbrHeure = int.Parse(textBox4.Text);

                    c.NbrHeure = int.Parse(textBox4.Text);

                    //DateTime Date = DateTime.Parse(textBox5.Text);
                    c.Date = DateTime.Parse(textBox5.Text);
                }
            }
        }
    }
}
