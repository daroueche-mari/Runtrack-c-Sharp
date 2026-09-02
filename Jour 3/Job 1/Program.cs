using System;

namespace Jour3
{
    public class Program
    {
        public static void Main()
        {
            GuildSupply mytest = new GuildSupply();

            mytest.ShowSupplies();
            mytest.UseSupply("Eau");
            mytest.ShowSupplies();

        }
    }
}