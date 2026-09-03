using System;

namespace Job1
{
    public class Combattant
    {
        public string name { get; set; }
        public int aggresivite { get; set; }
        
        public Combattant(string myname, int myaggresivite)
        {
            name = myname;
            aggresivite = myaggresivite;
        }

        public virtual string Strategie(string typejoueur)
        {
            return typejoueur switch
            {

                "Mage1" or "Mage3" when aggresivite > 5 => "Interrompre l'incantation en priorité !",
                "Mage2" => "Denfense standard !",
                "Archer1" or "Archer2" => "Se mettre à couvert !",
                "Guerrier1" or "Guerrier2" when aggresivite <= 3 => "Esquiver et ignorer !",
                _ => "Trouver une solution !"

            };
        }
    }

}