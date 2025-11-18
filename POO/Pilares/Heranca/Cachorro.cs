using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("AuAu");
        }
    }

}