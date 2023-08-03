using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            

            double calc = 0.0;

            calc = ((A * 3.5) + (B * 7.5)) / 11.0;

            Console.WriteLine("MEDIA = " + calc.ToString("F5"));

            Console.ReadLine();
        }
    }
}
