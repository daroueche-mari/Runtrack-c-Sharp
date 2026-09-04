using System;

namespace SingleJob
{
    public class Program
    {
        public static void Main()
        {
            Equipe mynewequipe = new Equipe(0);
            Meloap myme = new Meloap();
            Sameth mys = new Sameth();
            EgideDeTartaros myeg = new EgideDeTartaros();


            Console.WriteLine("Phase 1");
            mynewequipe.sante = 1000;
            Console.WriteLine("TOUR 1");
            Console.WriteLine("Orannis commence avec une Sante de :" + " " + mynewequipe.sante);
            int test = mys.mydic["StockSoutien"];
            int test2 = mys.mydic["ValStockSoutien"];
            Console.WriteLine("Le nombre de soutien disponible est de : " + " " + test);
            Console.WriteLine("Le puissance total des soutiens est de : " + " " + test2);
            Console.WriteLine("Orannis attaque avec une frappe de 20");
            myeg.OnAuraAbsorbed += () => myeg.ShowMsgAura(20);
            myeg.RecevoirAtk();
            Console.WriteLine("TOUR 2");
            int test3 = mys.mydic["ConditionStockSoutien"];
            Console.WriteLine("Nombre de soutiens disponible respectant les conditions est de :" + " " + test3);
            foreach (int val in mys.mymelo.ShowByLinq(20))
            {
                Console.WriteLine(" -> Soutien : " + val);
            }
            Console.WriteLine("Orannis attaque avec une frappe de 20");
            myeg.OnAuraAbsorbed += () => myeg.ShowMsgAura(20);
            myeg.RecevoirAtk();
            Console.WriteLine("TOUR 3");
            int ajoutpoint = test2 + 20;
            Console.WriteLine("La puissance total reçoit un bonus de :" + " " + ajoutpoint);
            Console.WriteLine("Orannis attaque avec une frappe de 20");
            myeg.OnAuraAbsorbed += () => myeg.ShowMsgAura(20);
            myeg.RecevoirAtk();
            Console.WriteLine("TOUR 4");
            Console.WriteLine("Orannis attaque avec une frappe de 20");
            myeg.OnAuraAbsorbed += () => myeg.ShowMsgAura(20);
            myeg.RecevoirAtk();

        }
    }
}