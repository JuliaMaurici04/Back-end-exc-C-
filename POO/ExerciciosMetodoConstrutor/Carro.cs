using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(int a, string mo, string ma)
        {
            Marca = ma;
            Modelo = mo;
            Ano = a;

        }
    }

}