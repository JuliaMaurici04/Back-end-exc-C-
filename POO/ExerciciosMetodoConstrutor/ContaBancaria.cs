using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class ContaBancaria
    {
        public string Titular;

        public double Saldo = 0;

        public ContaBancaria(double s, string t)
        {
            Titular = t;
            Saldo = s;
        }

        public ContaBancaria(string t)
        {
            Titular = t;
            Saldo = 0;
        }
    }
}