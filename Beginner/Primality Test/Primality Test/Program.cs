using System;

namespace Primality_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                int input = Convert.ToInt32(Console.ReadLine().Trim());
                if(input == 1)
                {
                    Console.WriteLine("no");
                    continue;
                }
                if (input == 2 || input==3)
                {
                    Console.WriteLine("yes");
                    continue;
                }
                
                for(int i = input / 2; i > 1; i--)
                {
                    if (input % i == 0)
                    {
                        Console.WriteLine("no");
                        break;
                    }
                    if (i - 1==1)
                    {
                        Console.WriteLine("yes");
                    }
                }
            }
        }
    }
}
