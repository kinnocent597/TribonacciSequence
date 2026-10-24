using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int nTerms = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= nTerms; i++)
            {
                Console.WriteLine($"Tribonacci({i} = {Tribonacci(i)}");
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static int Tribonacci(int nTerms)
        {
            if (nTerms == 0)
            {
                return 0;
            }
            if (nTerms == 1 || nTerms == 2)
            {
                return 1;
            }

            return Tribonacci(nTerms - 1) + Tribonacci(nTerms - 2) + Tribonacci(nTerms - 3);
        }
    }
}
