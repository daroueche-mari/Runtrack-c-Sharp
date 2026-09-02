using System;

namespace Job7
{


    public sealed class ReceptacleGolem : BossEntity
    {

        public ReceptacleGolem(string myname, int myhealth) : base(myname, myhealth) { }

        public override void TakeDamage(int amount)
        {
            health -= amount;
        }
        
        public override void ExecutePhasePattern()
        {
            if (health > 50)
            {
                Console.WriteLine("Golem : Coup de pierre");
            }
            else if (health == 50)
            {
                Console.WriteLine("Amplification du pouvoir maléfique");
                Console.WriteLine("Golem : Attaque de zone mentale");
                Console.WriteLine("Attention le sceau est fissuré");
            }
        }
    }
}