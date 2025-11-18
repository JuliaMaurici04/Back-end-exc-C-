using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class Produto
    {
        public double Preco;

        public string Nome;

        public int Estoque;

        public Produto(int e, double p, string n)
        {
            Estoque = e;
            Preco = p;
            Nome = n;

        }
    }
}