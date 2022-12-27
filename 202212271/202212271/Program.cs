using System;
using System.Drawing;

namespace _202212271
{
    internal class Program
    {
        
        static int[,] playBoard = new int[3, 3];
        static int posX = 0;
        static int posY = 0;
        static Random random = new Random();
        static int[] randNum = new int[9];
        static int inv = 0;
        static void Main(string[] args)
        {
            randPuzzle();
            printBoard();
           

        }
        static void printBoard()
        {

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (playBoard[i, j] == 9)
                    {
                        Console.Write(" X ");
                        posY = i;
                        posX = j;
                        continue;
                    }
                    Console.Write($" {playBoard[i, j]} ");
                }
                Console.WriteLine();
            }

        }
        static void randPuzzle()
        {
            static void init(char[,] arr, char cnt)
            {
                for (int i = 0; i < posX; i++)
                {
                    for (int j = 0; j < posY; j++)
                    {
                        if (i == 1 && j == 1)
                        {
                            arr[i, j] = 'X';
                        }
                        else
                        {
                            arr[i, j] = cnt;
                            cnt++;
                        }

                    }
                }
            }

            inv = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (randNum[i] > randNum[j])
                    {
                        inv = inv + 1;
                    }
                }



                
            }

        }
    }
}

    