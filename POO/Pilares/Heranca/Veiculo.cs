using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        // Permite o método ser sobrescrito
        public virtual void Acelerar()
        {
            Console.WriteLine($"Acelerando o Veículo");

        }

    }
}