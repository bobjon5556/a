using System;
using System.Linq;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LAB 1.크기가 100인 배열을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성.
            //가독성 좋게 출력
            //int형 배열 sizeH의 길이를 100으로 선언
            int[] sizeH = new int[100];
            //sizeH 안에 0~100사이의 숫자를 랜덤하게 넣기위해 Random문 선언
            Random randomNumber = new Random();
            //for문 시작 loop: 100번 도는 루프
            for (int index = 0; index < 100; index++)
            {
                //index = 0 일때 시작해서 99까지돔
                //sizeH[0]번 부터 1~100까지의 랜덤한 수 하나를 뽑아 저장함
                //100+1인 이유 (최대값은 포함X기 때문)
                sizeH[index] = randomNumber.Next(1, 100 + 1);
                //sizeH에 값이 제대로 들어갔는지 출력
                Console.WriteLine("sizeH{0}의 값은 {1}입니다", index, sizeH[index]);
            } //for문 종료
            Console.WriteLine("sizeH배열의 최대값은 {0} 입니다.", sizeH.Max());

            //LAB 2.사과를 제일 좋아하는 사람찾기
            //사람들 5명 (사람1,사람2,...)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
            //데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다. (기본형)
            //-이상한 입력 예외처리
            //-제일 적게 먹은 사람도 찾도록 수정해보기 (변형1)
            //-먹은 사과의 개수 순으로 정렬 ->알고리즘을 잘 모르겠다면 버블 정렬을 도전 해볼 것. (변형2)
            //                            ->알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것. (어려운거)
            //                              정렬 도전시 유저 입력X, 데이터는 난수로 100~1000개 정도의 값
            //                              중복 제거, 시간초는 전혀 상관 없음.

            //기본 + 변형1
            //5명의 사람이 먹은 사과의 갯수를 입력하기 위해  int형 배열 appleCount 의 크기를 5로 선언
            int[] appleCount = new int[5];
            //입력값 예외처리 for문 시작 배열은 0부터 시작하므로 index < 5 로 정함 loop: 5번 도는 루프
            for (int index = 0; index < 5; index++)
            {
                Console.Write("아침에 먹은 사과 개수를 입력하시오.: ");
                //string형식으로 입력받은 것을 int형식으로 변환하여 appleCount[index]안에 저장함
                int.TryParse(Console.ReadLine(), out appleCount[index]);
                //if문 시작 조건: 입력받은 appleCount[index]의 값이 0 보다 큰 정수일 때
                if (appleCount[index] > 0)
                {
                }
                //입력받은 appleCount의 값이 정수가 아니면 실행
                else
                {
                    //정수가 아니므로 오류메시지 출력
                    Console.WriteLine("잘못 입력하였습니다.");
                    //appleCount[index] 안에 다시 값을 입력받아 저장해야하기 때문에 index-- 증감식으로 재실행하기위해 선언
                    index--;
                } //if문 종료
            } //for문 종료
            
            //appleCount배열안에 제대로 값이 들어갔는지 확인하기 위한 for문 시작
            for (int index = 0; index < 5; index++)
            {
                //출력 index가 0부터 시작하므로 사람1부터 표시하기위해 index + 1 시킴
                Console.WriteLine("사람{0} 이 먹은 사과 개수는?: {1}", index + 1, appleCount[index]);
            } //for문 종료
            
            //appleCOunt배열안에 최대값과 최소값을 찾기위해 Array.IndexOf문과 .Max, .Min 문을 사용함
            //Array.IndexOf(주소값을 찾고자하는 배열이름 , (찾고자하는 주소값의 들어있는 값)) 배열은 0번부터시작이라 사람1...5까지 출력하기위해 +1시킴
            Console.WriteLine("사람{0}가 가장 많은 {1} 개수의 사과를 먹었습니다.", Array.IndexOf(appleCount, appleCount.Max()) + 1,
                appleCount.Max()); //가장 많이 먹은 사람과 개수 구하기
            Console.WriteLine("사람{0}가 가장 적은 {1} 개수의 사과를 먹었습니다.", Array.IndexOf(appleCount, appleCount.Min()) + 1,
                appleCount.Min()); //(변형1) 가장 적개 먹은 사람과 개수 구하기
            
            //아래문제랑 공백 구분
            Console.WriteLine();

            //변형2 -먹은 사과의 개수 순으로 정렬 ->알고리즘을 잘 모르겠다면 버블 정렬을 도전 해볼 것.
            int userInPut = 0;
            //입력값 예외처리하기 위한 for문 시작 사람 수만 입력하면되므로 loop: 2번돔
            for (int index = 0; index <= 1; index++)
            {
                Console.Write("입력하시오: ");
                //string형식으로 입력받은 값을 int형식으로 변환해서 저장
                int.TryParse(Console.ReadLine(), out userInPut);
                //입력값 예외처리를 위한 if 문 실행 조건: userInPut이 0보다 큰 정수일 때
                if (userInPut > 0)
                {
                    //0보다 큰 정수를 입력받았으므로 break로 즉시 종료
                    break;
                }
                //위에 조건이 만족하지않을때 실행
                else
                {
                    //입력된 값이 0보다큰 정수가 아니므로 오류메시지 출력
                    Console.WriteLine("XX다시 입력하시오.XX ");
                    //for문을 다시 돌리기위해 index값을 --로 감소시킴
                    index--;
                } //if문 종료
            } //for문 종료
            
            //입력받은 userInPut의 값이 사람이 먹은 사과의 갯수가 되기 때문에 appleCount2 (위에 문제에 쓴 변수명이라 2를 붙임)
            //라는 int형 배열을 만들어 그안에 int로 변형된 입력값을 저장
            int[] appleCount2 = new int[userInPut];
            //appleCount2 배열안에 입력값이 잘 들어갔는지 확인용 출력문
            Console.WriteLine("appleCount2의 길이는{0}", appleCount.Length);
            //가장 적게 먹은 사과갯수를 뒤에 버블정렬로 배열의 Index주소마다 값이 바뀔거기때문에
            //마지막출력문에 사람순서를 가장적게먹은 사람순서로 출력하기위한 appleEat (int형 배열 선언) 안에 userInPut 초기값을 저장함
            int[] appleEat = new int[userInPut];
            //사과 먹은 갯수를 0~100사이의 난수로 저장하기위한 Random 변수 선언
            Random randomCount = new Random();
            //사과 먹은 갯수를 appleCount2 안에 저장하기 위한 for문 시작
            for (int index = 0; index < userInPut; index++)
            {
                //appleCount2[0]번부터 userInPut (userInPut크기가 곧 배열의 길이임) 안에
                //.Next 함수를 이용하여 0~100+1 (최대값은 포함X라 0~99까지 넣기위해 +1)의 범위안에 랜덤숫자 1개를 저장
                appleCount2[index] = randomCount.Next(0, 100 + 1);
                //appleCount2안에 값이 잘 저장되었는지 확인용 출력문
                Console.WriteLine("사람{0}\t이 먹은 사과 개수는 {1}\t개 입니다", index + 1, appleCount2[index]);
                //먹은 사람 1번부터 userInPut까지 구하기 위해 appleEat에 index + 1(index가 0부터 시작이므로 +1)
                //값 저장 (appleEat배열안에 1,2,...userInPut+1의 정수가 저장됨)
                appleEat[index] = index + 1;
            } //for문 끝
            //공백처리
            Console.WriteLine();
            //가장 적게 먹은 사과갯수 부터 가장 많은 갯수 순서로 구하기 위한 for문 시작 loop: userInPut - 1 만큼 루프(배열은0부터시작)
            for (int index = 0; index < userInPut; index++)
            {
                //2번째 for문 시작 userInPu - 1번까지 반복 (배열은 0부터 시작하기 때문)
                for (int index2 = 0; index2 < userInPut - 1; index2++)
                {
                    //appleCount2 앞에 주소값과 뒤에 주사값을 비교하기 위한 if문 시작. (조건: 앞의 주소값 > 뒤의 주소값)
                    if (appleCount2[index2] > appleCount2[index2 + 1])
                    {
                        //버블정렬사용
                        //appleCount[0] > appleCount[1]보다 클때 실행됨
                        //temp라는 새로운 변수를 선언하고 그안에 크기가 작은 뒤에값을 저장
                        int temp = appleCount2[index2 + 1];
                        //앞의값과 뒤의값을 바꾸기위해 뒤에값에 앞의값을 저장
                        appleCount2[index2 + 1] = appleCount2[index2]; //apppleCount[1]값이 더큰 값인 appleCount[0]의 값을 저장
                        //temp안에 저장된 뒤에값을 앞에값에 저장
                        appleCount2[index2] = temp;

                        //위식과 동일 먹은 사람의 순번도 구하기위해 작성함
                        temp = appleEat[index2 + 1];
                        appleEat[index2 + 1] = appleEat[index2];
                        appleEat[index2] = temp;
                    } //if문 끝
                } //두번째 for문 끝
            } //첫번째 for문 끝
            //버블정렬이 잘 작동했는지 확인하기 위한 foreach문 시작
            //appleCount2안에있는 첫번째 요소(Element)부터 시작해서 끝까지 반복
            foreach (int element in appleCount2)
            {
                //눈으로 보기 위한 출력문
                Console.WriteLine("appleCount2 안에 {0} 값이 들어있음", element);
            } //foreach문 종료
            //공백구분
            Console.WriteLine();
            //몇번째 사람이 가장 적게 먹었는지 최소값부터 보여주는 출력문을 위한 for문 시작 loop: userInPut - 1만큼 루프(배열은0부터시작) 
            for (int index = 0; index < userInPut; index++)
            {
                //appleEat[] = 몇번째 사람, appleCount2[] = 먹은 사과 갯수
                Console.WriteLine("사람{0}\t이 먹은 사과 개수는 {1}\t개 입니다", appleEat[index], appleCount2[index]);
            } //for문 끝

        }
    }
}