using System;

namespace SingleJob
{
    // L'exception personnalisée dérive de la classe Exception
    public class CombatException : Exception
    {
        public CombatException(string message) : base(message) { }
    }
}