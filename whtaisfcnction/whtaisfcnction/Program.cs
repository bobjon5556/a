using System.Drawing;

namespace whtaisfcnction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] mapsize = new char[5, 5];
            int x = 0;
            int y = 0;

            bool Drow = false;    
            int[,] map = new int[5, 5];
            map[2, 2] = 2;

            

            for(; ;)
            {
                if (Drow == false)
                {
                    
                    DROW_MAP(map);
                    Drow = true;
                }
                

            }
        }
        static void DROW_MAP(int[,] MAP_)
        {
            for (int y = 0; y <= MAP_.GetUpperBound(0); y++)     //y축 루프문 (첫번째 배열)
            {
                for (int x = 0; x <= MAP_.GetUpperBound(1); x++) //x축 루프문 (두번째 배열)
                {
                    switch (MAP_[y, x])                           //배열 값에 따른 다른 그리기문
                    {
                        case 2:
                            Console.Write("옷".PadRight(3, ' '));        //2값은 플레이어
                            break;
                        case 1:
                            Console.Write("□".PadRight(3, ' '));        //1값은 벽
                            break;
                        case 0:
                            Console.Write(".".PadRight(4, ' '));
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}