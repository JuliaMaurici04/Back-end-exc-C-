using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;

        public int VolumeMaximo = 100;

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV");
        }

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
                NivelVolume++;
                Console.WriteLine($"Núvel atual do volume: {NivelVolume}");
            }
            else
            {
                Console.WriteLine($"O volume já atingiu o nível máximo {NivelVolume}");
            }

        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"O volume já está no mínimo {NivelVolume}");
            }

            else
            {
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }

        }
    }
}
