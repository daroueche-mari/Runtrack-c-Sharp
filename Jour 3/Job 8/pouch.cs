using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Job4
{
    public class Pouch<T>
    {
        private List<T> myprivatelist = new List<T>();

        public void Store(T a)
        {
            myprivatelist.Add(a);
        }

        public T Retrieve(int index)
        {
            return myprivatelist[index];
        }
        public int GetCount()
        {
            return myprivatelist.Count;
        }

    }
}