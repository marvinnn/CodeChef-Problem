using System;
using System.Linq;

namespace Cutting_Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while(testCase-- != 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                input[0] = input.Max() + 1;
                int minVal = input.Min();
                for(int i = minVal; i >= 1; i--)
                {
                    int flag = 0;
                    for(int j= input.Length - 1; j >= 1; j--)
                    {
                        if (input[j] % i == 0)
                        {
                            continue;
                        }
                        else
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        result = i;
                        break;
                    }
                }
                if(result == 0)
                {
                    for(int i = 1; i <= input.Length - 1; i++)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                else
                {
                    for (int i = 1; i <= input.Length - 1; i++)
                    {
                        Console.Write(input[i]/result + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
