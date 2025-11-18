using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class AlunoMédia
    {
        public string Nome;

        public int Nota1, Nota2, Nota3;

        public AlunoMédia(int n1, int n2, int n3)
        {
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;

        }
        public AlunoMédia()
        {
            Nota1 = Nota2 = Nota3 = 0;
        }

        public void Média()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3;

            System.Console.WriteLine($"A media do aluno(a) {Nome} foi: {media}");
        }




    }
}