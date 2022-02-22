using System;

namespace Day5_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Practice Problems ");
            Console.WriteLine("Enter the power of 2 ");
            int power = Convert.ToInt32(Console.ReadLine());
            PowerOfTwo.CalculatePowerOfTwo(power);

        }
    }
}