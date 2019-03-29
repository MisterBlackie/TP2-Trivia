using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2BD
{
    class Player
    {
        private string Alias { get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; }

        public Player(string Alias, string Nom, string Prenom) {
            this.Alias = Alias;
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        public string GetAlias() {
            return Alias;
        }
    }
}
