using System;
using System.Collections.Generic;
using System.Linq;

namespace TartarosRitual
{
    public static class HedgeCombat
    {
        public static void Run()
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("     JOB 06 : HEDGE LE MAGE NOIR");
            Console.WriteLine("==================================================\n");

            // Posture initiale : (stance, shieldPower, isCasting)
            var posture = ("Ombre", 50, false);

            // Expression Lambda pour le contrecoup
            Func<int, int> calculerContrecoup = power => power / 2;

            List<(string stance, int power, bool isCasting)> toursCombat = new()
            {
                ("Ombre", posture.Item2, false),
                ("Absorption", posture.Item2 - 10, false),
                ("Miasme", posture.Item2 - 20, true),
                ("Miasme", posture.Item2 - 30, true),
                ("Ombre", posture.Item2 - 40, false)
            };

            int currentShield = 50;
            int tour = 1;

            foreach (var tourState in toursCombat)
            {
                if (currentShield <= 0) break;

                var currentPosture = (tourState.stance, currentShield, tourState.isCasting);

                Console.WriteLine($"--- Tour {tour} ---");
                Console.WriteLine($"Posture : Stance = {currentPosture.stance}, Bouclier = {currentPosture.Item2}, Incantation = {currentPosture.isCasting}");

                int contrecoup = calculerContrecoup(currentPosture.Item2);
                Console.WriteLine($"Contrecoup potentiel : {contrecoup} dégâts.");

                // Pattern Matching sur Tuple
                string riposte = currentPosture switch
                {
                    ("Ombre", _, _) => "Utiliser un sort",
                    ("Absorption", _, _) => "Utiliser une attaque physique",
                    ("Miasme", _, true) => "Attaquer avec L'Égide de Tartaros",
                    _ => "Attaque inadaptée"
                };

                Console.WriteLine($"Action choisie : {riposte}");

                if (riposte != "Attaque inadaptée")
                {
                    currentShield -= 10;
                    Console.WriteLine("-> Attaque ADAPTÉE : Bouclier -10.");
                }
                else
                {
                    currentShield += 5;
                    Console.WriteLine("-> Attaque INADAPTÉE : Bouclier +5.");
                }

                Console.WriteLine($"Nouveau Bouclier : {currentShield}\n");
                tour++;
            }

            // Vérification LINQ
            List<int> historiqueBouclier = new List<int> { 50, 40, 30, 20, 10, currentShield };
            bool estDetruit = historiqueBouclier.Any(power => power <= 0);

            if (estDetruit || currentShield <= 0)
            {
                Console.WriteLine("✨ [LINQ Check] Le Miasme Miroir a été détruit avec succès !");
            }
        }
    }
}