using System;

namespace Job1
{
    public class Archer : Combattant
    {
        public Archer(string myname, int myaggresivite) : base(myname, myaggresivite){}

        public override string Strategie(string typejoueur)
        {
            return base.Strategie(typejoueur);
        }
    }

}