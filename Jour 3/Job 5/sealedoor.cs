using System;
using System.ComponentModel.Design;

namespace Job5
{
    public class SealedDoor : DungeonDoor
    {
        public SealedDoor(){}


        public sealed override void Open(int check)
        {
            if (check == 0)
            {
                Console.WriteLine("Vous n'avez la clé pour ouvrir la porte");
            } else if (check == 1)
            {
                Console.WriteLine("La porte s'ouvre");
            }
        }
    }
}