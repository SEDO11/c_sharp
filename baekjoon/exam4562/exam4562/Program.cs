using System;

namespace exam4562
{
    class Program
    {
        static void Main(string[] args)
        {
            int run = Convert.ToInt32(Console.ReadLine()); // 실행 횟수 입력
            for(int i=0; i < run; i++)
            {
                string brain_zombie = Console.ReadLine(); // 뇌 좀비 수를 공백을 기준으로 입력
                string[] b_z = brain_zombie.Split(' '); // 공백을 기준으로 나눔
                int brain = Convert.ToInt32(b_z[0]); // 뇌 수
                int zombie = Convert.ToInt32(b_z[1]); // 좀비 수

                if(brain >= zombie) // 뇌가 좀비의 수와 같거나 많은 경우
                {
                    Console.WriteLine("MMM BRAINS"); // 뇌를 먹는다
                }
                else // 좀비의 수가 뇌보다 많은 경우
                {
                    Console.WriteLine("NO BRAINS"); // 뇌를 먹지 않는다.
                }
            }
            
        }
    }
}
