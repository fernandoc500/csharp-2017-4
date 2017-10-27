using ControlModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConcurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho para o arquivo:");
            //string path = Console.ReadLine();
            //string path = "C:/Users/Fernando/Desktop/notas.txt";

            string[] file = File.ReadAllLines("C:/Users/Fernando/Desktop/notas.txt");
            FileManager fm = new FileManager();
            IList<Aluno> alunos = fm.IdentificarCandidatos(file);
            IList<string> gabarito = fm.IdentificarGabarito(file);
            alunos = fm.IdentificarRespostas(alunos, gabarito, file);
            alunos = fm.GerarTodasNotas(alunos, gabarito);

            foreach(Aluno a in alunos)
            {
                Console.WriteLine(a.Nome);
                Console.WriteLine(a.Nota);
            }

            Console.ReadLine();
        }
    }
}
