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
        public bool BienRepondu = false;

        public AfficherQuestion(ref OracleConnection Connection, ECodeCouleur Categorie)
        {
            InitializeComponent();
            conn = Connection;
            Categorie = Form1.CouleurCat;
            GetQuestion();
            GetReponses();

        }

        private void GetQuestion() {
            OracleCommand commandAfficherQuest = new OracleCommand("TRIVIA", conn);
            commandAfficherQuest.CommandText = "Trivia.chercherquestion";
            commandAfficherQuest.CommandType = CommandType.StoredProcedure;



            OracleParameter EnonceParam = new OracleParameter("enonce", OracleDbType.RefCursor);
            EnonceParam.Direction = ParameterDirection.ReturnValue;
            commandAfficherQuest.Parameters.Add(EnonceParam);

            OracleParameter ParamCodeCat = new OracleParameter("codecategorie", OracleDbType.Char);
            ParamCodeCat.Value = Form1.CouleurCat;
            ParamCodeCat.Direction = ParameterDirection.Input;
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
            OracleCommand commandAfficherRep = new OracleCommand("TRIVIA", conn);
            commandAfficherRep.CommandText = "trivia.Getreponse";
            commandAfficherRep.CommandType = CommandType.StoredProcedure;

            OracleParameter DescParam = new OracleParameter("description", OracleDbType.RefCursor);
            DescParam.Direction = ParameterDirection.ReturnValue;
            commandAfficherRep.Parameters.Add(DescParam);

            OracleParameter orapamnumQuestion = new OracleParameter("numquestion", OracleDbType.Int32, 6);
            orapamnumQuestion.Direction = ParameterDirection.Input;
            OracleCommand orapnum = new OracleCommand("SELECT numquestion FROM questions where EnonceQuestion =" + "'" + LB_Question.Text + "'", conn);


            OracleDataReader numReader = orapnum.ExecuteReader();
            int num = 0;
            while (numReader.Read())
            {
                num = numReader.GetInt32(0);
            }

            orapamnumQuestion.Value = num;
            commandAfficherRep.Parameters.Add(orapamnumQuestion);
            int count = 0;
            OracleDataReader Reader = commandAfficherRep.ExecuteReader();
            while (Reader.Read())
            {
                if (count == 0) {
                    RB_Rep1.Text = Reader.GetString(0);
                }
                else if (count == 1) {
                    RB_Rep2.Text = Reader.GetString(0);
                }
                else if (count == 2) {
                    RB_Rep3.Text = Reader.GetString(0);
                }
                else if (count == 3) {
                    RB_Rep4.Text = Reader.GetString(0);
                }
                count++;
               
            }

        }

        private string getStringOfCheckedButton() {
            if (RB_Rep1.Checked)
                return RB_Rep1.Text;
            else if (RB_Rep2.Checked)
                return RB_Rep2.Text;
            else if (RB_Rep3.Checked)
                return RB_Rep3.Text;
            else
                return RB_Rep4.Text;

        }

        private bool ValiderReponse() {
            string cmdString = "SELECT NumReponse FROM Reponse WHERE Description='" + getStringOfCheckedButton() + "'";
            OracleCommand command = new OracleCommand(cmdString, conn);
            OracleDataReader Reader = command.ExecuteReader();

            int NumReponse = -1;
            while (Reader.Read())
                NumReponse = Reader.GetInt32(0);

            OracleCommand validationCommand = new OracleCommand("TRIVIA", conn);
            validationCommand.CommandText = "Trivia.ValiderReponse";
            validationCommand.CommandType = CommandType.StoredProcedure;

            OracleParameter param = new OracleParameter("NumeroReponse", OracleDbType.Int32);
            param.Direction = ParameterDirection.Input;
            param.Value = NumReponse;

            OracleParameter returnValue = new OracleParameter("EstBonne", OracleDbType.RefCursor);
            returnValue.Direction = ParameterDirection.ReturnValue;

            validationCommand.Parameters.Add(returnValue);
            validationCommand.Parameters.Add(param);

            Reader.Dispose();
            Reader = validationCommand.ExecuteReader();

            while (Reader.Read()) {
                if (Reader.GetString(0) == "O")
                {
                    return true;
                }
            }
            return false;
        }

        private void AfficherQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (!RB_Rep1.Checked && !RB_Rep2.Checked && !RB_Rep3.Checked && !RB_Rep4.Checked)
            {
                DialogResult = DialogResult.None;
                return;
            }
            else {
                BienRepondu = ValiderReponse();
            }
        }
    }
}
