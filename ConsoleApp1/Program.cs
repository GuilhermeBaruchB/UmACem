using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            // de um em um até 100
            
            for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }

            // de dois em dois até 100 (apenas pares)

            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            // de dois em dois até 100 (apenas impares)

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }



            // de um em um até -100

            for (int i = 1; i >= 100; i--)
            {
                Console.WriteLine(i);
            }

            // de dois em dois até -100 (apenas pares)

            for (int i = 0; i <= 100; i -= 2)
            {
                Console.WriteLine(i);
            }

            // de dois em dois até 100 (apenas impares)

            for (int i = -1; i <= 100; i -= 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

    }
}

