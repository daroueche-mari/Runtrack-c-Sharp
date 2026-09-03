using System;

namespace Job1
{
    public class Guerrier : Combattant
    {
        public Guerrier(string myname, int myaggresivite) : base(myname, myaggresivite){}

        public override string Strategie(string typejoueur)
        {
            return base.Strategie(typejoueur);
        }
    }

}