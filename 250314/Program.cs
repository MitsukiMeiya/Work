using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250314
{
    class Program
    {
        static int solution(int[] sides)
        {
            int max = int.MinValue;
            int sum = 0;
            int answer = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                sum += sides[i];
            }

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] > max)
                {
                    max = sides[i];
                }
            }

            if (max > (sum - max))
            {
                answer = 1;
            }
            else if (max <= (sum - max))
            {
                answer = 2;
            }
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(answer);

            return answer;
        }
        static void Main(string[] args)
        {
            solution(new int[] { 3, 6, 2});
        }
    }
}
