// 카드 게임
using System;

namespace Exam5522
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0; // 최종값 변수 선언 0으로 초기화
            for(int i=0; i<5; i++) // 5회 반복
            {
                int num = Convert.ToInt32(Console.ReadLine());
                result += num; // 입력 값 덧셈
            }
            Console.WriteLine(result); // 출력
        }
    }
}
