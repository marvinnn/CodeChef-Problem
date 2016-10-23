using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] token = input.Split(' ');
            int withdraw = Convert.ToInt32(token[0]);
            double balance = Convert.ToDouble(token[1]);

            if(withdraw % 5 != 0)
            {
                Console.WriteLine(balance.ToString("0.00"));
            }
            else if(withdraw+0.50 >= balance)
            {
                Console.WriteLine(balance.ToString("0.00"));
            }
            else
            {
                Console.WriteLine((balance - 0.5 - withdraw).ToString("0.00"));
            }
        }
    }
}
