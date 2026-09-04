using System;

namespace TartarosRitual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lancement séquentiel des trois jobs
            TeleportRitual.Run();
            HedgeCombat.Run();
            SamethExorcism.Run();
        }
    }
}