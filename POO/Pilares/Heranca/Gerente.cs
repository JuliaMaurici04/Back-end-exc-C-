using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Gerente : Funcionario
    {
        public double Bonus;

        public double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }

}