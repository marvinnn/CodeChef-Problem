using System;

namespace Greedy_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int max = 0;
                for(int i = 2;i<= input[1]; i++)
                {
                    if (input[0] % i > max)
                    {
                        max = input[0] % i;
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}
