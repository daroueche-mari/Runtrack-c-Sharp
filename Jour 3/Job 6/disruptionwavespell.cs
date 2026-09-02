using System;

namespace Job6
{
    public class DisruptionWaveSpell : AntiShadowSpell
    {

        public DisruptionWaveSpell(string myname, int mymana) : base(myname, mymana) { }

        public override void Cast(string target)
        {
            Console.WriteLine("frappe la structure magique de l'ombre pour la faire exploser");
        }
    }
}