using System;

namespace Var_
{
    class Program
    {
        static void Main(string[] args)
        {
            //char c = 'a'; // 문자, 하나
            //String s = "hello world"; //문자열, 여러개
            //int i = 123; // 정수형
            //decimal d = 12.3m; // 실수형, 뒤에 m을 붙혀야 한다.
            //bool b = true; // true or false, 0과 1 입력, 선택
            //var v = 123; // var는 js에서 배운 것 처럼 형식에 관여 받지 않지만
            //             // 한 번 선언되면 해당 형식으로 저장된다

            String s1 = "Bob";
            int i1 = 3;
            decimal d1 = 34.4m;
            
            Console.WriteLine("Hello "+ s1 + "! You have "+ i1 + " in your inbox. The temperature is " + d1 + " celsius");
        }
    }
}
