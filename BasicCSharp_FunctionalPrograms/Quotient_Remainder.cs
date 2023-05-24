using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Quotient_Remainder
    {
        public static void QuotientAndRemainder(int n, int m)
        {

            int Quotient;
            int Remainder;
            if (n == 0)
            {
                Console.WriteLine("Divisor MUST NOT be zero");
            }
            else
            {
                Quotient = n / m;
                Console.WriteLine("Quotient:" + Quotient);
                Remainder = n % m;
                Console.WriteLine("Remainder:" + Remainder);
            }
           
            
        }
    }
}
