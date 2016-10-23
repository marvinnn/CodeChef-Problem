using System;

namespace Packaging_Cupcakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                ulong num = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine((num / 2) + 1);
                testCase--;
            }
        }
    }
}
