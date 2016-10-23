using System;

namespace Snape_and_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while(testCase-- != 0)
            {
                double[] input= Array.ConvertAll(Console.ReadLine().Trim().Split(' '), double.Parse);
                Console.WriteLine(Math.Sqrt(input[1] * input[1] - input[0] * input[0]).ToString("0.00000") + " " + Math.Sqrt(input[1] * input[1] + input[0] * input[0]).ToString("0.00000"));
            }
        }
    }
}
