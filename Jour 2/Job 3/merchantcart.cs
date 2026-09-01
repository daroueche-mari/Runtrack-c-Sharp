using System;

namespace Job3
{
    public class MerchantCart
    {
        private int goldpiece;

        public MerchantCart(int goldp)
        {
            this.goldpiece = goldp;
        }


        public int setGold(int setvalue)
        {
            goldpiece = setvalue;
            return goldpiece;
        }


        public int stateGold()
        {
            return goldpiece;
        }



        public int AddGold(int addvalue)
        {
             goldpiece += addvalue;
             return goldpiece;
        }
        public int PayFee(int removevalue)
        {
            goldpiece-=removevalue;
            return goldpiece;
        }
        public bool alertpay()
        {
            if(goldpiece < 0)
            {
                Console.WriteLine("Paiement refusé");
                return false;
            }
            return true;
        }
    }
}