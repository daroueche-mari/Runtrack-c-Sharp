using System;

namespace SingleJob
{
    public class Meloap
    {
        public List<Func<int>> mylist = new List<Func<int>>
        {
            () => 15,
            () => 25,
            () => 40
        };


        public int ExecuteByLinq(int i)
        {
            return (from c in mylist where c() > i select c).Count();
        }

        public int ExecuteByLinqToShow(int i)
        {
            var resultats = (from c in mylist
                             where c() > i
                             select c()).ToList();

            return resultats.Count;
        }

        public List<int> ShowByLinq(int i)
        {
            return (from c in mylist
                    where c() > i
                    select c()).ToList();
        }

        public int ExecuteByLinqSum(int i)
        {
            return (from c in mylist where c() > i select c()).Sum();
        }
    }
}