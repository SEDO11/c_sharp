using System;

namespace Exam9316
{
    class Program
    {
        static void Main(string[] args)
        {
            int run = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=run; i++)
            {
                Console.WriteLine($"Hello World, Judge {i}!");
            }
        }
    }
}
