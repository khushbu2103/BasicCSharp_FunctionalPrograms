using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Largest
    {
        public static void LargestNumber(int n1, int n2, int n3) 
        {
            int largest;
            if (n1 > n2 && n2 > n3)
            {
                largest = n1;
            }
            else if(n2 > n3 && n2 > n1)
            {
                largest = n2;
            }
            else
            {
                largest = n3;
            }
            Console.WriteLine("Largest number among these 3 numbers is: " + largest);
        }
    }
}
