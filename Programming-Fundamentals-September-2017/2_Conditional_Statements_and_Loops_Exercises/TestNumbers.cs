﻿using System;

namespace Test_Numbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int combinations = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    combinations++;
                    totalSum = totalSum + (3 * (i * j));

                    if (totalSum >= maxNumber)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}