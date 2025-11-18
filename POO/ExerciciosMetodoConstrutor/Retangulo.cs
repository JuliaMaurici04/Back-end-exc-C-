using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class Retângulo
    {
        public double Lado1, Lado2, Area;

        public Retângulo(double l1, double l2, double a)
        {
            Lado1 = l1;
            Lado2 = l2;
            Area = a;

        }

        public void AreaR(double l1, double l2, double a = 0)
        {
            a = 2 * (l1 + l2);

            System.Console.WriteLine($"A área do retângulo é: {a}");

        }
    }
}