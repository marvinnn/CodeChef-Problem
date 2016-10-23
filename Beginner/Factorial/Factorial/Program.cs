using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                ulong result = 0;
                ulong num = Convert.ToUInt64(Console.ReadLine());
                while (num >= 5)
                {
                    result += num / 5;
                    num = num / 5;
                }
                Console.WriteLine(result);
                testCase--;
            }
        }
    }
}
