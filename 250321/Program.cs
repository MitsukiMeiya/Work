using System;

namespace _250321
{
    internal class Program
    {
        /* 문제1
           주어진 문자열 중 찾는 문자가 있는 인덱스를 구하는 함수를 작성하고, 없을 경우 -1을 출력하시오.
        public static int FindKeyIndex(string text, char key)
        {
            char[] index = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == key)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindKeyIndex("abcdef", 'g'));
        }
        */

        /* 문제2
           주어진 숫자가 소수인지 판별하는 함수를 작성하시오.
        public static bool IsPrime(int number)
        {
            if (number > 1 && number!=2)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                        return false;
                    else
                        return true;
                }
            }
            else if (number == 2)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(7));
        }
        */

        /* 문제3
           주어진 숫자의 각 자리수의 합을 구하는 함수를 작성하시오.
        public static int SumOfDigits(int number)
        {
            int result = 0;
            string num = number.ToString();

            for (int i = 0; i < num.Length; i++)
            {
                result = result + int.Parse(num[i].ToString());
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigits(12345));
        }
        */

        /* 문제4
           주어진 두 배열에서 공통항목을 찾는 함수를 작성하시오. 단, 중복은 허용하지 않는다.
        public static int[] FindCommonItems(int[] array1, int[] array2)
        {

            for(int i = 0; i < array1.Length; i++)
            {
                for(int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[i])
                    {

                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindCommonItems([1,5,5,10],[3,5,5,10]));
        }
        */

    }
}
