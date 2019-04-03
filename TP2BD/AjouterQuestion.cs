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
    public partial class AjouterQuestion : Form
    {
        OracleConnection conn;
        public AjouterQuestion(ref OracleConnection Connection)
        {
            InitializeComponent();
            conn = Connection;
        }

        private bool ValiderChamps() {
            if (TB_Question.Text == "")
            {
                MessageBox.Show("Vous devez entrez une question.");
                return false;
            }
            else if (TB_Rep1.Text == "" || TB_Rep2.Text == "" || TB_Rep3.Text == "" || TB_Rep4.Text == "")
            {
                MessageBox.Show("Vous devez spécifier 4 questions pour cette question.");
                return false;
            }
            else if (!RB_R1.Checked && !RB_R2.Checked && !RB_R3.Checked && !RB_R4.Checked) {
                MessageBox.Show("Vous devez spécifier la bonne réponse parmis les quatres.");
                return false;
            }

            return true;
        }

        private string getNumCategorie() {
            string cmdString = "SELECT CodeCategorie FROM Categorie WHERE NomCategorie='" + CB_Categorie.SelectedItem.ToString() + "'";
            OracleCommand command = new OracleCommand(cmdString, conn);

            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read()) {
                return Reader.GetString(0);
            }

            return null; // Valeur qui indique null
        }

        private bool CreerQuestion() {
            if (!ValiderChamps())
                return false;

            OracleCommand command = new OracleCommand("TRIVIA", conn);
            command.CommandText = "Trivia.CreerQuestion";
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter paramEnonce = new OracleParameter("Enonce", OracleDbType.Varchar2);
            paramEnonce.Value = TB_Question.Text;
            paramEnonce.Direction = ParameterDirection.Input;

            OracleParameter paramFlag = new OracleParameter("pFlag", OracleDbType.Char);
            paramFlag.Value = 'N';
            paramFlag.Direction = ParameterDirection.Input;

            OracleParameter paramCategorie = new OracleParameter("CodeCategorie", OracleDbType.Char);
            paramCategorie.Value = getNumCategorie().ElementAt(0);
            paramCategorie.Direction = ParameterDirection.Input;

            command.Parameters.Add(paramEnonce);
            command.Parameters.Add(paramFlag);
            command.Parameters.Add(paramCategorie);
            command.ExecuteNonQuery();

            CreerReponse();

            return true;
        }

        private int getNumQuestion() {
            OracleCommand command = new OracleCommand("SELECT NumQuestion FROM Questions WHERE EnonceQuestion='" + TB_Question.Text + "'", conn);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
                return reader.GetInt32(0);

            return -1;
        }

        private void CreerReponse() {
            int Compteur = 0;
            int NumQuestion = getNumQuestion();


            while (Compteur < 4) {
                OracleCommand command = new OracleCommand("TRIVIA", conn);
                command.CommandText = "Trivia.CreerReponse";
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter paramDesc = new OracleParameter("pdescription", OracleDbType.Varchar2);
                paramDesc.Direction = ParameterDirection.Input;
                OracleParameter paramEstBonne = new OracleParameter("pestbonne", OracleDbType.Char);
                paramEstBonne.Direction = ParameterDirection.Input;
                OracleParameter paramNumQuestion = new OracleParameter("pnumquestion", OracleDbType.Int32);
                paramNumQuestion.Direction = ParameterDirection.Input;
                paramNumQuestion.Value = NumQuestion;
                switch (Compteur) {
                    case 0:
                        paramDesc.Value = TB_Rep1.Text;
                        paramEstBonne.Value = RB_R1.Checked ? 'O' : 'N';
                        break;

                    case 1:
                        paramDesc.Value = TB_Rep2.Text;
                        paramEstBonne.Value = RB_R2.Checked ? 'O' : 'N';
                        break;
                    case 2:
                        paramDesc.Value = TB_Rep3.Text;
                        paramEstBonne.Value = RB_R3.Checked ? 'O' : 'N';
                        break;
                    case 3:
                        paramDesc.Value = TB_Rep4.Text;
                        paramEstBonne.Value = RB_R4.Checked ? 'O' : 'N';
                        break;
                }

                command.Parameters.Add(paramDesc);
                command.Parameters.Add(paramEstBonne);
                command.Parameters.Add(paramNumQuestion);
                command.ExecuteNonQuery();
                Compteur++;
            }
        }

        private void AfficherCategorie() {
            string cmdString = "SELECT NomCategorie FROM Categorie";
            OracleCommand command = new OracleCommand(cmdString, conn);
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read()) {
                CB_Categorie.Items.Add(Reader.GetString(0));
            }
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            AfficherCategorie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CreerQuestion())
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
