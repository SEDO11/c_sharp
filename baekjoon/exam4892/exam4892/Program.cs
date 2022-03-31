using System;

namespace exam4892
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 1;
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine()); // 입력
                if(num != 0)
                {
                    int n1 = 3 * num;
                    int n2;
                    string t;
                    if (n1 % 2 == 0) // 짝수면
                    {
                        n2 = n1 / 2;
                        t = "even";
                    }
                    else // 홀수면
                    {
                        n2 = (n1 + 1) / 2;
                        t = "odd";
                    }

                    int n3 = 3 * n2;
                    int n4 = n3 / 9;
                    string result = $"{cnt}. {t} {n4}"; //출력 저장
                    Console.WriteLine(result); // 출력
                    cnt++; 
                }
                else
                {
                    break;
                }

            }
        }
    }
}
