using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Factor
    {
        public static void PrimeFactor(int n)
        {
          
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();

        }
    }
}
