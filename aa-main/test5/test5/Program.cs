using System.Runtime.CompilerServices;

namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int number = 1_08220000;
            Console.WriteLine("64로 모드연산:{0}", number%64);


            /*다차원 배열
             * 2차원 배열 3차원 배열처럼 자원이 2개 이상인 배열을 다차원 배열이라고 한다.
             * C#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.
             */

            int[] onrarray= new int[2] { 1, 2 };
            int[,] twoearray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] twoearray1 = new int[2, 3] { { 1, 2, 6 }, { 3, 4, 5 } };
            int[,] twoearray2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,,] threeearray2 = new int[2, 2, 2] {{ { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            //3행 3열짜리 배열에서 행과 열이 같으면 1 , 다르면 0을 출력
            twoearray2 = new int[3, 3];

            for (int y=0; y < 3; y++)
            {
                for(int x = 0; x < 3; x++)
                    {
                    if (x == y) { twoearray2[y, x] = 1; }
                    else { twoearray2[y, x] = 0; }
                }
            }//loop rkqtdmf eodlqgksms fnxm

            for (int y = 0; y <= twoearray2.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= twoearray2.GetUpperBound(1); x++)
                {
                    Console.Write("{0}", twoearray2[y, x]);
                }
                Console.WriteLine();

            }

            /*가변배열
             * 자원이 2개 이상인 배열은 디차원 베열이고, 배열길이가 가변 길이인 배열은 가변 배열이라고 한다.
             */
            int[][] zagarray = new int[2][];
            zagarray[0] = new int[]{1, 2 };
            zagarray[1] = new int[]{3,4,5};//[] 빈곳은 임의의 숫자를 입력하겠다는 뜻


            for(int y=0; y<2; y++)
            {
                for(int x=0; x<zagarray[y].Length; x++)
                Console.WriteLine("{0}", zagarray[y][x]);

            }
            Console.WriteLine();


            int[] intarray;          //int형 데이터 타입의 intarray 라는 배열을 선언
            intarray = new int[3];   //int형 데이터 타입의 변수를 3개의 메모리에 할당

            intarray[0] = 1;
            intarray[1] = 2;
            intarray[2] = 3;

            //배열 직접 츨력해본다
            for(int index=0;index<3; index++)
            {
                Console.WriteLine("{0} 번쨰 인덱스의 값 ->{1}", index, intarray[index]);
            } //3번 도는 루프
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //intarray 배열에서 int형 데이터 타입의 값을 하나씩 뽀ㅃ아서 index에 저장하려고 한다
            foreach(int index in intarray)
            {
                Console.WriteLine("intarray 배열에서 뽑아온 값 ->{0}", index);
            }

            //배열을 사용하여 국어 점수의 총점과 평균 구하기 학생 3명의 점수를 저장하는 배열선언해서, 각 학생별로 점수를 할당하고 (범위는1~100)모든 점수의 총점과 평균을 구하는 프로그램
            /*userInput 받아서 프로그램 작성
                유저 인풋은 3회
                점수는 1~100
                이상한 입력 예외처리
            */


        }
    }
}