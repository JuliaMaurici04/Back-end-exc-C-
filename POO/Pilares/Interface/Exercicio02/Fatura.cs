using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {

        public string Devedor;
        public string Credor;
        public float Valor;

        public int DiasDeAtraso;
        private float Juros = 0.10f;

        // Sobrecarga do COnstrutor - obriga a passar os dados na criacao do objeto
        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

         public void Imprimir()
        {
            Console.WriteLine($@"
            Credor: {Credor}
            Devedor: {Devedor}
            DiasDeAtraso de atraso: {DiasDeAtraso}
            Valor: R${Valor: F2}
            Juros: R${(Juros * DiasDeAtraso)}
            Total com juros: R${Valor: F2}
                ");//ja pula uma linha
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }

        }   
}