using System;

namespace Job2
{
    public class Wolf
    {
        public string name;
        public int health;
        public int damage;

        public Wolf(string nam, int hea, int dam)
        {
            this.name = nam;
            this.health = hea;
            this.damage = dam;
        }
        public Wolf(string secondnam)
        {
            this.name = secondnam;
            this.health = 20;
            this.damage = 5;
        }

    }
}