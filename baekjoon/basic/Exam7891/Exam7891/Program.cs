using System;

namespace Exam7891
{
    class Program
    {
        static void Main(string[] args)
        {

            int run = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<run; i++)
            {
                int result = 0;
                string num_str = Console.ReadLine();
                string[] num = num_str.Split(' ');
                int n1 = Convert.ToInt32(num[0]);
                int n2 = Convert.ToInt32(num[1]);
                result = n1 + n2;
                Console.WriteLine(result);
            }
        }
    }
}
