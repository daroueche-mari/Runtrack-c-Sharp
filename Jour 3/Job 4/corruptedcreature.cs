using System;

namespace Job3
{
    public class CorruptedCreature
    {
        public string name {get;set;}
        public int health {get;set;}


        public CorruptedCreature(string myname, int myhealth)
        {
            name = myname;
            health = myhealth;
        }
        
        public virtual int TakeMiasmaDamage(int damage)
        {
            health = health - damage;
            Console.WriteLine("PV Restant" + " " + health);
            return 0;
        }

    }
}