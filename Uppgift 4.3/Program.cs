﻿using System;

class program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
