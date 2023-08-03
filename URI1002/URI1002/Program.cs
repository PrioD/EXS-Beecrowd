using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area =0.0;
            
            double n = 3.14159; 
            
            double raio = 0.0;
            
            raio = double.Parse(Console.ReadLine());
            
            area = n * Math.Pow(raio, 2.0);
           
            
            
            Console.WriteLine("A = " + area.ToString("F4"));
            Console.ReadLine();
        }
    }
}
