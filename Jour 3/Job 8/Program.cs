using System;
using System.Linq;

namespace Job4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----Card-----");


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

            Console.WriteLine("-----TrapLocation-----");


            TrapLocation currentPos = new TrapLocation(5, 9);
            TrapLocation cible = new TrapLocation(3, 10);
            TrapLocation backupPos = currentPos;

            double distance = backupPos.DistanceTo(cible);
            Console.WriteLine(distance);

            Console.WriteLine("-----Monstre-----");

            List<Monster> mylist = new List<Monster>
            {
                new Monster("", 0, false),
                new Monster("", 0, false),
                new Monster("", 0, false),
                new Monster("", 0, false)

            };

            mylist[0].setMonster("Monstre1", 100, 1);
            mylist[1].setMonster("Monstre2", 200, 0);
            mylist[2].setMonster("Monstre3", 100, 0);
            mylist[3].setMonster("Monstre4", 300, 0);

            Console.WriteLine(mylist[0].getnameMonster());
            Console.WriteLine(mylist[0].gethealthMonster());
            Console.WriteLine(mylist[0].getstateMonster());

            int test = mylist[0].health + mylist[1].health + mylist[2].health + mylist[3].health;
            Console.WriteLine("Le nombre total de vie est de :" + " " + test);
            var newtest = mylist.MaxBy(s => s.health);
            Console.WriteLine(newtest?.health);
            Console.WriteLine(newtest?.name);


            Console.WriteLine("-----Sacoche-----");

            Pouch<Weapon> mywe = new Pouch<Weapon>();
            Pouch<Potion> mypo = new Pouch<Potion>();

            mywe.Store(new Weapon("Weapon"));
            mypo.Store(new Potion("Potion"));

            Console.WriteLine(mywe.GetCount());
            Console.WriteLine(mywe.Retrieve(0).name);
            Console.WriteLine(mypo.Retrieve(0).name);

            Console.WriteLine("-----Inspection-----");
            Hero myhero = new Hero("", 0, false);
            Merchant mymerchant = new Merchant("", 0, false);
            myhero.setMonster("hero", 100, 0);
            mymerchant.setMonster("marchand", 100, 0);
            Inspect<Monster> mymon = new Inspect<Monster>();
            Inspect<Merchant> mymer = new Inspect<Merchant>();
            Inspect<Hero> myher = new Inspect<Hero>();

            mymon.InspectEntity(mylist[0]);
            mymer.InspectEntity(mymerchant);
            myher.InspectEntity(myhero);

        }
    }
}