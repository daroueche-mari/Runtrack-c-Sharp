using System;

namespace Jour04
{
    public class Combattant
    {
        public string Nom { get; }
        public Role Role { get; }
        public Stats Stats { get; }

        // Encapsulation de la santé
        private int _sante;
        public int Sante
        {
            get => _sante;
            private set => _sante = Math.Max(0, value); // Empêche la vie de descendre sous 0
        }

        public bool EstVivant => Sante > 0;

        // Champ/Propriété nullable pour un effet d'état (ex: "Empoisonné", "Brûlé", null)
        public string? EffetEtat { get; set; }

        // Utilisation de 'this' dans le constructeur
        public Combattant(string nom, Role role, Stats stats, string? effetEtat = null)
        {
            this.Nom = nom;
            this.Role = role;
            this.Stats = stats;
            this._sante = stats.VieMax;
            this.EffetEtat = effetEtat;
        }

        public void SubirDegats(int degats)
        {
            Sante -= degats;
        }
    }
}
  
  