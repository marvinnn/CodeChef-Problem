using System;

namespace ChefDetective
{
    class Program
    {
        static void Main(string[] args)
        {
            int member = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            string[] token = input.Split(' ');
            int[] numbers = Array.ConvertAll(token, int.Parse);
            int i = 0;
            int[] report = new int[member+1];

            while (i <= member-1)
            {
                report[numbers[i]] += 1;
                i++;
            }
            i = 0;

            while(i <= member)
            {
                if(report[i] == 0)
                {
                    if (i  == member)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
                i++;
            }
        }
    }
}
