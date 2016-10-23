using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enormous_Input_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] token = input.Split(' ');
            int num = Convert.ToInt32(token[0]);
            int divisor = Convert.ToInt32(token[1]);
            int result = 0;

            while (num > 0)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % divisor == 0)
                {
                    result++;
                }
                num--;
            }
            Console.WriteLine(result);
        }
    }
}
