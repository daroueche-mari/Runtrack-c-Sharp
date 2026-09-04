using System;

namespace Job4
{
    public class Victim
    {
        public string Name{get;set;}
        public int Menacelvl{get;set;}
        public int Pointdevie{get;set;}
        public bool State{get;set;}


        public Victim(string myn, int mymenlvl, int mypdv, bool mystate)
        {
            Name = myn;
            Menacelvl = mymenlvl;
            Pointdevie = mypdv;
            State = mystate;
        }
    }
}