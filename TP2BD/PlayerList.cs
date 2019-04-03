using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2BD
{
    public class PlayerList
    {
        private List<Player> Liste { get; set; }
        private int IndexPlyAyantTour;

        public PlayerList() {
            Liste = new List<Player>();
        }

        public void Add(Player Joueur) {
            Liste.Add(Joueur);
        }

        public bool Remove(string Alias) {
            Player p = FindPlayer(Alias);

            if (p != null) {

                int IndexPlayer = Liste.FindIndex(ply => { return ply.GetAlias() == Alias; }); // Index du joueur à retirer
                if (IndexPlayer < IndexPlyAyantTour)
                {
                    IndexPlyAyantTour--;
                }
                return Liste.Remove(p);
            }

            return false;
        }

        public bool Remove(Player Joueur) {
            return Remove(Joueur.GetAlias());
        }

        public Player FindPlayer(string Alias) {
            foreach (Player p in Liste)
            {
                if (p.GetAlias() == Alias)
                {
                    return p;
                }
            }

            return null;
        }

        public void NextTour() {
            if (IndexPlyAyantTour + 1 >= Liste.Count)
            {
                IndexPlyAyantTour = 0;
            }
            else {
                IndexPlyAyantTour++;
            }
        }

        /// <summary>
        /// Retourne le joueur qui doit jouer, celui qui as le tour.
        /// </summary>
        /// <returns>Player ayant le tour</returns>
        public Player GetJoueur() {
            if (Liste.Count == 0)
                return null;
            else
                return Liste.ElementAt(IndexPlyAyantTour);
        }

        /// <summary>
        /// Ajoute un point à une catégorie
        /// </summary>
        /// <param name="Code">Code de couleur de la catégorie</param>
        public bool AddScoreToRoundPlayer(ECodeCouleur Code) {
            Liste.ElementAt(IndexPlyAyantTour).Score[Code]++;

            return Liste.ElementAt(IndexPlyAyantTour).Score[Code] >= 5;
        }
    }
}
