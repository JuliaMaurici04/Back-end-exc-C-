using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas simples
        // visibilidade tipoDeRetorno Nome(parametros){corpo}

        public static float Somar(float a, float b)
        {
           return a + b;
        }

         public static float Subtrair(float a, float b)
        {
           return a -  b;
        }
         public static float Dividir(float a, float b)
        {
           return a / b;

        }
         public static float Multiplicar(float a, float b)
        {
           return a * b;
        }


    }
}