using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;

        private string Modelo;

        private int VelocidadeAtual;

        //gets e sets

        //set Marca

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        // get do Modelo

        public string ObterModelo()
        {
            return Modelo;
        }

        // get da VelocidadeAtual

        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }


        // set da Velocidade

        public void Acelera(int valor)
        {
            if (valor > 0)
                VelocidadeAtual += valor;
        }

        public void Frear(int valor)
        {
            if (valor > 0)
                VelocidadeAtual -= valor;
        }

    }

}