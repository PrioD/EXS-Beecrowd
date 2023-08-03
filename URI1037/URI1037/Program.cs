using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0.0 && valor <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor >= 25.0000 && valor <= 50.000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor >= 50.000 && valor <= 75.000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor >= 75.000 && valor <= 100.000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.ReadLine();
        }
    }
}
