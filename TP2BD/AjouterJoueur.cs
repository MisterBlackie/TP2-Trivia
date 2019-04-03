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
    public partial class AjouterJoueur : Form
    {

        OracleConnection conn;
        public AjouterJoueur(ref OracleConnection Connection)
        {
            InitializeComponent();
            conn = Connection;
        }

        public bool ValiderInfo() {
            if (TB_Nom.Text != null && TB_Prenom.Text != null && TB_Alias.Text != null) {
                if (ValiderAlias())
                    return true;
                else {
                    MessageBox.Show(TB_Alias.Text + "est déjà utilisé !");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Les champs de saisie doivent être remplie.");
                return false;
            }
        }

        private bool ValiderAlias() {
            string cmdSQL = "SELECT Alias FROM Joueur WHERE Alias='" + TB_Alias.Text + "'";
            OracleCommand command = new OracleCommand(cmdSQL, conn);

            OracleDataReader Reader = command.ExecuteReader();

            if (Reader.HasRows)
                return false;
            else
                return true;
        }

        private void CreatePlayer()  {
            if (!ValiderInfo()) {
                DialogResult = DialogResult.None;
                return;
            }

            OracleCommand oraAjoutJoueur = new OracleCommand("TRIVIA", conn);
            oraAjoutJoueur.CommandText = "TRIVIA.creerJoueur";
            oraAjoutJoueur.CommandType = CommandType.StoredProcedure;


            OracleParameter oraPamAlias = new OracleParameter("alias", OracleDbType.Varchar2, 20);
            oraPamAlias.Direction = ParameterDirection.Input;
            oraPamAlias.Value = TB_Alias.Text;
            oraAjoutJoueur.Parameters.Add(oraPamAlias);


            OracleParameter oraPamNom = new OracleParameter("nom", OracleDbType.Varchar2, 40);
            oraPamNom.Direction = ParameterDirection.Input;
            oraPamNom.Value = TB_Nom.Text;
            oraAjoutJoueur.Parameters.Add(oraPamNom);

            OracleParameter oraPamPrenom = new OracleParameter("prenom", OracleDbType.Varchar2, 40);
            oraPamPrenom.Direction = ParameterDirection.Input;
            oraPamPrenom.Value = TB_Prenom.Text;
            oraAjoutJoueur.Parameters.Add(oraPamPrenom);


            oraAjoutJoueur.ExecuteNonQuery();

        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            CreatePlayer();
        }
    }
}
