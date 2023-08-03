using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double A = double.Parse(Console.ReadLine());
           double B = double.Parse(Console.ReadLine());
           double C = double.Parse(Console.ReadLine());
            
            double calc = 0.0;

            calc = ((A * 2.0) + (B * 3.0) + (C * 5.0))/10.0; 

            Console.WriteLine("MEDIA = "+calc.ToString("F1"));
            
            Console.ReadLine();
        
        }
    }
}
