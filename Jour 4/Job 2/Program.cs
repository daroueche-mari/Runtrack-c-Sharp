using System;

namespace Job2
{
    public class Program
    {
        public static void Main()
        {
            Agent myagent = new Agent();
            
            Console.WriteLine("Les secours sont intervenu après l'appel des villageois");
            Console.WriteLine(myagent.setaction(1));
            Console.WriteLine(myagent.setaction(3));
            myagent.Civil(3);
            Console.WriteLine("Nous soignons un civil, l'efficacité est de :");
            Console.WriteLine(myagent.Heal(9, 20));
            Console.WriteLine("Nous soignons un civil, l'efficacité est de :");
            Console.WriteLine(myagent.Heal(9, 10));
            Console.WriteLine("Nous soignons un civil, l'efficacité est de :");
            Console.WriteLine(myagent.Heal(9, 5));
            Console.WriteLine("Mission accompli !");
        }
    }
}