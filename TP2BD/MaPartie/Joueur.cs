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
using Oracle.ManagedDataAccess.Types;

namespace TP2BD
{
    public partial class Joueur : Form
    {

        public Joueur()
        {
            InitializeComponent();
        }
        // Déclaration d'une connexion oracle //
        OracleConnection conn = new OracleConnection();
        private void BTN_AddJoueur_Click(object sender, EventArgs e)
        {
            if (TBX_Nom.Text == "" || TBX_Prenom.Text == "" || TBX_Alias.Text == "" )
            {
                MessageBox.Show("Veuiller remplir tout les champs");
                return;
            }

            OracleCommand oraAjoutJoueur = new OracleCommand("TRIVIA", conn);
            oraAjoutJoueur.CommandText = "TRIVIA.creerJoueur";
            oraAjoutJoueur.CommandType = CommandType.StoredProcedure;


            OracleParameter oraPamAlias = new OracleParameter("alias", OracleDbType.Varchar2, 20);
            oraPamAlias.Direction = ParameterDirection.Input;
            oraPamAlias.Value = TBX_Alias.Text;
            oraAjoutJoueur.Parameters.Add(oraPamAlias);


            OracleParameter oraPamNom = new OracleParameter("nom", OracleDbType.Varchar2, 40);
            oraPamNom.Direction = ParameterDirection.Input;
            oraPamNom.Value = TBX_Nom.Text;
            oraAjoutJoueur.Parameters.Add(oraPamNom);

            OracleParameter oraPamPrenom = new OracleParameter("prenom", OracleDbType.Varchar2, 40);
            oraPamPrenom.Direction = ParameterDirection.Input;
            oraPamPrenom.Value = TBX_Prenom.Text;
            oraAjoutJoueur.Parameters.Add(oraPamPrenom);


            oraAjoutJoueur.ExecuteNonQuery();
            TBX_Alias.Text = "";
            TBX_Nom.Text = "";
            TBX_Prenom.Text = "";
            LBX_Joueur.Items.Clear();
            AfficherJoueur();
        }

        private void Joueur_Load(object sender, EventArgs e)
        {
            try
            {
                string dsource = "(DESCRIPTION="
                                    + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                                    + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                                    + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

                // Déclaration de la chaine de connection //
                string ChaineDeConnection = "Data Source = " + dsource + "; User Id = Cousinea; password = ORACLE1";
                conn.ConnectionString = ChaineDeConnection;
                conn.Open();
            }
            catch (Exception sqlmOracleConnection)
            {
                MessageBox.Show(sqlmOracleConnection.Message.ToString());
            }

            AfficherJoueur();
            

        }
        private void AfficherJoueur()
        {
            LBX_Joueur.Items.Clear();
            OracleCommand orapJoueur = new OracleCommand("SELECT alias FROM joueur ", conn);


            OracleDataReader JoueurReader = orapJoueur.ExecuteReader();

            while (JoueurReader.Read())
            {
                LBX_Joueur.Items.Add(JoueurReader.GetString(0));
            }
        }

        private void BTN_Pret_Click(object sender, EventArgs e)
        {

          
          
            LBX_Pret.Items.Add(LBX_Joueur.SelectedItem);
            RefreshLBX_Joueur();
        }

        private void LBX_Pret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBX_Joueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLBX_Joueur();
        }
        private void RefreshLBX_Joueur()
        {
            string itemInQuestion = LBX_Joueur.SelectedItem.ToString();

            // If specific string is found in listBox1...
            if (LBX_Pret.Items.Contains(itemInQuestion) || LBX_Pret.Items.Count >= NombreJoueur.Value)
            {
                // ...Enable the button
                BTN_Pret.Enabled = false;
            }
            else
            {
                BTN_Pret.Enabled = true;
            }
        }

        private void BTN_Retirer_Click(object sender, EventArgs e)
        {
            while (LBX_Pret.SelectedItems.Count > 0)
            {
                LBX_Pret.Items.Remove(LBX_Pret.SelectedItems[0]);
            }
            RefreshLBX_Joueur();
        }
    }
}
