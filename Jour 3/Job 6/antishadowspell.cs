using System;

namespace Job6
{
    public abstract class AntiShadowSpell
    {
        public string name {get;set;}
        public int manaCost {get;set;}

        public AntiShadowSpell(string myname, int mymana)
        {
            name = myname;
            manaCost = mymana;
        }

        public abstract void Cast(string target);
        public bool CanCast(int currentMana)
        {
            if (currentMana > 0)
            {
                return true;
            }
        return false;
        }
    }
}