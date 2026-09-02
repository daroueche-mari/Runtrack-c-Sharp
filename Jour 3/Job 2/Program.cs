using System;

namespace Job2
{
    public class Program
    {
        public static void Main()
        {
            ClarityTrinket myapp = new ClarityTrinket("", 0);

            Console.WriteLine("Le joueur A recoit l'attaque du joueur B mais il utilise l'amulette MagicalProtect");
            myapp.Protection = 10;
            myapp.Name = "MagicalProtect";
            myapp.Protect(5);



        }
    }
}