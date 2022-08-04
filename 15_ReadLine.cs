using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _15_ReadLine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Console.ReadLine()
            // 콘솔창에서 입력을 받아 문자열로 반환
            Console.WriteLine("입력한 값 = " + input);

            //실습
            //입력한 값에 5를 더한 값을 출력(int형으로)
            int number = Convert.ToInt32(input);
            int number2 = int.Parse(input);
            Console.WriteLine("당신이 입력한 값에 5를 더한 값은 : {0}", number + 5);
            Console.WriteLine("당신이 입력한 값에 3를 더한 값은 : " + (number2 + 3));

            //실습
            // 입력한 값에 10을 곱한 값 출력(float형으로)
            float number3 = float.Parse(input);
            Console.WriteLine("당신이 입력한 값에 10을 곱한 값은 : " + number3 * 10);

            Console.WriteLine("hello" + 3 + 3); // 문자열 + 숫자 하면 '+'는 붙이는 기능 이때 계산을 하고 싶으면 소괄호 위에 있는 (number2+3)처럼
                                                //ㄴ 문자열 + 숫자형 → 숫자형이 문자열 되는거
            Console.WriteLine(3 + 3 + 3); // 문자열이 없고 숫자만 있을시에는 '+'는 더하는 기능






        }
    }
}
