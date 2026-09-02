using System;

namespace Job5
{
    public class DungeonDoor
    {
        public DungeonDoor(){}


        public virtual void Open(int check)
        {
            Console.WriteLine("La porte s'ouvre");
        }
    }
}