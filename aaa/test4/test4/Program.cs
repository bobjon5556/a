using System;
using System.Collections;

namespace test4
{
    internal class Program
    {
        private static int swichnumber;

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");


            /*
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다.
             * 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             */

            /*
            Console.Write("정수 1, 2, 3 중에 하나를 입력하시오:");
            int.swichnumber = 0;
            int.TryParse(Console.ReadLine(), out swichnumber);
            
            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1을 입력 했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2을 입력 했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 입력 했습니다.");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;

            */

            /*
            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1을 입력 했습니다.");
                    goto case 3;
                case 2:
                case 3:
                    Console.WriteLine("3을 입력 했습니다.");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;

            02.5 중간점검
            1. case 절에서 break 문을 생략하면 어떻게 되는가?

            */

            /*

            Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            Console.Write("1. C \t");
            Console.Write("2.C++ \t");
            Console.Write("3.C# \t");
            Console.Write("4.java \t");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1. C 선택");
                    break;
                case 2:
                    Console.WriteLine("2.C++ 선택");
                    break;
                case 3:
                    Console.WriteLine("3.C# 선택");
                    break;
                case 4:
                    Console.WriteLine("4.java 선택");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;


            }


            while 문은 조건식이 참일 동안 문장을 반복 실행한다.


            */
            //while 문은 반복문인데 5번 실행할 예정
            /*

            int loopCounter = 0;
            while(loopCounter <5)
            {
                Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter + 1);
                loopCounter++;
                // loop 5만 도는 루프
            }

            //10 ~ 1 카운트 후 발사 출력하는 프로그램 작성

            loopCounter = 10;
            while (loopCounter > 0)

            {
                Console.Write("{0} ", loopCounter);
                loopCounter -= 1;
                //loop;
            }
            Console.WriteLine("발사");

            */

            /*
            Console.WriteLine("숫자를 입력하세요:");
            int userinput = int.Parse(Console.ReadLine());

            int loopCounter = 0;

            while (loopCounter < userinput)
            {
                if (userinput < 0) break;
                Console.WriteLine("{0} hello world", loopCounter + 1);
                loopCounter++;
                
            }
            Console.WriteLine("음의 정수를 입력하셨습니다:");

            */

            /*
            Console.WriteLine("숫자를 입력하세요:");
            int userinput = int.Parse(Console.ReadLine());

            int loopCounter = 1;

            while (loopCounter < userinput)
            {
                if (userinput < 0) break;
                Console.WriteLine("{0} hello world", loopCounter*3);
                loopCounter++;

            }
            Console.WriteLine("음의 정수를 입력하셨습니다");
            */

            /*
            {
                int sum = 0;

                while (true)
                {
                    Console.Write("수를 입력하세요: ");
                    string line = Console.ReadLine();
                    if (line == "0") break;
                    sum += int.Parse(line);
                }

                Console.WriteLine("지금까지 입력된 수의 합: " + sum);
            }

            */
            /*

            {
                Console.WriteLine("숫자를 입력하세요:");
                int userinput = int.Parse(Console.ReadLine());

                int loopCounter = 1;

                while (loopCounter < userinput)
                {
                    if (userinput < 0) break;
                    Console.WriteLine(loopCounter * 3);
                    loopCounter++;

                }
                Console.WriteLine("음의 정수를 입력하셨습니다");
            }

            */
            /*
            {
                Console.WriteLine("숫자를 입력하세요:");
                int userinput = int.Parse(Console.ReadLine());

                int loopCounter = 9;

                while (loopCounter > 0)
                {
                    if (userinput < 0) break;
                    Console.WriteLine(loopCounter * userinput);
                    loopCounter--;

                }
                Console.WriteLine("음의 정수를 입력하셨습니다");
            }
            */

            /*
            int sum = 0;

            
            {
                Console.WriteLine("입력할 갯수:");
                double userinput = double.Parse(Console.ReadLine());
                

                while (true)
                {
                    Console.Write("수를 입력하세요: ");
                    string line = Console.ReadLine();
                    if (line=="100") break;
                    sum += int.Parse(line);
                }

                Console.WriteLine("평균값 " + sum / userinput);

            }

            */

