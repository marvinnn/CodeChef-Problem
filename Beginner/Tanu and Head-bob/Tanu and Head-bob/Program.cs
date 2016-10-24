using System;

namespace Tanu_and_Head_bob
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine().Trim());
            while (testCase-- != 0)
            {
                int length = Convert.ToInt32(Console.ReadLine().Trim());
                char[] input = Console.ReadLine().Trim().ToCharArray();
                for(int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'Y')
                    {
                        Console.WriteLine("NOT INDIAN");
                        break;
                    }
                    else if(input[i] == 'I')
                    {
                        Console.WriteLine("INDIAN");
                        break;
                    }
                    else
                    {
                        if (i == input.Length - 1)
                        {
                            Console.WriteLine("NOT SURE");
                        }
                    }
                }
            }
        }
    }
}
