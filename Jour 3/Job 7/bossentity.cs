using System;

namespace Job7
{
    interface IDamageable
    {
        public void TakeDamage(int amount);
    }
    
    public abstract class BossEntity
    {
        public string name{get;set;}
        public int health{get;set;}

        public BossEntity(string myname, int myhealth)
        {
            name = myname;
            health = myhealth;
        }

        public virtual void TakeDamage(int amount){}
        public abstract void ExecutePhasePattern();
    }
}