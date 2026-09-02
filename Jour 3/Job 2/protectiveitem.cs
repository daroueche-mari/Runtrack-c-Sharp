using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Job2
{
    interface IProtectiveItem
    {
        int Protection { get; set; }
        string Name { get; set; }

        int Protect(int incomingDamage);
    }

    public class ClarityTrinket : IProtectiveItem
    {
        public int Protection{get;set;}
        public string Name{get;set;}

        public ClarityTrinket(string myname, int myshield)
        {
            Protection = myshield;
            Name = myname;
        }

        
        public int Protect(int incomingDamage)
        {
            var Resultat = Protection -= incomingDamage;
            Console.WriteLine(Name + " " + ": L'aura du charme absorbe " + " " + Resultat + " " + "points de dégats mentaux !");
            Console.WriteLine("MagicalProtect peut desormais absorbé seulement :" + " " + Protection);
            return 0;
        }
    }
    
}