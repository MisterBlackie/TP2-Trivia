using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace TP2BD
{
    public partial class Form1 : Form
    {

        private OracleConnection conn;
        private PlayerList ListeJoueur;
        public Form1()
        {
            InitializeComponent();
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label1.Width, label1.Height);

            this.label1.Region = new Region(path);

            ListeJoueur = new PlayerList();
            ConnectToDB();
        }

        private void ConnectToDB() {
            string ChaineConnexion = "Data Source=(DESCRIPTION="
                                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
                                     + "User Id=cousinea;Password=ORACLE1";
            try
            {
                conn = new OracleConnection(ChaineConnexion);
                conn.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Une erreur de connection à la base de donnée s'est produite.");
            }
        }

        private void JouerTour() {
            Roulette.Tourner();
            ECodeCouleur CouleurCat = Roulette.GetCouleur();

            if (CouleurCat == ECodeCouleur.BL) {
                // On permet au joueur de choisir sa couleur
            }

            AfficherQuestion Form = new AfficherQuestion(ref conn, CouleurCat);
            Form.ShowDialog();

            ListeJoueur.NextTour();
            AfficherNom();
        }

        private void AfficherNom() {
            LB_NomJoueur.Text = ListeJoueur.GetJoueur().GetAlias();
        }

        private void Deconnect() {
            try
            {
                conn.Close();
            }
            catch (Exception ex) {
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Deconnect();
        }

        private void BTN_JouerTour_Click(object sender, EventArgs e)
        {
            JouerTour();
        }
    }
}
