using System;

namespace The_Block_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                char[] input = Console.ReadLine().Trim().ToCharArray();
                bool flag = true;
                for(int i = 0; i <= input.Length / 2; i++)
                {
                    if (input[i] == input[input.Length - 1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("losses");
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("wins");
                }
            }
        }
    }
}
