﻿using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    Console.WriteLine("{0} is not a leap year", year);
                else
                    Console.WriteLine("{0} is a leap year", year);
            }
            else
                Console.WriteLine("{0} is not a leap year", year);
        }
    }
}