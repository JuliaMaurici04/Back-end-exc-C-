using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosContrutor
{
    public class Aluno
    {
        public string Nome;

        public int Nota;

        public Aluno(int nota, string nome)
        {
            Nome = nome;
            Nota = nota;

        }

        public Aluno(string nome)
        {
            Nome = nome;
            Nota = 0;

        }
    }
}