using System;

namespace Job3
{
    public class Program
    {
        public static void Main()
        {
            Cultist mycul1 = new Cultist("", 0, 0, 0);
            Cultist mycul2 = new Cultist("", 0, 0, 0);
            Cultist mycul3 = new Cultist("", 0, 0, 0);


            mycul1.Name = "Super 1";
            mycul1.Health = 100;

            mycul2.Name = "Super 2";
            mycul2.Health = 100;

            mycul3.Name = "Super 3";
            mycul3.Health = 100;



            Console.WriteLine("Personne présente au rituel :");
            Console.WriteLine(mycul1.Name);
            Console.WriteLine(mycul2.Name);
            Console.WriteLine(mycul3.Name);
            Console.WriteLine("Début du rituel");
            Console.WriteLine("TOUR 1");
            var testcul31 = mycul1.actionincantation(10);
            var testcul32 = mycul2.actionincantation(10);
            var testcul33 = mycul3.actionincantation(10);

            Console.WriteLine("La puissance de :" + " " + mycul1.Name + " " + mycul2.Name + " " + mycul3.Name + " " + "augmentent !");
            mycul1.SetLvlandMana(15);
            Console.WriteLine("TOUR 2");
            var testcul41 = mycul1.actionincantation(20);
            var testcul42 = mycul2.actionincantation(20);
            var testcul43 = mycul3.actionincantation(20);
            Console.WriteLine("La puissance de :" + " " + mycul1.Name + " " + mycul2.Name + " " + mycul3.Name + " " + "augmentent !");
            mycul1.SetLvlandMana(25);
            Console.WriteLine("TOUR 3");
            var testcul51 = mycul1.actionincantation(30);
            var testcul52 = mycul2.actionincantation(30);
            var testcul53 = mycul3.actionincantation(30);
            Console.WriteLine("La puissance de :" + " " + mycul1.Name + " " + mycul2.Name + " " + mycul3.Name + " " + "augmentent !");
            mycul1.SetLvlandMana(35);
            Console.WriteLine("TOUR 4");
            var testcul61 = mycul1.actionincantation(40);
            var testcul62 = mycul2.actionincantation(40);
            var testcul63 = mycul3.actionincantation(40);
            Console.WriteLine("La puissance de :" + " " + mycul1.Name + " " + mycul2.Name + " " + mycul3.Name + " " + "augmentent !");
            mycul1.SetLvlandMana(45);
            var testcul71 = mycul1.actionincantation(50);
            var testcul72 = mycul2.actionincantation(50);
            var testcul73 = mycul3.actionincantation(50);
            Console.WriteLine("TOUR 5");
            Console.WriteLine("La puissance de :" + " " + mycul1.Name + " " + mycul2.Name + " " + mycul3.Name + " " + "augmentent !");
            mycul1.SetLvlandMana(55);
        }
    }
}