using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("자음, 모음의 개수를 세는 프로그램"); //안내문
            string input;//아래 입력값을 변수로 바꿈
            input= Console.ReadLine();//입력값

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
            Console.WriteLine(a2+e2+i2+o2+u2);


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


        }

    }
}
