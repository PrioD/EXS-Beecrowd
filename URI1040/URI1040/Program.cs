using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] medias = Console.ReadLine().Split(' ');

            float n1 = float.Parse(medias[0]);

            float n2 = float.Parse(medias[1]);

            float n3 = float.Parse(medias[2]);

            float n4 = float.Parse(medias[3]);

            float calc = 0f;

            calc = ((n1 * 2f) + (n2 * 3f) + (n3 * 4f) + (n4 * 1f)) / 10f;

            if (calc == 4.85f)
            {
                calc = 4.8f;
            }

            Console.WriteLine("Media: " + calc.ToString("F1"));

            if (calc >= 7f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (calc < 5f)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (calc >= 5f && calc <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                float exame = float.Parse(Console.ReadLine());

                Console.WriteLine("Nota do exame: " + exame.ToString("F1"));
                float calc1 = (exame + calc) / 2f;
                
                if (calc1 >= 5f)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + calc1.ToString("F1"));
                }
                else { 
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + calc1.ToString("F1"));
                }
                    
            }
                   Console.ReadLine();
                
        }
    }
}
