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
    public partial class CreerPartie : Form
    {
        private OracleConnection conn;

        private int MAXPLAYER = 4;
        private int MINPLAYER = 2;

        public PlayerList ListeJoueur = new PlayerList();
        public CreerPartie(OracleConnection Connection)
        {
            InitializeComponent();
            conn = Connection;
        }

        /// <summary>
        /// Rajoute un joueur à la base de donnée
        /// </summary>
        /// <returns></returns>
        private Player AddPlayer() {
            // Creer Form
            // Renvoyer joueur
            throw new NotImplementedException();
        }

        /// <summary>
        /// Affiche les joueurs de la base de donnée dans la list box
        /// </summary>
        private void AfficherJoueur() {
            string CmdText = "SELECT * FROM Joueur";
            OracleCommand Command = new OracleCommand(CmdText, conn);

            OracleDataReader Reader = Command.ExecuteReader();

            while (Reader.Read()) {
                Player P = new Player(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2));
                LBX_AvailablePlayer.Items.Add(P);
            }
        }

        /// <summary>
        /// Change l'état des boutons d'ajout des list box et de craétion de partie
        /// </summary>
        private void ChangerEtatButton() {
            if (LBX_AddedPlayer.SelectedItem != null)
                BTN_RemovePlayer.Enabled = true;
            else
                BTN_RemovePlayer.Enabled = false;

            if (LBX_AvailablePlayer.SelectedItem != null)
                BTN_AddPlayer.Enabled = true;
            else
                BTN_AddPlayer.Enabled = false;

            ChangerEtatCreateGameButton();
        }

        private void ChangerEtatCreateGameButton() {
            if (LBX_AddedPlayer.Items.Count > 0)
                BTN_CreateGame.Enabled = true;
            else
                BTN_CreateGame.Enabled = false;

        }

        private void BTN_AddPlayer_Click(object sender, EventArgs e)
        {
            if (LBX_AvailablePlayer.SelectedItem != null) {
                LBX_AddedPlayer.Items.Add(LBX_AvailablePlayer.SelectedItem);
                ListeJoueur.Add((Player)LBX_AvailablePlayer.SelectedItem);
                LBX_AvailablePlayer.Items.Remove(LBX_AvailablePlayer.SelectedItem);
            }
            ChangerEtatButton();
        }

        private void BTN_RemovePlayer_Click(object sender, EventArgs e)
        {
            if (LBX_AddedPlayer.SelectedItem != null) {
                LBX_AvailablePlayer.Items.Add(LBX_AddedPlayer.SelectedItem);
                ListeJoueur.Remove((Player)LBX_AddedPlayer.SelectedItem);
                LBX_AddedPlayer.Items.Remove(LBX_AddedPlayer.SelectedItem);
            }
            ChangerEtatButton();
        }

        private void BTN_CreatePlayer_Click(object sender, EventArgs e)
        {
            Player p = AddPlayer();
            if (p != null)
            {
                LBX_AvailablePlayer.Items.Add(p);
            }
        }

        private void BTN_CreateGame_Click(object sender, EventArgs e)
        {
            if (LBX_AddedPlayer.Items.Count < MINPLAYER || LBX_AddedPlayer.Items.Count > MAXPLAYER) {
                DialogResult = DialogResult.None;
                MessageBox.Show("Le nombre de joueur doit être entre " + MINPLAYER + " et " + MAXPLAYER, "Erreur", MessageBoxButtons.OK);
            }
        }

        private void CreerPartie_Load(object sender, EventArgs e)
        {
            AfficherJoueur();
        }

        private void LBX_AddedPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangerEtatButton();
        }

        private void LBX_AvailablePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangerEtatButton();
        }
    }
}
