using System;

namespace Exam6778
{
    class Program
    {
        static void Main(string[] args)
        {
            int antenna = Convert.ToInt32(Console.ReadLine());
            int eye = Convert.ToInt32(Console.ReadLine());

            if (antenna >= 3 && eye <= 4)
            {
                Console.WriteLine("TroyMartian");
            }

            if (antenna <= 6 && eye >= 2)
            {
                Console.WriteLine("VladSaturnian");
            }

            if (antenna <= 2 && eye <= 3)
            {
                Console.WriteLine("GraemeMercurian");
            }

        }
    }
}
