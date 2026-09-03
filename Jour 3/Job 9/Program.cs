using System;

namespace Jour04
{
    // 1. Énumération Role
    public enum Role
    {
        Guerrier, // Votre classe d'aventurier
        Mage,     // Classe de Sameth
        Boss
    }

    // 2. Struct Stats immuable (readonly record struct ou readonly struct)
    public readonly struct Stats
    {
        public int VieMax { get; }
        public int Attaque { get; }
        public int Defense { get; }

        public Stats(int vieMax, int attaque, int defense)
        {
            VieMax = vieMax;
            Attaque = attaque;
            Defense = defense;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== LE GARDIEN DU DONJON ===\n");

            // Initialisation des personnages
            Combattant joueur = new Combattant("Aventurier", Role.Guerrier, new Stats(100, 25, 8));
            Combattant sameth = new Combattant("Sameth", Role.Mage, new Stats(80, 30, 4));
            Combattant boss = new Combattant("Gardien du Donjon", Role.Boss, new Stats(250, 22, 12), "Enragé");

            int tour = 1;

            // Boucle de combat
            while (boss.EstVivant && (joueur.EstVivant || sameth.EstVivant))
            {
                Console.WriteLine($"--- TOUR {tour} ---");

                // --- TOUR DU DUO (Joueur + Sameth) ---
                if (joueur.EstVivant)
                {
                    ExecuterAttaque(joueur, boss);
                }

                if (boss.EstVivant && sameth.EstVivant)
                {
                    ExecuterAttaque(sameth, boss);
                }

                // --- TOUR DU BOSS ---
                if (boss.EstVivant)
                {
                    // Le boss attaque un membre vivant du duo au hasard
                    Combattant cible = (joueur.EstVivant, sameth.EstVivant) switch
                    {
                        (true, true) => (new Random().Next(2) == 0) ? joueur : sameth,
                        (true, false) => joueur,
                        _ => sameth
                    };

                    ExecuterAttaque(boss, cible);
                }

                Console.WriteLine($"\n[Statut] {boss.Nom}: {boss.Sante} PV | {joueur.Nom}: {joueur.Sante} PV | {sameth.Nom}: {sameth.Sante} PV");
                Console.WriteLine(new string('-', 30) + "\n");
                tour++;
            }

            // --- FIN DU COMBAT ---
            if (!boss.EstVivant)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("Le Gardien du Donjon s'effondre dans un dernier rugissement !");
                Console.WriteLine("\nEn mourant, le Boss laisse tomber un médaillon gravé d'un symbole mystérieux.");
                Console.WriteLine("Vous ramassez le médaillon et le tendez à votre compagnon :");
                Console.WriteLine("« Tiens, Sameth. Prends-le pour compenser les objets que tu as perdus. »");
                Console.WriteLine("==================================================");
            }
            else
            {
                Console.WriteLine("Le duo a été vaincu...");
            }
        }

        private static void ExecuterAttaque(Combattant attaquant, Combattant cible)
        {
            int degats = BattleSystem.CalculateDamage(attaquant.Stats.Attaque, cible.Stats.Defense);
            cible.SubirDegats(degats);
            Console.WriteLine($"{attaquant.Nom} ({attaquant.Role}) attaque {cible.Nom} et inflige {degats} points de dégâts !");
        }
    }
}