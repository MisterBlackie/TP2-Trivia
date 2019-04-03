using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2BD
{
    public class Player
    {
        private string Alias { get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; }

        public Dictionary<ECodeCouleur, int> Score = new Dictionary<ECodeCouleur, int>();

        public Player(string Alias, string Nom, string Prenom) {
            this.Alias = Alias;
            this.Nom = Nom;
            this.Prenom = Prenom;

            setListe();
        }

        private void setListe() {
            foreach (var code in (ECodeCouleur[])Enum.GetValues(typeof(ECodeCouleur))) {
                if (code != ECodeCouleur.BL)
                  Score.Add(code, 0);
            }
        }

        public string GetAlias() {
            return Alias;
        }

        public override string ToString() {
            return Alias;
        }

        public ECodeCouleur GetLowestCategorie() {
            ECodeCouleur PlusFaible = ECodeCouleur.B; // Valeur de base qui sera changé par l'actuelle plus faible catégorie
            foreach (var Code in Score) {
                if (Code.Value < Score[PlusFaible])
                    PlusFaible = Code.Key;
            }

            return PlusFaible;
        }
    }
}
