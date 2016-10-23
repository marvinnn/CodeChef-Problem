using System;

namespace Turbo_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[testCase];
            int i = 0;
            while (i < testCase)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;
                i++;
            }
            Array.Sort(array);
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}