using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassEObjetos
{
    public class Garrafa
    {
         public string Nome= "";
         public string modelo = "";
        public string marca = "";
        public string tampa = "";
        public string cor = "";
        public int qntA = 0;

         public void Abrir()
        {
            Console.WriteLine($"Garrafa abrindo");
        }
         public void Encher ()
        {
            Console.WriteLine($"Garrafa enchendo");
        }
         public void Fechar()
        {
            Console.WriteLine($"Garrafa fechando");
        }
         public void Esvaziar()
        {
            Console.WriteLine($"Garrafa esvazeando");
        }
        
    }
}