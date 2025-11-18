using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Hello
    {
        // Porpriedades/Caracteristicas - Variáveis internas dessa classe
        public string TextoHello = "";

        // Métodos/Cmportamentos/Acoes - sao as funcoes internas dessa classe
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }
}