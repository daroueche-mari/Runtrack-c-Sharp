using System;

namespace Job6
{
    public class Program
    {
        public static void Main()
        {
            List<AntiShadowSpell> mytest = new List<AntiShadowSpell>
            {
                new PurifyingLightSpell("", 0),
                new DisruptionWaveSpell("", 0)
            };
            mytest[0].name = "Chevalier A";
            mytest[1].name = "Chevalier B";
            mytest[0].manaCost = 10;
            mytest[1].manaCost = 10;


            Console.WriteLine("Le combat entre l'ombre et la lumière commence");
            Console.WriteLine("Les chevaliers de la lumière verfient leur reserve d'energie");
            Console.WriteLine(mytest[0].CanCast(30));
            Console.WriteLine(mytest[1].CanCast(30));
            Console.WriteLine("les chevaliers attaquent");
            mytest[0].Cast("Ombre Maléfique");
            mytest[1].Cast("Ombre Maléfique");
            Console.WriteLine("les chevaliers ont consommé beaucoup de mana, ils leur restent assez d'energie pour encore attaqué");
            Console.WriteLine(mytest[0].CanCast(20));
            Console.WriteLine(mytest[1].CanCast(20));




        }
    }
}