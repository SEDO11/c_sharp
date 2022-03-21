//ai 오븐
using System;

namespace Exam2525
{
    class Program
    {
        static void Main(string[] args)
        {
            String timeStr = Console.ReadLine(); // 한줄에 공백으로 구분해서 시간과 분을 입력 받음
            String[] time = timeStr.Split(' '); // 입력 받은 시간을 공백을 기준으로 시간과 분으로 나눔
            int setTime = Convert.ToInt32(Console.ReadLine()); // 몇분 돌릴껀지 설정
            int hour = Convert.ToInt32(time[0]); // 시간
            int minute = Convert.ToInt32(time[1]); // 분
            int setMin = 60;
            int setHour = 24;

            minute += setTime; // 분끼리 계산
            //setTime /= 60;
            if (minute >= setMin) // 분이 60분 이상일 경우
            {
                hour += minute / setMin; // 분의 몫을 시간에 추가 해줌
                minute %= setMin; // 나머지를 분에 대입해줌
                if(hour >= setHour)
                {
                    hour %= setHour;
                }
            }

            Console.WriteLine($"{hour} {minute}");
        }
    }
}
