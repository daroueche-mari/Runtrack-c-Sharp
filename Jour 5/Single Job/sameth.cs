using System;

namespace SingleJob
{
    public class Sameth
    {
        public Meloap mymelo = new Meloap();
        public Dictionary<string, int> mydic;

        public Sameth()
        {
            mydic = new Dictionary<string, int>
            {
                ["StockSoutien"] = mymelo.ExecuteByLinq(0),
                ["ValStockSoutien"] = mymelo.ExecuteByLinqSum(0),
                ["ConditionStockSoutien"] = mymelo.ExecuteByLinqToShow(20),
                ["Eau"] = 5,
                ["Eau Fraiche"] = 9,
                ["Eau Gazeuse"] = 15,
                ["Potion"] = 25

            };
        }
        public string Soigner(string equipegroupe)
        {
            if (equipegroupe == "sante critique")
            {
                Console.WriteLine(mydic["Potion"]);
            }
            return "";
        }
    }
}