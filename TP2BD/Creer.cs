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

    public partial class Creer : Form
    {
       
        public Creer()
        {
            InitializeComponent();
        }
        // Déclaration d'une connexion oracle //
        OracleConnection conn = new OracleConnection();
        private void Creer_Load(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TBX_Enonce.Text == ""  || TBX_DescRep1.Text == "" || TBX_DescRep2.Text == "" || TBX_DescRep3.Text == "" || TBX_DescRep4.Text == "" || LBX_Categorie.SelectedItems.ToString() == null)
            {
                MessageBox.Show("Veuiller remplir tout les champs");
                return;
            }

            //Ajoute une question
            char Categorie = 'a';
            if (LBX_Categorie.SelectedItem.ToString() == "Sport")
            {
                Categorie = 'V';
            }
            else if (LBX_Categorie.SelectedItem.ToString() == "Jeux vidéos")
            {
                Categorie = 'B';
            }
            else if (LBX_Categorie.SelectedItem.ToString() == "Art")
            {
                Categorie = 'J';
            }
            else if (LBX_Categorie.SelectedItem.ToString() == "Culture")
            {
                Categorie = 'R';
            }
            OracleCommand oraAjoutQuestion = new OracleCommand("TRIVIA", conn);
            oraAjoutQuestion.CommandText = "TRIVIA.CreerQuestion";
            oraAjoutQuestion.CommandType = CommandType.StoredProcedure;

            //OracleParameter oraPamCodecat = new OracleParameter("numquestion", OracleDbType.Int32);
            //oraPamCodecat.Direction = ParameterDirection.Input;
            //oraPamCodecat.Value = 0;
            //oraAjoutQuestion.Parameters.Add(oraPamCodecat);

            OracleParameter oraPamEnonce = new OracleParameter("EnonceQuestion", OracleDbType.Varchar2 , 300);
            oraPamEnonce.Direction = ParameterDirection.Input;
            oraPamEnonce.Value = TBX_Enonce.Text;
            oraAjoutQuestion.Parameters.Add(oraPamEnonce);


            OracleParameter oraPamFlag = new OracleParameter("Flag", OracleDbType.Char, 1);
            oraPamFlag.Direction = ParameterDirection.Input;
            oraPamFlag.Value = 'N';
            oraAjoutQuestion.Parameters.Add(oraPamFlag);

            OracleParameter oraPamCatQuestion = new OracleParameter("CodeCategorie", OracleDbType.Char, 2);
            oraPamCatQuestion.Direction = ParameterDirection.Input;
            oraPamCatQuestion.Value = Categorie;
            oraAjoutQuestion.Parameters.Add(oraPamCatQuestion);
           

            oraAjoutQuestion.ExecuteNonQuery();

            //Ajoute une Réponsse 1

            OracleCommand oraAjoutReponse1 = new OracleCommand("TRIVIA", conn);
            oraAjoutReponse1.CommandText = "TRIVIA.CreerReponse";
            oraAjoutReponse1.CommandType = CommandType.StoredProcedure;

            OracleParameter oraPamDESC1 = new OracleParameter("description", OracleDbType.Varchar2, 60);
            oraPamDESC1.Direction = ParameterDirection.Input;
            oraPamDESC1.Value = TBX_DescRep1.Text;
            oraAjoutReponse1.Parameters.Add(oraPamDESC1);


            OracleParameter oraPamEstBonne1 = new OracleParameter("estbonne", OracleDbType.Char, 1);
            oraPamEstBonne1.Direction = ParameterDirection.Input;
            if (BOX_ChoixReponse.Value == 1)
            {
                oraPamEstBonne1.Value = 'O';
            }
            else
            {
                oraPamEstBonne1.Value = 'N';
            }
            oraAjoutReponse1.Parameters.Add(oraPamEstBonne1);

            OracleParameter orapamnumQuestion = new OracleParameter("numquestion", OracleDbType.Int32, 6);
            orapamnumQuestion.Direction = ParameterDirection.Input;
            OracleCommand orapnum = new OracleCommand("SELECT numquestion FROM questions where EnonceQuestion =" + "'" + TBX_Enonce.Text + "'", conn);
          

            OracleDataReader numReader = orapnum.ExecuteReader();
            int num = 0;
            while (numReader.Read())
            {
               num = numReader.GetInt32(0);
            }


            orapamnumQuestion.Value = num;
           

            oraAjoutReponse1.Parameters.Add(orapamnumQuestion);


            oraAjoutReponse1.ExecuteNonQuery();

            //Ajoute une Réponsse 2

            OracleCommand oraAjoutReponse2 = new OracleCommand("TRIVIA", conn);
            oraAjoutReponse2.CommandText = "TRIVIA.CreerReponse";
            oraAjoutReponse2.CommandType = CommandType.StoredProcedure;

            OracleParameter oraPamDESC2 = new OracleParameter("description", OracleDbType.Varchar2, 60);
            oraPamDESC2.Direction = ParameterDirection.Input;
            oraPamDESC2.Value = TBX_DescRep2.Text;
            oraAjoutReponse2.Parameters.Add(oraPamDESC2);


            OracleParameter oraPamEstBonne2 = new OracleParameter("estbonne", OracleDbType.Char, 2);
            oraPamEstBonne2.Direction = ParameterDirection.Input;
            if (BOX_ChoixReponse.Value == 2)
            {
                oraPamEstBonne2.Value = 'O';
            }
            else
            {
                oraPamEstBonne2.Value = 'N';
            }
            oraAjoutReponse2.Parameters.Add(oraPamEstBonne2);


            OracleParameter orapamnumQuestion2 = new OracleParameter("numquestion", OracleDbType.Int32, 6);
            orapamnumQuestion2.Direction = ParameterDirection.Input;
            OracleCommand orapnum2 = new OracleCommand("SELECT numquestion FROM questions where EnonceQuestion =" + "'" + TBX_Enonce.Text + "'", conn);
            
            OracleDataReader numReader2 = orapnum.ExecuteReader();
            int num2 = 0;
            while (numReader2.Read())
            {
                num2 = numReader2.GetInt32(0);
            }


            orapamnumQuestion2.Value = num;


            oraAjoutReponse2.Parameters.Add(orapamnumQuestion2);

            oraAjoutReponse2.ExecuteNonQuery();

            //Ajoute une Réponsse 3

            OracleCommand oraAjoutReponse3 = new OracleCommand("TRIVIA", conn);
            oraAjoutReponse3.CommandText = "TRIVIA.CreerReponse";
            oraAjoutReponse3.CommandType = CommandType.StoredProcedure;

            OracleParameter oraPamDESC3 = new OracleParameter("description", OracleDbType.Varchar2, 60);
            oraPamDESC3.Direction = ParameterDirection.Input;
            oraPamDESC3.Value = TBX_DescRep3.Text;
            oraAjoutReponse3.Parameters.Add(oraPamDESC3);


            OracleParameter oraPamEstBonne3 = new OracleParameter("estbonne", OracleDbType.Char, 3);
            oraPamEstBonne3.Direction = ParameterDirection.Input;
            if (BOX_ChoixReponse.Value == 3)
            {
                oraPamEstBonne3.Value = 'O';
            }
            else
            {
                oraPamEstBonne3.Value = 'N';
            }
            oraAjoutReponse3.Parameters.Add(oraPamEstBonne3);



            OracleParameter orapamnumQuestion3 = new OracleParameter("numquestion", OracleDbType.Int32, 6);
            orapamnumQuestion3.Direction = ParameterDirection.Input;
            OracleCommand orapnum3 = new OracleCommand("SELECT numquestion FROM questions where EnonceQuestion =" + "'" + TBX_Enonce.Text + "'", conn);
           
            OracleDataReader numReader3 = orapnum.ExecuteReader();
            int num3 = 0;
            while (numReader3.Read())
            {
                num3 = numReader3.GetInt32(0);
            }


            orapamnumQuestion3.Value = num;


            oraAjoutReponse3.Parameters.Add(orapamnumQuestion3);

            oraAjoutReponse3.ExecuteNonQuery();

            //Ajoute une Réponsse 4

            OracleCommand oraAjoutReponse4 = new OracleCommand("TRIVIA", conn);
            oraAjoutReponse4.CommandText = "TRIVIA.CreerReponse";
            oraAjoutReponse4.CommandType = CommandType.StoredProcedure;

            OracleParameter oraPamDESC4 = new OracleParameter("description", OracleDbType.Varchar2, 60);
            oraPamDESC4.Direction = ParameterDirection.Input;
            oraPamDESC4.Value = TBX_DescRep4.Text;
            oraAjoutReponse4.Parameters.Add(oraPamDESC4);


            OracleParameter oraPamEstBonne4 = new OracleParameter("estbonne", OracleDbType.Char, 4);
            oraPamEstBonne4.Direction = ParameterDirection.Input;
            if (BOX_ChoixReponse.Value == 4)
            {
                oraPamEstBonne4.Value = 'O';
            }
            else
            {
                oraPamEstBonne4.Value = 'N';
            }
            oraAjoutReponse4.Parameters.Add(oraPamEstBonne4);

            OracleParameter orapamnumQuestion4 = new OracleParameter("numquestion", OracleDbType.Int32, 6);
            orapamnumQuestion4.Direction = ParameterDirection.Input;
            OracleCommand orapnum4 = new OracleCommand("SELECT numquestion FROM questions where EnonceQuestion =" + "'" + TBX_Enonce.Text + "'", conn);
           
            OracleDataReader numReader4 = orapnum.ExecuteReader();
            int num4 = 0;
            while (numReader4.Read())
            {
                num4 = numReader4.GetInt32(0);
            }


            orapamnumQuestion4.Value = num;


            oraAjoutReponse4.Parameters.Add(orapamnumQuestion4);


            oraAjoutReponse4.ExecuteNonQuery();

            TBX_DescRep1.Text = "";
            TBX_DescRep2.Text = "";
            TBX_DescRep3.Text = "";
            TBX_DescRep4.Text = "";
            TBX_Enonce.Text = "";

        }

      
    }
}
