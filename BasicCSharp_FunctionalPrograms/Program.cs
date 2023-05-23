using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome HelloWorld");
            Console.WriteLine("Choose a number to select a program");
            Console.WriteLine("1.Flip coin\n2.Leap year\n3.Power of 2");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("enter the number of times you flip the coin");
                    Flip flip = new Flip();
                    flip.FlipCoin();
                    Console.ReadLine();
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter any year");
                        int year = Convert.ToInt32(Console.ReadLine());
                    LeapYear.Year(year);
                    break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter the number");
                        int N = Convert.ToInt32(Console.ReadLine());
                        Power2.PowerOf2(N);
                        break;
                    }
                default:
                    Console.WriteLine("please choose existing program");
                    break;

            }
            Console.ReadLine() ;    
        }
    }
}
