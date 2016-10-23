using System;

namespace Ambiguous_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num= 99;
            while (true)
            {
                bool status = false;
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0) { break; }
                string[] input = Console.ReadLine().Trim().Split(' ');
                int[] numArray = Array.ConvertAll(input, int.Parse);
                for (int i = 0; i <= numArray.Length - 1; i++)
                {
                    if (numArray[numArray[i]-1] != i+1)
                    {
                        status = true;
                        break;
                    }
                }
                if (!status)
                {
                    Console.WriteLine("ambiguous");
                }
                else
                {
                    Console.WriteLine("not ambiguous");
                }
            }
        }
        
    }
}
