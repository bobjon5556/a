using Microsoft.VisualBasic;
using System;
using System.Diagnostics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();//랜덤클래스 메서드

            int secretNumber1;// 랜덤값을 위해 만들어둔 변수
            int secretNumber2;// 랜덤값을 위해 만들어둔 변수
            int secretNumber3;// 랜덤값을 위해 만들어둔 변수

            int strike1 = 0;
            int strike2 = 0;
            int strike3 = 0;


                
            secretNumber1 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정
            secretNumber2 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정
            secretNumber3 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정




            Console.WriteLine(secretNumber1);//정답
            Console.WriteLine(secretNumber2);//정답
            Console.WriteLine(secretNumber3);//정답

            for (int i=0; i<9 ; i++) // 횟수 제한 없음
            {
                Console.Write("첫번째 숫자를 입력하세요 : ");//입력 안내문
                string input1 = Console.ReadLine();//숫자 입력창
                int number1 = Int32.Parse(input1);
                Console.Write("두번째 숫자를 입력하세요 : ");//입력 안내문
                string input2 = Console.ReadLine();//숫자 입력창
                int number2 = Int32.Parse(input2);
                Console.Write("세번째 숫자를 입력하세요 : ");//입력 안내문
                string input3 = Console.ReadLine();//숫자 입력창
                int number3 = Int32.Parse(input3);






                if (0 < secretNumber1)//0이상의 정수를 입력하면 실행
                {
                    if (number1 < (char)secretNumber1)//입력한 숫자가 답보다 작을 때
                    {
                        Console.WriteLine("1번째 숫자가 볼입니다.");
                    }

                    else if (number1 > (int)secretNumber1)//입력한 숫자가 답보다 클때
                    { Console.WriteLine("1번째 숫자가 볼입니다."); }

                    else
                    {
                        Console.WriteLine("스트라이크", (strike1 = 1));//그 이외의 값(정답)이 나오면 프로그램 종료




                    }

                    if (number2 < (int)secretNumber2)//입력한 숫자가 답보다 작을 때
                    {
                        Console.WriteLine("2번쨰 숫자가 볼입니다..");
                    }

                    else if (number2 > (int)secretNumber2)//입력한 숫자가 답보다 클때
                    { Console.WriteLine("2번째 숫자가 볼입니다."); }

                    else
                    {
                        Console.WriteLine("스트라이크", (strike2 = 1));//그 이외의 값(정답)이 나오면 프로그램 종료




                    }

                    if (number3 < (int)secretNumber3)//입력한 숫자가 답보다 작을 때
                    {
                        Console.WriteLine("3번째 숫자가 볼입니다.");
                    }

                    else if (number3 > (int)secretNumber3)//입력한 숫자가 답보다 클때
                    { Console.WriteLine("3번째숫자가 볼입니다."); }

                    else
                    {
                        Console.WriteLine("스트라이크", (strike3 = 1));//그 이외의 값(정답)이 나오면 프로그램 종료




                    }


                    if (i == 8)
                    {

                        Console.WriteLine("패배하셨습니다.");


                        break;
                    }
                    else 
                    { }



                    int strike4 =(strike1+ strike2 + strike3);
                    if (strike4 == 3)
                    {
                        Console.WriteLine("승리하셨습니다");


                        break;
                    }
                    else { }


                    


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