using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _44_Method5
    {
        //최소값부터 최대값까지 더하는 함수
        static int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }

        static int Sum2(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    output += i;
                }

            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 10));
            //1부터 10까지 더한 값을 출력
            Console.WriteLine(Sum(50, 500));
            //50부터 500까지 더한 값을 출력


            //실습
            //최소값부터 최대값까지 더하는 함수 제작
            //단 짝수만
            Console.WriteLine(Sum2(3, 100));
            Console.WriteLine(Sum2(1, 50));

        }
    }
}
