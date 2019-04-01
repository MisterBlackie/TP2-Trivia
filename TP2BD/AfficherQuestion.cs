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
        private int NumeroBonneReponse; // Le numéro du radio button contenant la bonne réponse
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
            MessageBox.Show(ParamCodeCat.Value.ToString());

            OracleDataReader Reader = commandAfficherQuest.ExecuteReader();
            while (Reader.Read()) {

                LB_Question.Text = Reader.GetString(0);
                IDQuestion = Reader.GetInt32(1);
            }
        }

        
        public void ConfirmerReponse() {
            switch (NumeroBonneReponse) {
                case 1:
                    BienRepondu = RB_Rep1.Checked;
                    break;
                case 2:
                    BienRepondu = RB_Rep2.Checked;
                    break;
                case 3:
                    BienRepondu = RB_Rep3.Checked;
                    break;
                case 4:
                    BienRepondu = RB_Rep4.Checked;
                    break;
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
                    NumeroBonneReponse = 1;
                }
                if (count == 1) {
                    RB_Rep2.Text = Reader.GetString(0);
                    NumeroBonneReponse = 2;
                }
                if (count == 2) {
                    RB_Rep3.Text = Reader.GetString(0);
                    NumeroBonneReponse = 3;
                }
                if (count == 3) {
                    RB_Rep4.Text = Reader.GetString(0);
                    NumeroBonneReponse = 4;
                }
                count++;
               
            }

        }

        private void AfficherQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmerReponse();
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (!RB_Rep1.Checked && !RB_Rep2.Checked && !RB_Rep3.Checked && !RB_Rep4.Checked) {
                DialogResult = DialogResult.None;
            }
        }
    }
}
