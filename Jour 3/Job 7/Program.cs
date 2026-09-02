using System;

namespace Job7
{
    public class Program
    {
        public static void Main()
        {
            ReceptacleGolem mytest = new ReceptacleGolem("", 0);
            ReceptacleGolem loot = new ReceptacleGolem("", 0);
            loot.name = "L'Egide de Tartaros";
            mytest.name = "SuperGolem";
            mytest.health = 100;

            Console.WriteLine("Le combat contre le golem commence");
            Console.WriteLine("Tour 1");
            Console.WriteLine(mytest.name + " " + "attaque");
            mytest.ExecutePhasePattern();
            Console.WriteLine("Le chevalier attaque le golem");
            mytest.TakeDamage(30);
            Console.WriteLine("Les vies restant du" + " " + mytest.name + " : " + mytest.health);

            Console.WriteLine("---------------------");

            Console.WriteLine("Tour 2");
            Console.WriteLine("Le chevalier attaque le golem");
            mytest.TakeDamage(20);
            Console.WriteLine(mytest.name + " " + "attaque");
            mytest.ExecutePhasePattern();
            Console.WriteLine("Les vies restant du" + " " + mytest.name + " : " + mytest.health);

            Console.WriteLine("---------------------");

            Console.WriteLine("Tour 3");
            Console.WriteLine(mytest.name + " " + "attaque");
            mytest.ExecutePhasePattern();
            Console.WriteLine("Le chevalier attaque le golem");
            mytest.TakeDamage(30);
            Console.WriteLine("Les vies restant du" + " " + mytest.name + " : " + mytest.health);

            Console.WriteLine("---------------------");

            Console.WriteLine("Tour 4");
            Console.WriteLine(mytest.name + " " + "attaque");
            mytest.ExecutePhasePattern();
            Console.WriteLine("Le chevalier attaque le golem");
            mytest.TakeDamage(30);
            Console.WriteLine("Les vies restant du" + " " + mytest.name + " : " + mytest.health);
            Console.WriteLine("Félicitation vous avez obtenu :" + " " + loot.name);
        }
    }
}