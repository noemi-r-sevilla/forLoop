﻿using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            for (int i =1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                }
            }
            int j = 1;
            while (j <= 255)
            {
                Console.WriteLine(j);
                j += 1;
            }
        }
    }
}