            /*
             * 
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날때마다 증감식이 실행된다.
             * 
             * */

            //1~10 까지 정수의 합
            /*
            int sumNumber = 0;
            for(int index =1; index <=10; index++)
            {
                sumNumber += index;
            }
            Console.WriteLine($"1부터 10까지의 정수의 합={sumNumber}");
            Console.WriteLine("1부터 10까지의 정수의 합= {0}", sumNumber);

            */

            /*
            int sumNumber = 1;


            for (int index = 1; index <= 100; index++)

            {
                sumNumber += index;
            }
            Console.WriteLine($"1부터 10까지의 정수의 합={sumNumber}");
            Console.WriteLine("1부터 10까지의 정수의 합= {0}", sumNumber);


            */
            /*
            int sumnumber = 0;
            for(Index=1; Index<=100;Index++)
                if(Index % 3 == 0) { /*do nothing}
                else { sumnumber += Index;
                }*/




            /*
             break 문
            break문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고 반복 루프 다음에 있는 문장이 실행된다.

            continue 문
            continue 문은 현재 수행하고 있는 반복과정의 나머지를 건너 뛰고 다음 반복 과정을 강제적으로 시작하게 만든다
            반복루프에서 continue 문은 만나게되면 continue 문 다음에 있는 후속코드들은 실행되지 않고 건너 뛰게 된다.

            */
            /*
            for(int index = 1; index <= 10; index++)
            {
                if (index == 4) { break:}
                Console.WriteLine("현재 인덱스: {0}", index);
            }
            */
            /*
            Console.WriteLine("입력할 정수의 수");
            int count = 0;
            int avg = 0;
            int.TryParse(Console.ReadLine(), out count);
            int div = count;
            while(count>0)
            {
                int number5 = int.Parse(Console.ReadLine());
                if(number5 > 0&& number5 <=0)
                {
                    avg += number5;
                    count--;
                }
                else
                {
                    Console.WriteLine("입력할 수");
                }

                float aswer = (float)avg / (float)div;
                Console.WriteLine("입력한 수의 평균" + aswer + "\n" + "\n" + "\n" + "\n");
            }

            */
            /*
            int aa = 0;//모음
            int bb = 0;//자음
            int cc = 0;

            Console.WriteLine("영문자를 입력");
            string line = Console.ReadLine();
            cc += int.Parse(line);

            while (0 > cc)
                {
                    switch (cc)
                    {
                        case 'a':
                        case 'i':
                        case 'e':
                        case 'o':
                        case 'u':
                            aa++; break;

                        default:
                            bb++;
                            break;
                    }
                Console.WriteLine("자음의 수");
                Console.WriteLine("모음의 수");
            }

            */

            /*
             * foreach 문은 배역(array)이나 컬렉션(collection)같은 값을 여러 개 담고 있는 데이터 구조에서 각각의 데이터가 들어있는 만큼 반복하는 반복문이다.
             * 데이터 개수나 반복 조건을 처리할 필요가 없다.
             * */

            //string 에서 글자를 하나씩 출력
            /*
            string stringText = "Hello world!";

            int loopcount = 0;
            foreach(char oneCharactor in stringText)

            { Console.Write("{0}", oneCharactor);
                loopcount++;


                Console.WriteLine();
                Console.WriteLine("Loop count: {0}, stringText's length");
                

            */



            /*
                    //[1] Input
                    int a = 0;

                    //[2] Process
                    
                    int i = 1;      // 초기식
                    while (i <= 100)     // 조건식
                    {
                        if (i % 3 == 0 || i % 4 == 0)   // 필터링(조건처리)
                        {
                            a += i;    // 실행문
                        }
                        i++;    // 증감식
                    }
                    
                    //[3] Output
                    Console.WriteLine(a);
                
            */


            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("{0}단\n", i);

                for (int j = 1; j <= 9; j++)
                {

                    if ( i<j )
                    continue;

                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();



        }
    }   
}






    

            
 