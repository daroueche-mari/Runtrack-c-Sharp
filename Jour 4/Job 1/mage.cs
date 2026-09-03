using System;

namespace Job1
{
    public class Mage : Combattant
    {
        public Mage(string myname, int myaggresivite) : base(myname, myaggresivite){}

        public override string Strategie(string typejoueur)
        {
            return base.Strategie(typejoueur);
        }
    }

}