using System;

namespace The_Lead_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            int score1 = 0, score2 = 0;
            int flag = 0, lead = 0;
            while (testCase > 0)
            {
                string input = Console.ReadLine();
                string[] token = input.Split(' ');
                score1 += Convert.ToInt32(token[0]);
                score2 += Convert.ToInt32(token[1]);
                if (score1 > score2)
                {
                    if(score1 - score2 > lead)
                    {
                        lead = score1 - score2;
                        flag = 1;
                    }
                }
                else
                {
                    if(score2 - score1 > lead)
                    {
                        lead = score2 - score1;
                        flag = 2;
                    }
                }
                testCase--;
            }
            Console.WriteLine(flag + " " + lead);
        }
    }
}
