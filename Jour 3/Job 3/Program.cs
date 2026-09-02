using System;

namespace Job3
{
    public class Program
    {
        public static void Main()
        {
            CorruptedGargoyle mygargoyle = new CorruptedGargoyle("", 0, 0);

            mygargoyle.name = "MonsterShadow";
            mygargoyle.health = 100;
            mygargoyle.ArmorValue = 15;

            Console.WriteLine("Information de la gargouille :" + " "+ mygargoyle.name + " " + mygargoyle.health + " " + mygargoyle.ArmorValue);
        }
    }
}