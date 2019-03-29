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
            CodeCategorie = nameof(Categorie);
        }

        private void GetQuestion() {
            OracleCommand command = new OracleCommand("TRIVIA", conn);
            command.CommandText = "GetQuestion";
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param = new OracleParameter("pcode", OracleDbType.Int32);
            param.Direction = ParameterDirection.Input;
            param.Value = CodeCategorie;

            OracleParameter returnParam = new OracleParameter("res", OracleDbType.RefCursor);
            returnParam.Direction = ParameterDirection.ReturnValue;

            command.Parameters.Add(returnParam);
            command.Parameters.Add(param);

            OracleDataReader Reader = command.ExecuteReader();
            while (Reader.Read()) {
                IDQuestion = Reader.GetInt32(0);
                LB_Question.Text = Reader.GetString(1);
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
