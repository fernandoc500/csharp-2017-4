using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeira entrada: ");
            int entrada1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda entrada: ");
            int entrada2 = int.Parse(Console.ReadLine());

            Console.Write("Resultado: ");
            Console.Write(somar(entrada1, entrada2));
            Console.ReadLine();
        }

        static int somar(int a, int b)
        {
            return a + b;
        }
    }
}
