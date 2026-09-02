using System;

namespace Job6
{
    public class PurifyingLightSpell : AntiShadowSpell
    {

        public PurifyingLightSpell(string myname, int mymana) : base(myname, mymana) { }

        public override void Cast(string target)
        {
            Console.WriteLine("bannit l'ombre en lui infligeant des dégâts sacrés tout en restaurant un peu de clarté dans la pièce");
        }
    }
}