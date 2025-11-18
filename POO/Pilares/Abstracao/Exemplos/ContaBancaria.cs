using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class ContaBancaria
    {
        public abstract void Depositar(double valor);
        public abstract void Sacar (double valor);


    }
}