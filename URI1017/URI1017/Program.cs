using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            
            int velocidade = int.Parse(Console.ReadLine());

           double calc = 0.0;
           
            calc = (tempo * velocidade)/12.0;

            Console.WriteLine(calc.ToString("F3"));

            Console.ReadLine();
        
        }
    }
}
