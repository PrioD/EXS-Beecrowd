using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            
            int ano = idade / 365;
            
            int resto = idade % 365;
            
            int mes = resto / 30;

            int dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");

            Console.WriteLine(mes + " mes(es)");

            Console.WriteLine(dia + " dia(s)");

            Console.ReadLine();



        }
    }
}
