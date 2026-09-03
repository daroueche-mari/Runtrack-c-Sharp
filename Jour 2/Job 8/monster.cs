using System;

namespace Job4
{
    public class Monster
    {
        public string name = "";
        public int health;
        public bool isDangerous = false;

        public Monster(string myname, int myhealth, bool danger)
        {
            name = myname;
            health = myhealth;
            isDangerous = danger;
        }

        public void setMonster(string newname, int newhealth, int newstate)
        {
            name = newname;
            health = newhealth;
            if(newstate == 1)
            {
                isDangerous = true;
            }
        }

        public string getnameMonster()
        {
            if(isDangerous == true)
            {
                return name;
            }
        return "";
            
        }
        public int gethealthMonster()
        {
            if(isDangerous == true){
                return health;
            }
            return 0;
        }
        public bool getstateMonster()
        {
            if(isDangerous == true)
            {
                return isDangerous;
            }
        return false;
        }

        public override string ToString()
        {
            return "description du monstre";
        }

       
    }
}