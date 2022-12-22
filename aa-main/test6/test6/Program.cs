using System;

namespace test6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random r = new Random(DateTime.Now.Millisecond);
            int[] Lottery = new int[4];

            for (int i = 0; i < 4; i++)

            {

                Lottery[i] = (int)r.Next(0, 14);



                for (int j = 0; j <= i; j++) //현재 발생시킨 지점까지 검색해서 같은수 비교

                {

                    if (Lottery[i] == Lottery[j] && j != i)

                    {

                        i = i - 1; // 같은수 있으면 i하나 감소해서 다시 발생

                        Console.WriteLine(Lottery);
                    }

                }






            }

        }

    }
}
