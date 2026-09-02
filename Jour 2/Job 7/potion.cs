using System;

namespace Job4
{
    public class Potion
    {
        public string name = "";

        public Potion(string n)
        {
            name = n;
        }


        public void Setname(string newname)
        {
            name = newname;
        }
        public string getname()
        {
            return name;
        }
    }
}