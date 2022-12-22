using Microsoft.VisualBasic;
using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();//랜덤클래스 메서드

            int secretNumber;// 랜덤값을 위해 만들어둔 변수
            int secretNumber1;// 랜덤값을 위해 만들어둔 변수1 사용되지 않음
            int secretNumber2;// 랜덤값을 위해 만들어둔 변수2
            int secretNumber3;// 랜덤값을 위해 만들어둔 변수3

            secretNumber = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정
            secretNumber1 = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정1 사용되지 않음
            secretNumber2 = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정2
            secretNumber3 = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정3

            for (; ; ) // 횟수 제한 없음
            {


                Console.WriteLine("다음 두 숫자의 합을 구하세요 : ");//입력 안내문
                
                Console.WriteLine(secretNumber2);

                Console.WriteLine(secretNumber3);

                string input = Console.ReadLine();//숫자 입력창
                int number = Int32.Parse(input);

                if (0 < secretNumber)//0이상의 정수를 입력되면 실행
                {
                    if (number < secretNumber2+ secretNumber3)//입력한 숫자가 답보다 작을 때
                    {
                        Console.WriteLine("틀렸습니다.");
                    }

                    else if (number > secretNumber2+ secretNumber3)//입력한 숫자가 답보다 클때
                    { Console.WriteLine("틀렸습니다."); }

                    else
                    {
                        Console.WriteLine("정답입니다");//그 이외의 값(정답)이 나오면 프로그램 종료

                        break;
                    }


                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");//문자열 입력시 프로그램 종료
                    break;
                }
            }
        }
    }
}