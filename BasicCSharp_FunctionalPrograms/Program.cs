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
            Console.WriteLine("1.Flip coin\n" +
                "2.Leap year\n" +
                "3.Power of 2\n" +
                "4.Harmonic number\n" +
                "5.Prime factors\n" +
                "6.Quotient and Remainder\n" +
                "7.Swipe Number\n" +
                "8.Even Odd Number\n" +
                "9.Vowel Or Consonant\n" +
                "10.Largest number");
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
                case 4:
                    {
                        Console.WriteLine("please enter the number till you want Harmonic number");
                        Harmonic.HramonicNumber();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Please enter the number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Factors of {n}:");
                        Factor.PrimeFactor(n);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("please enter 1st number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter 2nd number");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Quotient_Remainder.QuotientAndRemainder(n, m);
                        break;
                    }
                case 7:
                    {
                        Swipe.SwipeNumber();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("please enter a number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        EvenOdd.EvenOddNumber(n);
                            break;
                    }
                case 9:
                    {
                        Console.WriteLine("please enter a alphabet");
                        vowel_Consonant.VowelOrConsonant();
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("please enter 1st number");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter 2nd number");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter 3rd number");
                        int n3 = Convert.ToInt32(Console.ReadLine());
                        Largest.LargestNumber(n1, n2, n3);
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
