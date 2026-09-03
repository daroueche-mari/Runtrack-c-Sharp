using System;
using System.Collections.Generic;

namespace Jour01
{
    class Program
    {
        // Job 6 : La première épreuve
        public static void Identify(int niveau)
        {
            if (niveau == 0)
                Console.WriteLine("Créature inoffensive (Niveau 0).");
            else if (niveau == 1)
                Console.WriteLine("Créature très faible (Niveau 1).");
            else if (niveau >= 2 && niveau <= 4)
                Console.WriteLine("Créature de menace modérée (Niveau 2-4).");
            else
                Console.WriteLine("DANGER ! Créature très puissante (Niveau 5+).");
        }

        // Job 7 : Les mannequins d'entraînement
        public static void ListTargets(IEnumerable<string> targets)
        {
            Console.WriteLine(string.Join(" -> ", targets));
        }

        // Job 8 : Rester concentré
        public static void Mix(List<string> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static void Main(string[] args)
        {
            // Job 6 Test
            Identify(3);

            // Job 7 & 8 Test
            List<string> targets = new List<string> { "Premier", "Deuxième", "Troisième", "Quatrième", "Cinquième" };

            Console.Write("\nCombien de fois voulez-vous mélanger la liste ? ");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                ListTargets(targets);
                for (int i = 1; i <= x; i++)
                {
                    Mix(targets);
                    Console.WriteLine($"La liste est mélangée {i} fois");
                    ListTargets(targets);
                }
            }
        }
    }
}