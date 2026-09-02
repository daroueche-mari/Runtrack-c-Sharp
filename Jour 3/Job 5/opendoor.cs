using System;
using System.ComponentModel.Design;

namespace Job5
{
    public class OpenDoor : SealedDoor
    {
        public OpenDoor(){}


        public sealed override void Open(int check)
        {
            if (check == 0)
            {
                Console.WriteLine("La porte s'ouvre");
            } else if (check == 1)
            {
                Console.WriteLine("La porte s'ouvre");
            }
        }
    }
}