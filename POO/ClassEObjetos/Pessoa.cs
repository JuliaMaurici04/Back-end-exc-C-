using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassEObjetos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

         public void Falar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}");
        }
        public int Envelhercer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return Idade;//retorna a idade anterior
            }

            Idade += _anos;

            return Idade;//atualiza
        }
    }
}