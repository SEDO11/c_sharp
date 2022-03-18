using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        // 프로그램 실행이 시작되는 곳, Main에서 시작
        static void Main(string[] args)
        {
            if(args.Length == 0) //입력이 안됬을 경우
            {
                Console.WriteLine("사용법 : Hello.exe<이름>"); // 1번 줄의 코드 덕분에 구절 생략
                return; // 종료
            }

            WriteLine("Hello, {0}!", args[0]); //Hello Wrold를 프롬프트에 출력, 2번 줄의 코드 덕분에 구절 생략
        }
    }
}
