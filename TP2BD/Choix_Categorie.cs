using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2BD
{
    public partial class Choix_Categorie : Form
    {
        public Choix_Categorie()
        {
            InitializeComponent();
        }

        private void BTN_Sport_Click(object sender, EventArgs e)
        {
            Form1.CouleurCat = ECodeCouleur.V;
            this.Close();
        }

        private void BTN_Jeux_Click(object sender, EventArgs e)
        {
            Form1.CouleurCat = ECodeCouleur.B;
            this.Close();
        }

        private void BTN_Art_Click(object sender, EventArgs e)
        {
            Form1.CouleurCat = ECodeCouleur.J;
            this.Close();
        }

        private void BTN_Culture_Click(object sender, EventArgs e)
        {
            Form1.CouleurCat = ECodeCouleur.R;
            this.Close();
        }
    }
}
