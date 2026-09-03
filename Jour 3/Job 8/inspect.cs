using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Job4
{
    public class Inspect<T>
    {
        public void InspectEntity(T entity)
        {
            Console.WriteLine("Entité type :" + " " + entity);

        }
        public override string ToString()
        {
            return "description de l'entité";
        }

    }
}