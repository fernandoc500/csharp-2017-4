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
            string path = Console.ReadLine();
            //string path = "C:/Users/Fernando/Desktop/notas.txt";

            string[] file;
            try
            {
                file = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                do
                {
                    Console.WriteLine("Um erro ocorreu, digite novamente o caminho para o arquivo: ");
                    path = Console.ReadLine();
                } while (!File.Exists(path));

                file = File.ReadAllLines(path);
            }


            List<Aluno> alunos = new List<Aluno>();
            List<string> respostas = new List<string>();
            bool cadastro = true, gabarito = false, resposta = false;
            Aluno alunoAtual = new Aluno();
            int totalPerguntas = 0;

            for (int x = 0; x < file.Length; x++)
            {
                if (file[x] == "!Gabarito!")
                {
                    gabarito = true;
                    cadastro = false;
                    resposta = false;
                    continue;
                }

                if (file[x] == "!Candidatos!")
                {
                    resposta = true;
                    gabarito = false;
                    cadastro = false;

                    totalPerguntas = respostas.Count();
                    continue;
                }

                if (cadastro)
                {
                    alunos.Add(new Aluno(file[x+1], file[x]));
                    x++;
                    continue;
                }

                if (gabarito)
                {
                    respostas.Add(file[x]);
                }

                if (resposta)
                {
                    int y = 0;
                    for(y = 0; y <= totalPerguntas; y++)
                    {
                        if (y == 0)
                        {
                            foreach(Aluno al in alunos)
                            {
                                if (al.Matricula.Equals(file[x]))
                                {
                                    alunoAtual = al;
                                    break;
                                }

                            }
                            continue;
                        }
                        alunoAtual.Respostas.Add(file[x + y]);
                    }

                    x += (y - 1);
                    continue;
                }
            }

            foreach(Aluno a in alunos)
            {
                int index = 0;

                foreach(string g in respostas)
                {
                    if (g.Equals(a.Respostas[index]))
                    {
                        a.nota += 1.0;
                    }
                    else
                    {
                        a.nota -= 0.5;
                    }
                    index++;
                }

                if (a.nota < 0) a.nota = 0;


                if (a.nota >= 2)
                {
                    Console.WriteLine("Aluno aprovado: " + a.Nome + "  -  Nota: " + a.nota);

                }
            }

            Console.ReadLine();
        }
    }
}
