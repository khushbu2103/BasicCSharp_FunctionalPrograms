using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Power2
    {
        public static void PowerOf2(int N)
        {
           
            if (N < 0 || N >= 31)
            {
                Console.WriteLine("N must be between 0 and 30:");
                return;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"2^" + i + " = " + Math.Pow(2, i));

            }
        }
    }
}
