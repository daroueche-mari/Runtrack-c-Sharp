using System;

namespace Job4
{
    public class Weapon
    {
        public string name = "";

        public Weapon(string n)
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