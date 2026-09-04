using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Swift;
using System.Security;

namespace Job3
{
    public class Cultist
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }

        public Cultist(string myname, int myhealth, int mymana, int mylevel)
        {
            Name = myname;
            Health = myhealth;
            Mana = mymana;
            Level = mylevel;
        }
        public delegate int ActionIncantation(int puissancesort);
        public ActionIncantation actionincantation = Incantation => Incantation switch
        {
            10 => 15,
            20 => 25,
            30 => 35,
            40 => 45,
            50 => 55,
            _ => 5


        };

        public void SetLvlandMana(int puissancesort)
        {
            if (Incantation(puissancesort) == 15)
            {
                Console.WriteLine("Pouvoir :");
                Console.WriteLine(Mana = 55);
                Console.WriteLine("Niveau :");
                Console.WriteLine(Level = 15);
                Console.WriteLine("la puissance du sort est de" + " " + puissancesort);
            }
            else if (Incantation(puissancesort) == 25)
            {
                Console.WriteLine("Pouvoir :");
                Console.WriteLine(Mana = 65);
                Console.WriteLine("Niveau :");
                Console.WriteLine(Level = 20);
                Console.WriteLine("la puissance du sort est de" + " " + puissancesort);

            }
            else if (Incantation(puissancesort) == 35)
            {
                Console.WriteLine("Pouvoir :");
                Console.WriteLine(Mana = 75);
                Console.WriteLine("Niveau :");
                Console.WriteLine(Level = 25);
                Console.WriteLine("la puissance du sort est de" + " " + puissancesort);

            }
            else if (Incantation(puissancesort) == 45)
            {
                Console.WriteLine("Pouvoir :");
                Console.WriteLine(Mana = 85);
                Console.WriteLine("Niveau :");
                Console.WriteLine(Level = 30);
                Console.WriteLine("la puissance du sort est de" + " " + puissancesort);

            }
            else if (Incantation(puissancesort) == 55)
            {
                Console.WriteLine("Pouvoir :");
                Console.WriteLine(Mana = 95);
                Console.WriteLine("Niveau :");
                Console.WriteLine(Level = 40);
                Console.WriteLine("la puissance du sort est de" + " " + puissancesort);
                int total = 15 + 25 + 35 + 45 + 55;
                Console.WriteLine("Le total de la menace est de :" + " " + total);

            }
        }

        public static int Incantation(int puissancesort)
        {
            return puissancesort;
        }


    }
}