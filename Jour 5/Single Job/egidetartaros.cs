using System;

namespace SingleJob
{
    public class EgideDeTartaros
    {
        public event Action? OnAuraAbsorbed; 
        public Dictionary<string,int> mynewdic = new Dictionary<string, int>
        {
          ["EgideEnergie"] = 0  
        };
        public void RecevoirAtk()
        {
            OnAuraAbsorbed?.Invoke();
        }
        public void ShowMsgAura(int valfrappe)
        {
            Console.WriteLine("L'aura a absorbé la frappe de :" + " " + valfrappe);
        }
    }
}