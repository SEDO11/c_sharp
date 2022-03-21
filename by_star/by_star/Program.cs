using System;

namespace by_star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0부터 몇까지 숫자를 출력 하시겠습니까?> ");
            int input = Convert.ToInt32(Console.ReadLine()); //문자열로 입력받아 정수형으로 변환 java의 Integer.parseInt와 같음
            String result = null; // string 값 초기화
            for(int i=1; i<=input; i++)
            {
                if(i%3==0)
                {
                    result += "*";
                }
                else
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
