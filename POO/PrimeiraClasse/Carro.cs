using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Carro
    {
        // propriedades
        public int qtdRodas;
        public int qtdPortas;
        public string marca;
        public string modelo;
        public string cor;

        // métodos
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }
        public void Frear()
        {
            Console.WriteLine($"Carro Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando");
        }
        public void Desligar()
        {
            Console.WriteLine($"Carro Desligando");
        }

    }
}
