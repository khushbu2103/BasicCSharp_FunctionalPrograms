using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Swipe
    {
        public static void SwipeNumber()
        {
            Console.WriteLine("please enter 1st number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int second = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("after swipe first number is: {0} & second number is: {1} ",  first, second);
        }
    }
}
