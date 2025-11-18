using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        private double Taxa = 0.05;
        public override void Depositar(double valor)
        {
             if(valor <= 0)
            {
                Console.WriteLine($"O valor do saque deve ser maior que R$0,00");
                return;// para a execucao do metodo por aqui
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            //     valor solicitado + tava de 1%
            double totalComTaxa = valor + (valor * Taxa);

            if(valor <= 0 || totalComTaxa <= Saldo)
            {
                Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro sufienciente para o saque");
                return;//para aexecucao do metodo por aqui
            }

            // Calcular o sqque + taxa de saque
            Saldo -= totalComTaxa;
        }
    }
}