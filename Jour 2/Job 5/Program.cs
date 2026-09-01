using System;

namespace Job4
{
    public class Program
    {
        public static void Main()
        {
            ReturnCard carte1 = new ReturnCard(0, 0);
            ReturnCard carte2 = new ReturnCard(carte1);

            Console.WriteLine(carte1.SetCard(0));
            Console.WriteLine("Arrivé au premier donjon");
            Console.WriteLine(carte1.AddCard(1));
            Console.WriteLine("Le nombre total de carte est de :" + " " + ReturnCard.TotalCardIssued());
            ReturnCard.GetPostRules();
            Console.WriteLine("Arrivé au deuxième donjon");
            Console.WriteLine(carte2.AddCard(1));
            Console.WriteLine("Le nombre total de carte est de :" + " " + ReturnCard.TotalCardIssued());
            ReturnCard.GetPostRules();


            TrapLocation currentPos = new TrapLocation(5, 9);
            TrapLocation cible = new TrapLocation(3, 10);
            TrapLocation backupPos = currentPos;

            double distance = backupPos.DistanceTo(cible);
            Console.WriteLine(distance);

        }
    }
}