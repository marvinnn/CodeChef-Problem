using System;

namespace Transform_the_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                char[] input = Console.ReadLine().Trim().ToCharArray();
                char[] operat = new char[input.Length];
                int operatorCount = 0;
                string result = "";
                for(int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(') { continue; }
                    if (char.IsLetter(input[i]))
                    {
                        result += input[i];
                    }
                    else if(input[i] == ')')
                    {
                        result+= operat[--operatorCount];
                    }
                    else
                    {
                        operat[operatorCount] = input[i];
                        operatorCount++;
                    }
                }
                Console.WriteLine(result);
                testCase--;
            }
        }
    }
}
