using System;

namespace character_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이스케이프 문자
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\\ World!");

            //축자 문자열, 이스케이프 없음
            Console.WriteLine(@"Hello\ World!");

            //유니코드 이스케이프 문자, H E L L O 유니코드 이다.
            Console.WriteLine("\u0048\u0045\u004C\u004C\u004F World!");

            // 문자열 연결
            Console.WriteLine("Hello " + "World " + 3);

            // 문자열 보간, java "{}".format()방식이랑 같음
            String num1 = "아이스크림";
            String num2 = "사과";
            Console.WriteLine($"{num2} {num1}"); // 직접 넣는 방식
            Console.WriteLine("{0} {1}", num1, num2); // format 처럼 지정하고 뒤에 넣는 방식

            //축자, 문자열 보간 결합
            String pn = "First_Project"; 
            Console.WriteLine($@"C:\Output\{pn}\Data");

            //과제
            string projectName = "ACME";
            String englishMessage = "View English output";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($"{englishMessage}: \n\tc:\\Exercise\\{projectName}\\data.txt");
            Console.WriteLine($"{russianMessage}: \n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
        }
    }
}
