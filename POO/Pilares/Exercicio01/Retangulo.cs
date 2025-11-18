using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
         public double Largura;

        public double Altura;

        public void CalcularArea()
        {
            Console.WriteLine($"A área do retângulo é: {Largura * Altura}");
        }
    }
}