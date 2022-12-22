using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("모음의 개수를 세는 프로그램"); //안내문
            string input;//아래 입력값을 변수로 바꿈
            input = Console.ReadLine();//입력값

            char a1 = 'a';   //각각의 모음에 char 연산자를 대응
            char e1 = 'e';
            char i1 = 'i';
            char o1 = 'o';
            char u1 = 'u';

            int a2 = input.Count(f => (f == a1));//위에 대응한 연산자에 input 값 을 넣서 갯수를 셉니다.
            int e2 = input.Count(f => (f == e1));
            int i2 = input.Count(f => (f == i1));
            int o2 = input.Count(f => (f == o1));
            int u2 = input.Count(f => (f == u1));

            Console.WriteLine("모음의 갯수");//모든 모음의 갯수의 합을 더해줍니다.
            Console.WriteLine(a2 + e2 + i2 + o2 + u2);


            //아래는 만들다가 실패한 반복문을 사용한 식입니다.



            //char ch = Int32.TrayParse(input);
            /*
            for (int i = 0; i < input.Length; i++)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowel++;
                else
                    consonant++;

            }

            Console.WriteLine("모음의 갯수");
            Console.WriteLine(vowel);

            Console.WriteLine("자음의 갯수");
            Console.WriteLine(consonant);
            */
            


            {
                Random rand = new Random();//랜덤클래스 메서드

                int secretNumber;// 랜덤값을 위해 만들어둔 변수

                secretNumber = rand.Next(1, 100);//1~100 사이의 정수를 랜덤으로 결정


                for (; ; ) // 횟수 제한 없음
                {
                    Console.Write("숫자를 입력하세요 : ");//입력 안내문

                    string input = Console.ReadLine();//숫자 입력창
                    int number = Int32.Parse(input);

                    if (0 < secretNumber)//0이상의 정수를 입력하면 실행
                    {
                        if (number < secretNumber)//입력한 숫자가 답보다 작을 때
                        {
                            Console.WriteLine("숫자가 작습니다.");
                        }

                        else if (number > secretNumber)//입력한 숫자가 답보다 클때
                        { Console.WriteLine("숫자가 큽니다"); }

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
            {
                Random rand = new Random();//랜덤클래스 메서드

                int secretNumber;// 랜덤값을 위해 만들어둔 변수
                int secretNumber1;// 랜덤값을 위해 만들어둔 변수1
                int secretNumber2;// 랜덤값을 위해 만들어둔 변수2
                int secretNumber3;// 랜덤값을 위해 만들어둔 변수3

                secretNumber = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정
                secretNumber1 = rand.Next(0, 99);//1~100 사이의 정수를 랜덤으로 결정1
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
                        if (number < secretNumber2 + secretNumber3)//입력한 숫자가 답보다 작을 때
                        {
                            Console.WriteLine("틀렸습니다.");
                        }

                        else if (number > secretNumber2 + secretNumber3)//입력한 숫자가 답보다 클때
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
}