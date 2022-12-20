using Microsoft.VisualBasic;
using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 0;//모음
            int bb = 0;//자음
            int cc = 0;

            Console.WriteLine("영문자를 입력");
            string input = Console.ReadLine();
            int input2 = Int32.Parse(input);

            while (true)
            {
                switch (input2)
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
        }
            }
        }
    
