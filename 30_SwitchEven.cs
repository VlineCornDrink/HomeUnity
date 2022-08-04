using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _30_SwitchEven
    {
        static void Main(string[] args)
        {
            // 실습
            // 숫자를 입력받아서 switch문을 사용해서 입력받은 숫자가 홀수면 홀수 출력
            // 짝수면 짝수 출력

            Console.Write("숫자를 입력하시오: ");
            int input = int.Parse(Console.ReadLine()); // 이렇게 코드 수 줄이는걸 최적화?

            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수");
                    break;

                default:
                    Console.WriteLine("홀수");
                    break;
            }

        }
    }
}
