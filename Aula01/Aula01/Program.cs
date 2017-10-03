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
            int teste = somar(5, 5);

            Console.Write(teste);
            Console.ReadLine();
        }

        static int somar(int a, int b)
        {
            return a + b;
        }
    }
}
