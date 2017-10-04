using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInicializacao
{
    class Program
    {
        //O programa irá procurar na classe o método estático com o nome Main para executar.
        //É possível escolher o objeto de inicialização na tela de propriedades do projeto.
        //Tente alterar para a classe "OtherProgram"
        static void Main(string[] args)
        {
            //Imprime uma mensagem no console.
            Console.Write("Hello, It's me");
            //Cria um objeto da Classe Musica.
            //Este objeto está armazenado na variável m
            Musica m = new Musica();
            //Chama o método TocarMusicaSemBloquear.
            //Este método inicia uma nova Thread, que irá executar a música do Mário.
            m.TocarMusicaSemBloquear();
            //Define uma nova Cor para as letras do console.
            Console.ForegroundColor = ConsoleColor.Red;
            //Escreve a Palavra Mario, na Cor vermelha definida na linha anterior.
            Console.WriteLine(" Mario!");
            //Espera o usuário digitar alguma tecla. 
            //Serve para o console não fechar após a impressão da mensagem linha anterior.
            Console.ReadKey();
            //Finaliza a Thread criada anteriormente. 
            //Sem este método o programa irá terminar a outra Thread terminar para finalizar o 
            //programa. 
            m.Dispose();
        }
    }
}
