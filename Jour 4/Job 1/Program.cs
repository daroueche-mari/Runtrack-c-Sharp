using System;

namespace Job1
{
    public class Program
    {
        public static void Main()
        {
            var players = (
                myarcher1: new Archer("Archer1", 15),
                myarcher2: new Archer("Archer2", 15),
                mymage1: new Mage("Mage1", 6),
                mymage2: new Mage("Mage2", 15),
                mymage3: new Mage("Mage3", 6),
                myguerrier1: new Guerrier("Guerrier1", 2),
                myguerrier2: new Guerrier("Guerrier2", 2)
            );

            Console.WriteLine("Le combat commence !");
            Console.WriteLine("Archer 1 :" + " " + players.myarcher1.Strategie("Archer1"));
            Console.WriteLine("Archer 2 :" + " " + players.myarcher2.Strategie("Archer2"));
            Console.WriteLine("Les Archers sont à couvert et préparent une incantation !");
            Console.WriteLine("Les Mages se préparent en cas de mauvaise surprises !");
            Console.WriteLine("Mage 1 :" + " " + players.mymage1.Strategie("Mage1"));
            Console.WriteLine("Mage 2 :" + " " + players.mymage2.Strategie("Mage2"));
            Console.WriteLine("Mage 3 :" + " " + players.mymage3.Strategie("Mage3"));
            Console.WriteLine("Les Archers lancent l'incantation et utilise Pluie de Flèche Magique !");
            Console.WriteLine("Guerrier 1 :" + " " + players.myguerrier1.Strategie("Guerrier1"));
            Console.WriteLine("Guerrier 2 :" + " " + players.myguerrier2.Strategie("Guerrier2"));
            Console.WriteLine("Les Mages n'ont pas pu esquiver !");

        }
    }
}