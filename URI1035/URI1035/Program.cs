using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetfu = Console.ReadLine().Split(' '); 
            int a, b, c, d;

            a = int.Parse(vetfu[0]);

            b = int.Parse(vetfu[1]);

            c = int.Parse(vetfu[2]);

            d = int.Parse(vetfu[3]);

            int soma = c + d;

            int soma2 = a + b;

            if (b > c && d > a && soma > soma2 && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
                Console.ReadLine();
        }
    }
}
