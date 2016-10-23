using System;

namespace Chef_and_Keyboard
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

                int width = numbers[0];
                int height = numbers[1];
                int color = numbers[2];
                int factorFinder = color;
                int result = 0;

                while(factorFinder > 0)
                {
                    if(color%factorFinder == 0)
                    {
                        int factorFound = color / factorFinder;
                        if(width >= factorFinder && height >= factorFound)
                        {
                            result++;
                        }
                    }
                    factorFinder--;
                }
                Console.WriteLine(result);
                testCase--;
            }
            Console.ReadLine();
        }
    }
}
