﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp_FunctionalPrograms
{
    internal class Flip
    {
        public void FlipCoin()
        {
            
            int numberOfFlip = Convert.ToInt32(Console.ReadLine());
            int headCount = 0;
            int tailCount = 0;
            Random random = new Random();
            for (int i = 0; i < numberOfFlip; i++)
            {
                int FlipRandom = random.Next(0, 2);
                if (FlipRandom == 0)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            double headsPercentage = (headCount / (double)numberOfFlip) * 100;
            double tailsPercentage = (tailCount / (double)numberOfFlip) * 100;

            Console.WriteLine("Heads: {0} ({1}%)", headCount, headsPercentage);
            Console.WriteLine("Tails: {0} ({1}%)", tailCount, tailsPercentage);


        }
    }
}
