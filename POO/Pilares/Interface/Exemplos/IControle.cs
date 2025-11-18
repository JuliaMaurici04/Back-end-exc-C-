using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
        //propriedades obrigatorias
        public int NivelVolume { get; set;}

        //metodos obrigatorios na classe
        void Ligar();
        void Desligar();
        void AumentarVolume();
        void DiminuirVolume();

    }
}