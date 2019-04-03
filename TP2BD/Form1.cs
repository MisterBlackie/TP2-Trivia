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
        public static ECodeCouleur CouleurCat;
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

        private void AfficherMenu() {
            Menu Form = new Menu(ref conn);

            if (Form.ShowDialog() != DialogResult.OK)
            {
                Deconnect();
                Close();
            }
            else
            {
                ListeJoueur = Form.Liste;
                AfficherNom();
            }
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
            CouleurCat = Roulette.GetCouleur();

            if (CouleurCat == ECodeCouleur.BL)
            {
                    // On permet au joueur de choisir sa couleur
                    Choix_Categorie m = new Choix_Categorie();
                    m.ShowDialog();
            }

            AfficherQuestion Form = new AfficherQuestion(ref conn, CouleurCat);
            Form.ShowDialog();

            if (!Form.BienRepondu)
            {
                LB_Reponse.ForeColor = Color.Red;
                LB_Reponse.Text = "Mauvaise réponse !";
                ListeJoueur.NextTour();
                AfficherNom();
            }
            else {
                LB_Reponse.ForeColor = Color.Green;
                LB_Reponse.Text = "Bonne réponse !";
            
                AddScore(CouleurCat);
                AfficherScore();
                AfficherFaibleCategorie();
            }
        }

        private void AfficherFaibleCategorie() {
            ECodeCouleur Code = ListeJoueur.GetJoueur().GetLowestCategorie();
            string NomCat = "";
            switch (Code) {
                case ECodeCouleur.B:
                    NomCat = "Bleu";
                    break;
                case ECodeCouleur.J:
                    NomCat = "Jaune";
                    break;
                case ECodeCouleur.R:
                    NomCat = "Rouge";
                    break;
                case ECodeCouleur.V:
                    NomCat = "Vert";
                    break;
            }
            LB_FaibleCat.Text = NomCat;
        }

        private void AfficherScore() {
            string CmdString = "SELECT Joueur.Alias, NomCategorie FROM Joueur INNER JOIN Score ON Score.Alias = Joueur.Alias INNER JOIN Categorie ON Categorie.CodeCategorie = Score.CodeCategorie";
            OracleCommand command = new OracleCommand(CmdString, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            DataSet DS = new DataSet();

            da.Fill(DS);

            DG.DataSource = DS.Tables[0];
        }

        private void AddScore(ECodeCouleur Code) {
            // Faudrait un trigger au lieu de ça !!
            if (ListeJoueur.AddScoreToRoundPlayer(Code)) {
                OracleCommand commandAfficherScore = new OracleCommand("TRIVIA", conn);
                commandAfficherScore.CommandType = CommandType.StoredProcedure;
                commandAfficherScore.CommandText = "TRIVIA.AfficherScore";

                OracleParameter returnValue = new OracleParameter("return", OracleDbType.RefCursor);
                returnValue.Direction = ParameterDirection.ReturnValue;
                commandAfficherScore.Parameters.Add(returnValue);

                OracleParameter param = new OracleParameter("pAlias", OracleDbType.Varchar2);
                param.Direction = ParameterDirection.Input;
                param.Value = ListeJoueur.GetJoueur().GetAlias();
                commandAfficherScore.Parameters.Add(param);

                OracleDataReader Reader = commandAfficherScore.ExecuteReader();
                while (Reader.Read())
                {
                    if (Reader.GetString(2) == Code.ToString())
                        return; // La catégorie est déjà gagnée
                }

                OracleCommand command = new OracleCommand("TRIVIA", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TRIVIA.CreerScore";

                OracleParameter paramCat = new OracleParameter("pCodeCategorie", OracleDbType.Char);
                paramCat.Direction = ParameterDirection.Input;
                paramCat.Value = Code.ToString().ElementAt(0);
                command.Parameters.Add(paramCat);

                OracleParameter paramAlias = new OracleParameter("pAlias", OracleDbType.Varchar2);
                paramAlias.Direction = ParameterDirection.Input;
                paramAlias.Value = ListeJoueur.GetJoueur().GetAlias();
                command.Parameters.Add(paramAlias);

                command.ExecuteNonQuery();
            }
        }

        private void AfficherNom() {
            LB_NomJoueur.Text = ListeJoueur.GetJoueur().GetAlias();
            AfficherFaibleCategorie();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFlag();
            ResetScore();
            this.Close();
        }

        private void ResetFlag()
        {
            OracleCommand commandResetFlag = new OracleCommand("TRIVIA", conn);
            commandResetFlag.CommandText = "trivia.ResetFlag";
            commandResetFlag.CommandType = CommandType.StoredProcedure;

            OracleParameter ParamCodeQuest = new OracleParameter("codecategorie", OracleDbType.Int32);
            ParamCodeQuest.Value = 0;
            ParamCodeQuest.Direction = ParameterDirection.Input;
            commandResetFlag.Parameters.Add(ParamCodeQuest);
        }

        private void ResetScore() {
            string cmdString = "DELETE FROM Score";
            OracleCommand command = new OracleCommand(cmdString, conn);
            command.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherMenu();
            AfficherScore();
            AfficherNom();
        }
    }
}
