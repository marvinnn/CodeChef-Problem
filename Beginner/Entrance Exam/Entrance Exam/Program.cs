using System;

namespace Entrance_Exam
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

                int applicant = numbers[0];
                int enrolled = numbers[1];
                int test = numbers[2];
                long maxPoint = numbers[3];
                int[] score = new int[applicant-1];
                int i = 0;

                while (i <= applicant-2)
                {
                    input = Console.ReadLine();
                    token = input.Split(' ');
                    numbers = Array.ConvertAll(token, int.Parse);
                    for(int j = 0; j <= numbers.Length - 1; j++)
                    {
                        score[i] += numbers[j];
                    }
                    i++;
                }

                long sergey = 0;
                input = Console.ReadLine();
                token = input.Split(' ');
                numbers = Array.ConvertAll(token, int.Parse);
                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    sergey += numbers[j];
                }

                Array.Sort(score, (a, b) => -a.CompareTo(b));
                long deficit = score[enrolled-1] - sergey;
                if (deficit < 0)
                {
                    Console.WriteLine("0");
                }
                else if(deficit+1 <= maxPoint)
                {
                    Console.WriteLine(deficit + 1);
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
                testCase--;
            }
        }
    }
}