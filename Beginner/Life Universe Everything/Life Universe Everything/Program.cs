using System;

namespace Life_Universe_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                short num = Convert.ToInt16(Console.ReadLine());
                if (num == 42)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }
    }
}
