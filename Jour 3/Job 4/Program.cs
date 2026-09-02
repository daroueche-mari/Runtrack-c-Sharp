using System;

namespace Job3
{
    public class Program
    {
        public static void Main()
        {
            CorruptedGargoyle mygargoyle = new CorruptedGargoyle("", 0, 0);
            MadAdventurer myadventurer = new MadAdventurer("", 0);
            mygargoyle.name = "MonsterShadow";
            mygargoyle.health = 100;
            mygargoyle.ArmorValue = 15;

            Console.WriteLine("Information de la gargouille :" + " " + mygargoyle.name + " " + mygargoyle.health + " " + mygargoyle.ArmorValue);

            Console.WriteLine("----------Suite----------");
            List<CorruptedCreature> mytest = new List<CorruptedCreature>
            {
                new CorruptedGargoyle("Black Red Gargoyle", 100, 15),
                new MadAdventurer("Green Adventurer", 100),
                new CorruptedGargoyle("Black Purple Gargoyle", 100, 15),
                new MadAdventurer("Orange Adventurer", 100)

            };
            Console.WriteLine("Début des attaques");
            mytest[0].TakeMiasmaDamage(20);
            Console.WriteLine("Nouvelle attaque");
            mytest[1].TakeMiasmaDamage(20);
            Console.WriteLine("Nouvelle attaque");
            mytest[2].TakeMiasmaDamage(20);
            Console.WriteLine("Nouvelle attaque");
            mytest[3].TakeMiasmaDamage(20);
        }
    }
}