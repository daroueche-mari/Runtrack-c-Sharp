using System;

namespace Job3
{
    public class MadAdventurer : CorruptedCreature
    {
        public MadAdventurer(string myname, int myhealth) : base(myname, myhealth){}

        public override int TakeMiasmaDamage(int damage)
        {
            health = (health - damage);
            Console.WriteLine("PV Restant" + " " + health);
            return 0;

        }

    }
}