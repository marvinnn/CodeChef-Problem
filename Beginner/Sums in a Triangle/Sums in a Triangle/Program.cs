using System;

namespace Sums_in_a_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                int depth = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[depth, depth];
                for(int i = 0; i <= depth - 1;i++)
                {
                    string input = Console.ReadLine().Trim(); ;
                    string[] token = input.Split(' ');
                    int[] numbers = Array.ConvertAll(token, int.Parse);
                    for(int j = 0; j < numbers.Length; j++)
                    {
                        array[i,j] = numbers[j];
                    }
                }
                for (int i = depth - 2; i >= 0; i--)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        array[i, j] += Math.Max(array[i + 1, j], array[i + 1, j + 1]);
                    }
                }
                Console.WriteLine(array[0, 0]);
                testCase--;
            }
        }
    }
}
