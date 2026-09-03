using System;

namespace Jour01
{
    class Program
    {
        // Job 4 : La porte magique
        public static void PorteMagique()
        {
            Console.Write("Entrez votre nom : ");
            string ?nom = Console.ReadLine();

            Console.Write("Entrez votre classe : ");
            string ?classe = Console.ReadLine();

            Console.Write("Entrez votre niveau : ");
            string ?niveau = Console.ReadLine();

            Console.WriteLine($"\nBienvenue {nom}, {classe} de niveau {niveau}!");
            Console.WriteLine("Ouverture de la porte.");
        }

        // Job 5 : Le secrétaire
        public static void DisplayAdventurer(string nom, string classe, int age, int niveau, double piecesDOr, bool estNouveau)
        {
            string statutNouveau = estNouveau ? "est nouveau" : "n’est pas nouveau";
            Console.WriteLine($"L’aventurier {nom}, un {classe} de {age} ans, est niveau {niveau} et a une bourse de {piecesDOr} pièces d’or.");
            Console.WriteLine($"Cet aventurier {statutNouveau}.");
        }

        static void Main(string[] args)
        {
            PorteMagique();
            Console.WriteLine();
            DisplayAdventurer("Bob", "guerrier", 45, 5, 4530.6, false);
        }
    }
}