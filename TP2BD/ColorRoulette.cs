using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TP2BD
{
    /// <summary>
    /// Représente les codes de couleurs des catégorie
    /// </summary>
    public enum ECodeCouleur {
        B, // Bleu
        J, // Jaune
        V, // Vert
        R, // Rouge
        BL // Blanc
    }
    public partial class ColorRoulette : PictureBox
    {
        private List<KeyValuePair<ECodeCouleur, Color>> CodeCouleur = new List<KeyValuePair<ECodeCouleur, Color>>();
        private Random Randomizer = new Random();
        private System.Timers.Timer Timer;
        private int NbRoulement;
        private ECodeCouleur CouleurChoisie;
        public ColorRoulette()
        {
            InitializeComponent();
            this.NbRoulement = 5;
            SetTimer();
            SetCouleur(); 
        }

        /// <summary>
        /// Crée les codes des couleurs utilisée dans  la roulette
        /// </summary>.
        private void SetCouleur() {
            CodeCouleur.Add(new KeyValuePair<ECodeCouleur, Color>(ECodeCouleur.B, Color.Blue));
            CodeCouleur.Add(new KeyValuePair<ECodeCouleur, Color>(ECodeCouleur.J, Color.Yellow));
            CodeCouleur.Add(new KeyValuePair<ECodeCouleur, Color>(ECodeCouleur.V, Color.Green));
            CodeCouleur.Add(new KeyValuePair<ECodeCouleur, Color>(ECodeCouleur.R, Color.Red));
            CodeCouleur.Add(new KeyValuePair<ECodeCouleur, Color>(ECodeCouleur.BL, Color.White));
        }

        public void Tourner() {
            Timer.Start();
            Thread thread = new Thread(Wait);
            thread.Start();
            thread.Join();
            Timer.Stop();
        }

        private void Wait() {
            long Temps = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + NbRoulement;
            while (DateTimeOffset.UtcNow.ToUnixTimeSeconds() != Temps)
            {

            }
        }

        private void SetTimer() {
            Timer = new System.Timers.Timer(20);
            Timer.Elapsed += OnTimeElapsed;
            Timer.AutoReset = true;
            Timer.Enabled = false;
        }
        private int Randomize() {
            return Randomizer.Next(CodeCouleur.Count);
        }

        private void OnTimeElapsed(object source, System.Timers.ElapsedEventArgs e) {
            ChangerCouleur();
        }

        private void ChangerCouleur() {
            int index = Randomize();
            Color Couleur = CodeCouleur.ElementAt(index).Value;
            CouleurChoisie = CodeCouleur.ElementAt(index).Key;
            BackColor = Couleur;
        }

        /// <summary>
        /// Retourne le code de couleur choisi par la roulette
        /// </summary>
        /// <returns>Code de couleur</returns>
        public ECodeCouleur GetCouleur() {
            return CouleurChoisie;
        }
    }
}
