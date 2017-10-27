using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlModel
{
    public class FileManager
    {
        public IList<string> gabarito;

        public IList<Aluno> IdentificarCandidatos(string[] linhasArquivo)
        {
            IList<Aluno> alunos = new List<Aluno>();
            for (int x = 0; x < linhasArquivo.Length; x++)
            {
                if (linhasArquivo[x] != "!Gabarito!")
                {
                    alunos.Add(new Aluno(linhasArquivo[x + 1], linhasArquivo[x]));
                    x++;
                    continue;
                }
                else
                {
                    break;
                }
            }

            return alunos;
        }

        public IList<string> IdentificarGabarito(string[] linhasArquivo)
        {
            bool gabarito = false;
            IList<string> respostas = new List<string>();

            for (int x = 0; x < linhasArquivo.Length; x++)
            {
                if (linhasArquivo[x] == "!Gabarito!")
                {
                    gabarito = true;
                    continue;
                }
                else if (linhasArquivo[x] == "!Candidatos!")
                {
                    break;
                }

                if (gabarito)
                {
                    respostas.Add(linhasArquivo[x]);
                }
            }

            return respostas;
        }

        public IList<Aluno> IdentificarRespostas(IList<Aluno> alunos, IList<string> gabarito, string[] linhasArquivo)
        {
            Aluno alunoAtual = new Aluno();
            int totalPerguntas = gabarito.Count();
            bool respostas = false;

            for (int x = 0; x < linhasArquivo.Length; x++)
            {
                if (linhasArquivo[x] == "!Candidatos!")
                {
                    respostas = true;
                    continue;
                }

                if (respostas)
                {
                    int y = 0;
                    for (y = 0; y <= totalPerguntas; y++)
                    {
                        if (y == 0)
                        {
                            foreach (Aluno al in alunos)
                            {
                                if (al.Matricula.Equals(linhasArquivo[x]))
                                {
                                    alunoAtual = al;
                                    break;
                                }
                            }
                            continue;
                        }
                        alunoAtual.Respostas.Add(linhasArquivo[x + y]);
                    }

                    x += (y - 1);
                }
            }
            return alunos;
        }

        public IList<Aluno> GerarTodasNotas(IList<Aluno> alunos, IList<string> gabarito)
        {
            foreach (Aluno a in alunos)
            {
                int index = 0;

                foreach (string g in gabarito)
                {
                    if (a.Respostas[index] != "?" && a.Respostas[index] != "x")
                    {
                        if (g.Equals(a.Respostas[index]))
                        {
                            a.Nota += 1.0;
                        }
                        else
                        {
                            a.Nota -= 0.5;
                        }
                    }
                    index++;
                }
                if (a.Nota < 0) a.Nota = 0;
            }

            return alunos;
        }

        public IList<Aluno> OrdenarPorNota(IList<Aluno> alunos)
        {
            int maiorIndice = 0;
            Aluno aux;
            for (int x = 0; x < alunos.Count(); x++)
            {
                maiorIndice = x;
                for (int y = x; y < alunos.Count(); y++)
                {
                    if (alunos[maiorIndice].Nota < alunos[y].Nota)
                    {
                        maiorIndice = y;
                    }
                }

                aux = alunos[maiorIndice];
                alunos[maiorIndice] = alunos[x];
                alunos[x] = aux;
            }


            return alunos;
        }

        public IList<Aluno> ProcessarArquivo(string path)
        {
            string[] file = File.ReadAllLines(path);
            FileManager fm = new FileManager();
            IList<Aluno> alunos = fm.IdentificarCandidatos(file);
            this.gabarito = fm.IdentificarGabarito(file);
            alunos = fm.IdentificarRespostas(alunos, this.gabarito, file);
            alunos = fm.GerarTodasNotas(alunos, this.gabarito);
            alunos = fm.OrdenarPorNota(alunos);

            return alunos;
        }
    }
}
