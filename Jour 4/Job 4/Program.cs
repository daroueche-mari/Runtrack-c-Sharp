using System;

namespace Job4
{
    public class Program
    {
        public static void Main()
        {
            Victim myvictim = new Victim("", 0, 0, false);
            
            List<Victim> newlist = new List<Victim>{
                new Victim("Victime 1", 30, 100, false),
                new Victim("Victime 2", 20, 100, true),
                new Victim("Victime 3", 90, 100, false)

            };

            Console.WriteLine("Reperage des victimes les plus dangereux !");
            var test = (from t in newlist orderby t.Menacelvl descending select t.Name).FirstOrDefault();
            Console.WriteLine("Menace élevé :");
            Console.WriteLine(test);
            Console.WriteLine("Les victimes sont mis en quarantaine !");
            var test2 = (from t in newlist orderby t.State descending select t.Name).FirstOrDefault();
            Console.WriteLine("Zone de Quarantaine :");
            Console.WriteLine(test2);
            Console.WriteLine("Les victimes sont trié de maniere decroissante, selon leur niveau de menace");
            // 🟢 Remplace la virgule par un point
            var test3 = newlist.OrderByDescending(t => t.Menacelvl).Select(t => t.Name).ToList();
            Console.WriteLine(string.Join(", ", test3));
        }
    }
}