using System;

namespace Job2
{
    public class Agent
    {
        public delegate string SetAction(int mode);

        public void Civil(int nbcivil)
        {
            Console.WriteLine("Le nombre de civil est de : " + " " + nbcivil);
        }

        public static string Action(int mode)
        {
            return mode switch
            {
                1 => "Veuillez evacuer les lieux !",
                2 => "Ecartez vous des blessés !",
                3 => "Nous avons repéré des civils blessé, nous leur donnons les premiers soins !",
                _ => "Nous allons intervenir"
            };
        }
        public SetAction setaction = Action;

        public int Heal(int graviteblessure, int stockfourniture)
        {
          var efficacitesoin = graviteblessure * stockfourniture;
          return efficacitesoin;
        }
    }
}