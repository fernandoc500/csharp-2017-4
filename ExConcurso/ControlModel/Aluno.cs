using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlModel
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public List<string> Respostas { get; set; }
        public double Nota { get; set; }
        public Aluno() { }
        public Aluno(string nome, string matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;

            this.Respostas = new List<string>();
        }
    }
}
