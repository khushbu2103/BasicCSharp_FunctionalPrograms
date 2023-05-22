using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class LeapYear
    {
        public static void Year(int year)
        {
            if(year < 1000 || year > 9999)
            {
                Console.WriteLine("please enter 4 degit number as year");
            }

            else if(( year % 4 == 0 && year % 100 != 0) || year % 400 ==0 )
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap Year", year);
            }
        }

    }
}
