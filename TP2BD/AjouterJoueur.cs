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
        PlayerList Liste;
        OracleConnection conn;
        public AjouterJoueur(ref PlayerList Liste, ref OracleConnection Connection)
        {
            InitializeComponent();
            this.Liste = Liste;
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
                MessageBox.Show("Les cha,ps de saisie doivent être remplie.");
                return false;
            }
        }

        private bool ValiderAlias() {
            if (Liste.FindPlayer(TB_Alias.Text) != null)
                return false;
            else
                return true;
        }

        private void CreatePlayer()  {
            if (!ValiderInfo()) return;

            


        }
    }
}
