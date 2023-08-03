using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int calc1 = 0;
            
            calc1 = valor / 100;

            int resto1 = 0;
          
            resto1 = valor % 100;
            
            int calc2 = 0;

            calc2 = resto1 / 50;

            int resto2 = 0;
            
            resto2 = resto1 % 50;

            int calc3 = 0;

            calc3 = resto2 / 20;

            int resto3 = 0;
            
            resto3 = resto2 % 20;

            int calc4 = 0;

            calc4 = resto3 / 10;

            int resto4 = 0;
            
            resto4 = resto3 % 10;

            int calc5 = 0;

            calc5 = resto4 / 5;

            int resto5 = 0;

            resto5 = resto4 % 5;

            int calc6 = 0;

            calc6 = resto5 / 2;

            int resto6 = 0;

            resto6 = resto5 % 2;

            int calc7 = 0;

            calc7 = resto6 / 1;

            Console.WriteLine(valor);

            Console.WriteLine(calc1 + " nota(s) de R$ 100,00");
            
            Console.WriteLine(calc2 + " nota(s) de R$ 50,00");
            
            Console.WriteLine(calc3 + " nota(s) de R$ 20,00");
            
            Console.WriteLine(calc4 + " nota(s) de R$ 10,00");
            
            Console.WriteLine(calc5 + " nota(s) de R$ 5,00");
            
            Console.WriteLine(calc6 + " nota(s) de R$ 2,00");

            Console.WriteLine(calc7 + " nota(s) de R$ 1,00");

            Console.ReadLine();

        }
    }
}
