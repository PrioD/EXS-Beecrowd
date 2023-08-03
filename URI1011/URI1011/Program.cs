using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorRaio = double.Parse(Console.ReadLine());
            
            double calc = 0.0;
            
            double pi = 3.14159;
            
            calc = (4.0 / 3.0) * pi * Math.Pow(valorRaio, 3.0);

            Console.WriteLine("VOLUME = " + calc.ToString("F3"));

            Console.ReadLine();
        }
    }
}
