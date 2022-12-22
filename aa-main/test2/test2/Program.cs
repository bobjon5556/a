using Microsoft.VisualBasic;
using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args
            )

        {

            // LAB 1번문제
            // 크기가 100인 배열을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성.
            //가독성 좋게 출력

            Random rand = new Random(); //랜덤메서드 생성
            int[] v = new int[100];// v라는 이름의 1-100까지의 배열 생성


            for (int i = 0; i < v.Length; i++)//v의 배열 수 만큼의 랜덤 값 생성
            { v[i] = rand.Next(1, 100); }//위에 만든 v배열의 구성을 100개의 1-100의 사이값을 가진 배열로 변경

            

            // 최대값
            int max = v[0]; //v배열값이 입력되지 않은 max변수 생성
            for (int i = 1; i < v.Length; i++)//1부터 시작해서 v의 값 까지 순차적으로 1씩 증가하며 실행하는 반복문
                if (v[i] > max)//v배열의 값이 max값 보다 작다면 실행되는 조건문 if
                { max = v[i]; }//순차적으로 1씩 늘어 max 값과 같은 v배열 의 값=최대값
            Console.WriteLine("최대값: {0}", max);//max값을 출력





            //lab 2번 문제
            //사과를 제일 좋아하는 사람찾기
            //사람들 5명 (사람1,사람2,...)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
            //데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다. (기본형)
            //-이상한 입력 예외처리
            //-제일 적게 먹은 사람도 찾도록 수정해보기 (변형1)
            //-먹은 사과의 개수 순으로 정렬 ->알고리즘을 잘 모르겠다면 버블 정렬을 도전 해볼 것. (변형2)
            //                            ->알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것. (어려운거)
            //                              정렬 도전시 유저 입력X, 데이터는 난수로 100~1000개 정도의 값
            //                              중복 제거, 시간초는 전혀 상관 없음.

            int userInputNum = 0;//밑에 입력값을 선언하기 위한 변수1
            int userInputNum1 = 0;//밑에 입력값을 선언하기 위한 변수2
            int userInputNum2 = 0;//밑에 입력값을 선언하기 위한 변수3
            int userInputNum3 = 0;//밑에 입력값을 선언하기 위한 변수4
            int userInputNum4 = 0;//밑에 입력값을 선언하기 위한 변수5


            for (; ; ) // 횟수 제한 없이 반복 실행
            {
                Console.Write("1번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum);//입력된 값을 userInputNum 변수로 저장
                Console.Write("2번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum1);//입력된 값을 userInputNum1 변수로 저장
                Console.Write("3번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum2);//입력된 값을 userInputNum2 변수로 저장
                Console.Write("4번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum3);//입력된 값을 userInputNum3 변수로 저장
                Console.Write("5번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum4);//입력된 값을 userInputNum4 변수로 저장

                int[] fiveman = new int[5] { userInputNum, userInputNum1, userInputNum2, userInputNum3, userInputNum4 };
                //위에 입력된 5개의 변수의 값을 가진 배열 fiveman 생성

                if (0 < userInputNum)//0이상의 정수를 입력하면 실행
                {

                    // 최대값
                    int max1 = fiveman[0];//fiveman의 배열값이 입력되지 않은 변수 max1생성
                    for (int i = 1; i < fiveman.Length; i++)
                        //1부터 시작해서 fiveman의  값 까지 순차적으로 1씩 증가하며 실행하는 반복문
                        if (fiveman[i] > max1)//순차적으로 입력된 배열 fiveman의 값이 변수 max1보다 크다면 실행
                        { max1 = fiveman[i]; }//변수 max1과 배열 fiveman의 값 중 일치하는 값 =최대값

                    Console.WriteLine("최대값: {0}", max1);//max1값을 출력


                    // 최소값
                    int min1 = fiveman[0];//fiveman의 배열값이 입력되지 않은 변수 min1생성
                    for (int i = 1; i < fiveman.Length; i++)
                        //1부터 시작해서 fiveman의  값 까지 순차적으로 1씩 증가하며 실행하는 반복문
                        if (fiveman[i] < min1)//순차적으로 입력된 배열 fiveman의 값이 변수 max1보다 작다면 실행
                        { min1 = fiveman[i]; }//변수 min1과 배열 fiveman의 값 중 일치하는 값 =최소값
                    Console.WriteLine("최소값: {0}", min1);//min1값을 출력


                    //정렬(함수사용)

                    Array.Sort(fiveman); //메서드 Array를 사용 변수 fiveman Sort 함수값으로 정렬(오름차순)
                    Console.WriteLine(string.Join(", ", fiveman));//정렬된 fivaman 변수값을 출력




                    //정렬 (함수사용x)

                    // 입력
                    int[] data = fiveman; //변수 fiveman 값을 가진 int타입의 data변수 생성
                    int N = data.Length;//data값의 크기를 가지는 int타입의 변수 N생성

                    //처리: 선택 정렬 알고리즘
                    for (int i = 0; i < N - 1; i++)// 0부터 시작되어 변수N-1까지 순차적으로 반복실행
                    {
                        for (int j = i + 1; j < N; j++)  //j = i + 1 to N 
                            //i+1만큼의 값부터 시작되어 변수 N값 까지 순차적으로 반복실행
                        {
                            if (data[i] > data[j])//배열 끼리의 부등호 방향에 따라  오름차순(>), 내림차순(<)이 결정
                            {
                                int temp = data[i]; data[i] = data[j]; data[j] = temp;
                                //배열의 값을 교환하기 위해 입력값을 동일하다고 지정
                            }
                        }
                    }


                    for (int i = 0; i < N; i++)// 0부터 시작되어 변수N의값 까지 순차적으로 반복실행
                    {
                        Console.Write($"{data[i]}\t");
                        //보간된 문자열($)로 식별한 i까지의 값을 가진 배열 data를 가로 탭(\t)으로 띄워서 출력

                    }
                    Console.WriteLine();//빈칸



                   


                    break;//실행중단하고 위의 함수에서 벗어납니다.

                }
                else
            
                Console.WriteLine("잘못 입력하셨습니다.");//문자열 입력시 프로그램 종료
                break;//실행중단하고 위의 함수에서 벗어납니다.

            }
        }

     }
}
