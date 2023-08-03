using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            
            string[] vetinho = Console.ReadLine().Split(' ');   
            
            A = double.Parse(vetinho[0]);
            
            B = double.Parse(vetinho[1]);
            
            C = double.Parse(vetinho[2]);
            
            double calc1 = (A * C) / 2.0;
            
            double calc2 = 3.14159 * Math.Pow(C, 2.0);
            
            double calc3 = (A + B) * C / 2.0;
            
            double calc4 = Math.Pow(B, 2.0);
            
            double calc5 = A * B;

            Console.WriteLine("TRIANGULO: " + calc1.ToString("F3"));

            Console.WriteLine("CIRCULO: " + calc2.ToString("F3"));

            Console.WriteLine("TRAPEZIO: " + calc3.ToString("F3"));

            Console.WriteLine("QUADRADO: " + calc4.ToString("F3"));

            Console.WriteLine("RETANGULO: " + calc5.ToString("F3"));

            Console.ReadLine();

        }
    }
}
