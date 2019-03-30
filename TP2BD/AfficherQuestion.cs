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
    public partial class AfficherQuestion : Form
    {
        private OracleConnection conn;
        private int IDQuestion;
        private string CodeCategorie;

        public AfficherQuestion(ref OracleConnection Connection, ECodeCouleur Categorie)
        {
            InitializeComponent();
            conn = Connection;
          Categorie = Form1.CouleurCat;
            GetQuestion();
           
        }

        private void GetQuestion() {
            OracleCommand commandAfficherQuest = new OracleCommand("TRIVIA", conn);
            commandAfficherQuest.CommandText = "Trivia.chercherquestion";
            commandAfficherQuest.CommandType = CommandType.StoredProcedure;

            

            OracleParameter EnonceParam = new OracleParameter("enonce", OracleDbType.RefCursor);
            EnonceParam.Direction = ParameterDirection.ReturnValue;
            commandAfficherQuest.Parameters.Add(EnonceParam);

            OracleParameter ParamCodeCat = new OracleParameter("codecategorie", OracleDbType.Int32);
            ParamCodeCat.Direction = ParameterDirection.Input;
            ParamCodeCat.Value = Form1.CouleurCat;
            commandAfficherQuest.Parameters.Add(ParamCodeCat);

            OracleDataReader Reader = commandAfficherQuest.ExecuteReader();
            while (Reader.Read()) {
                
                LB_Question.Text = Reader.GetString(0);
                IDQuestion = Reader.GetInt32(1);
            }
        }

        /// <summary>
        /// Affiche les réponses
        /// </summary>
        private void GetReponses()
        {
            OracleCommand command = new OracleCommand("TRIVIA", conn);
            command.CommandText = "Getreponse";
            command.CommandType = CommandType.StoredProcedure;
        }

        private void reponseButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
