using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your start: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the end: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers are :");

            int i;
            for (i = start; i <= end; i++)
            {
                bool primenumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primenumber = false;
                        break;
                    }
                }
                if (primenumber)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
