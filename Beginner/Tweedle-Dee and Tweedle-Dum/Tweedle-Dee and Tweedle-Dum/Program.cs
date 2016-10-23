using System;

namespace Tweedle_Dee_and_Tweedle_Dum
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
                int pile = Convert.ToInt32(token[0]);
                string first = token[1].ToString();

                input = Console.ReadLine();
                token = input.Split(' ');
                int[] numbers = Array.ConvertAll(token, int.Parse);

                if(pile==1 && first == "Dee" && numbers[0] % 2 == 0)
                {
                    Console.WriteLine("Dee");
                }
                else
                {
                    Console.WriteLine("Dum");
                }
                testCase--;
            }
        }
    }
}
