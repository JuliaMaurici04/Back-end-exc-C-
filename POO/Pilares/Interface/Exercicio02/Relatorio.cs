using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
         public string Nome = "";
         public string TextoRelatorio = "";

         // Sobrecarga do contrutor
         public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Responsavel: {Nome}...");
            Console.WriteLine(TextoRelatorio);
            Console.WriteLine($"--");
        }
    }
}