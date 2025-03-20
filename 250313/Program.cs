using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250313
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 과제 1. 다수의 입력을 받아 연산하는 기능 구현
            int startNum, endNum;
            int sumNum=0;

            Console.WriteLine("두 수 사이의 합을 구합니다.");
            Console.Write("시작할 작은 수를 입력해주세요. : ");
            int.TryParse(Console.ReadLine(), out startNum);
            Console.Write("끝 수를 입력해주세요. : ");
            int.TryParse(Console.ReadLine(), out endNum);
            
            for(int i = startNum; i <= endNum; i++)
            {
                sumNum = sumNum + i;
            }
            Console.WriteLine($"{startNum} 과 {endNum} 사이 숫자의 합은 {sumNum}입니다.");
            */


            /*과제 4. 별찍기 기능 구현
            //1번
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
                Console.WriteLine();
            }

            //2번
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //3번
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
                Console.WriteLine();
            }

            //4번
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 4-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */


            /*심화 과제
            int starNum;

            while (true)
            {
                Console.WriteLine("출력할 다이아몬드를 홀수로 입력 : ");
                int.TryParse(Console.ReadLine(), out starNum);
                if (starNum == 1)
                {
                    Console.WriteLine("1이 아닌 값을 입력하시오");
                }
                else if (starNum % 2 == 0)
                {
                    Console.WriteLine("홀수를 입력하세요");
                }
                else
                {
                    for (int i = starNum; i > 1; i -= 2)
                    {
                        for (int j = 0; j < i / 2; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k <= starNum - i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    for (int i = 0; i < starNum; i += 2)
                    {
                        for (int j = 0; j < i; j += 2)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < starNum - i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
            */
        }
    }
}