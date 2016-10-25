using System;

namespace Fit_Squares_in_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                int input = Convert.ToInt32(Console.ReadLine().Trim());
                int M = input / 2;
                Console.WriteLine((M * (M - 1)) / 2);
            }
        }
    }
}
