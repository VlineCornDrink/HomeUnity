using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _49_ArrayAdd
    {
        static void Main(string[] args)
        {
            // 배열과 반복문
            int[] num = { 10, 20, 30, 40, 50 };

            //배열의 크기(길이)
            Console.WriteLine(num.Length);

            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                //배열의 개수만큼 반복
                result += num[i];

            }
            Console.WriteLine(result);

            //실습
            //배열을 선언하고 자유롭게 값을 넣어주기
            //for문을 이용하여 모든값을 더한 후 출력

            float[] num2 = { 1.2f, 2.3f, 3.3f };
            float result2 = 0.0f;
            for (int i = 0; i < num2.Length; i++)
            {
                result2 += num2[i];


            }
            Console.WriteLine("{0:F2}", result2);

        }
    }
}
