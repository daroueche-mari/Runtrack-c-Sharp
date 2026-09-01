using System;

namespace Job2
{
    public class Program
    {
        public static void Main()
        {
            Wolf loup1 = new Wolf("SuperLoup", 100, 20);
            Wolf loup2 = new Wolf("HyperLoup");

            Console.WriteLine(loup2.name);
            Console.WriteLine(loup1.damage);
        }
    }
}