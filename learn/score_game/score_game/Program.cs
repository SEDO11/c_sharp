using System;

namespace score_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        static int Points(int levels)
        {
            int result = 0;
            for(int i=1; i<=levels; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
