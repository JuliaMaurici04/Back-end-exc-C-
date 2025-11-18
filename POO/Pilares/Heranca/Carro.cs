using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Carro : Veiculo
    {
        // Sobrescrita do método Acelerar
        public override void Acelerar()
        {
            Console.WriteLine($"Vrum Vrum");

        }
    }
}