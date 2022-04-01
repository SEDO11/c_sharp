// 둘째와 셋째의 나이를 통해 첫째의 나이 구하기
using System;

namespace Exam6749
{
    class Program
    {
        static void Main(string[] args)
        {
            int n3 = Convert.ToInt32(Console.ReadLine()); // 막내의 나이 입력
            int n2 = Convert.ToInt32(Console.ReadLine()); // 둘째의 나이 입력
            int n1 = n2 + (n2 - n3);
            Console.WriteLine(n1);
        }
    }
}
