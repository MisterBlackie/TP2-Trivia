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
    public partial class Menu : Form
    {
        private OracleConnection conn;
        public PlayerList Liste;
        public Menu(ref OracleConnection Connection)
        {
            InitializeComponent();
            conn = Connection;
        }

        private void BTN_CreerQuestion_Click(object sender, EventArgs e)
        {
            new AjouterQuestion(ref conn).ShowDialog();
        }

        private void BTN_CreerPartie_Click(object sender, EventArgs e)
        {
            CreerPartie Form = new CreerPartie(conn);
            if (Form.ShowDialog() == DialogResult.OK) {
                DialogResult = DialogResult.OK;
                Liste = Form.ListeJoueur;
            }
        }
    }
}
