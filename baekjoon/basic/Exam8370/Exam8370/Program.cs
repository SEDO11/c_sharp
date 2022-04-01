// 비행기 좌석 개수 구하기
using System;

namespace Exam8370
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] nk = num.Split(' ');
            int n1 = Convert.ToInt32(nk[0]);
            int k1 = Convert.ToInt32(nk[1]);
            int n2 = Convert.ToInt32(nk[2]);
            int k2 = Convert.ToInt32(nk[3]);

            int result = (n1 * k1) + (n2 * k2);
            Console.WriteLine(result);
        }
    }
}
