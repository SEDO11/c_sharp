using System;

namespace number_
{
    class Program
    {
        static void Main(string[] args)
        {
            //연산
            int a = 7;
            int b = 5;
            int sum = a + b;
            int minus = a - b;
            int mum = a * b;
            float div = (float) a / b; // 강제 타입 변환 int -> float으로 변경
            String s1 = "나는";
            String s2 = "살이야";

            // 실수형 연산 출력
            Console.WriteLine(div);
            // 문자열과 숫자형 연산 출력
            Console.WriteLine(s1 + (a + b) + s2);

            //과제
            int fahrenheit = 94;
            decimal result = (fahrenheit - 32) * ((decimal) 5 / 9);

            Console.WriteLine($"화씨 {fahrenheit}도는 섭씨 {result}도 입니다.");
        }
    }
}
