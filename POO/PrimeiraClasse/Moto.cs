using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
     public class Moto
    {
        public string Marca = "";
        public string Modelo = "";
        public string Cor = "";
        public int qtRodas = 0;
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");

        }
        public void Freiar()
        {
            Console.WriteLine($"Moto Freiando");

        }
        public void Ligar()
        {
            Console.WriteLine($"Moto ligada");

        }
        public void Desligar()
        {
            Console.WriteLine($"Moto desligar");

        }
    }
}