using System;

namespace Job01
{
    public enum PotionType
    {
        Health,
        Mana,
        Stamina
    }

    public class Order
    {
        public static void CommandeClient()
        {
            Console.WriteLine("1. Commande Article");
            Console.WriteLine("2. Quitter");
            Console.WriteLine("Que voulez vous faire ?");
            int choix = int.Parse(Console.ReadLine()!);


            switch (choix)
            {
                case 1:
                    {
                        Console.WriteLine("Que voulez vous commander ?");
                        Console.WriteLine("1.Potion Health");
                        Console.WriteLine("2.Potion Mana");
                        Console.WriteLine("3.Potion Stamina");
                        int choixcommande = int.Parse(Console.ReadLine()!);
                        if (choixcommande == 1)
                        {
                            Console.WriteLine("Quel instruction voulez vous donner ?");
                            string instruction = Console.ReadLine()!;
                            Console.WriteLine("Instruction enregistré !");
                            Console.WriteLine("Votre commande est validé !");
                            Console.WriteLine(PotionType.Health + " " + instruction);
                        }
                        if (choixcommande == 2)
                        {
                            Console.WriteLine("Quel instruction voulez vous donner ?");
                            string instruction = Console.ReadLine()!;
                            Console.WriteLine("Instruction enregistré !");
                            Console.WriteLine("Votre commande est validé !");
                            Console.WriteLine(PotionType.Mana + " " + instruction);
                        }
                        if (choixcommande == 3)
                        {
                            Console.WriteLine("Quel instruction voulez vous donner ?");
                            string instruction = Console.ReadLine()!;
                            Console.WriteLine("Instruction enregistré !");
                            Console.WriteLine("Votre commande est validé !");
                            Console.WriteLine(PotionType.Stamina + " " + instruction);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Aurevoir");
                        break;
                    }

                default:
                        Console.WriteLine("Aucune instruction !");
                    break;
            }
        }

    }
}