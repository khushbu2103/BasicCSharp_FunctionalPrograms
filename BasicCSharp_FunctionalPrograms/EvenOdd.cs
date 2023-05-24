using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class EvenOdd
    {
        public static void EvenOddNumber(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}: is even number", n);
            }
            else
            {
                Console.WriteLine("{0}: is odd number", n);
            }
         
        }
    }
}
