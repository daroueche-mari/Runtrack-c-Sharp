using System;

namespace Jour3
{
    partial class GuildSupply
    {
        public List<string> Consommables {get; set;}
        public GuildSupply()
        {
           Consommables = new List<string>{"Eau", "EauFraiche", "EauGazeuse"};
        }
    }
}