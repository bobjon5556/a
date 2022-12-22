//System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용
using System;

namespace whatisarray//내 프로그램 이름
{
    internal class Program //클래스 c#에서는 모든 요소들이 클래스 안에 있어야 함
    {
        static void Main(string[] args)//무조건 1개는 있어야한다. C#콘솔 창을 사용할때
        {
            Console.WriteLine("Hello, World!"); //프로그램은 여기서 부터 읽기 시작한다.


            //3의 배수를 제외한 수
            //int sumOfnumver=0;
            //int variable = 100;
            //bool isrealmultipleofthree = (variable_%3==0);
            //(variable_%3 ==0)
            //어떤변수 = "남자"

            //if (/*여기서 조건문은*/)  //남자 입니까? //조건문 A
            {

                //조건문이 참이면 여기로 옴
                //조건문은 여기서 부터 읽기 시작한다
                //조건문은 여기서 끝난다.
            }
            //else if ()//여자 입니까?  //조건문 B
            //{ }
            // else
            {
                //위의 조건문이 거짓이면 여기로 옴
                //조건문은 여기서부터 읽기 시작한다
                //조건문은 여기서 끝난다.
            }



            // 조건문을 여기서 시작했으면 이제 여기서 다시 프로그램이 시작

            int somenumber = 100;
            bool ispositiveintger = (0 < somenumber);

            bool isnumberzero = (somenumber == 0);


            int useriputnumber = 3;
            for (int index = 1; index <= 9; index++)
            {
                Console.WriteLine("{0} x {1}={2}",
                useriputnumber, index, useriputnumber * index);



            }


            /*프로그램 사용자로부터 입력받은 정수의 평균을 출력하는 프로그램을 작성하되
             * 다음 두가지의 조건을 만족할 것
             * -먼저 몇개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다
             * 그리고 그 수만큼 정수를 입력 받는다
             * 평균값은 소수점 이하까지 계상해서 출력한다.
             * */

            /*
             * 1.비밀코드 맞추기
             * 컴퓨터가 숨긴 비밀코드를 추측하는 게임을 작성
             * 비밀코드는 a~z사이의 문자
             * 컴퓨터는 사용자의 추측을 읽고 앞에 있는지 뒤에 있는지 알려준다
             */
            char scretcode = 'y';
            char userInputAlphabet = 'c';
            bool isSmallAlphabet = ('a' <= userInputAlphabet && userInputAlphabet <= 'z');

            bool isApabetfore = (userInputAlphabet <= scretcode);
            bool isApabetBack = (scretcode <= userInputAlphabet);

            if (isApabetfore)
            {
                Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다");
            }
            else
            { //do nothing
                Console.WriteLine("{0},{1}", "당신의 입력을 처리할 수 없습니다", "알파벳 소문자만 입력 바랍니다");
            }

            if (isApabetBack)
            {
                Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다");
            }
            else
            { //do nothing
            }


            //1~100 숫자 중에서 3의 배수 이면서 4의 배수인 정수 합 구하기
            int sumnumber = 0;
            int somenumber1 = 100;
            bool ismulti3 = (somenumber1 % 3 == 0);
            bool ismulti4 = (somenumber1 % 4 == 0);

            bool isSatis = ismulti3 && ismulti4;

            if (isSatis)
            {

                sumnumber += somenumber;
            }

            //별을 100번 찍는 법
            Console.WriteLine("{0},{1},{2},{3},{4}", "**********");
            Console.WriteLine("{0},{1},{2},{3},{4}", "**********");

            for (int index = 1; index <= 100; index++)
            {
                Console.Write("{0}", "*");
            }
            for (int index2 = 1; index2 <= 10; index2++) //이건 10번 도는 루프
            {
                for (int index2 = 1; index2 <= 10; index2++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                {
                    Console.WriteLine("{0}", "*");
                }
                Console.WriteLine();
            }


            for (int index = 1; index <= 100; index++)//이건 100번 도는 루프
            {
                Console.Write("{0}", "*");
            }


            int hundredCount = 0;

            for (int index2 = 1; index2 <= 10; index2++) //이건 10번 도는 루프 총합 1000번
            {
                for (int index2 = 1; index2 <= 10; index2++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                {
                    for (int index3 = 1; index3 <= 10; index3++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                    {
                        hundredCount++;
                        if (100 < hundredCount) { break; }
                        else
                        { //do nothing
                        }
                        Console.Write("{0}", "*");//별을 찍는 지점

                        if(hundredCount % 10 ==0)
                        {
                            Console.WriteLine();
                        }
                    }

                }
                Console.WriteLine();
            }
            /*
             * 유저 입력 받아서 (1~20줄) 유저 입력은 줄 단의 개수임 등차수열로 한단이 내려갈떄마다 별 1개씩 추가로 증가하는 프로그램 작성*/

            
            int hundredCount1 = 0;
            int aaaa = 0;

            char userChar = Convert.ToChar(Console.ReadLine());

            for (int index2 = 1; index2 <= userChar; index2++)
            {
                if (100 < hundredCount1) { break; }



                else
                { 
                }


            }


            /*컬렉션
             * 이름 하나로 데이터 여러개를 담을 수 있는 자료구조를 컬렉션 또는 컨테이너 라고한다.
             * C#에서 다루는 컬렉션은 배역(Attay),리스트(List) 사전(Dictianry)등이 있다.
             * 
             * 배열
             * 배열은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료구조 이다. 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근한다.
             * 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다
             * 
             * 배열의 특징들
             * 1.배열 하나에는 데이터 형식 한종류만 보관할 수 있다.
             * 2.배열은 메모리의 연속된 공간을 미리 할당하고 이를 대괄호[]와 0부터 시작하는 정수형 인덱스를 사용하여 접근 할 수 있다
             * 3.배열을 선언할 떄는 new 키워드로 배열을 생성한 후 사용할 수 있다
             * 4,배열에서 값하나는 요소(Element)또는 항목(Item)으로 횬현한다
             * 5필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상횐다.
             * 
             * 배열에는 3가지 종류가 있다.
             * 1.1차원 배열:배열의 첨자 하나만 사용하는 배열
             * 2.디치원 배열:첨자 2개 이상을 사용하는 배열
             * 3.가변(jagged)배열:배열의 배열이라고도 하며 이름 하나로 다양한 차원의 배열을 표현할 때 사용된다.
             * 
             */
            //배열의 선언과 초기화

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            
             for (int index=0; index < numbers.Length; index++)
                { 
             Console.Write("{0}", numbers[index]);
                 


            }//프로그램은 여기서 끝난다.
    }
}