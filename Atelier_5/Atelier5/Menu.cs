using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier5
{
    public partial class Menu : Form
    {

       SommForm form2 = new SommForm();

        Difference form3 = new Difference();

        Division form4 = new Division();
        Produit form5 = new Produit();
       
        public Menu()
        {
            InitializeComponent();
        }


        private void Quitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Difference_Click_1(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Somme_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }

        private void Produit_Click(object sender, EventArgs e)
        {
            form5.Show();
            this.Hide();
        }
    }
}
