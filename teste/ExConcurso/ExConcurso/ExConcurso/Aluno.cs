using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConcurso
{
    class Aluno
    {
        public string Nome;
        public string Matricula;
        public List<string> Respostas { get; set; }
        public double nota { get; set; }
        public Aluno() { }
        public Aluno(string nome, string matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;

            this.Respostas = new List<string>();
        }


    }
}
