using System;

namespace Exam5217
{
    class Program
    {
        static void Main(string[] args)
        {
            int run = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<run; i++)
            {
                int cnt = 0;
                string result_str = "";
                int num = Convert.ToInt32(Console.ReadLine());
                for(int j=1; j<=num; j++)
                {
                    int check = num - j;
                    if (check > j && cnt == 0) // 한번만 실행 할 경우
                    {
                        result_str = $"{j} {check}";
                        cnt++;
                    }
                    else if (check > j && cnt > 0)
                    {
                        result_str += $", {j} {check}";
                    }
                    
                }
                string result = $"Pairs for {num}: {result_str}";
                Console.WriteLine(result);

            }
        }
    }
}
