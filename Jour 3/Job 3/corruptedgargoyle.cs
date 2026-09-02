using System;

namespace Job3
{
    public class CorruptedGargoyle : CorruptedCreature
    {
        public int ArmorValue {get;set;}

        public CorruptedGargoyle(string myname, int myhealth, int myarmor) : base(myname, myhealth)
        {
            ArmorValue = myarmor;
        }
        
    }
}