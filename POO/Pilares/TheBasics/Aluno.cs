using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aluno : Pessoas
    {
        public Aluno(Endereco endereco) : base(endereco)
        {
            
        }

        public string RA;
        public double Nota;
        public string Curso;
    }
}