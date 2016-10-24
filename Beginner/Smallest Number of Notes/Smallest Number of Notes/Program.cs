using System;

namespace Smallest_Number_of_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                int input = Convert.ToInt32(Console.ReadLine().Trim());
                int[] divisor = { 100, 50, 10, 5, 2, 1 };
                int result = 0;
                for(int i = 0; i <= divisor.Length-1; i++)
                {
                    if (input == 0)
                    {
                        break;
                    }
                    if (input >= divisor[i])
                    {
                        result += input / divisor[i];
                        input %= divisor[i];
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
