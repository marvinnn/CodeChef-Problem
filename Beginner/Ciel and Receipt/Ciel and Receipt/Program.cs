using System;

namespace Ciel_and_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                int price = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                for(int i = 11; i >= 0; i--)
                {
                    if(price < Math.Pow(2, i))
                    {
                        continue;
                    }
                    else
                    {
                        if(price % Math.Pow(2, i)==0)
                        {
                            result += Convert.ToInt32(Math.Floor(price / Math.Pow(2, i)));
                            break;
                        }
                        else
                        {
                            result += Convert.ToInt32(Math.Floor(price / Math.Pow(2, i)));
                            price = Convert.ToInt32(price % Math.Pow(2, i));
                        }
                    }
                }
                Console.WriteLine(result);
                testCase--;
            }
        }
    }
}
