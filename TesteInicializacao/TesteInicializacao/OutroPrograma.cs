using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteInicializacao
{
    class OutroPrograma
    {
        static void Main(string[] args)
        {
            //Imprime uma mensagem no console. Não pulará a linha após escrever a mensagem.
            Console.Write("Hello, It's me");
            //Escolhe a cor da letra que será impressa.
            Console.ForegroundColor = ConsoleColor.Green;
            //Imprime a mensagem na tela e irá pular a linha após a mensagem.
            Console.WriteLine(" Luigi!");
            //Cria novo objeto.
            Musica m = new Musica();
            //Executa a música do Mario sem bloquear a execução da próxima linha.
            //Teste com a Função TocarMusica
            m.TocarMusicaSemBloquear();

            Console.WriteLine("Quem é você?");

            //Função que irá ler uma linha do teclado e irá armazenar o valor na string "nome"
            String nome = Console.ReadLine();
            //Escolhe a cor de fundo do console
            Console.BackgroundColor = ConsoleColor.DarkRed;
            //Escolhe a cor das letras que serão impressas.
            Console.ForegroundColor = ConsoleColor.White;
            //Imprime no console a mensagem "Olá" + o que foi digitado e armazenado na variável nome.
            Console.WriteLine("Olá " + nome + "!");

            RecuperadorDeDados recuperador = new RecuperadorDeDados();
            String matricula = recuperador.ObterMatricula(nome);

            Console.WriteLine("Sua matrícula é: " + matricula);

            //Espera o usuário digitar alguma tecla. 
            //Serve para o console não fechar após a impressão da mensagem linha anterior.
            Console.ReadKey();
            //Finalizar a Musica
            m.Dispose();
        }
    }
}
