using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio
    {
         public string Dono = "";
        public void Imprimir()
        {
            System.Console.WriteLine($"Imprimimindo Relatorio do {Dono}...");
        }
    }
}