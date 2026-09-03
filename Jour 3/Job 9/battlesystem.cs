using System;

namespace Jour04
{
    
    public static class BattleSystem
    {
        public static int CalculateDamage(int attack, int defense)
        {
            int degatsReels = attack - defense;
            // Les dégâts ne peuvent être inférieurs à 1
            return Math.Max(1, degatsReels);
        }
    }
}