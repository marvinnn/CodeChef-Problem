using System;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase-- != 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Console.WriteLine(input[0] + input[1]);
            }
        }
    }
}
