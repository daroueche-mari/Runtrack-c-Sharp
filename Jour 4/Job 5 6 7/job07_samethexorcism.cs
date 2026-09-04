using System;

namespace TartarosRitual
{
    public static class SamethExorcism
    {
        // Fonction Exorcise manipulant les tuples
        public static (int health, int corruption, bool isConscious) Exorcise((int health, int corruption, bool isConscious) state)
        {
            int newHealth = Math.Min(100, state.health - 20);
            int newCorruption = state.corruption - 15;
            bool newIsConscious = newHealth > 20;

            return (newHealth, newCorruption, newIsConscious);
        }

        public static void Run()
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("     JOB 07 : LA DÉLIVRANCE DE SAMETH");
            Console.WriteLine("==================================================\n");

            // État initial (physicalHealth, corruptionLevel, isConscious)
            (int health, int corruption, bool isConscious) sameth = (100, 50, true);

            Console.WriteLine($"État initial : Santé = {sameth.health}, Corruption = {sameth.corruption}, Conscient = {sameth.isConscious}\n");

            int etape = 1;
            bool termine = false;

            while (!termine)
            {
                Console.WriteLine($"--- Utilisation {etape} de L'Égide ---");

                sameth = Exorcise(sameth);

                // Pattern Matching sur Tuple avec motifs relationnels
                string analyse = sameth switch
                {
                    ( > 0, <= 0, _) => "Sameth est libéré !",
                    ( > 20, > 0, true) => "Sameth résiste, poursuite de la purification avec L'Égide.",
                    ( <= 20 and > 0, > 0, false) => "Sameth a perdu connaissance.",
                    ( <= 0, _, _) => "Le corps de Sameth n'a pas résisté à l'exorcisme.",
                    _ => "État indéterminé..."
                };

                Console.WriteLine($"Santé = {sameth.health}, Corruption = {sameth.corruption}, Conscient = {sameth.isConscious}");
                Console.WriteLine($"Résultat : {analyse}\n");

                if (sameth.corruption <= 0 || sameth.health <= 0)
                {
                    termine = true;
                }

                etape++;
            }
        }
    }
}