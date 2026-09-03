using System;
using System.Security.Cryptography.X509Certificates;
using Job1;

namespace Job2
{
    public class Program
    {
        public static void Main()
        {
           Msg mymessage = new Msg();

           Console.WriteLine(mymessage.Communicate("Hello"));
           mymessage.CharacterSheet();
        }
    }
}