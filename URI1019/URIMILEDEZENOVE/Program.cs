using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URIMILEDEZENOVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int segundos = N % 60;

            int minutos = (N / 60)%60;

            int horas = N / 3600;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        
        }
    }
}
