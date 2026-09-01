using System;

namespace Job4
{
    struct TrapLocation
    {
        int x;
        int y;

        public TrapLocation(int posx, int posy)
        {
           x = posx;
           y = posy; 
        }

        public double DistanceTo(TrapLocation other)
        {
            int deltaX = other.x - x;
            int deltaY = other.y - y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}