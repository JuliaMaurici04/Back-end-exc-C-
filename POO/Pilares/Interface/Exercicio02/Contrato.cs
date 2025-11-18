using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public void Imprimir()
        {
            Console.WriteLine($@"
            Partes:  
                Contratante: {Contratante}
                Contratada: {PrestadorServico}
                Clausulas do Contratante do Contrato:

                ()
            ");
        }
    }
}