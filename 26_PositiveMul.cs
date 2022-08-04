using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _26_PositiveMul
    {
        static void Main(string[] args)
        {
            // 숫자 2개를 입력받아 두 수의 곱 출력 
            // 단, 결과값이 음수라면 양수 출력

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int result = num1 * num2;
            if (result < 0)
            {
                result *= -1;
                Console.WriteLine("두 수 곱한 값은 : " + result);
            }
            Console.WriteLine("두 수 곱한 값은 : " + result);




        }
    }
}
