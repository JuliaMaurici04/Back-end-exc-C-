using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Dono = "";
        public void Imprimir()
        {
            System.Console.WriteLine($"Imprimindo Contrato do {Dono}...");
        }
    }
}