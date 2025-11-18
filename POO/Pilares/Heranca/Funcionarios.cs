using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Funcionario
    {
        public string Nome;

        public int SalarioBase;

        public double CalcularSalario()
        {
            return SalarioBase;
        }

    }
}