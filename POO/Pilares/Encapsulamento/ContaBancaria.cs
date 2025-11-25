using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
       private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            Saldo = saldoInicial;
        }
        // metodo que guarda o saldo
        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
                Saldo = valor;
                return;
            }

            System.Console.WriteLine($"Valor para depósito inválido");
        }
        // metodo publico que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float sacar)
        {
            
        }
    }
}