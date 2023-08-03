using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x= 0.0;
            
            double y = 0.0;

            double calc = 0.0;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            
            calc = x / y;

            Console.WriteLine(calc.ToString("F3") +"km/l");

            Console.ReadLine();


        
        }
    }
}
