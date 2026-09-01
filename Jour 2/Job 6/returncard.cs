using System;

namespace Job4
{
    public class ReturnCard
    {
        public static int nbcard;
        public int card;

        public ReturnCard(int getnbcard, int mycard)
        {
            nbcard = getnbcard;
            card = mycard;
        }

        public ReturnCard(ReturnCard copy)
        {
           card = copy.card;
        }






        public int SetCard(int start)
        {
            card = start;
            return card;
        }
        public int AddCard(int newcard)
        {
            
            card += newcard;
            return card;
        }

        public static int TotalCardIssued()
        {
            nbcard++;
            return nbcard;
        }
        public static void GetPostRules()
        {
            Console.WriteLine("Les consignes de sécurité : A,B,C,D.");
        }


    }
}