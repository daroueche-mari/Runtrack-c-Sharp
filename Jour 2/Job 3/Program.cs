using System;

namespace Job3
{
    public class Program
    {
        public static void Main()
        {
            MerchantCart marchand1 = new MerchantCart(0);

            Console.WriteLine("Le marchand a :" + " " + marchand1.setGold(1000));
            Console.WriteLine("Le marchand fait un paiement");
            Console.WriteLine("Solde après achat :" + " " + marchand1.PayFee(500));
            Console.WriteLine("Le marchand fait un paiement");
            Console.WriteLine("Solde après achat :" + " " + marchand1.PayFee(600));
            Console.WriteLine(marchand1.alertpay());
            Console.WriteLine("argent renvoyé sur le compte du marchand :" + " " + marchand1.AddGold(600));
            Console.WriteLine("Solde du marchand :" + " " + marchand1.stateGold());
        }
    }
}