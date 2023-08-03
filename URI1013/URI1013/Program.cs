using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace URI1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]xdbr = Console.ReadLine().Split(' ');
            double A = double.Parse(xdbr[0]);
            
            double B = double.Parse(xdbr[1]);

            double C = double.Parse(xdbr[2]);

            double calc1 = (A + B +Math.Abs (A - B)) / 2;
            
            double calc2 = (calc1 + C +Math.Abs (calc1 - C))/2;
            
            Console.WriteLine(calc2 +" eh o maior");
           
            Console.ReadLine(); 
        }
    }
}
