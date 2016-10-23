using System;

namespace Chef_and_Remisness
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while(testCase-- != 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Console.WriteLine(Math.Max(input[0], input[1]) + " " + (input[0] + input[1]));
            }
        }
    }
}
