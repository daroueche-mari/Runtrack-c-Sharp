using System;

namespace Jour3
{
    partial class GuildSupply
    {
        public void ShowSupplies()
        {
            Consommables.ForEach(item => Console.WriteLine(item));
        }

        public void UseSupply(string namedelete)
        {
            if (!Consommables.Contains(namedelete))
            {
                Console.WriteLine("l'élement n'existe pas");
            }
            Consommables.Remove(namedelete);
            Console.WriteLine("L'élement a été supprimé");
        }
    }
}