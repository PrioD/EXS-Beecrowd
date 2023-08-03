using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMBER = 0;
            
            int A = 0;
            
            double B = 0;  
            
            double CALC = 0.0 ;

           
            
            NUMBER = int.Parse(Console.ReadLine());
            
            A = int.Parse(Console.ReadLine());

           B = double.Parse(Console.ReadLine());
            
            CALC = A * B;
           
            Console.WriteLine("NUMBER = "+ NUMBER);
            
            Console.WriteLine("SALARY = U$ " + CALC.ToString("F2"));

            Console.ReadLine();



        }
    }
}
