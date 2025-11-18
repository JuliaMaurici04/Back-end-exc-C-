using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassEObjetos
{
    public class ContaBancaria
    {

        public double saldo;

        public string titular = "";

        public void Depositar(double NovoValor)
        {
            if (NovoValor > 0)
            {
                saldo += NovoValor;
                Console.WriteLine($"Depósito no valor de R$ {NovoValor:F2} realizado");
            }
            else
            {
                Console.WriteLine($"O valor depositado deve ser maior que 0.");
            }

            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }

        public void sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque no valor de R$ {saldo:F2} realizado");
            }
        }
    }
}