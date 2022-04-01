using System;

namespace Exam9713
{
    class Program
    {
        static void Main(string[] args)
        {
            int run = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<run; i++)
            {
                int result = 0;
                int num = Convert.ToInt32(Console.ReadLine());
                for(int j=1; j<=num; j++)
                {
                    if(j%2 == 1) //홀수일 경우
                    {
                        result += j;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
