using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sum = 0;
            Console.WriteLine("Please enter the start");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the End");
            int end = int.Parse(Console.ReadLine());

            for (x = start; x <= end; x++)
            {
                for (int j = 1; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == x)
                {
                    Console.WriteLine("Perfect numbers are: " + sum);
                }
                sum = 0;
            }
        }
    }
}
