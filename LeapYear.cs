using System;

namespace Day5_PracticeProblems
{
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt16(Console.ReadLine());
            if (year <= 9999 && year >= 1000)
            {
                int x = year % 4;
                int y = year % 100;
                int z = year % 400;
                if (z == 0)
                {
                    Console.WriteLine(+year + " is a leap year ");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine(+year + " is a leap year ");
                }
                else
                {
                    Console.WriteLine(+year + " is not a leap year ");
                }
            }
            else
            {
                Console.WriteLine("enter a valid year");
            }

        }
    }
}