using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Pessoas
    {
        public string Nome;
        public int Idade;
        public Endereco EnderecoCompleto;
        public Pessoas(Endereco endereco)
        {

        }
        public void falar()
        {
            Console.WriteLine($"Ola, eu sou {Nome} e tenho {Idade} anos");
        }
        public void Envelhecer()
        {
            Idade++;
        }
    }
}