using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Animal
    {
        public virtual void FazerSom()
        {
            Console.WriteLine("Som do Animal");
        }
    }
}