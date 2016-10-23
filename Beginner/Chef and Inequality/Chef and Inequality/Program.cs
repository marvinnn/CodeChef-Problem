using System;

namespace Chef_and_Inequality
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                string input = Console.ReadLine();
                string[] token = input.Split(' ');
                int[] numbers = Array.ConvertAll(token, int.Parse);

                int a = numbers[0];
                int b = numbers[1];
                int c = numbers[2];
                int d = numbers[3];
                ulong result = 0;

                if(a>b || c > d)
                {
                    Console.WriteLine(result);
                    testCase--;
                    break;
                }

                int x = b;
                while (x >= a)
                {
                    if (x < d)
                    {
                        if (x < c)
                        {
                            result = result + Convert.ToUInt64(d - c + 1);
                        }
                        else
                        {
                            result = result + Convert.ToUInt64(d - x);
                        }
                    }
                    x--;
                }
                Console.WriteLine(result);
                testCase--;
            }
            Console.ReadLine();
        }
    }
}
